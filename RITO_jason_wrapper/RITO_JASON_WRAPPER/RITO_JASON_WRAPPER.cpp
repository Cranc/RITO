// This is the main DLL file.

#include "stdafx.h"
#include "RITO_JASON_WRAPPER.h"


#include "../../RITO_Jason_Dynamic_Library/RITO_JASON_LIB/RITO_JASON_LIB.h"
#include "../../RITO_Jason_Dynamic_Library/RITO_JASON_LIB/RITO_JASON_LIB.cpp"

using namespace RITO_JASON_WRAPPER;
using namespace msclr::interop;

MyJasonWrapper::MyJasonWrapper(String^ SummonerName){
	this->Rito_Lib = new RITO_JASON_LIB(marshal_as<string>(SummonerName));
}

long MyJasonWrapper::GetSummonerIdWrapper(){
	return this->Rito_Lib->GetSummonerID();
}

void MyJasonWrapper::SetSummonerNameWrapper(String^ SummonerName){
	//msclr::interop::marshal_context context;
	this->Rito_Lib->SetSummonerName(marshal_as<string>(SummonerName));
}

String^ MyJasonWrapper::GetSummonerNameWrapper(){
	return marshal_as<String^>(this->Rito_Lib->GetSummonerName());
}

int MyJasonWrapper::GetProfileIconIdWrapper(){
	return this->Rito_Lib->GetProfileIconID();
}

String^ MyJasonWrapper::GetResponseErrorWrapper(){
	return marshal_as<String^>(this->Rito_Lib->GetResponseError());
}