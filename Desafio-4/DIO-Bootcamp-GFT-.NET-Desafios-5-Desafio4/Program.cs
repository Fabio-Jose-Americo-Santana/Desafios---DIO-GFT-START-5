﻿//Desafio
//Você recebeu o desafio de ler 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
//Entrada
//O arquivo de entrada contém 100 números inteiros, positivos e distintos.
//Saída
//Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo
//Exemplo Entrada	        Exemplo Saída
//      2                       34565
//      113                       4
//      45
//      34565
//      6...
//      8



using System;

class TESTE
{
    static void Main(string[] args)
    {
        int n;
        int maior = 0;
        int posicao = 1;
        for (int i = 1; i <= 100; i++)
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
                posicao = i;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}