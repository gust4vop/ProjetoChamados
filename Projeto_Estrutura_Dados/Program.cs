using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.DataVisualization.Charting;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> chamados = new Queue<string>();
        Stack<string> chamadosAtendidos = new Stack<string>();

        while (true)
        {
            Console.WriteLine("1 - Novo chamado");
            Console.WriteLine("2 - Atender chamado");
            Console.WriteLine("3 - Mostrar chamados atendidos");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do chamado: ");
                    string novoChamado = Console.ReadLine();
                    chamados.Enqueue(novoChamado);
                    Console.WriteLine("Chamado adicionado com sucesso!\n");
                    break;
                case "2":
                    if (chamados.Count > 0)
                    {
                        string chamadoAtendido = chamados.Dequeue();
                        chamadosAtendidos.Push(chamadoAtendido);
                        Console.WriteLine("Chamado atendido: " + chamadoAtendido + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Não há chamados pendentes!\n");
                    }
                    break;
                case "3":
                    Console.WriteLine("Chamados atendidos:");
                    foreach (string chamado in chamadosAtendidos)
                    {
                        Console.WriteLine(chamado);
                    }
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!\n");
                    break;
            }

}
