//  -*-  coding: utf-8-with-signature;  mode: c++  -*-  //
/*************************************************************************
**                                                                      **
**                  ---  DocView Template Project  ---                  **
**                                                                      **
**          Copyright (C), 2017-2023, Takahiro Itou                     **
**          All Rights Reserved.                                        **
**                                                                      **
**          License: (See COPYING or LICENSE files)                     **
**          GNU Affero General Public License (AGPL) version 3,         **
**          or (at your option) any later version.                      **
**                                                                      **
*************************************************************************/

/**
**      An Implementation of Test Case 'SampleDocument'.
**
**      @file       Common/Tests/SampleDocumentTest.cpp
**/

#include    "TestDriver.h"
#include    "Sample/Common/SampleSettings.h"

SAMPLE_NAMESPACE_BEGIN

//========================================================================
//
//    SampleDocumentTest  class.
//
/**
**    クラス SampleDocument の単体テスト。
**/

class  SampleDocumentTest : public  TestFixture
{
    CPPUNIT_TEST_SUITE(SampleDocumentTest);
    CPPUNIT_TEST(testCtor);
    CPPUNIT_TEST_SUITE_END();

public:
    virtual  void   setUp()     override    { }
    virtual  void   tearDown()  override    { }

private:
    void  testCtor();

};

CPPUNIT_TEST_SUITE_REGISTRATION( SampleDocumentTest );

//========================================================================
//
//    Tests.
//

void  SampleDocumentTest::testCtor()
{
    SampleDocument  testee;

    return;
}

SAMPLE_NAMESPACE_END

//========================================================================
//
//    エントリポイント。
//

int  main(int argc, char * argv[])
{
    return ( executeCppUnitTests(argc, argv) );
}
