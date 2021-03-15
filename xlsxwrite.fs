\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library xlsxio_write
s" xlsxio_write" add-lib
\c #include "/usr/local/include/xlsxio_write.h"

\ ------===< functions >===-------
c-function xlsxiowrite_get_version xlsxiowrite_get_version a a a -- void	( pmajor pminor pmicro -- )
c-function xlsxiowrite_get_version_string xlsxiowrite_get_version_string  -- s	( -- )
c-function xlsxiowrite_open xlsxiowrite_open s s -- a	( filename sheetname -- )
c-function xlsxiowrite_close xlsxiowrite_close a -- n	( handle -- )
c-function xlsxiowrite_set_detection_rows xlsxiowrite_set_detection_rows a n -- void	( handle rows -- )
c-function xlsxiowrite_set_row_height xlsxiowrite_set_row_height a n -- void	( handle height -- )
c-function xlsxiowrite_add_column xlsxiowrite_add_column a s n -- void	( handle name width -- )
c-function xlsxiowrite_add_cell_string xlsxiowrite_add_cell_string a s -- void	( handle value -- )
c-function xlsxiowrite_add_cell_int xlsxiowrite_add_cell_int a n -- void	( handle value -- )
c-function xlsxiowrite_add_cell_float xlsxiowrite_add_cell_float a r -- void	( handle value -- )
c-function xlsxiowrite_add_cell_datetime xlsxiowrite_add_cell_datetime a n -- void	( handle value -- )
c-function xlsxiowrite_next_row xlsxiowrite_next_row a -- void	( handle -- )

\ ----===< postfix >===-----
end-c-library
