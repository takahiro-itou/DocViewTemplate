// This is the main DLL file.

#include "stdafx.h"

#include <msclr/marshal_cppstd.h>

#include "Wrapper.h"

#include <string>

namespace Wrapper {

int Class1::test1(System::String^ message)
{
    std::string tmp = msclr::interop::marshal_as<std::string>(message);
    return static_cast<int>(tmp.length());
}

}