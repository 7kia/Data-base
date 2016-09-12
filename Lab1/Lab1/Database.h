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

private:
	void ProcesssFile(std::ifstream & file);
//////////////////////////////////////////////////////////////////////
// Data
private:
	std::unordered_multimap<std::string, std::vector<std::string>>	m_content;
};