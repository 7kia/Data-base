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

	m_content.insert({ "ID", {}  });
	m_content.insert({ "Name",{} });
	m_content.insert({ "Adress",{} });

	ProcesssFile(m_inputFile);
}

void CDatabase::ProcesssFile(std::ifstream & file)
{
	std::string stringFromFile;

	while (getline(file, stringFromFile))
	{
		auto words = SplitWords(stringFromFile);

		if (words.size() != words.size())
		{
			throw std::runtime_error("Amount words in cell incorrect must be " + to_string(words.size()));
		}

		size_t index = 0;
		for (auto & element : m_content)
		{
			element.second.push_back(words[index++]);
		}

	}
}
