\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library xlsxio_read
s" xlsxio_read" add-lib
\c #include "/usr/local/include/xlsxio_read.h"

\ ----===< int constants >===-----

\ ------===< callbacks >===-------
c-callback xlsxioread_list_sheets_callback_fn: s a -- n	( name callbackdata -- )
c-callback xlsxioread_process_cell_callback_fn: n n s a -- n	( row col value callbackdata -- )
c-callback xlsxioread_process_row_callback_fn: n n a -- n	( row maxcol callbackdata -- )

\ ------===< functions >===-------
c-function xlsxioread_get_version xlsxioread_get_version a a a -- void	( pmajor pminor pmicro -- )
c-function xlsxioread_get_version_string xlsxioread_get_version_string  -- s	( -- )
c-function xlsxioread_open xlsxioread_open s -- a	( filename -- )
c-function xlsxioread_open_filehandle xlsxioread_open_filehandle n -- a	( filehandle -- )
c-function xlsxioread_open_memory xlsxioread_open_memory a n n -- a	( data datalen freedata -- )
c-function xlsxioread_close xlsxioread_close a -- void	( handle -- )
c-function xlsxioread_list_sheets xlsxioread_list_sheets a a a -- void	( handle callback callbackdata -- )
c-function xlsxioread_process xlsxioread_process a s u a a a -- n	( handle sheetname flags cell_callback row_callback callbackdata -- )
c-function xlsxioread_sheetlist_open xlsxioread_sheetlist_open a -- a	( handle -- )
c-function xlsxioread_sheetlist_close xlsxioread_sheetlist_close a -- void	( sheetlisthandle -- )
c-function xlsxioread_sheetlist_next xlsxioread_sheetlist_next a -- s	( sheetlisthandle -- )
c-function xlsxioread_sheet_last_row_index xlsxioread_sheet_last_row_index a -- n	( sheethandle -- )
c-function xlsxioread_sheet_last_column_index xlsxioread_sheet_last_column_index a -- n	( sheethandle -- )
c-function xlsxioread_sheet_flags xlsxioread_sheet_flags a -- u	( sheethandle -- )
c-function xlsxioread_sheet_open xlsxioread_sheet_open a s u -- a	( handle sheetname flags -- )
c-function xlsxioread_sheet_close xlsxioread_sheet_close a -- void	( sheethandle -- )
c-function xlsxioread_sheet_next_row xlsxioread_sheet_next_row a -- n	( sheethandle -- )
c-function xlsxioread_sheet_next_cell xlsxioread_sheet_next_cell a -- a	( sheethandle -- )
c-function xlsxioread_sheet_next_cell_string xlsxioread_sheet_next_cell_string a a -- n	( sheethandle pvalue -- )
c-function xlsxioread_sheet_next_cell_int xlsxioread_sheet_next_cell_int a a -- n	( sheethandle pvalue -- )
c-function xlsxioread_sheet_next_cell_float xlsxioread_sheet_next_cell_float a a -- n	( sheethandle pvalue -- )
c-function xlsxioread_sheet_next_cell_datetime xlsxioread_sheet_next_cell_datetime a a -- n	( sheethandle pvalue -- )
c-function xlsxioread_free xlsxioread_free a -- void	( data -- )

\ ----===< postfix >===-----
end-c-library
