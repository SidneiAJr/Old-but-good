/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>
using namespace std;
int main()
{
    int v1;
    int v2;
    int v3;
    int v4;
    int res;
    int res2;
    int res3;
    int res4;
    
    
    cout <<"Digite um numero ";
    cin >> v1;
    cout <<"Digite um numero ";
    cin >> v2;
    cout <<"Digite um numero ";
    cin >> v3;
    cout <<"Digite um numero ";
    cin >> v4;
    
    res=v1+v2+v3+v4;
    res2=res*2;
    res3=res/2;
    res4=res-0;
    
    
    cout <<"O Primeiro resultado é:" <<res << "\n\n";
    cout <<"O Primeiro resultado é:" <<res2 << "\n\n";
    cout <<"O Primeiro resultado é:" <<res3 << "\n\n";
    cout <<"O Primeiro resultado é:" <<res4 << "\n\n";
    
    
    
    

    return 0;
}
