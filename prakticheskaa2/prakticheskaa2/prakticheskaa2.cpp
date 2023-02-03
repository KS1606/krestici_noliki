#include <iostream>
#include <Windows.h>
#include<cmath>
using namespace std;

int main()
{
    while (true)
    {   
        SetConsoleCP(1251);
        setlocale(LC_ALL, "Russian");
        cout << " Выберите операцию которую хотите выполнить : \n";
        cout << " 0.Выход из программы \n 1.Сложение\n 2.Вычитание\n 3.Умножение\n 4.Деление\n ";
        cout << "5.Возведение в степень\n 6.Квадратный корень из числа\n 7.Нахождение процента от числа\n";
        int a;
        cin >> a;
        if (a == 0)
        {
            break;
        }
        switch (a)
        {
        case 1:
            system("cls");
            int b, c, d;
            cout << "Сложение.\n";
            cout << " Введите первую переменную : ";
            cin >> b;
            cout << " Введите вторую переменную : ";
            cin >> c;
            d = b + c;
            cout << " Результат сложения : " << d;
            break;

        case 2:
            system("cls");
            int b1, c1, d1;
            cout << "Вычитание.\n";
            cout << " Введите первую переменную : ";
            cin >> b1;
            cout << " Введите вторую переменную : ";
            cin >> c1;
            d1 = b1 - c1;
            cout << " Результат вычитания : " << d1;
            break;

        case 3:
            system("cls");
            int b2, c2, d2;
            cout << "Умножение.\n";
            cout << " Введите первую переменную : ";
            cin >> b2;
            cout << " Введите вторую переменную : ";
            cin >> c2;
            d2 = b2 * c2;
            cout << " Результат умножения : " << d2;
            break;

        case 4:
            system("cls");
            float b3, c3, d3;
            cout << "Деление.\n";
            cout << " Введите первую переменную : ";
            cin >> b3;
            cout << " Введите вторую переменную : ";
            cin >> c3;
            d3 = b3 / c3;
            cout << " Результат деления : " << d3;
            break;

        case 5:
            system("cls");
            int b4, c4, d4;
            cout << "Возведение в степень.\n";
            cout << " Введите переменную : ";
            cin >> b4;
            cout << " Введите степень : ";
            cin >> c4;
            d4 = pow(b4,c4);
            cout << " Результат возведения в степень : " << d4;
            break;

        case 6:
            system("cls");
            int b5, d5;
            cout << "Кводратный корень из числа.\n";
            cout << " Введите переменную : ";
            cin >> b5;
            d5 = sqrt(b5);
            cout << " Результат нахождения квадратного корня : " << d5;
            break;

        case 7:
            system("cls");
            float b6, c6, d6;
            cout << "Процент от числа.\n";
            cout << " Введите переменную : ";
            cin >> b6;
            cout << " Введите процент : ";
            cin >> c6;
            d6 = ((b6/100)*c6);
            cout << " Результат нахождения процента от числа : " << d6;
            break;

        default:
            cout << " Возникла ошибка. Была введена не правильная операция.";

        }
        int a1;
        cout << "\n Для токо чтобы вернуться в меню введите 0 : ";
        cin >> a1;
        if (a1 == 0)
        {
            system("cls");
        }
        else
        {
            break;
        } 
    }
    return 0;
}
    

