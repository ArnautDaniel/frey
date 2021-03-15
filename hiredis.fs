\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library hiredis
s" hiredis" add-lib
\c #include "/usr/local/include/hiredis/hiredis.h"

\ ----===< int constants >===-----
#1	constant HIREDIS_MAJOR
#0	constant HIREDIS_MINOR
#1	constant HIREDIS_PATCH
#1	constant REDIS_BLOCK
#2	constant REDIS_CONNECTED
#4	constant REDIS_DISCONNECTING
#8	constant REDIS_FREEING
#16	constant REDIS_IN_CALLBACK
#32	constant REDIS_SUBSCRIBED
#64	constant REDIS_MONITORING
#128	constant REDIS_REUSEADDR
#512	constant REDIS_NO_AUTO_FREE
#15	constant REDIS_KEEPALIVE_INTERVAL
#10	constant REDIS_CONNECT_RETRIES
#1	constant REDIS_OPT_NONBLOCK
#2	constant REDIS_OPT_REUSEADDR
#4	constant REDIS_OPT_NOAUTOFREE
#8	constant REDIS_OPT_NO_PUSH_AUTOFREE
#-1	constant REDIS_INVALID_FD

\ --------===< enums >===---------
\ enum redisConnectionType
#0	constant REDIS_CONN_TCP
#1	constant REDIS_CONN_UNIX
#2	constant REDIS_CONN_USERFD

\ -------===< structs >===--------
\ struct redisReply
begin-structure redisReply
	drop 40 4 +field redisReply-vtype
	drop 56 8 +field redisReply-element
	drop 8 8 +field redisReply-integer
	drop 24 8 +field redisReply-len
	drop 32 8 +field redisReply-str
	drop 48 8 +field redisReply-elements
	drop 0 4 +field redisReply-type
	drop 16 8 +field redisReply-dval
drop 64 end-structure
\ redisOptions
begin-structure redisOptions
	drop 48 8 +field redisOptions-privdata
	drop 56 8 +field redisOptions-free_privdata
	drop 64 8 +field redisOptions-push_cb
	drop 72 8 +field redisOptions-async_push_cb
	drop 0 4 +field redisOptions-type
	drop 8 8 +field redisOptions-connect_timeout
	drop 16 8 +field redisOptions-command_timeout
	drop 24 24 +field redisOptions-endpoint
	drop 4 4 +field redisOptions-options
drop 80 end-structure
\ redisOptions_endpoint
begin-structure redisOptions_endpoint
	drop 0 4 +field redisOptions_endpoint-fd
	drop 0 24 +field redisOptions_endpoint-tcp
	drop 0 8 +field redisOptions_endpoint-unix_socket
drop 24 end-structure
\ redisOptions_endpoint_tcp
begin-structure redisOptions_endpoint_tcp
	drop 8 8 +field redisOptions_endpoint_tcp-ip
	drop 16 4 +field redisOptions_endpoint_tcp-port
	drop 0 8 +field redisOptions_endpoint_tcp-source_addr
drop 24 end-structure
\ struct redisContextFuncs
begin-structure redisContextFuncs
	drop 32 8 +field redisContextFuncs-write
	drop 8 8 +field redisContextFuncs-async_read
	drop 16 8 +field redisContextFuncs-async_write
	drop 0 8 +field redisContextFuncs-free_privctx
	drop 24 8 +field redisContextFuncs-read
drop 40 end-structure
\ struct redisContext
begin-structure redisContext
	drop 264 8 +field redisContext-push_cb
	drop 224 8 +field redisContext-saddr
	drop 184 8 +field redisContext-command_timeout
	drop 176 8 +field redisContext-connect_timeout
	drop 152 8 +field redisContext-obuf
	drop 8 4 +field redisContext-err
	drop 12 128 +field redisContext-errstr
	drop 192 24 +field redisContext-tcp
	drop 144 4 +field redisContext-flags
	drop 160 8 +field redisContext-reader
	drop 168 4 +field redisContext-connection_type
	drop 240 8 +field redisContext-privdata
	drop 248 8 +field redisContext-free_privdata
	drop 140 4 +field redisContext-fd
	drop 216 8 +field redisContext-unix_sock
	drop 256 8 +field redisContext-privctx
	drop 232 8 +field redisContext-addrlen
	drop 0 8 +field redisContext-funcs
drop 272 end-structure
\ redisContext_unix_sock
begin-structure redisContext_unix_sock
	drop 0 8 +field redisContext_unix_sock-path
drop 8 end-structure
\ redisContext_tcp
begin-structure redisContext_tcp
	drop 16 4 +field redisContext_tcp-port
	drop 8 8 +field redisContext_tcp-source_addr
	drop 0 8 +field redisContext_tcp-host
drop 24 end-structure

\ --===< function pointers >===---
c-funptr redisOptions-free_privdata() {((redisOptions*)ptr)->free_privdata} a -- void	( <noname> -- )
c-funptr redisContextFuncs-free_privctx() {((struct redisContextFuncs*)ptr)->free_privctx} a -- void	( <noname> -- )
c-funptr redisContextFuncs-async_read() {((struct redisContextFuncs*)ptr)->async_read} a -- void	( <noname> -- )
c-funptr redisContextFuncs-async_write() {((struct redisContextFuncs*)ptr)->async_write} a -- void	( <noname> -- )
c-funptr redisContextFuncs-read() {((struct redisContextFuncs*)ptr)->read} a a n -- n	( <noname> <noname> <noname> -- )
c-funptr redisContextFuncs-write() {((struct redisContextFuncs*)ptr)->write} a -- n	( <noname> -- )
c-funptr redisContext-free_privdata() {((struct redisContext*)ptr)->free_privdata} a -- void	( <noname> -- )

\ ------===< functions >===-------
c-function redisReaderCreate redisReaderCreate  -- a	( -- )
c-function freeReplyObject freeReplyObject a -- void	( reply -- )
c-function redisvFormatCommand redisvFormatCommand a s n -- n	( target format ap -- )
c-function redisFormatCommand redisFormatCommand a s ... -- n	( target format <noname> -- )
c-function redisFormatCommandArgv redisFormatCommandArgv a n a a -- n	( target argc argv argvlen -- )
c-function redisFormatSdsCommandArgv redisFormatSdsCommandArgv a n a a -- n	( target argc argv argvlen -- )
c-function redisFreeCommand redisFreeCommand a -- void	( cmd -- )
c-function redisFreeSdsCommand redisFreeSdsCommand n -- void	( cmd -- )
c-function redisConnectWithOptions redisConnectWithOptions a -- a	( options -- )
c-function redisConnect redisConnect s n -- a	( ip port -- )
c-function redisConnectNonBlock redisConnectNonBlock s n -- a	( ip port -- )
c-function redisConnectBindNonBlock redisConnectBindNonBlock s n s -- a	( ip port source_addr -- )
c-function redisConnectBindNonBlockWithReuse redisConnectBindNonBlockWithReuse s n s -- a	( ip port source_addr -- )
c-function redisConnectUnix redisConnectUnix s -- a	( path -- )
c-function redisConnectUnixNonBlock redisConnectUnixNonBlock s -- a	( path -- )
c-function redisConnectFd redisConnectFd n -- a	( fd -- )
c-function redisReconnect redisReconnect a -- n	( c -- )
c-function redisSetPushCallback redisSetPushCallback a a -- a	( c fn -- )
c-function redisEnableKeepAlive redisEnableKeepAlive a -- n	( c -- )
c-function redisFree redisFree a -- void	( c -- )
c-function redisFreeKeepFd redisFreeKeepFd a -- n	( c -- )
c-function redisBufferRead redisBufferRead a -- n	( c -- )
c-function redisBufferWrite redisBufferWrite a a -- n	( c done -- )
c-function redisGetReply redisGetReply a a -- n	( c reply -- )
c-function redisGetReplyFromReader redisGetReplyFromReader a a -- n	( c reply -- )
c-function redisAppendFormattedCommand redisAppendFormattedCommand a s n -- n	( c cmd len -- )
c-function redisvAppendCommand redisvAppendCommand a s n -- n	( c format ap -- )
c-function redisAppendCommand redisAppendCommand a s ... -- n	( c format <noname> -- )
c-function redisAppendCommandArgv redisAppendCommandArgv a n a a -- n	( c argc argv argvlen -- )
c-function redisvCommand redisvCommand a s n -- a	( c format ap -- )
c-function redisCommand redisCommand a s ... -- a	( c format <noname> -- )
c-function redisCommandArgv redisCommandArgv a n a a -- a	( c argc argv argvlen -- )

\ ----===< postfix >===-----
end-c-library
