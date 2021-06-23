namespace Classes.Metodos
{
    public class Ref //parametro do tipo ref
    {
        static void Inverter(ref int x, ref int y) //inverter trocou a ordem
        {//se fosse sem o inverter, recebe por valor
        //com o ref, recebe por referencia entao vai interferir de onde está sendo chamado

            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
}