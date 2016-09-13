#pragma once

#include <vector>
#include <string>
#include <iostream>// for std::cin and std::cout
#include <fstream>
#include <vector>
#include <memory>
#include <unordered_map>

#include <boost/algorithm/string.hpp>

#include "Mixin\HaveFileForReading.h"

class CDatabase
	: public CHaveFileForReading
{
public:
	CDatabase(const std::string & nameInputFile);

//////////////////////////////////////////////////////////////////////
// Methods
public:
	void							PrintDatabase(std::ostream & str);
	std::string						Find(const std::string & id, const std::string & search);

	std::string						FindValueIds(const std::string & whereSearch
												, const std::string & search
												, const std::string & idPrintCell);

private:
	void							ProcesssFile(std::ifstream & file);
	std::vector<std::string>		ReadTypeIds(std::ifstream & file);
	std::vector<size_t>				FindIds(const std::string & id, const std::string & search);
//////////////////////////////////////////////////////////////////////
// Data
private:
	std::unordered_map<std::string, std::vector<std::string>>			m_content;
	std::vector<std::string>											m_ids;
};