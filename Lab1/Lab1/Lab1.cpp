// Lab1.cpp: ���������� ����� ����� ��� ����������� ����������.
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

	std::cout << database.Find("���", "�������� ������") << std::endl;
	std::cout << database.Find("���", "��������� �����") << std::endl;

    return 0;
}

