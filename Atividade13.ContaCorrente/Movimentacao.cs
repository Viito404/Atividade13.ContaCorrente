using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade13.ContaCorrente
{
     internal class Movimentacao
     {
          public double valor;
          public string tipo;

          public Movimentacao(double valor, string tipo)
          {
               this.valor = valor;
               this.tipo = tipo;
          }
     }
}
