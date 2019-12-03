using System;
using System.Collections;
using System.Collections.Generic;

namespace Senaizinho.Models {
    public class Sala {
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; set; }
        public int NumeroSala { get; set; }
        public List<string> AlunosSala;

        public Sala (int numeroSala, int capacidadeTotal) {
            this.NumeroSala = numeroSala;
            this.CapacidadeTotal = capacidadeTotal;
            this.CapacidadeAtual = 0;
            this.AlunosSala = new List<string> ();
        }

        public string AlocarAluno (string nome) {
            string mensagemAlocar = "";

            if (this.AlunosSala.Count <= CapacidadeTotal) {
                AlunosSala.Add (nome);
                mensagemAlocar = "ALUNO ALOCADO";
                this.CapacidadeAtual += 1;
                this.CapacidadeTotal -= 1;
            } else {
                mensagemAlocar = "ALUNO NÃO ALOCADO";
            }
            return mensagemAlocar;
        }

        public string RemoverAluno (string nome) {
            string mensagem = "";
            bool alunoRemovido = false;

            if (this.CapacidadeAtual > 0) {
                foreach (var alunoSala in this.AlunosSala) {
                    if (nome == alunoSala) {
                        this.AlunosSala.Remove(nome);
                        alunoRemovido = true;
                    }
                }
            } else {
                mensagem = "ALUNO NÃO ENCONTRADO";
            }

            if (alunoRemovido == true) {
                mensagem = "ALUNO REMOVIDO COM SUCESSO!";
            }

            return mensagem;

        }

        public string MostrarAluno () {
            string exibicaoNomes = "";
            foreach (var nomeAluno in this.AlunosSala) {
                exibicaoNomes = nomeAluno + "-" + exibicaoNomes;
            }

            return exibicaoNomes;

        }

    }
}