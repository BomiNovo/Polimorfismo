namespace Polimorfismo
{
    class Desenvolvedor : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return Salario * 0.12;
        }
    }
}
