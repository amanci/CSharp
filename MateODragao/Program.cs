using System;
using MateODragao.Modelos;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {

            bool desejaContinuar = true;

            do {
                System.Console.WriteLine ("******************************");
                System.Console.WriteLine ("       MATE O DRAGÃO !");
                System.Console.WriteLine ("******************************");

                System.Console.WriteLine (" 1 | INICIAR JOGO");
                System.Console.WriteLine (" 0 | SAIR DO JOGO");
                string opcaoIniciarSair = Console.ReadLine ();

                switch (opcaoIniciarSair) {
                    case "1":
                        Console.Clear ();

                        Guerreiro guerreiro = CriarGuerreiro ();

                        Dragao dragao = new Dragao ();

                        dragao.Nome = "Regina Casé";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Hp = 300;

                        // INÍCIO - PRIMEIRO DIÁLOGO
                        CriarDialogo (guerreiro.Nome, "EU SOU A XENA! DERROTAR-TE-EI");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: VEM TRANQUILO! VEM PRO ESQUENTA!");
                        System.Console.WriteLine ();

                        FinalizarDialogo ();

                        // FIM - PRIMEIRO DIÁLOGO 

                        // INÍCIO - SEGUNDO DIÁLOGO
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: EU SOU {guerreiro.Nome}, {guerreiro.Sobrenome}, Ó CRIATURA HORRENDA");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: EU VIM DO {guerreiro.CidadeNatal} PARA MATAR-TE");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? VOCÊ TRABALHA NA GLOBO?");

                        FinalizarDialogo ();
                        // FIM - SEGUNDO DIÁLOGO

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        // INÍCIO - TRETA
                        if (jogadorAtacaPrimeiro) {
                            System.Console.WriteLine ("***** TURNO DO JOGADOR *****");
                            System.Console.WriteLine ("ESCOLHA SUA AÇÃO: ");
                            System.Console.WriteLine (" 1 - ATACAR");
                            System.Console.WriteLine ("2 - FUGIR");
                            string opcaoAtacarFugir = Console.ReadLine ();

                            switch (opcaoAtacarFugir) {
                                case "1":
                                    Random gerarNumAleatorio = new Random ();

                                    int numAleatorioJogador = gerarNumAleatorio.Next (0, 5);
                                    int numAleatorioDragao = gerarNumAleatorio.Next (0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numAleatorioJogador;
                                    int dragaoDestrazaTotal = dragao.Destreza + numAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrazaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: ACERTOU MISERAVI!");

                                        dragao.Hp -= poderAtaqueGuerreiro + 5;

                                        System.Console.WriteLine ("**********");
                                        System.Console.WriteLine ($"HP DRAGÃO: {dragao.Hp}");
                                        System.Console.WriteLine ($"HP GUERREIRO: {guerreiro.Hp}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: ERROOU!");
                                    }
                                    break;

                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: DEI FUGA!");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EASY");
                                    break;
                            }

                            FinalizarDialogo ();

                            while (dragao.Hp > 0 && guerreiro.Hp > 0 && jogadorNaoCorreu) {
                                System.Console.WriteLine ("***** TURNO DO DRAGÃO *****");

                                Random gerarNumAleatorio = new Random ();

                                int numAleatorioJogador = gerarNumAleatorio.Next (0, 5);
                                int numAleatorioDragao = gerarNumAleatorio.Next (0, 5);
                                int guerreiroDestrezaTotal = guerreiro.Destreza + numAleatorioJogador;
                                int dragaoDestrazaTotal = dragao.Destreza + numAleatorioDragao;

                                if (dragaoDestrazaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: CHAMA O BOMBEIRO!");

                                    guerreiro.Hp -= dragao.Forca;

                                    System.Console.WriteLine ("**********");
                                    System.Console.WriteLine ($"HP DRAGÃO: {dragao.Hp}");
                                    System.Console.WriteLine ($"HP GUERREIRO: {guerreiro.Hp}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: ERROOU!");
                                }

                                FinalizarDialogo ();

                                // INICIO - TURNO JOGADOR
                                System.Console.WriteLine ("***** TURNO DO JOGADOR *****");
                                System.Console.WriteLine ("ESCOLHA SUA AÇÃO: ");
                                System.Console.WriteLine (" 1 - ATACAR");
                                System.Console.WriteLine ("2 - FUGIR");

                                opcaoAtacarFugir = Console.ReadLine ();

                                switch (opcaoAtacarFugir) {
                                    case "1":
                                        gerarNumAleatorio = new Random ();

                                        numAleatorioJogador = gerarNumAleatorio.Next (0, 5);
                                        numAleatorioDragao = gerarNumAleatorio.Next (0, 5);
                                        guerreiroDestrezaTotal = guerreiro.Destreza + numAleatorioJogador;
                                        dragaoDestrazaTotal = dragao.Destreza + numAleatorioDragao;

                                        if (guerreiroDestrezaTotal > dragaoDestrazaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: ACERTOU MISERAVI!");

                                            dragao.Hp -= poderAtaqueGuerreiro + 5;

                                            System.Console.WriteLine ("**********");
                                            System.Console.WriteLine ($"HP DRAGÃO: {dragao.Hp}");
                                            System.Console.WriteLine ($"HP GUERREIRO: {guerreiro.Hp}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: ERROOU!");
                                        }

                                        if (guerreiro.Hp <= 0) {
                                            System.Console.WriteLine ("O GUERREIRO FALECEU! NO CÉU TEM PÃO?");
                                        }

                                        if (dragao.Hp <= 0) {
                                            System.Console.WriteLine ("O DRAGÃO FALECEU! NO CÉU TEM PÃO?");
                                        }

                                        FinalizarDialogo ();

                                        break;

                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: DEI FUGA!");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EASY");
                                        break;
                                }

                                FinalizarDialogo ();

                                // FIM - TURNO JOGADOR
                            }
                        }
                        // FIM - TRETA
                        break;

                    case "0":
                        desejaContinuar = false;
                        System.Console.WriteLine ("VOCÊ SAIU DO JOGO");
                        break;

                    default:
                        System.Console.WriteLine ("OPÇÃO INVÁLIDA");
                        break;
                }

            } while (desejaContinuar);
        }

        private static void CriarDialogo (string nome, string frase) {
            System.Console.WriteLine ($"{nome.ToUpper()}: {frase}");
        }

        private static void FinalizarDialogo () {
            System.Console.WriteLine ();
            System.Console.WriteLine ("APERTE | ENTER | PARA PROSSEGUIR");
            Console.ReadLine ();

            Console.Clear ();
        }

        private static Guerreiro CriarGuerreiro () {
            Guerreiro guerreiro = new Guerreiro ();

            guerreiro.Nome = "Xena";
            guerreiro.Sobrenome = "A PRINCESA GUERREIRA";
            guerreiro.DataNasc = DateTime.Parse ("01/01/1001");
            guerreiro.CidadeNatal = "Acre";
            guerreiro.FerramentaAtaque = "NOKIA ATAQUE";
            guerreiro.FerramentaProtecao = "NOKIA DEFESA";
            guerreiro.Forca = 4;
            guerreiro.Destreza = 2;
            guerreiro.Inteligencia = 2;
            guerreiro.Hp = 20;

            return guerreiro;
        }
    }
}