namespace Classes.Metodos
{
    public class Out //também ajuda a trabalhar com o método
    {
        static void Dividir(int x, int y, out int resultado, out int resto) 
        {
            resultado = x / y;
            resto = x % y;
        }
        
        public static void Dividir() 
        {//permite que na propria chamada do metodo eu já declare uma variável que
        //vai ser chamada no próprio retorno do método que eu estou chamando e eu
        //consigo com ela acessar aqui dentro deste método
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);	// Escreve "3 1"
        }
    }
}