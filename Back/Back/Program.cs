using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            n3 = int.Parse(Console.ReadLine());

            if (VerificaNumeros(n1, n2, n3))
            {
                Console.WriteLine("Resposta:");

                string resultadoFormula = FormulaLei(n1, n2, n3);
                Console.WriteLine(resultadoFormula);

                TrianguloDados(n1, n2, n3);
            }
            else
            {
                Console.WriteLine("Números inválidos! Digite outros números maiores que zero.");
            }

            Console.ReadLine();
        }

        static bool VerificaNumeros(int n1, int n2, int n3)
        {
            return (n1 > 0 && n2 > 0 && n3 > 0);
        }

        static void TrianguloDados(int n1, int n2, int n3)
        {
            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("Triângulo Equilátero!");
            }
            else if (n1 != n2 && n1 != n3 && n2 != n3)
            {
                Console.WriteLine("Triângulo Escaleno!");
            }
            else
            {
                Console.WriteLine("Triângulo Isósceles!");
            }
        }

        static string FormulaLei(int n1, int n2, int n3)
        {
            double cosA, cosB, cosC;

            cosA = (Math.Pow(n2, 2) + Math.Pow(n3, 2) - Math.Pow(n1, 2)) / (2 * n2 * n3);
            cosB = (Math.Pow(n1, 2) + Math.Pow(n3, 2) - Math.Pow(n2, 2)) / (2 * n1 * n3);
            cosC = (Math.Pow(n1, 2) + Math.Pow(n2, 2) - Math.Pow(n3, 2)) / (2 * n1 * n2);

            return ($"CosA = {cosA}, CosB = {cosB}, CosC = {cosC}");
        }
    }
}
