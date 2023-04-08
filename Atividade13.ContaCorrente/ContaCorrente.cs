using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade13.ContaCorrente
{
     internal class ContaCorrente
     {
          public double saldo, limite, limiteSaque;
          public int numero, quantidadeMovimentacoes;
          public Movimentacao[] movimentacoes;
          public bool especial;
          public void Sacar(int valorSaque)
          {
               limiteSaque = saldo + limite;
               if (valorSaque <= limiteSaque)
               {
                    saldo -= valorSaque;
                    movimentacoes[quantidadeMovimentacoes] = new Movimentacao(valorSaque, "Débito");
                    quantidadeMovimentacoes++;
               }

               else
                    Console.WriteLine("\nImpossível realizar saque!");
          }

          public void Depositar(int valorDeposito)
          {
               saldo += valorDeposito;
               movimentacoes[quantidadeMovimentacoes] = new Movimentacao(valorDeposito, "Crédito");
               quantidadeMovimentacoes++;
          }

          public void Transferir(ContaCorrente conta, double valorTransferencia)
          {
               if(valorTransferencia <= limiteSaque)
               {
               saldo -= valorTransferencia;
               conta.saldo += valorTransferencia;
               movimentacoes[quantidadeMovimentacoes] = new Movimentacao(valorTransferencia, "Transferência");
               quantidadeMovimentacoes++;
               }
               else
                    Console.WriteLine("\nImpossível realizar transferência!");
          }

          public void ExibirExtrato()
          {             
               for (int i = 0; i < quantidadeMovimentacoes; i++)
               {
                    if (movimentacoes[i].tipo != null && movimentacoes[i].valor != null)
                    Console.WriteLine($"Operação:{movimentacoes[i].tipo}\nValor:{movimentacoes[i].valor}\n");
                    else
                    {
                         Console.WriteLine("");
                    }
               }
               
               
          }
     }
}
