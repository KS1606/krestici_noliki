
namespace _13._10._22
{
    public class Clolkylator
    {
        public int x, y;
        public Clolkylator(int XKonteiner, int YKonteiner)
        {
            x = XKonteiner;
            y = YKonteiner;


        }
        public int Plus()
        {
            //делаем сложение
            return x + y;
        }
        public int Minus()
        {
            //делаем вычитание
            return x - y;
        }
        public int Del()
        {
            //делаем деление 
            return x / y;
        }
        public int Umnoj()
        {
            //делаем умножение
            return x * y;
        }
    }
}
