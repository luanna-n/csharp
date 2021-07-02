# Dividindo X por Y :woman_technologist:

## **Nível: Básico**

## Desafio

Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.

## Entrada

A entrada contém um número inteiro **N**. Este **N** será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

## Saída

Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

## Código

using System; <br>
 <br>
class Desafio { <br>
    static void Main() { <br>
        int limit = Int32.Parse(Console.ReadLine()); <br>
        for (int i = 0; i < limit; i++)  <br>
        { <br>
            string[] line = Console.ReadLine().Split(" "); <br>
            double X = double.Parse(line[0]); <br>
            double Y = double.Parse(line[1]); <br>
            if (Y == 0) { <br>
                Console.WriteLine("divisao impossivel"); <br>
            } else { <br>
                double divisao = X / Y;  <br>
                Console.WriteLine(divisao.ToString("N1")); <br>
            } <br>
        }
    }
}
