using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace psc_lista_06_2025.Models
{
    public class Atividades
    {
        /// <summary>
        /// Faça um Programa que leia um vetor de 5 números inteiros e mostre-os. 
        /// </summary>
        public static void Atividade1()
        {
            int[] numeros = new int[5];
            int i = 0;
            while (i < numeros.Length)
            {
                Console.WriteLine($"Digite o número da posição {i + 1}:");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    numeros[i] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Número inválido, tente novamente.");
                }
            }
            Console.WriteLine("Números lidos: " + string.Join(", ", numeros));
        }
        /// <summary>
        /// Faça um Programa que leia um vetor de 10 números reais e mostre-os na  
        /// ordem inversa.
        /// </summary>
        public static void Atividade2()
        {
            int[] numeros = new int[10];
            int i = 0;
            while (i < numeros.Length)
            {
                Console.WriteLine($"Digite o número da posição {i + 1}:");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    numeros[numeros.Length - 1 - i] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Número inválido, tente novamente.");
                }
            }
            Console.WriteLine("Números lidos: " + string.Join(", ", numeros));
        }
        /// <summary>
        /// Faça um Programa que leia 4 notas, mostre as notas e a média na tela.
        /// </summary>
        public static void Atividade3()
        {
            double[] numeros = new double[4];
            int i = 0;
            while (i < numeros.Length)
            {
                Console.WriteLine($"Digite a nota {i + 1}/{numeros.Length}:");
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double value))
                {
                    numeros[i] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Número inválido, tente novamente.");
                }
            }
            Console.WriteLine("Números lidos: " + string.Join(", ", numeros));
            Console.WriteLine("Média: " + numeros.Average());
        }
        /// <summary>
        /// Faça um Programa que leia um vetor de 10 caracteres, e diga quantas  
        /// consoantes foram lidas. Imprima as consoantes.  
        /// </summary>
        public static void Atividade4()
        {
            var consonantes = new List<char>();
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Digite o caractere {i + 1}/10:");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada vazia, tente novamente.");
                    continue;
                }

                input = input.Trim();

                if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^\p{L}$"))
                {
                    Console.WriteLine("Entrada inválida: digite apenas UMA letra.");
                    continue;
                }

                string normalized = input.Normalize(System.Text.NormalizationForm.FormD);

                var sb = new System.Text.StringBuilder();

                foreach (var ch in normalized)
                {
                    var category = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(ch);

                    if (category != System.Globalization.UnicodeCategory.NonSpacingMark)
                        sb.Append(ch);
                }
                char baseChar = char.ToLowerInvariant(sb[0]);
                bool isVowel = "aeiou".IndexOf(baseChar) >= 0;

                if (!isVowel)
                {
                    consonantes.Add(input[0]);
                }

                i++;
            }

            Console.WriteLine($"Número de consoantes lidas: {consonantes.Count}");
            if (consonantes.Count > 0)
                Console.WriteLine("Consoantes: " + string.Join(", ", consonantes));
            else
                Console.WriteLine("Nenhuma consoante foi lida.");
        }
        /// <summary>
        /// Faça um Programa que leia 20 números inteiros e armazene-os num vetor.  
        /// Armazene os números pares no vetor PAR e os números IMPARES no vetor  
        /// ímpar. Imprima os três vetores. 
        /// </summary>
        public static void Atividade5()
        {
            int[] numeros = new int[20];
            int[] pares = new int[20];
            int[] impares = new int[20];
            int contPares = 0;
            int contImpares = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}/20:");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    numeros[i] = value;

                    if (value % 2 == 0)
                    {
                        pares[contPares] = value;
                        contPares++;
                    }
                    else
                    {
                        impares[contImpares] = value;
                        contImpares++;
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido, tente novamente.");
                    i--;
                }
            }

            Console.WriteLine("Números lidos: " + string.Join(", ", numeros));
            Console.WriteLine("Números pares: " + string.Join(", ", pares.Take(contPares)));
            Console.WriteLine("Números ímpares: " + string.Join(", ", impares.Take(contImpares)));
        }
        /// <summary>
        /// Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene
        /// num vetor a média de cada aluno, imprima o número de alunos com média
        /// maior ou igual a 7.0.
        /// </summary>
        public static void Atividade6()
        {
            double[] medias = new double[10];
            int alunosAprovados = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite as quatro notas do aluno {i + 1}:");

                double soma = 0;
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    string? input = Console.ReadLine();

                    if (double.TryParse(input, out double nota))
                    {
                        soma += nota;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida, tente novamente.");
                        j--;
                    }
                }

                medias[i] = soma / 4;

                if (medias[i] >= 7.0)
                {
                    alunosAprovados++;
                }
            }

            Console.WriteLine($"Número de alunos com média maior ou igual a 7.0: {alunosAprovados}");
        }
        /// <summary>
        /// Faça um Programa que leia um vetor de 5 números inteiros, mostre a soma, a
        /// multiplicação e os números.
        /// </summary>
        public static void Atividade7()
        {
            int[] numeros = new int[5];
            int soma = 0;
            int multiplicacao = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int valor))
                {
                    numeros[i] = valor;
                    soma += valor;
                    multiplicacao *= valor;
                }
                else
                {
                    Console.WriteLine("Número inválido, tente novamente.");
                    i--;
                }
            }

            Console.WriteLine($"Números lidos: {string.Join(", ", numeros)}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
        }
    }
}