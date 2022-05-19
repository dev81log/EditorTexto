using System;

namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha as opções: ");
            Console.WriteLine("1 - Abrir o Arquivo");
            Console.WriteLine("2 - Criar novo Arquivo");
            Console.WriteLine("0 - Sair do programa");

            short opcoesMenu = short.Parse(Console.ReadLine());

            switch (opcoesMenu)
            {
                case 0: Environment.Exit(0); break;
                case 1: AbrirArquivo(); break;
                case 2: EditarArquivo(); break;
                default: Menu(); break;
            }
        }

        static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo para abrir:");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Thread.Sleep(10000);
            Menu();
        }

        static void EditarArquivo()
        {
            Console.WriteLine("Digite seu texto de arquivo (ESC sair)");
            Console.WriteLine("---------------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            CriarArquivo(texto);
        }

        static void CriarArquivo(string texto)
        {
            Console.Clear();
            Console.WriteLine("Passe o caminho onde o arquivo sera salvo");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Salvo arquivo {caminho} com sucesso");
            Thread.Sleep(2000);
            Menu();
        }
    }
}

