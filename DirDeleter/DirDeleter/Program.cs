using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.Write("DIRectorDELeter\n\n");
            Console.Write("Digite o diretório que deseja trabalhar: ");
            string path = Console.ReadLine();
            Console.Clear();

            string[] diretorios = Directory.GetDirectories(path);

            string file = "";
            foreach (string pasta in diretorios)
            {
                string[] ficheiros = Directory.GetFiles(pasta);





                DirectoryInfo dir = new DirectoryInfo(pasta);

                foreach (string ficheiro in ficheiros)
                {
                    if (Directory.GetFiles(pasta).Length != 0 || Directory.GetDirectories(pasta).Length != 0)
                    {

                        int golo = ficheiro.IndexOf(@"\", path.Length);
                        golo = ficheiro.IndexOf(@"\", golo + 2);
                        file = ficheiro.Substring(golo);
                    }

                    File.Move(ficheiro, path + file);
                }
                dir.Delete();
                if (Directory.Exists(pasta))
                {
                    Console.WriteLine("erro OwO");
                }
                else
                {
                    Console.WriteLine("Bem sucedido, és o rei");
                }

            }
            Console.ReadKey();
            string[] afterdir = Directory.GetDirectories(path);
            Console.Clear();
            Console.WriteLine("A tua posta ficou assim\nListar diretorios:\n ");
            foreach (string pasta in afterdir)
            {
                Console.WriteLine(pasta);
            }

            Console.ReadKey();
        }
    }
}
