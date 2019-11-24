using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Быкова Дарья ИУ5-31Б";
            string a, b, c;
            double A, B, C;
            if (args == null)
            {
                Console.WriteLine("Введите первый коэффициент: ");
                a = Console.ReadLine();
                while (Double.TryParse(a, out A) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    a = Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Введите второй коэффициент: ");
                b = Console.ReadLine();
                while (Double.TryParse(b, out B) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    b = Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Введите третий коэффициент: ");
                c = Console.ReadLine();
                while (Double.TryParse(c, out C) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    c = Console.ReadLine();
                }
            }
            else
            {
                if ((args.Length >= 1))
                {
                    a = args[0];
                }
                else
                {
                    Console.WriteLine("Введите первый коэффициент: ");
                    a = Console.ReadLine();
                }
                while (!Double.TryParse(a, out A))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    a = Console.ReadLine();

                }
                if ((args.Length >= 2))
                {
                    b = args[1];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Введите второй коэффициент: ");
                    b = Console.ReadLine();
                }
                while (!Double.TryParse(b, out B))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    b = Console.ReadLine();
                }
                if ((args.Length >= 3))
                {
                    c = args[2];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Введите третий коэффициент: ");
                    c = Console.ReadLine();
                }
                while (!Double.TryParse(c, out C))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    c = Console.ReadLine();
                }
            }

            if ((A == 0) && (B == 0) && (C == 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Корень- любое число");
            }
            else
            {
                if ((A == 0) && (B == 0) && (C != 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                }
                else
                {
                    if (A != 0)
                    {
                        double dscr = B * B - 4 * A * C;
                        if (dscr > 0)
                        {
                            double y1 = (-B + Math.Sqrt(dscr)) / (2 * A);
                            double y2 = (-B - Math.Sqrt(dscr)) / (2 * A);
                            Console.ForegroundColor = ConsoleColor.Green;
                            if ((y1 > 0) && (y2 > 0))
                            {
                                double x1 = Math.Sqrt(y1);
                                double x2 = -Math.Sqrt(y1);
                                double x3 = Math.Sqrt(y2);
                                double x4 = -Math.Sqrt(y2);
                                Console.WriteLine("Корень 1= " + x1);
                                Console.WriteLine("Корень 2= " + x2);
                                Console.WriteLine("Корень 3= " + x3);
                                Console.WriteLine("Корень 4= " + x4);
                            }
                            if ((y1 > 0) && (y2 < 0))
                            {
                                double x1 = Math.Sqrt(y1);
                                double x2 = -Math.Sqrt(y1);
                                Console.WriteLine("Корень 1= " + x1);
                                Console.WriteLine("Корень 2= " + x2);
                            }
                            if ((y1 < 0) && (y2 > 0))
                            {
                                double x1 = Math.Sqrt(y2);
                                double x2 = -Math.Sqrt(y2);
                                Console.WriteLine("Корень 1= " + x1);
                                Console.WriteLine("Корень 2= " + x2);
                            }
                            if ((y1 < 0) && (y2 < 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Корней нет");
                            }
                            if ((y1 == 0) && (y2 < 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Корень- ноль");
                            }
                            if ((y1 == 0) && (y2 > 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                double x1 = Math.Sqrt(y2);
                                double x2 = -Math.Sqrt(y2);
                                Console.WriteLine("Корень 1= " + x1);
                                Console.WriteLine("Корень 2= " + x2);
                                Console.WriteLine("Корень 3= 0");
                            }
                            if ((y1 < 0) && (y2 == 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Корень- ноль");
                            }
                            if ((y1 > 0) && (y2 == 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                double x1 = Math.Sqrt(y1);
                                double x2 = -Math.Sqrt(y1);
                                Console.WriteLine("Корень 1= " + x1);
                                Console.WriteLine("Корень 2= " + x2);
                                Console.WriteLine("Корень 3= 0");
                            }
                        }
                        else
                        {
                            if (dscr == 0)
                            {
                                double y = (-B + Math.Sqrt(dscr)) / (2 * A);
                                Console.ForegroundColor = ConsoleColor.Green;
                                double x1 = Math.Sqrt(y);
                                double x2 = -Math.Sqrt(y);
                                Console.WriteLine("Корень 1= " + x1);
                                Console.WriteLine("Корень 2= " + x2);
                            }
                            if (dscr < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Корней нет");
                            }
                        }

                    }

                    else
                    {
                        if (C == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корень- ноль");
                        }
                        else
                        {
                            if (C > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Корней нет");
                            }
                            else
                            {
                                double dscr = -4 * B * C;
                                double x1 = (Math.Sqrt(dscr)) / (2 * B);
                                double x2 = (-Math.Sqrt(dscr)) / (2 * B);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Первый корень= " + x1);
                                Console.WriteLine("Второй корень= " + x2);
                            }
                        }
                    }
                }
            }
            string s = Console.ReadLine();
        }
    }
}