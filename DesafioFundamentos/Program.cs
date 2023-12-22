using DesafioFundamentos.Models;
using DesafioFundamentos;
using System.Text;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = Encoding.UTF8;

decimal precoInicial = Utils.ObterValorDecimal("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");

decimal precoPorHora = Utils.ObterValorDecimal("Agora digite o preço por hora:");

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    var mensagem = "Digite a sua opção: \n 1 - Cadastrar veículo \n 2 - Remover veículo \n 3 - Listar veículos \n 4 - Encerrar";
    Console.Clear();

    switch (Utils.ObterValorInteiro(mensagem))
    {
        case 1:
            es.AdicionarVeiculo();
            break;

        case 2:
            es.RemoverVeiculo();
            break;

        case 3:
            es.ListarVeiculos();
            break;

        case 4:
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
