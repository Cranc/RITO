// RITO_JASON_WRAPPER.h

#pragma once

#include "../../RITO_Jason_Dynamic_Library/RITO_JASON_LIB/RITO_JASON_LIB.h"
//#include "../../RITO_Jason_Dynamic_Library/RITO_JASON_LIB/RITO_JASON_LIB.cpp"
#include <msclr\marshal_cppstd.h>
#include <string>

using namespace System;
using namespace MY_JASON_LIB;
namespace RITO_JASON_WRAPPER {

	public ref class MyJasonWrapper
	{
		// TODO: Add your methods for this class here.
	public:
		MyJasonWrapper(String^ SummonerName);
		long GetSummonerIdWrapper();
		void SetSummonerNameWrapper(String^ SummonerName);
		String^ GetSummonerNameWrapper();
		int GetProfileIconIdWrapper();
		String^ GetResponseErrorWrapper();

	private:
		RITO_JASON_LIB *Rito_Lib;
	};
}
