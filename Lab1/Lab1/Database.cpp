#include "stdafx.h"
#include "Database.h"

using namespace std;

namespace
{
	static const std::string DIVEDE_SEQUENCE = "|";
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
	std::vector<std::string> ids;
	for(const auto & pair : m_content)
	{
		ids.push_back(pair.first);
	}
	
	//std::reverse(ids.begin(), ids.end());

	size_t sizeBase = m_content[ids[0]].size();
	for (size_t index = 0; index < sizeBase; ++index)
	{
		for (const auto & id : ids)
		{
			str << m_content[id][index];
			str << DIVEDE_SEQUENCE;
		}
		str << std::endl;
	}
}

void CDatabase::ProcesssFile(std::ifstream & file)
{
	const std::vector<std::string> ids = ReadTypeIds(file);

	std::string stringFromFile;

	while (getline(file, stringFromFile))
	{
		auto words = SplitWords(stringFromFile);

		if (words.size() != words.size())
		{
			throw std::runtime_error("Amount words in cell incorrect must be " + to_string(words.size()));
		}

		size_t index = 0;
		for (const auto & id : ids)
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
