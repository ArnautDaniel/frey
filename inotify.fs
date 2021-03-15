require utility.fs

(
: show-template-str
    s" inotifywait -m --format '%w %e %f' -e moved_to -r orders/";
)

\ Start inotifywait to log any files that move in or out of the orders
\ directory.  We background it.

: frey-template-str
    s" inotifywait -m -o orders.log -c -r -e moved_to,moved_from  orders/ &" ;

: fnotify
    frey-template-str system ;

create orderlog 64 allot
s" orders.log" orderlog PLACE

1024 Value orderbuffmax
create orderbuffer orderbuffmax allot

Variable orderlen
0 Value notify-in
0 Value notify-out

: fnotify-log ( -- )
    orderlog count open-input to notify-in ;

: flogline ( -- str )
    orderbuffer orderbuffmax notify-in read-line throw drop
    dup orderlen ! orderbuffer swap ;
    
: feof ( -- )
    notify-in file-position throw drop 1 - s>d
    notify-in reposition-file throw
    flogline 2drop ;

: feof? ( -- t/f )
    orderlen @ 0= if
	feof flogline 2drop then ;

\ Call flog to get the latest string
\ if there are no new strings it simple
\ returns an empty one.
\ flog refreshes the file via feof? to ensure
\ that new lines are read.
: frey-log ( -- str )
    flogline feof? ;
