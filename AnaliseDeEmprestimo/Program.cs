using System;

namespace AnaliseDeEmprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 4) A prefeitura de Mococa abriu uma linha de crédito para os funcionários estatutários. 
             * O valor máximo da prestação não poderá ultrapassar 30% do salário bruto. Faça um 
             * programa que permita entrar com o salário bruto e o valor da prestação, e informar 
             * se o empréstimo pode ou não ser concedido. 
             */
            double salario_bruto;
            double trinta_porcento;
            double valor_prestacao;

            Console.WriteLine("Informe o salário bruto: ");
            salario_bruto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da prestação: ");
            valor_prestacao = Convert.ToDouble(Console.ReadLine());

            trinta_porcento = salario_bruto * 0.3;

            if(valor_prestacao > trinta_porcento)
            {
                Console.WriteLine("Emprestimo negado. Prestação maior que 30% do seu salário.");

            } else
            {
                Console.WriteLine("Emprestimo aprovado.");
            }


            Console.ReadKey();
        }
    }
}
