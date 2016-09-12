// Lab1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "Database.h"
#include <windows.h>

int main()
{
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	CDatabase database("base.txt");

	//database.PrintDatabase(std::cout);

	std::cout << database.Find("ФИО", "Богданов Кирилл") << std::endl;
	std::cout << database.Find("ФИО", "Кузьминых Жанна") << std::endl;
	std::cout << std::endl;
	std::cout << database.Find("Адрес", "Кирова 78") << std::endl;
	std::cout << database.Find("Адрес", "Ленина 37") << std::endl;
	std::cout << std::endl;
	std::cout << database.Find("Телефон", "14-26-51") << std::endl;
	std::cout << database.Find("Телефон", "21-17-13") << std::endl;

    return 0;
}

