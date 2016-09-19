#include "stdafx.h"
#include "FunctionsForTests.h"

using namespace std;

void CompareFiles(const string & first, const string & second)
{
	ifstream resultFile(first);
	ifstream rightResultFile(second);

	istream_iterator<char> iterResultFile(resultFile), endIter;
	istream_iterator<char> iterRightRsultFile(rightResultFile);

	BOOST_CHECK_EQUAL_COLLECTIONS(iterResultFile, endIter, iterRightRsultFile, endIter);
}

void RunSearch(CDatabase & database
			, const std::string & whereSearch
			, const std::string & search
			, const std::string & idPrintCell
			, const std::string nameOutputFile)
{
	ofstream outputFile(nameOutputFile);

	FindAndPrint(database
				, whereSearch
				, search
				, idPrintCell
				, outputFile);
	
}

std::string	GetAbsolutePath(const std::string & name
							, const std::string & folder
							, const std::string & prefix)
{
	std::string result;

	if (!folder.empty())
	{
		result = prefix + folder + "/";
	}
	result += prefix + name + TestNameFiles::nameFormatFiles;

	return result;
}


void TestSearchToDatabase(CDatabase & database
				, const std::string & nameFile
				, const std::string & folder
				, const std::string & whereSearch
				, const std::string & search
				, const std::string & idPrintCell)
{
	
	std::string nameOutputFile = GetAbsolutePath(nameFile, folder, TestNameFiles::nameOutputFile);

	BOOST_REQUIRE_NO_THROW(RunSearch(database
									, whereSearch
									, search
									, idPrintCell
									, nameOutputFile));

	std::string nameRightFile = GetAbsolutePath(nameFile, folder, PREFIX_RIGHT_DATA);
	CompareFiles(nameOutputFile, nameRightFile);
};
