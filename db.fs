require hiredis.fs

variable rc

: initdb ( -- )
    s" 127.0.0.1" 6379 redisconnect rc ! ;

: smember ( item -- replyobj )
    s" smembers " 2swap s+ rc @ rot rot rediscommand ;

: printmember ( replyobj -- )
    cr dup redisreply-len @ swap redisreply-str @ swap type ;

: printmembers ( replyobj -- )
    dup redisreply-elements @ swap redisreply-element @
    swap 0 DO
	dup i cells + @ printmember
    loop drop ;

    