#include <iostream>
#include <Windows.h>
#include<cmath>
#include <string>
#include "practi3.h"
using namespace std;
int main()
{
    int rez = 0;
    SetConsoleCP(1251);
    setlocale(LC_ALL, "Russian");
    do {
        string n;
        int c = 0;
        int i;
        cout << "Введите число : ";
        cin >> n;
        if (n == "End") {
            break;
        }
        int a = stoi(n);
        if (a < 0) {
            cout << "Число отрицательное!\n";
        }
        else if (a == 0) {
            cout << "Введенное число 0!\n" << "Факториал 0 это 1\n";
        }
        else {
            if (a == 4 || a == 9) {
                cout << "";
            }
            else {
                for (i = 2; i < sqrt(a); i++) {
                    if (a % i == 0) {
                        c = c + 1;
                        break;
                    }
                }
                if (c == 0) {
                    rez = rez + a;
                    cout << "Число явяется простым!\n";
                }
            }
            long res = 1;
            for (i = 1; i <= a; i++) {
                res = res * i;
            }
            cout << "Факториал " << a << " это " << res << "\n";
        }
        cout << "-----------------------------------------\n";
        cout << "Введите 'End' для выхода из программы!\n";
	} while (true);
    cout << "\nСумма всех простых чисел :" << rez;
    return 0;
}

