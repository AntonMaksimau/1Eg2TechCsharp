// lekcja 1
/* 
using System;

namespace Moje
{
    
    class Program
    {
        
        static void Main()
        {
            
            // print("Hello world!4 ")
            Console.WriteLine("Hello world!4 ");
            // print("Hello world!3 \n\n\n",end="")
            Console.Write("Hello world!3 \n\n\n");
            // print("Hello world!2 ",end="")
            Console.Write("Hello world!2 ");
            // print("Hello world!1 ")
            Console.WriteLine("Hello world!1 ");
            Console.ReadKey();
            Console.Write("\n");
            Console.ReadLine();
            // -_----d-sa-das-d-sad
            // dasdjasdh--
            
        }
        
    }
    
}
*/
/*
using System;

namespace Moje{
    
    class Program{
        
        static void Main(){
            // int - Tylko dla liczb od -2147483648 do 2147483647
            int number = -100;
            Console.WriteLine("Переменная: " + number + ".");
            number = -200;
            Console.WriteLine(number);
            number = 5;
            Console.WriteLine(number);
            // uint - Tylko dla dodatnich cał. liczb int
            uint number2 = 10;
            Console.WriteLine(number2);
            // byte - Tylko dla cał. liczb od 0 do 255
            byte number3 = 255;
            Console.WriteLine(number3);
            // short - Tylko dla cał. liczb od -32 768 do 32 767
            short number4 = -30000;
            Console.WriteLine(number4);
            // long - Tylko dla  cał. liczb od -9 223 372 036 854 775 808 do 9 223 372 036 854 775 807
            long number5 = 3123121232768;
            Console.WriteLine(number5);
            
            // float - liczby z przecinkiem
            float number6 = 5.3123f;
            Console.WriteLine(number6);
            // double - większy okres liczb z przecinkiem niż float
            double number7 = 543534.3123d;
            Console.WriteLine(number7);

            // string - jak str w Python
            string word = "21d";
            Console.WriteLine(word);
            // char - dla 1 sumbolu
            char symbol = 'D';
            Console.WriteLine(symbol);

            // bool - Tylko dla true lub false
            bool isGood = true; // false
            Console.WriteLine(isGood);
            

        }
    }
}
*/
/*
using System;

namespace KartaPracy1{
    
    class Program{
        
        static void Main(){
            
            int num_1 = 5, num_2 = 3;
            Console.WriteLine(num_1 + num_2);
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num_1);
            
        }
    }
}
*/
/*
using System;

namespace Moje{
    
    class Program{
        
        static void Main(){

           
            Console.Write("Wprowadź liczbę z przecinkiem: ");
            // number = Convert.ToDouble(Console.ReadLine());
            float number = float.Parse(Console.ReadLine());

            float result = number + 10.908f;
            Console.WriteLine("Liczba +: " + result);

            result = number - 10.908f;
            Console.WriteLine("Liczba -: " + result);

            result = number * 10.908f;
            Console.WriteLine("Liczba *: " + result);

            result = number / 10.908f;
            Console.WriteLine("Liczba /: " + result);

            result = number % 10.908f;
            Console.WriteLine("Liczba %: " + result);

            result += 5f;
            // result = result + 5f
            // /= , *=, -=
            Console.WriteLine(result);

            result++; // result --;
            // = result += 1
            Console.WriteLine(result);
        }
        
    }
    
}
*/
/*
using System;

namespace Moje{

    class Program{

        static void Main(){

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(-432));
            
            Console.WriteLine(Math.Ceiling(54.1));
            // Zaokrąglanie do większej liczby
            Console.WriteLine(Math.Floor(54.99));
            // Zaokrąglanie do mniejszej liczby

            Console.WriteLine(Math.Round(56.51));
            // Normalne zaokrąglanie liczby

            Console.WriteLine(Math.Min(3, 4));
            // Zwraca mniejszą liczbę
            Console.WriteLine(Math.Max(3, 4));
            // Zwraca większą liczbe

            Console.WriteLine(Math.Pow(5, 2));
            // Podnieść liczbę do potęgi
        }
    }
}
*/

using System;

namespace Moje{

    class Program{

        static void Main(){

            Console.Write("Wprowadź radius koła: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Powieszchnia koła z radiusem {0} = {1}", radius, area);
            
        }
        
    }
    
}