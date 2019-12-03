using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using _29.Models;

namespace _29
{
    class Program
    {   
        private static List<Registro> _Registros = new List<Registro>();

        public Program(){
    
        }

        private static List<Registro> CadastrarContatos(List<Registro> listaReg){
            string nome = "";
            string telefone = "";
            string aniversario = "";
            string opcaoSair = "";

            do{

                System.Console.Write("NOME: ");
                nome = Console.ReadLine().ToUpper();
                System.Console.WriteLine();

                System.Console.Write("TELEFONE: ");
                telefone = Console.ReadLine().ToUpper();
                System.Console.WriteLine();

                System.Console.Write("ANIVERSÁRIO (dd/mm): ");
                aniversario = Console.ReadLine().ToUpper();
                System.Console.WriteLine();

                Registro registro = new Registro(nome, telefone, aniversario);
                _Registros.Add(registro);

                System.Console.WriteLine("DESEJA REALIZAR MAIS ALGUM CADASTRO?");
                System.Console.Write("S OU N: ");
                opcaoSair = Console.ReadLine().ToUpper();
                System.Console.WriteLine();

            } while(opcaoSair != "N");

            return _Registros;
        }

        
        private static List<Registro> AtualizarContatos (List<Registro> listaReg){

            string nomeAtualizado = "";
            string telefoneAtualizado = "";
            string aniversarioAtualizado = ""; 
            int id  = 1;
            int opcaoMenu = -1;
            // TODO IMPLEMENTAR LAÇO while NO MENU OPÇÃO ATUALIZAR 
            // ! string opcaoSair = "";

            foreach (var registro in listaReg){
                System.Console.WriteLine($"ID: {id} | NOME: {registro.GetSetNome} | TELEFONE: {registro.GetSetTelefone} | ANIVERSÁRIO: {registro.GetSetAniversario}"); 
                
                id++;
            }

            System.Console.WriteLine();
            System.Console.Write("DIGITE O ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Clear();

            System.Console.WriteLine("CONTATO A SER ATUALIZADO");
            System.Console.WriteLine();
            
            System.Console.WriteLine($"ID: {id} | NOME: {listaReg[id-1].GetSetNome} | TELEFONE: {listaReg[id -1].GetSetTelefone} | ANIVERSÁRIO: {listaReg[id - 1].GetSetAniversario}");
            System.Console.WriteLine();

            System.Console.WriteLine("SELECIONE O DADO QUE DESEJA ATUALIZAR");
            System.Console.WriteLine();

            System.Console.WriteLine("[1] NOME");
            System.Console.WriteLine("[2] TELEFONE");
            System.Console.WriteLine("[3] ANIVERSÁRIO");
            System.Console.WriteLine("[4] TODOS");
            System.Console.WriteLine();

            System.Console.Write("OPÇÃO: ");
            opcaoMenu = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            switch(opcaoMenu){

                case 1:
                    System.Console.Write("NOME: ");
                    nomeAtualizado = Console.ReadLine().ToUpper();
                    _Registros[id -1].GetSetNome = nomeAtualizado;
                break;

                case 2:
                    System.Console.Write("TELEFONE: ");
                    telefoneAtualizado = Console.ReadLine().ToUpper();
                    _Registros[id -1].GetSetTelefone = telefoneAtualizado;
                break;

                case 3:
                    System.Console.Write("ANIVERSÁRIO (dd/mm): ");
                    aniversarioAtualizado = Console.ReadLine().ToUpper();
                    _Registros[id -1].GetSetAniversario = aniversarioAtualizado;
                break;

                case 4:
                    System.Console.Write("NOME: ");
                    nomeAtualizado = Console.ReadLine().ToUpper();
                    _Registros[id -1].GetSetNome = nomeAtualizado;
                    System.Console.WriteLine();

                    System.Console.Write("TELEFONE: ");
                    telefoneAtualizado = Console.ReadLine().ToUpper();
                    _Registros[id -1].GetSetTelefone = telefoneAtualizado;
                    System.Console.WriteLine();

                    System.Console.Write("ANIVERSÁRIO (dd/mm): ");
                    aniversarioAtualizado = Console.ReadLine().ToUpper();
                    _Registros[id -1].GetSetAniversario = aniversarioAtualizado;
                    System.Console.WriteLine();

                break;

                default:
                    System.Console.WriteLine("OPÇÃO INVÁLIDA");
                break;
            }
            return _Registros;
        }
 

        private static List<Registro> RemoverContatos (List<Registro> listaReg){

            int id  = 1;
            foreach (var registro in listaReg){
                System.Console.WriteLine($"ID: {id} | NOME: {registro.GetSetNome} | TELEFONE: {registro.GetSetTelefone} | ANIVERSÁRIO: {registro.GetSetAniversario}");

                id++;
            }
            System.Console.WriteLine();
            System.Console.Write("DIGITE O ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Clear();

            System.Console.WriteLine("CONTATO REMOVIDO");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID: {id} | NOME: {listaReg[id-1].GetSetNome} | TELEFONE: {listaReg[id -1].GetSetTelefone} | ANIVERSÁRIO: {listaReg[id - 1].GetSetAniversario}");
            System.Console.WriteLine();
            _Registros.RemoveAt(id - 1);
        
            return _Registros;
        }


        private static void BuscarContatos (List<Registro> listaReg){
            
            int idNome = 1;
            string nomeBusca = "";
            int idAniversario = 1;
            string aniversarioBusca = "";
            int opcaoBusca = -1;

            System.Console.WriteLine("SELECIONE O TIPO DE BUSCA");
            System.Console.WriteLine();

            System.Console.WriteLine("[1] BUSCA POR NOME");
            System.Console.WriteLine("[2] BUSCA POR ANIVERSÁRIO (dd/mm)");
            System.Console.WriteLine();

            System.Console.Write("OPÇÃO: ");
            opcaoBusca = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            switch(opcaoBusca){

                case 1:
                    System.Console.Write("DIGITE O NOME PARA BUSCA: ");
                    nomeBusca = Console.ReadLine();
                    System.Console.WriteLine();

                    foreach(var registro in listaReg){

                        if(registro.GetSetNome ==  nomeBusca){
                            System.Console.WriteLine("DADOS DO CONTATO");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"ID: {idNome} | NOME: {listaReg[idNome - 1].GetSetNome} | TELEFONE: {listaReg[idNome -1].GetSetTelefone} | ANIVERSÁRIO: {listaReg[idNome - 1].GetSetAniversario}");
                            System.Console.WriteLine();
                            break;
                        }
                        idNome++;
                    }
                break;

                case 2:
                    System.Console.Write("DIGITE O ANIVERSÁRIO (dd/mm) PARA BUSCA: ");
                    aniversarioBusca = Console.ReadLine();
                    System.Console.WriteLine();

                    foreach(var registro in listaReg){
                        
                        if(registro.GetSetAniversario ==  aniversarioBusca){
                            System.Console.WriteLine("DADOS DO CONTATO");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"ID: {idAniversario} | NOME: {listaReg[idAniversario - 1].GetSetNome} | TELEFONE: {listaReg[idAniversario - 1].GetSetTelefone} | ANIVERSÁRIO: {listaReg[idAniversario - 1].GetSetAniversario}");
                            System.Console.WriteLine();
                            break;
                        }
                        idAniversario++;
                    }
                break;

            }   
        }


        private static void ListarContatos(List<Registro> listaReg){

            int id = 1;

            System.Console.WriteLine("LISTA DE CONTATOS");
            System.Console.WriteLine();

            foreach(var registros in listaReg){

                System.Console.WriteLine($"ID: {id} | NOME: {registros.GetSetNome} | TELEFONE: {registros.GetSetTelefone} | ANIVERSÁRIO: {registros.GetSetAniversario}");

                id++;
            }
            System.Console.WriteLine();
        } 
 

        private static void ExibirMenu(){
            
            int opcaoMenu = -1;

            do {
                System.Console.WriteLine ("=============== MENU ===============");
        
                System.Console.WriteLine();
                System.Console.WriteLine ("[1] CADASTRAR");
                System.Console.WriteLine ("[2] ATUALIZAR");
                System.Console.WriteLine ("[3] REMOVER");
                System.Console.WriteLine ("[4] BUSCAR");
                System.Console.WriteLine ("[5] LISTAR");
                System.Console.WriteLine ("[6] ENCERRAR");
                System.Console.WriteLine();

                System.Console.Write ("SELECIONE A OPÇÃO: ");
                opcaoMenu = int.Parse (Console.ReadLine ());

                Console.Clear();

                switch (opcaoMenu) {

                    case 1:
                        CadastrarContatos(_Registros);
                    break;
                
                    case 2:
                        AtualizarContatos(_Registros);
                    break;

                    case 3:
                        RemoverContatos(_Registros);
                    break;

                    case 4:
                        BuscarContatos(_Registros);
                    break;

                    case 5:
                        ListarContatos(_Registros);
                    break;

                    case 6:
                        System.Console.WriteLine("ENCERRANDO...");
                    break;

                    default:
                        System.Console.WriteLine("OPÇÃO INVÁLIDA");
                    break;
                }

            } while (opcaoMenu != 6);
        }


        static void Main(string[] args)
        {
            ExibirMenu();
        }
    }
}
