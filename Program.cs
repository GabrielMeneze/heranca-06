using System;

namespace _06_heran
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpff = new CPF();
            Pessoa user = new Pessoa();

            System.Console.Write("Digite seu nome: ");
            string Nome = Console.ReadLine();


            System.Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();

            System.Console.Write("Digite seu RG: ");
            string rg = Console.ReadLine();

            
            System.Console.Write("Digite seu CNPJ: ");
            string cnpj = Console.ReadLine(); 

            cpff.Validar(cpf, rg, cnpj);

            if(cpff.Tokenn != "" && cpff.Tokenn != null){
                System.Console.WriteLine("Acesso Permitido, Bem vindo {0}",Nome);
            }else{
                System.Console.WriteLine("Acesso negado");
            }

            
        }
    }
}
