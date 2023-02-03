#include <iostream>
#include <string>
#include <Windows.h>
using namespace std;

int main()
{
    SetConsoleCP(1251);
    setlocale(LC_ALL, "Russian");// загружаем русский для роботы с ФИО
    string FIO;
    cout << "Введите Ваше ФИО : "; // выводим сообщение пользователю 
    getline(cin, FIO); // даем пользователю возможность вввести перемменую с пробелами
    
    string grup;
    cout << "Введите вашу группу : ";
    cin >> grup;

    unsigned int vozrast;
    cout << "Введите свой возраст : ";
    cin >> vozrast;

    cout << "----------------------------";
    cout << "\nВаше ФИО : " << FIO; // выводим данные которые ввел пользователь
    cout << "\nВаша группа : " << grup;
    cout << "\nВаш возраст : " << vozrast;

    return 0;
}

