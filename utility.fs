
: open-input ( addr u -- ) r/o open-file throw  ;
: open-output ( addr u -- ) w/o create-file throw ;

: +s ( addr1 u addr2 u -- addr3 u )
    2swap s+ ;

