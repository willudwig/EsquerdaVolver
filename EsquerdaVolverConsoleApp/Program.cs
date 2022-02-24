using System;

namespace EsquerdaVolverConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movimentos = "dde".ToUpper();
            char[] mov = movimentos.ToCharArray();
            char orientacao = 'N';

            MudarDirecao(ref orientacao, mov);
            Console.WriteLine("\n" + orientacao);

            Console.ReadKey();
        }

        static void MudarDirecao(ref char orient, char[] mov)
        {
            for (int i = 0; i < mov.Length; i++)
            {
                switch (mov[i])
                {
                    case 'E':
                        switch (orient)
                        {
                            case 'N':
                                orient = 'O';
                                break;
                            case 'S':
                                orient = 'L';
                                break;

                            case 'L':
                                orient = 'N';
                                break;

                            case 'O':
                                orient = 'S';
                                break;
                        }
                        break;

                    case 'D':
                        switch (orient)
                        {
                            case 'N':
                                orient = 'L';
                                break;
                            case 'S':
                                orient = 'O';
                                break;

                            case 'L':
                                orient = 'S';
                                break;

                            case 'O':
                                orient = 'N';
                                break;
                        }
                        break;

                }
            }

        }
    }
}
