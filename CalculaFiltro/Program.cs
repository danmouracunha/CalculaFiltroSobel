using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaFiltro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Gx = new int[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            int[,] Gy = new int[3, 3] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            int[,] Imagem = new int[12, 12] {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 },
                                            { 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            int[,] ResultadoX = new int[12, 12] {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 },
                                            { 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            int[,] ResultadoY = new int[12, 12] {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 },
                                            { 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                                            { 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            int i = 0, j = 0;
            int ValorAtual = 0;
            for (i = 1; i < 11; i++)
            {
                for (j = 1; j < 11; j++)
                {
                    ValorAtual = (Gy[0, 0] * Imagem[i - 1, j - 1]) + (Gy[0, 1] * Imagem[i - 1, j]) + (Gy[0, 2] * Imagem[i - 1, j + 1])
                                + (Gy[1, 0] * Imagem[i, j - 1]) + (Gy[1, 1] * Imagem[i, j]) + (Gy[1, 2] * Imagem[i, j + 1])
                                + (Gy[2, 0] * Imagem[i + 1, j - 1]) + (Gy[2, 1] * Imagem[i + 1, j]) + (Gy[2, 2] * Imagem[i + 1, j + 1]);
                    ResultadoX[i, j] = ValorAtual;
                }
            }
            for (j = 1; j < 11; j++)
            {
                for (i = 1; i < 11; i++)
                {
                    ValorAtual = (Gy[0, 0] * Imagem[i - 1, j - 1]) + (Gy[0, 1]*Imagem[i - 1, j]) +  (Gy[0, 2] * Imagem[i - 1, j + 1])
                                +(Gy[1, 0] * Imagem[i, j - 1]) +     (Gy[1, 1]*Imagem[i, j]) +      (Gy[1, 2] * Imagem[i, j + 1])
                                +(Gy[2, 0] * Imagem[i + 1, j - 1]) + (Gy[2, 1] *Imagem[i + 1, j]) + (Gy[2, 2] * Imagem[i + 1, j + 1]);
                    ResultadoY[i, j] = ValorAtual;
                }
            }
            int rowLength = ResultadoX.GetLength(0);
            int colLength = ResultadoX.GetLength(1);
            Console.Write("Resultado em X:" + Environment.NewLine + Environment.NewLine);
            for (i = 0; i < rowLength; i++)
            {
                for (j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", ResultadoX[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.Write("Resultado em Y: " + Environment.NewLine + Environment.NewLine);
            for (i = 0; i < rowLength; i++)
            {
                for (j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", ResultadoY[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();




        }
    }
}
