using System;

namespace Validacao_informacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double salario;
            char civil;

            do{
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            if(nome == "" || nome == " "){
                Console.WriteLine("Erro! Nome inválido.");
            }

            }while(nome == "" || nome == " ");

            do{
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if(idade < 0 || idade > 100){
                    Console.WriteLine("Erro! Idade inválida");
                }  
            }while(idade < 0 || idade > 100);

            do{
                Console.WriteLine("Valor da sua renda mensal: ");
                salario = double.Parse(Console.ReadLine());

                if(salario <= 0){
                    Console.WriteLine("Sua renda não pode ser cadastrada! Escreva um valor real.");
                }

            }while(salario <= 0);

            do{
                Console.WriteLine("Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)");
                civil = char.Parse(Console.ReadLine());

                if(civil != 's' && civil != 'c' && civil != 'v' && civil != 'd'){
                    Console.WriteLine("Resposta inválida! Digite um valor como o do exemplo acima.");
                }

            }while(civil != 's' && civil != 'c' && civil != 'v' && civil != 'd');

            Console.WriteLine("Informações obtidas");
        }
    }
}
