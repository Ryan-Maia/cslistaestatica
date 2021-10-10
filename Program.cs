using System;

namespace exercicio
{
    class Program
    {
        static int choice;
        static Lista jogadores;
        static Lista quadras;
        static void Main(string[] args)
        {
            jogadores = new Lista(10);
            quadras = new Lista(10);
            
            choice = 0;

            
            while(true){
                Console.Clear();

                Console.WriteLine("Seja bem vindo ao controle de jogadores do time de basket da FATEC - ARAÇATUBA!");
                Console.WriteLine("Selecione uma das opções abaixo para acessar a correspondente área.");

                Console.CursorVisible = false;

                string[] messages = {"Cadastro de jogador", "Cadastro de quadra", "Encerrar"};

                writeOptions(messages);

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
        static void writeOptions (string[] messages)
        {
            Console.Clear();
            for(int i = 0; i < messages.Length; i++){
                if(i == choice)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("{0} - {1}",i+1, messages[i]);
                Console.ResetColor();
            }
        }

        static void playerMenu ()
        {
            string[] options = {"Listar Jogadores", "Cadastrar Jogador", "Editar Jogador", "Remover Jogador", "Ordenar Jogadores", "Retornar ao Menu"};
            
            while (true){
                writeOptions(options);
                Console.CursorVisible = false;

                string pressedKey = Console.ReadKey().Key.ToString();

                if(pressedKey == "UpArrow"){
                    choice = (choice - 1 < 0) ? options.Length - 1 : choice -= 1 ;
                } else if (pressedKey == "DownArrow"){
                    choice = (choice + 1 > options.Length - 1) ? 0 : choice += 1 ;
                } else if (pressedKey == "Enter"){
                    if(choice == 0)
                    {
                        Console.Clear();
                        string[] jogadoresLista = jogadores.Listar();
                        for (int i = 0; i < jogadoresLista.Length; i++)
                        {
                            Console.WriteLine("{0} - {1}",i+1,jogadoresLista[i]);
                        }
                        Console.Write("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                    }
                    else if (choice == 1)
                    {
                        Console.Clear();
                        Console.CursorVisible = true;
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
                            if(jogadores.Quantidade() == 0){
                                Console.Clear();
                                Console.WriteLine("Lista vazia. Pressione Enter para sair");
                                Console.ReadKey();
                                break;
                            }
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
                                Console.Clear();
                                Console.CursorVisible = true;
                                Console.Write("Insira um novo nome (vazio para cancelar): ");
                                string nome = Console.ReadLine();
                                nome = nome.Trim();
                                if (nome != ""){
                                    jogadores.Alterar(choice, nome);
                                }
                            }
                            else if (pressedKey2 == "Escape")
                            {
                                choice = 0;
                                break;
                            }
                        }
                    }
                    else if (choice == 3)
                    {
                        choice = 0;
                        while (true)
                        {
                            if(jogadores.Quantidade() == 0){
                                Console.Clear();
                                Console.WriteLine("Lista vazia. Pressione Enter para sair");
                                Console.ReadKey();
                                break;
                            }
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
                                Console.Clear();
                                Console.CursorVisible = true;
                                jogadores.Remover(choice);
                            }
                            else if (pressedKey2 == "Escape")
                            {
                                choice = 0;
                                break;
                            }
                        }
                    }
                    else if (choice == 4)
                    {
                        jogadores.Ordernar(1);
                        Console.WriteLine("Jogadores ordenados com sucesso!");
                        Console.ReadKey();
                    }
                    else 
                    {
                        choice = 0;
                        break;
                    }
                } else if (pressedKey == "Escape"){
                    break;
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
