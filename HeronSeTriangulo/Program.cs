using System;

namespace HeronTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC, resultP, resultA;
            double bc, ac, ab;
            bool aValido, bValido, cValido;
            bool op1 = false, op2 = false, op3 = false;
            string sair;

            do
            {
                Console.Clear();

                Console.Write("Digite o Valor de A: ");
                aValido = double.TryParse(Console.ReadLine(), out ladoA);

                if (!aValido)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione Enter para sair, e execute o programa novamente");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }

                Console.Write("Digite o Valor de B: ");
                bValido = double.TryParse(Console.ReadLine(), out ladoB);

                if (!bValido)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione Enter para sair, e execute o programa novamente");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }

                Console.Write("Digite o Valor de C: ");
                cValido = double.TryParse(Console.ReadLine(), out ladoC);

                if (!cValido)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione Enter para sair, e execute o programa novamente");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
                Console.WriteLine();

                bc = Math.Abs(ladoB - ladoC);
                ac = Math.Abs(ladoA - ladoC);
                ab = Math.Abs(ladoA - ladoB);

                if (ab < ladoC && ladoC < ladoA + ladoB)
                {
                    op1 = true;
                }

                if (ac < ladoB && ladoB < ladoA + ladoC)
                {
                    op2 = true;
                }

                if (bc < ladoA && ladoA < ladoB + ladoC)
                {
                    op3 = true;
                }

                if (op1 && op2 && op3)
                {
                    resultP = (ladoA + ladoB + ladoC) / 2;
                    resultA = Math.Sqrt(resultP * (resultP - ladoA) * (resultP - ladoB) * (resultP - ladoC));

                    Console.WriteLine("Semiperímetro = {0}", resultP);
                    Console.WriteLine("Area = {0}(cm²)", resultA);
                    Console.WriteLine();

                    Console.Write("Seu tipo do triangulo é: ");
                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        Console.WriteLine("Equilátero");
                        DrawEquilatero();
                    }
                    else if (ladoA != ladoB && ladoB != ladoC)
                    {
                        Console.WriteLine("Escaleno");
                        DrawEscaleno();

                    }
                }
                else
                {
                    resultP = (ladoA + ladoB + ladoC) / 2;
                    resultA = Math.Sqrt(resultP * (resultP - ladoA) * (resultP - ladoB) * (resultP - ladoC));

                    Console.WriteLine("Semiperímetro = {0}", resultP);
                    Console.WriteLine("Area = {0}(cm²)", resultA);

                    Console.WriteLine("Isósceles");
                    DrawIsosceles();
                }

                Console.Write("Deseja Sair? S/N: ");
                sair = Console.ReadLine().ToUpper();
            }
            while (sair != "S" && sair != "SIM");
        }
        static void DrawEquilatero()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t      /*\\");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t     /***\\");
            Console.WriteLine("\t    /*****\\");
            Console.WriteLine("\t   /*******\\");
            Console.WriteLine("\t  /*********\\");
            Console.WriteLine("\t /***********\\");
            Console.WriteLine("\t/-------------\\");
            Console.WriteLine();
            Console.ResetColor();
        }
        static void DrawEscaleno()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t*");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t***");
            Console.WriteLine("\t*****");
            Console.WriteLine("\t*******");
            Console.WriteLine("\t*********");
            Console.WriteLine("\t***********");
            Console.WriteLine("\t*************");
            Console.ResetColor();
        }

        static void DrawIsosceles()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t*");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t ***");
            Console.WriteLine("\t  *****");
            Console.WriteLine("\t   *******");
            Console.WriteLine("\t    *********");
            Console.WriteLine("\t     ***********");
            Console.WriteLine("\t      *************");
            Console.ResetColor();
        }
    }
}