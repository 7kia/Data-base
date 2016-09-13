#include "stdafx.h"
#include "Database.h"

using namespace std;

namespace
{
	static const std::string DIVEDE_SEQUENCE = ",";//"|";
}

// TODO : see need transfer
vector<string> SplitWords(string const& text)
{
	vector<string> words;

	boost::split(words
				, text
				, boost::is_any_of(DIVEDE_SEQUENCE)
				, boost::token_compress_on);
	return words;
}

CDatabase::CDatabase(const std::string & nameInputFile)
	: CHaveFileForReading()
{
	CheckAndOpenFileForReading(nameInputFile);

	ProcesssFile(m_inputFile);
}

void CDatabase::PrintDatabase(std::ostream & str)
{

	size_t sizeBase = m_content[m_ids[0]].size();
	for (size_t index = 0; index < sizeBase; ++index)
	{
		for (const auto & id : m_ids)
		{
			str << m_content[id][index];
			str << DIVEDE_SEQUENCE;
		}
		str << std::endl;
	}
}

std::string CDatabase::Find(const std::string & id, const std::string & search)
{

	// TODO : fix define incorrect id
	// size_t indexFounded = m_content[id].size();
	std::vector<size_t> indexesFounded = FindIds(id, search);

	// Not found
	if (indexesFounded.size() == 0)
	{
		return std::string();
	}

	std::string founded;
	for (const auto & indexFounded : indexesFounded)
	{
		for (const auto & id : m_ids)
		{
			founded += m_content[id][indexFounded];
			founded += DIVEDE_SEQUENCE;
		}
		founded += "\n";
	}


	return founded;
}

std::string CDatabase::FindValueIds(const std::string & whereSearch
									, const std::string & search
									, const std::string & idPrintCell)
{
	// TODO : fix define incorrect id
	// size_t indexFounded = m_content[id].size();
	std::vector<size_t> indexesFounded = FindIds(whereSearch, search);

	// Not found
	if (indexesFounded.size() == 0)
	{
		return std::string();
	}

	std::string founded;
	for (const auto & indexFounded : indexesFounded)
	{		
		if (founded.size())
		{
			founded += DIVEDE_SEQUENCE + " ";
		}
		founded += m_content[idPrintCell][indexFounded];
	}


	return founded;
}

void CDatabase::ProcesssFile(std::ifstream & file)
{
	m_ids = ReadTypeIds(file);

	std::string stringFromFile;

	while (getline(file, stringFromFile))
	{
		auto words = SplitWords(stringFromFile);

		if (words.size() != words.size())
		{
			throw std::runtime_error("Amount words in cell incorrect must be " + to_string(words.size()));
		}

		size_t index = 0;
		for (const auto & id : m_ids)
		{
			m_content[id].push_back(words[index++]);
		}

	}
}

std::vector<std::string> CDatabase::ReadTypeIds(std::ifstream & file)
{
	std::string stringFromFile;

	getline(file, stringFromFile);

	return SplitWords(stringFromFile);
}

std::vector<size_t> CDatabase::FindIds(const std::string & id, const std::string & search)
{
	std::vector<size_t> indexesFounded;
	for (size_t index = 0; index < m_content[id].size(); ++index)
	{
		if (m_content[id][index] == search)// TODO : replace algorithm search
		{
			indexesFounded.push_back(index);
		}
	}
	return indexesFounded;
}
