namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y; //em qualquer lugar que eu instanciar um objeto Ponto, poderei acessar
        private int distancia;
        
        public Ponto(int x, int y)
        {
            this.x = x; //ta se referindo a essa classe aqui!!!
            this.y = y;
        }

        protected void CalcularDistancia() //quem herdar, terá acesso
        {
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        private void CalcularDistancia2() //so aqui dentro (interno)
        {
            //Faz alguma coisa...
        }

        public virtual void CalcularDistancia3() //virtual permite que uma classe filha sobrescreva a atuação dele
        {
            //Faz alguma coisa...
        }
    }
}