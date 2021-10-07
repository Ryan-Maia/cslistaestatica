using System;

namespace exercicio
{
    class Program
    {
        static int choice;
        static Lista jogadores;
        static Lista quadras;
        static string[] messages = {"1 - Cadastro de jogador", "2 - Cadastro de quadra", "3 - Encerrar"};
        static void Main(string[] args)
        {
            jogadores = new Lista(10);
            quadras = new Lista(10);
            
            choice = 0;
            while(true){
                menu();
                string pressedKey = Console.ReadKey().Key.ToString();
                if(pressedKey == "DownArrow"){
                    choice = (choice + 1 > messages.Length - 1) ? 0 : choice += 1;
                } else if (pressedKey == "UpArrow"){
                    choice = (choice - 1 < 0) ? messages.Length - 1 : choice -= 1;
                } else if (pressedKey == "Enter"){
                    if(choice == 0){
                        choice = 0;
                        playerMenu();
                    }
                    else if (choice == 1){
                        choice = 0;
                        stageMenu();
                    }
                    else {
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar o sistema!");
                        break;
                    }
                }
            }
            
        }
        static void menu() 
        {
            Console.Clear();

            Console.WriteLine("Seja bem vindo ao controle de jogadores do time de basket da FATEC - ARAÇATUBA!");
            Console.WriteLine("Selecione uma das opções abaixo para acessar a correspondente área.");

            Console.CursorVisible = false;

            for(int i = 0; i < messages.Length; i++){
                if(i == choice)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(messages[i]);
                    Console.ResetColor();
                }
                else 
                {
                    Console.WriteLine(messages[i]);
                }
            }
        }
        static void writeOptions (string[] messages)
        {
            Console.Clear();
            for(int i = 0; i < messages.Length; i++){
                if(i == choice)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(messages[i]);
                    Console.ResetColor();
                }
                else 
                {
                    Console.WriteLine(messages[i]);
                }
            }
        }

        static void playerMenu ()
        {
            string[] options = {"1 - Listar Jogadores", "2 - Cadastrar Jogador", "3 - Editar Jogador", "4 - Remover Jogador", "5 - Ordenar Jogadores", "6 - Retornar ao Menu"};
            
            while (true){
                writeOptions(options);

                string pressedKey = Console.ReadKey().Key.ToString();

                if(pressedKey == "UpArrow"){
                    choice = (choice - 1 < 0) ? options.Length - 1 : choice -= 1 ;
                } else if (pressedKey == "DownArrow"){
                    choice = (choice + 1 > options.Length - 1) ? 0 : choice += 1 ;
                } else if (pressedKey == "Enter"){
                    if(choice == 0)
                    {
                        Console.Clear();
                        foreach (string jogador in jogadores.Listar())
                        {
                            Console.WriteLine(jogador);
                        }
                        Console.Write("Aperte Enter para continuar");
                        Console.ReadLine();
                    }
                    else if (choice == 1)
                    {
                        Console.Clear();
                        Console.Write("Insira um nome (vazio para cancelar): ");
                        string nome = Console.ReadLine();
                        nome = nome.Trim();
                        if (nome != ""){
                            jogadores.Inserir(nome);
                        }
                        
                    }
                    else if (choice == 2)
                    {
                        choice = 0;
                        while (true)
                        {
                            writeOptions(jogadores.Listar());
                            Console.WriteLine("Aperte ESC para retornar");
                            string pressedKey2 = Console.ReadKey().Key.ToString();

                            if(pressedKey2 == "UpArrow")
                            {
                                choice = (choice - 1 < 0) ? jogadores.Quantidade() - 1 : choice -= 1 ;
                            } 
                            else if (pressedKey2 == "DownArrow")
                            {
                                choice = (choice + 1 > jogadores.Quantidade() - 1) ? 0 : choice += 1 ;
                            }
                            else if (pressedKey2 == "Enter")
                            {
                                //
                            }
                            else if (pressedKey2 == "Escape")
                            {
                                break;
                            }
                        }
                    }
                    else if (choice == 3)
                    {

                    }
                    else if (choice == 4)
                    {

                    }
                    else 
                    {
                        choice = 0;
                        break;
                    }
                }
            }
        }
        static void stageMenu ()
        {
            string[] options = {"1 - Consultar Quadra", "2 - Cadastrar Quadra", "3 - Editar Quadra", "4 - Remover Quadra", "5 - Ordenar Quadras", "6 - Retornar ao menu"};

            while (true){
                writeOptions(options);

                string pressedKey = Console.ReadKey().Key.ToString();

                if(pressedKey == "UpArrow"){
                    choice = (choice - 1 < 0) ? options.Length - 1 : choice -= 1 ;
                } else if (pressedKey == "DownArrow"){
                    choice = (choice + 1 > options.Length - 1) ? 0 : choice += 1 ;
                } else if (pressedKey == "Enter"){
                    if(choice == 4){
                        choice = 0;
                        break;
                    }
                }
            }
            Console.WriteLine("Player Menu");
        }
    }
}
