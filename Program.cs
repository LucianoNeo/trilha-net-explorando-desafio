using DesafioProjetoHospedagem.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new()
{
    new (nome: "Hóspede 1"),
    new (nome: "Hóspede 2"),
    new (nome: "Hóspede 3"),
    new (nome: "Hóspede 4"),
};

Suite suite = new(tipoSuite: "Premium", capacidade: 10, valorDiaria: 150);

Reserva reserva = new(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");