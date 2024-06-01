using Sistema_De_Hospedagem_De_Hotel;

internal class Program
{
    private static void Main(string[] args)
    {

    // Cria os modelos de hóspedes e cadastra na lista de hóspedes
    List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Paulo");
        Pessoa p2 = new Pessoa(nome: "Maria");

        hospedes.Add(p1);
        hospedes.Add(p2);


            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Master", capacidade: 3, valorDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new Reserva(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
    }
}