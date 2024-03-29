
##
##    List of Tests.
##

EXTRATESTS              =
TESTS                   =  \
        SampleCoreSettingsTest  \
        SampleDocumentTest      \
        ${EXTRATESTS}
##
##    Test Configurations.
##

TARGET_TESTEE_LIBRARY       +=  -lsampleCommon

DIST_NOINST_DATA_FILES      +=
DIST_NOINST_HEADER_FILES    +=
EXTRA_TEST_DRIVERS          +=
LIBRARY_TEST_DRIVERS        +=
SOURCE_TEST_DRIVERS         +=

##
##    Compile and Link Options.
##

TEST_CPPFLAGS_COMMON        +=
TEST_LDFLAGS_COMMON         +=

##
##    Test Programs.
##

SampleCoreSettingsTest_SOURCES  =  SampleCoreSettingsTest.cpp
SampleDocumentTest_SOURCES      =  SampleDocumentTest.cpp

