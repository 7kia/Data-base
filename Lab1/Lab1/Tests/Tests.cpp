// Lab2-1Test.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "../Database.h"
#include "FunctionsForTests.h"
#include <windows.h>

BOOST_AUTO_TEST_SUITE(SearchDatabaseTests)

struct SmallDatabaseTestsFixture_
{
	CDatabase database;
	const std::string rightFolder = "RightSmall";

	SmallDatabaseTestsFixture_()
		: database("../base.txt")
	{
		SetConsoleOutputCP(1251);
		SetConsoleCP(1251);
	}
};

BOOST_FIXTURE_TEST_SUITE(SmallDatabaseTestsFixture, SmallDatabaseTestsFixture_)

BOOST_AUTO_TEST_CASE(Test_full_name)
{
	const std::string fileName = "FullName.txt";
	std::ofstream outputFile(fileName);

	FindAndPrint(database, "ФИО", "Богданов Кирилл", outputFile);
	FindAndPrint(database, "ФИО", "Кузьминых Жанна", outputFile);

	CompareFiles(fileName, rightFolder + "/" + fileName);
}

BOOST_AUTO_TEST_CASE(Test_address)
{
	const std::string fileName = "Addres.txt";
	std::ofstream outputFile(fileName);

	FindAndPrint(database, "Адрес", "Кирова 78", outputFile);
	FindAndPrint(database, "Адрес", "Ленина 37", outputFile);

	CompareFiles(fileName, rightFolder + "/" + fileName);
}

BOOST_AUTO_TEST_CASE(Test_phone)
{
	const std::string fileName = "Phone.txt";
	std::ofstream outputFile(fileName);

	FindAndPrint(database, "Телефон", "14-26-51", outputFile);
	FindAndPrint(database, "Телефон", "21-17-13", outputFile);

	CompareFiles(fileName, rightFolder + "/" + fileName);
}

BOOST_AUTO_TEST_CASE(if_not_found_then_print_message)
{
	const std::string fileName = "NotFounded.txt";
	std::ofstream outputFile(fileName);

	FindAndPrint(database, "Телефон", "2-17-13", outputFile);
	FindAndPrint(database, "Адрес", "Ленина 3", outputFile);
	FindAndPrint(database, "ФИиФТ", "Богданов Кирилл", outputFile);

	CompareFiles(fileName, rightFolder + "/" + fileName);
}

BOOST_AUTO_TEST_SUITE_END()// SmallDatabaseTestsFixture



struct BigDatabaseTestsFixture_
{
	CDatabase database;
	const std::string rightFolder = "RightSmall";

	BigDatabaseTestsFixture_()
		: database("../db.csv")
	{
		SetConsoleOutputCP(1251);
		SetConsoleCP(1251);
	}
};

BOOST_FIXTURE_TEST_SUITE(BigDatabaseTestsFixture, BigDatabaseTestsFixture_)


BOOST_AUTO_TEST_CASE(id_tests)
{
	const std::string fileName = "BigId.txt";
	std::ofstream outputFile(fileName);

	FindAndPrint(database, "author", "\"Yaroslav Polyakov\"", "id", outputFile);
	// Скажи что в примере ошибка, не напечатана вторая строчка, покажи в Excel
	FindAndPrint(database, "author", "\"Peter Winter-Smith\"", "id", outputFile);

	CompareFiles(fileName, rightFolder + "/" + fileName);
}



BOOST_AUTO_TEST_SUITE_END()// BigDatabaseTestsFixture


BOOST_AUTO_TEST_SUITE_END()// SearchDatabaseTests
