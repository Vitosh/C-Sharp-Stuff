#include<iostream>
using namespace std;


int __stdcall fib3(int & x)
{
	int k = 0;
	int p = 0;

	if (x == 0)
		return 0;

	if (x == 1)
		return 1;
	
	k = x-1;
	p = x - 2;
	return fib3(k) + fib3(p);

}