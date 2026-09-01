using System;
class Program
{
static void Main()

{   Console.Write("Informe sua nota final: ");
    double nota_final = double.Parse(Console.ReadLine());

    Console.Write("Informe sua porcentagem de frequencia: ");
    double frequencia = double.Parse(Console.ReadLine());
    
    if (nota_final >= 9 || frequencia >= 95)
    {
        Console.WriteLine("Você é um aluno destaque");
    }
    else
    {
        Console.WriteLine("Não atingiu os requisitos.");
    }

}
}
