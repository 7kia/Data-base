// Lab1.cpp: ���������� ����� ����� ��� ����������� ����������.
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
	FindAndPrint(database, "���", "�������� ������", std::cout);
	FindAndPrint(database, "���", "��������� �����", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "�����", "������ 78", std::cout);
	FindAndPrint(database, "�����", "������ 37", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "�������", "14-26-51", std::cout);
	FindAndPrint(database, "�������", "21-17-13", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "�������", "2-17-13", std::cout);
	FindAndPrint(database, "�����", "������ 3", std::cout);
	FindAndPrint(database, "�����", "�������� ������", std::cout);
	//*/
	//FindAndPrint(database, "author", "\"Yaroslav Polyakov\"", std::cout);
	std::cout << std::endl;
	//FindAndPrint(database, "author", "\"Peter Winter-Smith\"", std::cout);
	std::cout << std::endl;
	FindAndPrint(database, "author", "\"Yaroslav Polyakov\"", "id", std::cout);
	std::cout << std::endl;
	// ����� ��� � ������� ������, �� ���������� ������ �������, ������ � Excel
	FindAndPrint(database, "author", "\"Peter Winter-Smith\"", "id", std::cout);

    return 0;
}

