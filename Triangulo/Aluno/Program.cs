namespace Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.name = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno:");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nota Final = {aluno.CalculaNotaFinal():F2}");
            Console.WriteLine(aluno.CalculaAprovado() ? "Aprovado" : "Reprovado");
            
            if (!aluno.CalculaAprovado())
            {
                double notaFaltante = 70.00 - aluno.CalculaNotaFinal();
                Console.WriteLine($"Faltaram = {notaFaltante:F2}");
            }
        }
    }
}