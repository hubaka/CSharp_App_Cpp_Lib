#include "TweetBankCore.h"
#include <iostream>


TweetBankCore::TweetBankCore()
{
	m_var = 0;
}


TweetBankCore::~TweetBankCore()
{
}

int TweetBankCore::tweet()
{
	m_var++;
	return m_var;
}