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
	std::cout << std::endl;
	std::cout << database.Find("�����", "������ 78") << std::endl;
	std::cout << database.Find("�����", "������ 37") << std::endl;
	std::cout << std::endl;
	std::cout << database.Find("�������", "14-26-51") << std::endl;
	std::cout << database.Find("�������", "21-17-13") << std::endl;

    return 0;
}

