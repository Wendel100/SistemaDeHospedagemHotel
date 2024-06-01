using System.Security.Cryptography;

namespace Sistema_De_Hospedagem_De_Hotel
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }


        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

                if (hospedes.Count<= Suite.Capacidade)
                {
                    Console.WriteLine("capacidade permitida ");
                }
                else
                {
                    Console.WriteLine("capacidade seja menor que o número de hóspedes recebido");
                    // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                    // *IMPLEMENTE AQUI*
                }
            }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            //return Hospedes.Count;      
                return Hospedes.Count;
            
   }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados*Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if(DiasReservados >=10)
            {
                decimal desconto = DiasReservados *010;
                valor = desconto;
            }

            return valor;
        }

    }
}
