using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeHospedagem.Model
{
    public class Reserva
    {

        public Reserva(int diasReservados)
        {
            DiasReservadas = diasReservados;
        }
        public List<Pessoa> Hospides;
        public Suite Suite;
        public int DiasReservadas;

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(Suite.Capacidade >= hospedes.Count)
            {
            Hospides = hospedes;
            }else 
            {
                throw new Exception("o numero de hospedes nao pode ser maior que a capacdade");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }


        public int ObterQuantidadeHospedes()
        {
            int h = Hospides.Count;
            return h;
        }

         public decimal CalcularValorDiaria()
        {

            decimal valor = Suite.ValorDiaria * Suite.ValorDiaria;

            if (DiasReservadas>=10)
            {
                valor *= 0.1M;
            }

            return valor;
        }
    }
}