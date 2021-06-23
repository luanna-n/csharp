namespace Classes.Herança
{
    public class Ponto3D : Ponto //herda da classe Ponto (:)
    //só posso herdar de 1 unica classe MAS posso herdar de multiplas interfaces
    {
        public int z; //complementei, pois já tinha x e y
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
            //não tem acesso ao CalcularDistancia2() pois é privado!!!
        }

        public static void Calcular() //static não pertence a instancia, pertence a CLASSE
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3() //override vai sobreescrever da classe mãe
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}