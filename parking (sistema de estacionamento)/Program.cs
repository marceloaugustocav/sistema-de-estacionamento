using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Estacionamento!");
        Console.WriteLine("***************************");

        int capacity = 5; // Capacidade máxima do estacionamento
        List<string> parkingLot = new List<string>();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Estacionar um carro");
            Console.WriteLine("2 - Retirar um carro");
            Console.WriteLine("3 - Ver carros estacionados");
            Console.WriteLine("4 - Sair do programa");

            Console.Write("Opção: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (parkingLot.Count >= capacity)
                    {
                        Console.WriteLine("Estacionamento lotado! Não é possível estacionar.");
                    }
                    else
                    {
                        Console.Write("Digite a placa do carro: ");
                        string plateNumber = Console.ReadLine();
                        parkingLot.Add(plateNumber);
                        Console.WriteLine($"Carro com a placa {plateNumber} estacionado com sucesso!");
                    }
                    break;

                case "2":
                    if (parkingLot.Count == 0)
                    {
                        Console.WriteLine("Estacionamento vazio! Não há carros para retirar.");
                    }
                    else
                    {
                        Console.Write("Digite a placa do carro a ser retirado: ");
                        string plateToRemove = Console.ReadLine();
                        if (parkingLot.Remove(plateToRemove))
                        {
                            Console.WriteLine($"Carro com a placa {plateToRemove} retirado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine($"Carro com a placa {plateToRemove} não encontrado no estacionamento.");
                        }
                    }
                    break;

                case "3":
                    if (parkingLot.Count == 0)
                    {
                        Console.WriteLine("Estacionamento vazio! Não há carros estacionados.");
                    }
                    else
                    {
                        Console.WriteLine("Carros estacionados:");
                        foreach (string plate in parkingLot)
                        {
                            Console.WriteLine(plate);
                        }
                    }
                    break;

                case "4":
                    Console.WriteLine("Saindo do programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
