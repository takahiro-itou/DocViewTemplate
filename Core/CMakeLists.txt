
##----------------------------------------------------------------
##
##    Package Configurations.
##    パッケージ設定。
##

##
##    要求するツールのバージョンを指定する。
##

cmake_minimum_required(VERSION  3.0.2)

##
##    パッケージの情報を指定する。
##

set(PROJECT_NAME        Sample)
set(serial              "0.0.0")

project(${PROJECT_NAME}     VERSION  1.0.0)


##
##    共通の .cmake ファイルの置いてある場所。
##

set(COMMON_CMAKE_DIR        "${PROJECT_SOURCE_DIR}/.CMake")

##
##    ターゲットシステムを判定
##

Include (${COMMON_CMAKE_DIR}/TargetSystem.cmake)


##----------------------------------------------------------------
##
##    プロジェクトの基本設定。
##

##
##    デフォルトのコンパイルオプション。
##

Include (${COMMON_CMAKE_DIR}/DefaultCompileOptions.cmake)

##
##    Project Name Space.
##

set(SAMPLE_CNF_NAMESPACE    Sample)


##----------------------------------------------------------------
##
##    ディレクトリ名。
##

set(INCTOP_DIR_NAME         "Include")
set(BINTOP_DIR_NAME         "Bin")
set(LIBTOP_DIR_NAME         "Lib")

Include(${COMMON_CMAKE_DIR}/ConfigDirectory.cmake)


##----------------------------------------------------------------
##
##    ビルド環境の検査。
##

##
##    Check Programs.
##

##
##    Check Header Files.
##

##
##    Check Libraries.
##

##
##    Check Types.
##

##
##    Check Extra Compiler/Linker Options.
##

Include (${COMMON_CMAKE_DIR}/EnableCxx11.cmake)

Include (${COMMON_CMAKE_DIR}/CheckConstExpr.cmake)
Include (${COMMON_CMAKE_DIR}/CheckNullPtr.cmake)
Include (${COMMON_CMAKE_DIR}/CheckOverride.cmake)

##----------------------------------------------------------------
##
##    Additional Packages.
##    外部ライブラリ。
##

set(CMAKE_MODULE_PATH
    ${CMAKE_MODULE_PATH}  ${COMMON_CMAKE_DIR}/Modules
)

Find_Package (CppUnit)

##----------------------------------------------------------------
##
##    設定を書き込んだファイルを生成。
##

configure_file(
    "${INCLUDE_SOURCE_DIR}/.Config/ConfiguredSample.h.in"
    "${INCLUDE_BINARY_DIR}/.Config/ConfiguredSample.h"
)

configure_file(
    "${INCLUDE_SOURCE_DIR}/.Config/Config.h.cmake.in"
    "${INCLUDE_BINARY_DIR}/.Config/.${PROJECT_NAME}.Config.h"
)

##----------------------------------------------------------------
##
##    パッケージコンフィグレーション。
##

configure_file(
    "${CMAKE_CURRENT_SOURCE_DIR}/${PROJECT_NAME}Config.cmake.in"
    "${CMAKE_CURRENT_BINARY_DIR}/${PROJECT_NAME}Config.cmake"
    @ONLY
)

install(FILES   "${CMAKE_CURRENT_BINARY_DIR}/${PROJECT_NAME}Config.cmake"
        DESTINATION  .
)

##----------------------------------------------------------------
##
##    サブディレクトリの追加。
##

Add_SubDirectory (Lib)
Add_SubDirectory (Bin)
