using System;
using System.Collections;
using System.Collections.Generic;

namespace _27 {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, string> Cadastro = new Dictionary<string, String> ();
            string sair = "";
            int menu = -1;

            do {
                System.Console.WriteLine ("=============== MENU ===============");
                System.Console.WriteLine ("1 | CADASTRAR CONTATO");
                System.Console.WriteLine ("2 | APAGAR CONTATO");
                System.Console.WriteLine ("3 | BUSCAR CONTATO");
                System.Console.WriteLine ("4 | LISTAR CONTATOS");
                System.Console.WriteLine ("5 | ENCERRAR PROGRAMA");

                System.Console.WriteLine ("SELECIONE A OPÇÃO: ");
                menu = int.Parse (Console.ReadLine ());

                switch (menu) {
                    case 1:
                        do {
                            System.Console.WriteLine ("NOME: ");
                            string nome = Console.ReadLine ().ToUpper();

                            System.Console.WriteLine ("DATA NASCIMENTO (DD/MM/AAAA): ");
                            string dataNascimento = Console.ReadLine().ToUpper();

                            Cadastro.Add (nome, dataNascimento);

                            System.Console.WriteLine ("DESEJA SAIR DA TELA DE CADASTRO? S / N");
                            sair = Console.ReadLine().ToUpper();

                        } while (sair != "S");
                    break;

                    case 2:
                        do {
                            System.Console.WriteLine ("NOME: ");
                            string nome = Console.ReadLine ().ToUpper();

                            foreach (var nomeKey in Cadastro) {
                                if (nomeKey.Key == nome) {
                                    Cadastro.Remove (nome);
                                    System.Console.WriteLine("CONTATO APAGADO");
                                    break;

                                } else{
                                    System.Console.WriteLine("CONTATO NÃO EXISTE");
                                    break;
                                }
                            }
                            
                            System.Console.WriteLine ("DESEJA SAIR? S / N");
                            sair = Console.ReadLine().ToUpper();

                        } while (sair != "S");
                    break;

                    case 3:
                        do {
                            System.Console.WriteLine ("NOME: ");
                            string nome = Console.ReadLine().ToUpper();

                            foreach (var exibirCadastro in Cadastro) {
                                if (exibirCadastro.Key == nome) {
                                    System.Console.WriteLine($"NOME: {exibirCadastro.Key} - {exibirCadastro.Value}");
                                    break;

                                } else {
                                    System.Console.WriteLine ("CONTATO NÃO ENCONTRADO");
                                    break;
                                }
                            }
                            System.Console.WriteLine ("DESEJA SAIR? S / N");
                            sair = Console.ReadLine ().ToUpper ();

                        } while (sair != "S");
                    break;

                    case 4:
                    int id = 1;
                        foreach(var listarContatos in Cadastro){

                            System.Console.WriteLine($"ID: {id} | NOME: {listarContatos.Key} | DATA-NASCIMENTO: {listarContatos.Value}");

                            id++;
                        }
                    break;

                    case 5:
                        System.Console.WriteLine ("ENCERRANDO...");
                    break;

                    default:
                        System.Console.WriteLine ("OPÇÃO INVÁLIDA");
                    break;

                }

            } while (menu != 5);
        }
    }
}