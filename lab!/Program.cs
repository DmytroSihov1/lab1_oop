using System;
using System.Collections.Generic;

namespace lab_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            players.Add(new Player("Dmytro Sihov", "defender" , new Country("Ukraine")));
            players.Add(new Player("Vasya", "defender", new Country("France")));
            players.Add(new Player("Petya", "goalkeeper", new Country("Brazil")));
            players.Add(new Player("Vlad", "forward", new Country("Ukraine")));
            players.Add(new Player("Ruslan", "forward", new Country("Italy")));

            FootballClub fc = new FootballClub();
            fc.Players = players;

            fc.printAllPlayers();

            Console.WriteLine("\nAll forwards: ");
            foreach (Player player in fc.findPlayersByRole("forward")) 
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("\nAll players from Ukraine: ");
            foreach (Player player in fc.findPlayersByCountry(new Country("Ukraine")))
            {
                Console.WriteLine(player);
            }

            //1.2 Застосування null - сумісних типів

            //int code;
            //int value = 4;
            //double? result = Util.sqrt(value, out code);
            //Console.WriteLine(String.Format("sqrt({0})={1}", value, code == 0 ? result : "Error"));
            //value = 2;
            //result = Util.sqrt(value, out code);
            //Console.WriteLine(String.Format("sqrt({0})={1}", value, code == 0 ? result : "Error"));
            //value = -16;
            //result = Util.sqrt(value, out code);
            //Console.WriteLine(String.Format("sqrt({0})={1}", value, code == 0 ? result : "Error"));
            //value = 256;
            //result = Util.sqrt(value, out code);
            //Console.WriteLine(String.Format("sqrt({0})={1}", value, code == 0 ? result : "Error"));

            //1.3 Найбільший спільний дільник

            //static void gcd(ref int num1, ref int num2)
            //{
            //    while (num1 != 0 && num2 != 0)
            //    {
            //        if (num1 > num2)
            //        {
            //            num1 %= num2;
            //        }
            //        else
            //        {
            //            num2 %= num1;
            //        }
            //    }
            //    if (num1 == 0) { num1 = num2; }
            //    else if (num2 == 0) { num2 = num1; }
            //}
            //int num1 = 270;
            //int num2 = 269;
            //Console.Write(String.Format("gcd({0}, {1}) = ", num1, num2));
            //gcd(ref num2, ref num1);
            //Console.WriteLine(num1);
            //num1 = 60;
            //num2 = 72;
            //Console.Write(String.Format("gcd({0}, {1}) = ", num1, num2));
            //gcd(ref num2, ref num1);
            //Console.WriteLine(num1);
            //num1 = 10;
            //num2 = 20;
            //Console.Write(String.Format("gcd({0}, {1}) = ", num1, num2));
            //gcd(ref num2, ref num1);
            //Console.WriteLine(num1);

            //1.5 Робота з невирівняним масивом

            //double[,] a = {{1.5, 0, -1, 9, 10},
            //               {-12, -3, 0,-12, 13},
            //               {7, 10, 7,77, 14},
            //               {1, 2, 3, 4, 15}};
            //double[][] b = new double[a.GetLength(0)][];
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    b[i] = new double[a.GetLength(1) / 2];
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    int index = 0;
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if ((j + 1) % 2 == 0)
            //        {
            //            b[i][index++] = a[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Two-dimensional array: ");
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write(a[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Jagged array: ");
            //for (int i = 0; i < b.Length; i++)
            //{
            //    for (int j = 0; j < b[i].Length; j++)
            //    {
            //        Console.Write(b[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
