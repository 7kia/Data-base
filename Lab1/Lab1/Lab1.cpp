// Lab1.cpp: ���������� ����� ����� ��� ����������� ����������.
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

int main()
{
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	CDatabase database("base.txt");

	//database.PrintDatabase(std::cout);

	FindAndPrint(database, "���", "�������� ������");
	FindAndPrint(database, "���", "��������� �����");
	std::cout << std::endl;
	FindAndPrint(database, "�����", "������ 78");
	FindAndPrint(database, "�����", "������ 37");
	std::cout << std::endl;
	FindAndPrint(database, "�������", "14-26-51");
	FindAndPrint(database, "�������", "21-17-13");
	std::cout << std::endl;
	FindAndPrint(database, "�������", "2-17-13");
	FindAndPrint(database, "�����", "������ 3");
	FindAndPrint(database, "�����", "�������� ������");

    return 0;
}

