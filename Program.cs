using System;

namespace Exercicio_Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string  senhadigitada;
            
            Console.Write("\nOlá, usuário. Por favor, digite sua senha:.. ");
            senhadigitada = Console.ReadLine();

            if (senhadigitada=="1234abcd")
            {
                Console.ForegroundColor =  ConsoleColor.DarkGreen;
                Console.WriteLine("Acesso permitido\n");
                Console.ResetColor();
            }
            else 
            {
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine("Acesso negado\n"); 
               Console.ResetColor();
            }
           
        }
    }
}
