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
                case 2: CriarNovoArquivo(); break;
                default: Menu(); break;
            }

        }

        static void AbrirArquivo() { }

        static void CriarNovoArquivo() { }
    }
}

