namespace Proletario
{
    class Program
    {
        static void Main(string[] args)
        {
            Proletario proletario = new Proletario();

            Console.Write("Nome: ");
            proletario.name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            proletario.salary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            proletario.tax = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario: {proletario}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double increaseSalary = double.Parse(Console.ReadLine());
            proletario.AumentarSalario(increaseSalary);

            Console.WriteLine($"Dados atualizados: {proletario}");
        }
    }
}