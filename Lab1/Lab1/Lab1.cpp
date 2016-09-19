// Lab1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "Database.h"
#include <windows.h>

int main()
{
	//SetConsoleOutputCP(1251);
	//SetConsoleCP(1251);
	setlocale(LC_ALL, "");
	// base.txt
	CDatabase database("base.txt");//..db.csv

	//database.PrintDatabase(std::cout);

	///*
	FindAndPrint(database, "ФИО", "Богданов Кирилл", std::cout);
	FindAndPrint(database, "ФИО", "Кузьминых Жанна", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "Адрес", "Кирова 78", std::cout);
	FindAndPrint(database, "Адрес", "Ленина 37", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "Телефон", "14-26-51", std::cout);
	FindAndPrint(database, "Телефон", "21-17-13", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "Телефон", "2-17-13", std::cout);
	FindAndPrint(database, "Адрес", "Ленина 3", std::cout);
	FindAndPrint(database, "ФИиФТ", "Богданов Кирилл", std::cout);
	//*/
	//FindAndPrint(database, "author", "\"Yaroslav Polyakov\"", std::cout);
	std::cout << std::endl;
	//FindAndPrint(database, "author", "\"Peter Winter-Smith\"", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "author", "\"Yaroslav Polyakov\"", "id", std::cout);
	std::cout << std::endl;
	// Скажи что в примере ошибка, не напечатана вторая строчка, покажи в Excel
	FindAndPrint(database, "author", "\"Peter Winter-Smith\"", "id", std::cout);

    return 0;
}

