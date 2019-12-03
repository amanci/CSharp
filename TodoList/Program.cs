using System.Runtime.Serialization;
using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection.Emit;
using System.Data;
using System.Net;
using System.Security.AccessControl;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.IO;
using System.Collections.Generic;
using TodoList_Fukaya;


namespace TodoList_Fukaya
{
    class Program
    {
        static int Main(string[] args)
        {
            List<TodoItem> todoList = new List<TodoItem>();
            string fileName = "todo.csv";
            string filePath = @"//home//am4nc1//GIT//CSharp//SENAI_INFO//TodoList_Fukaya//" + fileName;

            todoList = initList(@filePath);
            
            if(todoList == null){
                return -1;
            }

            int opcao = 0;

            do{
                Console.Clear();
                Console.WriteLine("Todo List");
                Console.WriteLine();
                ListaItens(todoList);
                Console.WriteLine();
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1 - Adicionar Item");
                Console.WriteLine("2 - Remover Item");
                Console.WriteLine("3 - Terminar");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao){
                    case 1:
                        AddItem(todoList);
                        break;
                    case 2:
                        RemoveItem(todoList);
                        break;
                    case 3:
                        SaveList(todoList, @filePath);
                        Console.WriteLine("Tchau!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
            }while(opcao != 3);

            return 0;
        }

        static List<TodoItem> initList(string filePath)
        {
            List<TodoItem> todoList = new List<TodoItem>();

            try{
                string[] todoFile = File.ReadAllLines(@filePath);
                
                foreach(string line in todoFile){
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"","");
                    string nota = itens[1].Replace("\"","");
                    TodoItem todoItem = new TodoItem(titulo,nota);
                    todoList.Add(todoItem);
                }

                todoList.RemoveAt(0);
                return todoList;

            } catch(IOException e){
                Console.WriteLine("Erro de Acesso.");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    
        static void ListaItens(List<TodoItem> todoList){
            Console.Clear();
            int count = 1;
            Console.WriteLine("Todo List");
            Console.WriteLine();
            Console.WriteLine($"ID{"",2} Titulo{"",12} Notas");
            foreach (TodoItem item in todoList)
            {
                Console.WriteLine($"{count,3}: {item.Titulo,-15} - {item.Nota}");
                count++;
            }
        }

        static void AddItem(List<TodoItem> todoList){
            Console.Clear();
            Console.WriteLine("Novo Item");
            Console.WriteLine();
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.Write("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo,nota);
            todoList.Add(item);
        }

        static void RemoveItem(List<TodoItem> todoList){
            int index = 0;

            do{
                Console.Clear();
                Console.WriteLine("Remove Item");
                Console.WriteLine();
                ListaItens(todoList);
                Console.WriteLine();
                Console.WriteLine("Digite o ID ou x para terminar");
                Console.WriteLine("ID: ");
                string id = Console.ReadLine();

                if(id.ToLower() == "x"){
                    break;
                } else {
                    index = int.Parse(id) - 1;
                }

                if((index < 0) || (index > todoList.Count - 1)){
                    Console.WriteLine("ID inválido");
                    Console.WriteLine("Pressione <enter> para continuar");
                    Console.ReadLine();
                } else {
                    todoList.RemoveAt(index);
                }
            }while(true);
        }
            static void SaveList (List<TodoItem> lista, string path){
                
                List <string> linhas = new List <string> ();

                linhas.Add("TITLE, NOTE");

                foreach(TodoItem item in lista){
                    string titulo = "\"" +  item.Titulo + "\"";
                    string nota = "\"" + item.Nota + "\"";

                    linhas.Add(titulo + "," + nota);
                }

                string tentarNovamente = "n";

                do{
                    try{
                        File.WriteAllLines(@path, linhas);
                        tentarNovamente = "n";
                    } catch (IOException e){
                        Console.WriteLine("ERRO NA LEITURA DO ARQUIVOS");
                        Console.WriteLine(e.Message);

                        do{
                            Console.WriteLine("DESEJA TENTAR NOVAMENTE (S / N) ?");

                            tentarNovamente = Console.ReadLine();
                            tentarNovamente =  tentarNovamente.ToLower();

                            if ((tentarNovamente != "n") || (tentarNovamente != "s")){
                                
                                Console.WriteLine("OPÇÃO INVÁLIDA !");

                            }
                        } while ((tentarNovamente == "s") || (tentarNovamente == "n"));
                    }
                } while (tentarNovamente != "n");
            }
        }
    }
