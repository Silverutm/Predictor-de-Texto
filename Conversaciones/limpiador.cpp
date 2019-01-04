#include <iostream>
#include <cstdio>
#include <cctype>
#include <cstdlib>
using namespace std;
string s, sn;
int main()
{
	int contador=0;
	while( cin>>s)
	{
		//for (auto c: s)
			//printf("%d\n", c);
			//cout<<c+0<<endl;
		//return 0;
		
		sn="";
		if (s[s.size()-1]==':') continue;		//eliminar los nombres de personas
		for (auto c:s)
			if (isalpha(c))
				sn.push_back(tolower(c) );
			else if (c==-87) sn.push_back(tolower('e') );
			else if (c==-83) sn.push_back(tolower('i') );
			else if (c==-95) sn.push_back(tolower('a') );
			else if (c==-77) sn.push_back(tolower('o') );
			else if (c==-70) sn.push_back(tolower('u') );
		if (sn.size())
		cout<<sn<<" ";
		contador++;
		if (sn.size()>=30) {cout<<"error"<<endl;return 0;}
		//if (contador==10) return 0;
	}
	return 0;
}