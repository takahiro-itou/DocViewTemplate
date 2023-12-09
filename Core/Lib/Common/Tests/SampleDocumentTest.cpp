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
#include    "Sample/Common/SampleDocument.h"

SAMPLE_NAMESPACE_BEGIN
namespace  Common  {

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
    CPPUNIT_TEST(testCountAlphabet);
    CPPUNIT_TEST_SUITE_END();

public:
    virtual  void   setUp()     override    { }
    virtual  void   tearDown()  override    { }

private:
    void  testCtor();
    void  testCountAlphabet();

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

void  SampleDocumentTest::testCountAlphabet()
{
    SampleDocument  testee;

    testee.setMessage("abcXYZ123");
    CPPUNIT_ASSERT_EQUAL( 6, testee.countAlphabet() );

    return;
}

}   //  End of namespace  Common
SAMPLE_NAMESPACE_END

//========================================================================
//
//    エントリポイント。
//

int  main(int argc, char * argv[])
{
    return ( executeCppUnitTests(argc, argv) );
}
