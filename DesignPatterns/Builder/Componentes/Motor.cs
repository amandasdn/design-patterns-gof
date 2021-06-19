namespace Builder.Componentes
{
    class Motor
    {
        private int _potencia;

        public int Potencia
        {
            get => _potencia;
            set => _potencia = value;
        }

        public Motor(int potencia)
        {
            Potencia = potencia;
        }
    }
}
