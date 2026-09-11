namespace Polimorfismo
{
    class Gerente : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return Salario * 0.15 + 1000;
        }
    }
}
