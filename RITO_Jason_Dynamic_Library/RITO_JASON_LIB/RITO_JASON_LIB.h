/*#ifdef RITOJASONDLL_EXPORTS
#define RITOJASONDLL_API __declspec(dllexport) 
#else
#define RITOJASONDLL_API __declspec(dllimport) 
#endif
*/
#pragma once
#include <stdexcept>
#include <string>


using namespace std;

namespace MY_JASON_LIB
{
	class RITO_JASON_LIB{
		public:
			/*
			static RITOJASONDLL_API RITO_JASON_LIB* GetInstance(string SummonerName);
			*/
			RITO_JASON_LIB(string SummonerName);
			long GetSummonerID();
			void SetSummonerName(string SummonerName);
			string GetSummonerName();
			int GetProfileIconID();
			string GetResponseError();
		private:
			
			~RITO_JASON_LIB();
			string SummonerName;
			string Error;
	};

	/*
	extern "C" __declspec(dllexport) IKlass* __cdecl create_klass()
	{
		return new MyKlass;
	}
	
	extern "C" { __declspec(dllexport) long GetSummonerID(string SummonerName); }
	extern "C" { __declspec(dllexport) int GetProfileIconID(string SummonerName); }
	extern "C" { __declspec(dllexport) double Multiply(double a, double b); }
	extern "C" { __declspec(dllexport) double Divide(double a, double b); }
	*/
}