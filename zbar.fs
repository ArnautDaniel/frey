require utility.fs

: zbarstr ( -- str )
    s" zbarimg -q " ;

: zbarend ( -- str )
    s" > zbar.log " ;

0 Value zbar-in
create zbarbuffer 1024 allot

: zbar-call ( str -- )
    zbarstr 2swap s+ zbarend s+ system ;

: zbar-return ( -- qrcode/n )
    s" zbar.log" open-input to zbar-in drop
    zbarbuffer 1024 zbar-in read-line throw drop nip
    zbarbuffer swap zbar-in close-file throw ;

: zbar ( str -- qrcode/n )
    zbar-call zbar-return ;