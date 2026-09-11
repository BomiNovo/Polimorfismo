namespace Polimorfismo
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public virtual double CalcularBonusAnual()
        {
            return Salario * 0.10;
        }
    }
}
