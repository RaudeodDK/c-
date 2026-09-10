using System;
class Program
{
    static void Main()

    {
        double saldo = 500;
        int opcao;
        double deposito;
        double saque;

        do
        {
            Console.WriteLine("--------- Menu Banco ---------");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar dinheiro");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1 ){
                Console.WriteLine($"Seu saldo é de: R$ {saldo}");
            }
            
            else if (opcao == 2 ){
                Console.Write("Quanto deseja depositar?: ");
                deposito = double.Parse(Console.ReadLine());

                saldo = saldo + deposito;
            }

            else if (opcao == 3 ){
                Console.Write("Quanto deseja sacar?: ");
                saque = double.Parse(Console.ReadLine());

                if (saldo < saque){
                    Console.WriteLine("Saldo insuficiente");
                }
                else{
                    saldo = saldo - saque;
                }

            }
            else if (opcao > 3 || opcao < 0)
            {
                Console.WriteLine("Opção inválida, tente novamente");
            }
        }
        while (opcao != 0);
            {
                Console.WriteLine("Obrigado por usar o nosso sistema.");
            }
    }
}

// // Operadores Relacionais em C#

// // Igualdade (==)
// int a = 10;
// int b = 10;
// Console.WriteLine("a == b: " + (a == b)); // true

// // Desigualdade (!=)
// int x = 5;
// int y = 8;
// Console.WriteLine("x != y: " + (x != y)); // true

// // Maior que (>)
// Console.WriteLine("x > y: " + (x > y)); // false

// // Menor que (<)
// Console.WriteLine("x < y: " + (x < y)); // true

// // Maior ou igual (>=)
// Console.WriteLine("a >= b: " + (a >= b)); // true

// // Menor ou igual (<=)
// Console.WriteLine("x <= y: " + (x <= y)); //                 true

// // Exemplo com strings
// string nome1 = "João";
// string nome2 = "João";
// Console.WriteLine("nome1 == nome2: " + (nome1 == nome2)); // true

// // Exemplo com booleanos
// bool matricula = true;
// bool ativo = true;
// Console.WriteLine("matricula != ativo: " + (matricula != ativo)); // falso


// // ========== OPERADORES LÓGICOS ==========
// Console.WriteLine("\n--- OPERADORES LÓGICOS ---");

// // AND (&&) - Ambas as condições devem ser verdadeiras
// int idade = 20;
// bool temCarteira = true;
// Console.WriteLine("Pode dirigir? " + (idade >= 18 && temCarteira)); // true

// // OR (||) - Pelo menos uma condição deve ser verdadeira
// bool fimDeSemana = false;
// bool feriado = true;
// Console.WriteLine("Dia de descanso? " + (fimDeSemana || feriado)); // true

// // NOT (!) - Inverte o valor booleano
// bool chovendo = true;
// Console.WriteLine("Dia ensolarado? " + (!chovendo)); // false

// // Combinações mais complexas
// int nota = 8;
// bool compareceu = true;
// bool trabalhoEntregue = true;
// bool aprovado = (nota >= 7 && compareceu) || trabalhoEntregue;
// Console.WriteLine("Aluno aprovado? " + aprovado); // true


// Console.WriteLine("Qual a nota do aluno?");
// int nota = int.Parse(Console.ReadLine());

// // Variáveis booleanas
// bool notaSuficiente = nota >= 7;  // Operador relacional (>=)
// bool compareceu = true;
// bool trabalhoEntregue = true;

// // Operadores lógicos: && (AND), || (OR), ! (NOT)
// bool aprovado = (notaSuficiente && compareceu) || trabalhoEntregue;

// // Exibindo o resultado com operadores lógicos
// if (aprovado)
// {
//     Console.WriteLine("Aluno APROVADO! ✓");
//     Console.WriteLine("Razão: " + (notaSuficiente ? "Nota >= 7" : "Trabalho entregue"));
// }
// else
// {
//     Console.WriteLine("Aluno REPROVADO! ✗");
//     Console.WriteLine("Motivo: Nota < 7 E não compareceu E não entregou trabalho");
// }

// // Outros exemplos com operadores lógicos
// Console.WriteLine("\n--- Demonstração com valores diferentes ---");
// bool repouso = false;        // Não descansou
// bool estudou = true;          // Estudou
// bool podeRealizarProva = estudou && !repouso;  // Estudou E (NOT descansou)
// Console.WriteLine("Pode realizar a prova? " + podeRealizarProva); // false

//     Console.Write("Informe sua nota final: ");
//     double nota_final = double.Parse(Console.ReadLine());

//     Console.Write("Informe sua porcentagem de frequencia: ");
//     double frequencia = double.Parse(Console.ReadLine());

//     if (nota_final >= 9 || frequencia >= 95)
//     {
//         Console.WriteLine("Você é um aluno destaque");
//     }
//     else
//     {
//         Console.WriteLine("Não atingiu os requisitos.");
//     }
// int contador = 1;

// do
// {
//     Console.WriteLine(contador);
//     contador++;
// }
// while(contador <= 5);


// int idade;
// do
// {
//     Console.Write("Digite uma idade válida (maior ou igual a 0): ");
//     idade = int.Parse(Console.ReadLine());
// }
// while (idade < 0 );

// Console.WriteLine($"Idade registrada {idade}");

// int senha;

// do
// {
//     Console.Write("Informe uma senha: ");
//     senha = int.Parse(Console.ReadLine());
// }
// while (senha != 1234);