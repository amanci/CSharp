using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using Senaizinho.Models;

namespace Senaizinho {
    class Program {
        public int LimiteAlunos { get; set; }
        public int LimiteSalas { get; set; }
        public List<Aluno> Alunos;
        public List<Sala> Salas;
        public int AlunosCadastrados { get; set; }
        public int SalasCadastradas { get; set; }
        bool QuerSair { get; set; }

        public Program () {
            this.LimiteAlunos = 100;
            this.LimiteSalas = 10;
            this.Alunos = new List<Aluno> ();
            this.Salas = new List<Sala> ();
            this.AlunosCadastrados = 0;
            this.SalasCadastradas = 0;
            this.QuerSair = false;
        }
        public void CadastrarAluno () {
            if (this.LimiteAlunos > 0) {

                Aluno aluno = new Aluno ();

                System.Console.WriteLine ("DIGITE O NOME DO ALUNO: ");
                aluno.Nome = Console.ReadLine ();

                System.Console.WriteLine ("DIGITE A IDADE DO ALUNO: ");
                aluno.Idade = int.Parse (Console.ReadLine ());

                this.Alunos.Add (aluno);

                this.LimiteAlunos--;
                this.AlunosCadastrados++;
            }
        }

        public void CadastrarSala () {
            if (this.LimiteSalas > 0) {

                System.Console.WriteLine ("========= CADASTRAR SALA ==========");
                System.Console.WriteLine ("DIGITE O NÚMERO DA SALA: ");
                int numeroSala = int.Parse (Console.ReadLine ());

                Sala sala = new Sala (numeroSala, 10);

                this.Salas.Add (sala);

                LimiteSalas--;
                this.SalasCadastradas++;
            }
        }

        public void AlocarAluno () {
            System.Console.WriteLine ("DIGITE O NOME DO ALUNO A SER ALOCADO: ");
            string nomeAlunoDigitado = Console.ReadLine ();

            System.Console.WriteLine ("DIGITE O NÚMERO DA SALA: ");
            int numeroSalaDigitado = int.Parse (Console.ReadLine ());

            bool alunoExiste = false;
            bool salaExiste = false;


            //int contadorAluno = 0;
            int contadorSala = 0;

            //int indexAluno = 0;
            int indexSala = 0;

            foreach (var aluno in this.Alunos) {
                if (nomeAlunoDigitado == aluno.Nome) {
                    
                    aluno.NumeroSala = numeroSalaDigitado;
                    alunoExiste = true;

                    //indexAluno = contadorAluno;
                }
                 //contadorAluno++;
            }

            foreach (var sala in this.Salas) {
                if (numeroSalaDigitado == sala.NumeroSala) {
                    salaExiste = true;
                    indexSala = contadorSala;
                }
                contadorSala++;
            }

            if (alunoExiste == true && salaExiste == true) {
                Sala sala = new Sala (numeroSalaDigitado, 10);
                var alunosSala = sala.AlunosSala;
                
               string retornoAlocar =  sala.AlocarAluno (nomeAlunoDigitado);
               this.Salas.RemoveAt(indexSala);
               this.Salas.Insert(indexSala, sala);
               
               System.Console.WriteLine(retornoAlocar);

            } else if (alunoExiste == false && salaExiste == false) {
                System.Console.WriteLine ("ALUNO NÃO EXISTE");
                System.Console.WriteLine ("SALA NÃO EXISTE");

            } else if (alunoExiste == true && salaExiste == false) {
                System.Console.WriteLine ("ALUNO EXISTE");
                System.Console.WriteLine ("SALA NÃO EXISTE");

            } else if (alunoExiste == false && salaExiste == true) {
                System.Console.WriteLine ("ALUNO NÃO EXISTE");
                System.Console.WriteLine ("SALA EXISTE");
            }
        }

        public void RemoverAluno () {
            System.Console.WriteLine ("DIGITE O NOME DO ALUNO A SER REMOVIDO: ");
            string nomeAlunoDigitado = Console.ReadLine (); 


            for (int i = 0; i < this.Alunos.Count; i++){

            }
        }

        static void Main (string[] args) {
            Program p = new Program ();
            p.CadastrarAluno ();
            p.CadastrarSala ();
            p.AlocarAluno ();
            p.RemoverAluno();
            
        }
    }
}