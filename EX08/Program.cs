using System;
using Dinheiro;
using DinheiroInput;
using Miscelania;

class Program
{
    static void Main(string[] args)
    {
        var dinheiro = new Money();

        dinheiro.CotacaoDolar = Entrada.EntrarComPedido("Qual é a cotação do dólar? R$");
        dinheiro.Aporte = Entrada.EntrarComPedido("Quantos dólares você quer comprar? $");
        double reaisNecessarios = dinheiro.ReaisNecessarios() + dinheiro.ReaisNecessarios() * 0.06;

        ConsoleUI.ExibirMensagemEncerrarPrograma($"Na cotação do dolár, de R${Formatador.Formatar(dinheiro.CotacaoDolar)}, para termos ${Formatador.Formatar(dinheiro.Aporte)}, é necessário colocarmos R${Formatador.Formatar(reaisNecessarios)}");
    }
}