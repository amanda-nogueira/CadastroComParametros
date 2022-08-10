using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroComParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome = "", tel = "", nec = "", cpf = "", rg = "", uf = "";
            int id = 0;

            Console.WriteLine(" Cadastro de usuários ");

            while (nome == "")
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
            }
            while (tel.Length < 11)
            {
                Console.WriteLine("Digite o número do seu celular: ");
                tel = Console.ReadLine();
            }
            while (!((id >= 18) && (id <= 99)))
            {
                Console.WriteLine("Digite sua idade: ");
                id = int.Parse(Console.ReadLine());
            }
            while (!((nec.ToUpper() == "S") || (nec.ToUpper() == "N")))
            {
                Console.Write("Necessidade especial? (S)im ou (N)ão? ");
                nec = Console.ReadLine();
            }
            while (cpf.Length < 11)
            {
                Console.WriteLine("Digite seu CPF: ");
                cpf = Console.ReadLine();
            }
            while (rg.Length < 9)
            {
                Console.WriteLine("Digite seu RG: ");
                rg = Console.ReadLine();
            }
            while (!(uf.Length == 2))
            {
                Console.WriteLine("Qual o estado em que você nasceu? (EX.: SP): ");
                uf = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("\n\n** Concluindo cadastro...**");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("Seu cadastro foi concluído com sucesso ");
            Console.WriteLine("Nome...........: {0}", nome);
            Console.WriteLine("Celular........: {0}", tel);
            Console.WriteLine("Idade..........: {0}", id);
            Console.WriteLine("Nec. Especial..: {0}", nec);
            Console.WriteLine("CPF............: {0}", cpf);
            Console.WriteLine("RG.............: {0}", rg);
            Console.WriteLine("UF.............: {0}", uf);

            Console.ReadKey();
        }
    }
}
