// RITO_JASON_LIB.cpp : Defines the exported functions for the DLL application.
//
#pragma once
#include "stdafx.h"
#include "RITO_JASON_LIB.h"
#include <string>
using namespace MY_JASON_LIB;
using namespace std;

RITO_JASON_LIB::RITO_JASON_LIB(string SummonerName) : SummonerName(SummonerName), Error("0"){}

RITO_JASON_LIB::~RITO_JASON_LIB(){

}
/*
RITO_JASON_LIB& RITO_JASON_LIB::GetInstance(string SummonerName){
	return new RITO_JASON_LIB(SummonerName);
}
*/
int RITO_JASON_LIB::GetProfileIconID(){
	return 0;
}

long RITO_JASON_LIB::GetSummonerID(){
	return 0;
}

string RITO_JASON_LIB::GetSummonerName(){
	return this->SummonerName;
}

void RITO_JASON_LIB::SetSummonerName(string SummonerName){
	this->SummonerName = SummonerName;
}

string RITO_JASON_LIB::GetResponseError(){
	return this->Error;
}