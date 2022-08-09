using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        //método sacar
        public bool Sacar(double valor)
        {
            if ( saldo < valor)
            {
                Console.WriteLine("Valor indisponível!.");
                return false;
            }
            if(valor < 0)
            {
                Console.WriteLine("Valor inválido, tente novamente!.");
                return false;
            }
            else
            {
                saldo = saldo - valor;
                Console.WriteLine("Saque efetuado com sucesso!.");
                return true;
            }
        }

        public void Depositar(double valor) // método void não retorna valor só executa e não retorna
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
    }

   
}