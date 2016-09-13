// Lab1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "Database.h"
#include <windows.h>

void FindAndPrint(CDatabase & database
				, const std::string id
				, const std::string & search)
{
	const std::string result = database.Find(id, search);
	if (result.empty())
	{
		std::cout << "Not found " + id + " with name " + search << std::endl;
	}
	else
	{
		std::cout << result << std::endl;
	}
}
void FindAndPrint(CDatabase & database
				, const std::string & whereSearch
				, const std::string & search
				, const std::string & idPrintCell)
{
	const std::string result = database.FindValueIds(whereSearch, search, idPrintCell);
	if (result.empty())
	{
		std::cout << "Not found " + whereSearch + " with name " + search << std::endl;
	}
	else
	{
		std::cout << result << std::endl;
	}
}

int main()
{
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	// base.txt
	CDatabase database("db.csv");

	//database.PrintDatabase(std::cout);

	/*
		FindAndPrint(database, "ФИО", "Богданов Кирилл");
	FindAndPrint(database, "ФИО", "Кузьминых Жанна");
	std::cout << std::endl;
	FindAndPrint(database, "Адрес", "Кирова 78");
	FindAndPrint(database, "Адрес", "Ленина 37");
	std::cout << std::endl;
	FindAndPrint(database, "Телефон", "14-26-51");
	FindAndPrint(database, "Телефон", "21-17-13");
	std::cout << std::endl;
	FindAndPrint(database, "Телефон", "2-17-13");
	FindAndPrint(database, "Адрес", "Ленина 3");
	FindAndPrint(database, "ФИиФТ", "Богданов Кирилл");
	*/
	//FindAndPrint(database, "author", "\"Yaroslav Polyakov\"");
	std::cout << std::endl;
	//FindAndPrint(database, "author", "\"Peter Winter-Smith\"");
	std::cout << std::endl;
	FindAndPrint(database, "author", "\"Yaroslav Polyakov\"", "id");
	std::cout << std::endl;
	FindAndPrint(database, "author", "\"Peter Winter-Smith\"", "id");

    return 0;
}

