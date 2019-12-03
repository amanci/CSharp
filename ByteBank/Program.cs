using System;
using System.Runtime.CompilerServices;
using System.Xml;
using ByteBank.Models;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            string nome, cpf, email, senha;

            // Pessoas.PegarNome("ALLAN", out sobreNome);

            Pessoas pessoas = new Pessoas ("ALLAN");

            System.Console.WriteLine ("********************");
            System.Console.WriteLine ("CADASTRO DE CLIENTES");
            System.Console.WriteLine ("********************");

            System.Console.Write ("NOME: ");
            nome = Console.ReadLine ();

            System.Console.Write ("CPF: ");
            cpf = Console.ReadLine ();

            System.Console.Write ("E-MAIL: ");
            email = Console.ReadLine ();

            Clientes cliente1 = new Clientes (nome, cpf, email);

            bool trocouSenha = false;

            do {
                System.Console.Write ("SENHA: ");
                senha = Console.ReadLine ();

                trocouSenha = cliente1.TrocarSenha (senha);
                if (!trocouSenha) {
                    System.Console.WriteLine ("SENHA NÃO ATENDE OS REQUISITOS");
                } else {
                    System.Console.WriteLine ("SENHA TROCADA");
                }
            } while (!trocouSenha);

            int agencia, numeroConta;
            double saldo, deposito, saque, saldoAtualizado;

            System.Console.Write ("DIGITE SUA AGÊNCIA: ");
            agencia = int.Parse (Console.ReadLine ());

            System.Console.Write ("DIGITE O NÚMERO DA CONTA: ");
            numeroConta = int.Parse (Console.ReadLine ());

            bool saldoAceito;

            ContaCorrente contaCorrente = new ContaCorrente (agencia, numeroConta, cliente1);

            do {
                System.Console.Write ("DIGITE SALDO: R$ ");
                saldo = double.Parse (Console.ReadLine ());
                saldoAceito = contaCorrente.VerificarSaldo (saldo);

                if (saldoAceito == false) {
                    System.Console.WriteLine ("SALDO INVÁLIDO");
                } else {
                    System.Console.WriteLine ("SALDO VÁLIDO");
                }
            } while (saldoAceito != true);

            contaCorrente.Agencia = 123;

            System.Console.Write ("DIGITE O VALOR DO DEPÓSITO: R$ ");
            deposito = double.Parse (Console.ReadLine ());

            saldoAtualizado = contaCorrente.Deposito (deposito);

            System.Console.WriteLine ($"SALDO ATUALIZADO : R$ {saldoAtualizado}");

            bool saqueAceito = false;

            do {
                System.Console.Write ("DIGITE O VALOR PARA O SAQUE: R$ ");
                saque = double.Parse (Console.ReadLine ());
                saqueAceito = contaCorrente.Saque (saque);

                if (saqueAceito == false) {
                    System.Console.WriteLine ("NÃO FOI POSSÍVEL REALIZAR O SAQUE.");
                    System.Console.WriteLine ("                     *****DIGITE O VALOR NOVAMENTE*****");
                } else {
                    System.Console.WriteLine ("SAQUE REALIZADO.");
                    saqueAceito = true;
                }
            } while (saqueAceito != true);

            Console.WriteLine ("ByteBank - Deposito");
            Clientes usuario = contaCorrente.Titular;
            Console.WriteLine ($"Bem vindo - {usuario.Nome}");
            Console.WriteLine ($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.NumeroConta}");
            Console.WriteLine ($"Saldo: {contaCorrente.Saldo}");
            Console.Write ("Digite o valor do Deposito: ");
            double valor = double.Parse (Console.ReadLine ());
            saldo = contaCorrente.Deposito (valor);
            Console.WriteLine ($"Saldo atual: {saldo}");
            Console.WriteLine ();

            Console.WriteLine ("ByteBank - Saque");
            Console.WriteLine ($"Bem vindo - {usuario.Nome}");
            Console.WriteLine ($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.NumeroConta}");
            Console.WriteLine ($"Saldo: {contaCorrente.Saldo}");
            Console.Write ("Qual o valor do Saque? ");
            valor = double.Parse (Console.ReadLine ());
            if (contaCorrente.Saque (valor)) {
                Console.WriteLine ("Saque realizado com sucesso. Retire as notas");
            } else {
                Console.WriteLine ("Não foi possivel realizar a operação");

            }
            Console.WriteLine ($"Saldo atual: {contaCorrente.Saldo}");
            Console.WriteLine ();

            Clientes cliente2 = new Clientes ("Alexandre", "123.321.123-12", "a@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente (123, 132, cliente2);
            Console.WriteLine ("ByteBank - Transferencia");
            Console.WriteLine ($"Bem vindo - {usuario.Nome}");
            Console.WriteLine ($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente}");
            Console.WriteLine ($"Saldo origem: {contaCorrente.Saldo}");
            Console.WriteLine ($"Saldo destino: {contaCorrente2.Saldo}");
            Console.Write ("Digite o valor da tranferência: ");
            valor = double.Parse (Console.ReadLine ());

            if (contaCorrente.Transferencia (contaCorrente2, valor)) {
                Console.WriteLine ("Tranferencia efetuada com sucesso.");
            } else {
                Console.WriteLine ("Operação não pode ser realizada.");
            }
            Console.WriteLine ($"Saldo origem: {contaCorrente.Saldo}");
            Console.WriteLine ($"Saldo destino: {contaCorrente2.Saldo}");
        }
    }
}