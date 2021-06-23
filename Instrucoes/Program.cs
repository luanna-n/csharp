using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
            /*
            Posso declarar variaveis e constantes locais;
            Posso declarar tudo numa linha, ou todas juntas, 
            especificando o valor na criação ou após a criação;
            Imprime o valor 10
            */
        }

        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        /*
        string[] é uma string // args é o parametro
        $ interpolação de string => permite concatenar e alterar o texto da string
        */

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0: //caso seja 0
                    Console.WriteLine("Nenhum argumento");
                    break; //imprime o argumento e sai do switch
                    //caso fosse retornar algo, usaria o RETURN e não precisaria do break
                case 1: //caso seja 1
                    Console.WriteLine("Um argumento");
                    break;
                default: //caso seja diferente de 0 e de 1
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        /*
        O switch é parecido com o if/else, mas a forma dele trabalhar é mais simples
        A escrita pode ser mais verbosa
        */

        static void InstrucaoWhile(string[] args) //iterar entre alguns itens
        {
            int i = 0;
            while (i < args.Length) //enquanto i menor que o numero de argumentos que tenho for verdade
            {
                Console.WriteLine(args[i]); //imprimo os argumentos de acordo com a posicao deles dentro do array
                i++; //i = i +1;
            }
        }

        static void InstrucaoDo(string[] args)
        {
            string texto;
            do //faz a verificação no final => ao menos 1x vai passar pela instrução
            //no while, pode não passar nenhuma vez
            {
                texto = Console.ReadLine(); //leia algo
                Console.WriteLine(texto); //pega o que foi lido (digitado pelo user)
            } while (!string.IsNullOrEmpty(texto)); //enquanto o string NÃO for nulo ou vazio, CONTINUA!
        }

        static void InstrucaoFor(string[] args)
        { //para i começando em 0, enquanto i < numero, acrescente 1 ao i
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]); //escreva o argumento que está na posição i dentro do array
            }
        }

        static void InstrucaoForeach(string[] args)
        {//executa um for, so que a forma de escrever é mais simples
        //para cada string S (NOME QUE EU DEI) dentro de args (meu parametro)
        //escreva S
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while (true) //enquanto for verdeiro (infinito)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {//eu posso tirar essas chaves nesse caso, pois o IF SEM CHAVES executa apenas a proxima linha
                //e nesse caso, só tenho 1 proxima linha
                    break; //auxiliar muito usado em laços de repetição
                    //funciona com o while e com o for
                }

                Console.WriteLine(s);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/")) //se começar com /, eu continuo, vou pro proximo bloco
                //se não tiver a /, executa o bloco de codigo
                //poderia ser obtido com um if/else
                {
                    continue; //auxiliar
                }
                
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(string[] args) //(void) esse metodo nao retorna nenhum valor, ele so executa alguma coisa
        {
            int Somar(int a, int b) //metodo somar => retorna alga
            {
                return a + b; //auxiliar
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }

        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {//exceptions
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();
                    //não posso fazer divisao por 0 => tratei a exceção
                    //se eu nao tivesse feito isso, teria dado um erro

                return x / y;
            }

            try //vou tentar fazer isso
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }//deu erro? tenta cair numa catch
            catch (InvalidOperationException e)
            {//vai imprimir minha excepcao + a mensagem = Informe 2 numeros
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {//todos as outras excecao
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {//se der certo ou se der errado => ele vai imprimir isso aqui
            //essa é a função do finally
                Console.WriteLine("Até breve!");
            }
        }

        static void InstrucaoUsing(string[] args)
        {//

            // System.IO.TextWriter w;
            // w = System.IO.File.CreateText("teste.txt");
            // outra forma de fazer o que está aqui embaixo
            // a diferença é que EU vou precisar eliminar ele (o elemento W) da memoria depois

            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}