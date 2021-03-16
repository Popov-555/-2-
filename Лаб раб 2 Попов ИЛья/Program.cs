using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// namespace такой же как и название проекта
namespace oapPopov
{
    // про классы мы пока не говорили...
    class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {/*
            Console.Write("Input number1: ");
            var number1 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Input number2: ");
            var number2 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Input number3: ");
            var number3 = Convert.ToDouble( Console.ReadLine() );
        static void Main(string[] args)
        {
            //ExceptionTest();
            //ExceptionTest2();
            //ExceptionTest3();
            //ExceptionTest4(); 
            //ExceptionTest5();
            //ExceptionTest6();
            //ExceptionTest7();
            //ExceptionTest8();
            //ExceptionTest9();
            //ExceptionTest10();
            //ExceptionTest11();
            //ExceptionTest12();
           

            if (number1 >= 0)
            {
                number1 = Math.Pow(number1, 2);
            }
            else 
            {
                number1 = Math.Pow(number1, 4);
            }
            FactorialAsync(-4);
            FactorialAsync(6);

            Console.ReadKey();
        }

        private static void FactorialAsync(int v)
        {
            throw new NotImplementedException();
        }

        static void ExceptionTest()
        {
            Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
            task1.Start();

            if (number2 >= 0)
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

            Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));

            Console.ReadLine();
        }
        static void ExceptionTest2()
        {
            Task task = new Task(Display);
            task.Start();

            Console.WriteLine("Завершение метода Main");

            Console.ReadLine();
        }
        static void ExceptionTest3()
        {
            Task task = new Task(Display);
            task.Start();
            task.Wait();
            Console.WriteLine("Завершение метода Main");
            Console.ReadLine();
        }
        static async Task ExceptionTest4Async()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                number2 = Math.Pow(number2, 2);
                result *= i;
            }
            else 
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен {result}");

            Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(() => Factorial());                // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }
        static void ExceptionTest5()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                number2 = Math.Pow(number2, 4);
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен {result}");

            Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(() => FactorialAsync());                // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }
        static void ExceptionTest6()
        {
            string s = "Hello world! One step at a time";

            number3 = (number3 >= 0) ? Math.Pow(number3, 2) : швMath.Pow(number3, 4);

            if (number3 >= 0)
            using (StreamWriter writer = new StreamWriter("hello.txt", false))
            {
                await writer.WriteLineAsync(s);  // асинхронная запись в файл
            }
            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                number3 = Math.Pow(number3, 2);
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }
            else
        }
            static void ExceptionTest6()
            {
                number3 = Math.Pow(number3, 4);
                int result = 1;
                for (int i = 1; i <= 6; i++)
                {
                    result *= i;
                }
                Thread.Sleep(8000);
                Console.WriteLine($"Факториал равен {result}");
            }
            Console.WriteLine($"number1 = {number1}");
            Console.WriteLine($"number2 = {number2}");
            Console.WriteLine($"number3 = {number3}");
            
            */
            /*
            Console.Write("Input X1: ");
            var X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Y1: ");
            var Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input X2: ");
            var X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Y2: ");
            var Y2 = Convert.ToDouble(Console.ReadLine());
            var Dlina1 = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
            var Dlina2 = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
            if (Dlina1 < Dlina2)

        static void ExceptionTest7()
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("первaя точка ближе");
                result *= i;
            }
            else
            Thread.Sleep(5000);
            Console.WriteLine($"Факториал равен {result}");
            {
                Console.WriteLine("вторая точка ближе");
                Console.WriteLine("Некоторая работа");
                Console.Read();
            }
           */
            /*
            Console.Write("Input Ugol1: ");
            var Ugol1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Ugol2: ");
            var Ugol2 = Convert.ToDouble(Console.ReadLine());
            if((Ugol1 + Ugol2)<180)
        }
            static void ExceptionTest8()
            {
                Console.WriteLine("треугольник существует");
                if(Ugol1 == 90 || Ugol2 == 90 || Ugol2 + Ugol1 == 90)
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("треугольник прямоугольный");
                    result *= i;
                }
                else Console.WriteLine("треугольник не прямоугольный");
                return result;
            }
            else
            // определение асинхронного метода
            /*static async void FactorialAsync(int n)
                {
                    int x = await Task.Run(() => Factorial(n));
                    Console.WriteLine($"Факториал равен {x}");
                }
                static void Main(string[] args)
                {
                    FactorialAsync(5);
                    FactorialAsync(6);
                    Console.Read();*/

            static void ExceptionTest9()
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("треугольник не существует");
                    result *= i;
                }
            }
        }
    }
}
               
                /*
                Console.Write("Number1: ");
                var Number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Number2: ");
                var Number2 = Convert.ToDouble(Console.ReadLine());
                var PoluSumma = (Number1 + Number2) / 2;
                var Proizvedenie = 2 * (Number1 * Number2);
                if (Number1 < Number2)
                return result;
            }
            static async Task<int> FactorialAsync(int n)
            {
                return await Task.Run(() => Factorial(n));
            }
            static async Task Main(string[] args)
            {
                int n1 = await FactorialAsync(5);
                int n2 = await FactorialAsync(6);
                Console.WriteLine($"n1={n1}  n2={n2}");
                Console.Read();
            }
            static void ExceptionTest10()
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"Факториал числа {n} равен {result}");
            }
            // определение асинхронного метода
            static async void FactorialAsync()
            {
                await Task.Run(() => Factorial(4));
                await Task.Run(() => Factorial(3));
                await Task.Run(() => Factorial(5));
            }
            static void ExceptionTest11()
            {
                if (n < 1)
                    throw new Exception($"{n} : число не должно быть меньше 1");
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"Факториал числа {n} равен {result}");
            }
            static async void FactorialAsync(int n)
            {
                try
                {
                    await Task.Run(() => Factorial(n));
                }
                catch (Exception ex)
                {
                    Number1 = PoluSumma;
                    Number2 = Proizvedenie;
                    Console.WriteLine(ex.Message);
                }
                else
            }
            static void ExceptionTest12()
            {
                Task task = null;
                try
                {
                    Number2 = PoluSumma;
                    Number1 = Proizvedenie;
                    task = Task.Run(() => Factorial(n));
                    await task;
                }
                Console.WriteLine($"number1 = {Number1}");
                Console.WriteLine($"number2 = {Number2}");
                */
                