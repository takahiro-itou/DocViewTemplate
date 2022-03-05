
##----------------------------------------------------------------
##
##    モジュールの設定。
##

set(MODULE_DIR_NAME         "TestDriver")
set(MODULE_OUTPUT_NAME      "TestDriver")
set(MODULE_TITLE            "TestDriver")

set(INCLIB_SOURCE_DIR       "${INCLUDE_SOURCE_DIR}/${MODULE_DIR_NAME}")
set(INCLIB_BINARY_DIR       "${INCLUDE_BINARY_DIR}/${MODULE_DIR_NAME}")

##----------------------------------------------------------------
##
##    ソースファイルとヘッダファイルのリスト。
##

set(LIBRARY_SOURCE_FILES
        TestDriver.cpp
)

set(INCLIB_HEADER_FILES
)

##----------------------------------------------------------------
##
##    ビルドとインストールの設定。
##

If ( CPPUNIT_FOUND )
    include_directories("${CPPUNIT_INCLUDE_DIR}")
    link_libraries     ("${CPPUNIT_LIBRARIES}")
    set(CMAKE_CXX_FLAGS     "${CMAKE_CXX_FLAGS}  -DHAVE_CPPUNIT=1")
Else  ()
    set(CMAKE_CXX_FLAGS     "${CMAKE_CXX_FLAGS}  -DHAVE_CPPUNIT=0")
EndIf ()

Include (${COMMON_CMAKE_DIR}/BuildLibraryCommon.cmake)
