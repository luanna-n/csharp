using System;

namespace EstruturaDoPrograma /*deve ser o nome da pasta onde ele*/
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            /*Console.WriteLine(s.Desempilha()); vai rolar um problema agora*/
        }
    }
}
