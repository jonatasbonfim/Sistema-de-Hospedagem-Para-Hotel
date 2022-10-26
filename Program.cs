using System.Text;
using Sistema_de_Hospedagem_Para_Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "");
Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome: "");
Pessoa p4 = new Pessoa(nome: "Hóspede 4", sobrenome: "");
Pessoa p5 = new Pessoa(nome: "Hóspede 5", sobrenome: "");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 8, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R$ {reserva.CalcularValorDiaria()}");
