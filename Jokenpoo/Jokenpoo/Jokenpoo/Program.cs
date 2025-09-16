using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p;
            
            
            int vitorias, derrotas, empates, vitorias1 , derrotas1 , empates1 ;
            vitorias = 0;
            derrotas = 0;
            empates = 0;
            vitorias1 = 0;
            derrotas1 = 0;
            empates1 = 0;
            
            Console.WriteLine("Você prefere jogar com outro jogador ou com a máquina? Digite 1 para jogar com outro jogador, e 2 para jogar com a máquina:");
            int r = int.Parse(Console.ReadLine());

            if (r == 1)
            {
                Console.WriteLine("Digite o nome do jogador 1:");
                string nome1 = Console.ReadLine();
                Console.WriteLine("Digite o nome do jogador 2:");
                string nome2 = Console.ReadLine();
                p = true;
                while (p)
                {
                    
                    Console.WriteLine("Escolha 1 para pedra, 2 para papel e 3 para tesoura:");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        Console.Write("Você escolheu pedra.\n");
                    }
                    if (a == 2)
                    {
                        Console.Write("Você escolheu papel.\n");
                    }
                    if (a == 3)
                    {
                        Console.Write("Você escolheu tesoura.\n");
                    }

                    Console.WriteLine("Agora é sua vez Player 2, escolha 1 para pedra, 2 para papel e 3 para tesoura: ");
                    int b = int.Parse(Console.ReadLine());
                    if (b == 1)
                    {
                        Console.Write("Você escolheu pedra.\n");
                    }
                    if (b == 2)
                    {
                        Console.Write("Você escolheu papel.\n");
                    }
                    if (b == 3)
                    {
                        Console.Write("Você escolheu tesoura.\n");
                    }

                    if (a == b)
                    {
                        Console.Write("Empate!\n");
                        empates = empates + 1;
                        empates1 = empates1 + 1;
                        Console.Write("======== RANKING ========\n");
                        Console.Write($" {nome1} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                        Console.Write($" {nome2} : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");

                    }
                    if (a == 1 && b == 2)
                    {
                        Console.Write("Player 2 venceu!\n");
                        vitorias1 = vitorias1 + 1;
                        derrotas = derrotas = 1;
                        Console.Write("======== RANKING ========\n");
                        Console.Write($" {nome1} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                        Console.Write($" {nome2} : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                    }
                    if (a == 2 && b == 1)
                    {
                        Console.Write("Player 1 venceu!\n");
                        vitorias = vitorias + 1;
                        derrotas1 = derrotas1 = 1;
                        Console.Write("======== RANKING ========\n");
                        Console.Write($" {nome1} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                        Console.Write($" {nome2} : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                    }
                    if (a == 2 && b == 3)
                    {
                        Console.Write("Player 2 venceu!\n");

                        vitorias1 = vitorias1 + 1;
                        derrotas = derrotas = 1;
                        Console.Write("======== RANKING ========\n");
                        Console.Write($" {nome1} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                        Console.Write($" {nome2} : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                    }
                    if (a == 3 && b == 2)
                    {
                        Console.Write("Player 1 venceu!\n");
                        vitorias = vitorias + 1;
                        derrotas1 = derrotas1 = 1;
                        Console.Write("======== RANKING ========\n");
                        Console.Write($" {nome1} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                        Console.Write($" {nome2} : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                    }
                    if (a == 3 && b == 1)
                    {
                        Console.Write("Player 2 venceu!\n");
                        vitorias1 = vitorias1 + 1;
                        derrotas = derrotas = 1;
                        Console.Write("======== RANKING ========\n");
                        Console.Write($" {nome1} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                        Console.Write($" {nome2} : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                    }
                    if (a == 1 && b == 3)
                    {
                        Console.Write("Player 1 venceu!\n");
                        vitorias = vitorias + 1;
                        derrotas1 = derrotas1 = 1;
                        Console.Write("======== RANKING ========\n");
                        Console.Write($" {nome1} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                        Console.Write($" {nome2} : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                    }

                }
                Console.WriteLine("Quer continuar jogando?");
                Console.WriteLine("1. Continuar");
                Console.WriteLine("2. Sair");
                int f = int.Parse( Console.ReadLine());
                if ( f == 2)
                {
                    f = false;
                    break;
                }
            } 


            if (r == 2)
            {
                Console.WriteLine("Digite o nome do jogador:");
                string nome3 = Console.ReadLine();

                Console.WriteLine("\nEscolha 1 para pedra, 2 para papel e 3 para tesoura:");
                int A = int.Parse(Console.ReadLine());
                if (A == 1)
                {
                    Console.Write("Você escolheu pedra.\n");
                }
                if (A == 2)
                {
                    Console.Write("Você escolheu papel.\n");
                }
                if (A == 3)
                {
                    Console.Write("Você escolheu tesoura.\n");
                }

                Random sorteio = new Random();
                int numeroSorteado = sorteio.Next(1, 3);

                Console.WriteLine("A máquina escolheu:" + numeroSorteado);
                if (numeroSorteado == 1)
                {
                    Console.Write("A máquina escolheu pedra.\n");
                }
                if (numeroSorteado == 2)
                {
                    Console.Write("A máquina escolheu papel.\n");
                }
                if (numeroSorteado == 3)
                {
                    Console.Write("A máquina escolheu tesoura.\n");
                }

                if (A == numeroSorteado)
                {
                    Console.Write("Empate!\n");
                    empates = empates + 1;
                    empates1 = empates1 + 1;
                    Console.Write("======== RANKING ========\n");
                    Console.Write($" {nome3} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                    Console.Write($" Maquina : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                }
                if (A == 1 && numeroSorteado == 2)
                {
                    Console.Write("A máquina venceu!\n");
                    vitorias1 = vitorias1 + 1;
                    derrotas = derrotas = 1;
                    Console.Write("======== RANKING ========\n");
                    Console.Write($" {nome3} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                    Console.Write($" Maquina : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                }
                if (A == 2 && numeroSorteado == 1)
                {
                    Console.Write("Player 1 venceu!\n");
                    vitorias = vitorias + 1;
                    derrotas1 = derrotas1 = 1;
                    Console.Write("======== RANKING ========\n");
                    Console.Write($" {nome3} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                    Console.Write($" Maquina : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                }
                if (A == 2 && numeroSorteado == 3)
                {
                    Console.Write("A máquina venceu!\n");
                    vitorias1 = vitorias1 + 1;
                    derrotas = derrotas = 1;
                    Console.Write("======== RANKING ========\n");
                    Console.Write($" {nome3} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                    Console.Write($" Maquina : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                }
                if (A == 3 && numeroSorteado == 2)
                {
                    Console.Write("Player 1 venceu!\n");
                    vitorias = vitorias + 1;
                    derrotas1 = derrotas1 = 1;
                    Console.Write("======== RANKING ========\n");
                    Console.Write($" {nome3} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                    Console.Write($" Maquina : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                }
                if (A == 3 && numeroSorteado == 1)
                {
                    Console.Write("A máquina venceu!\n");
                    vitorias1 = vitorias1 + 1;
                    derrotas = derrotas = 1;
                    Console.Write("======== RANKING ========\n");
                    Console.Write($" {nome3} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                    Console.Write($" Maquina : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                }
                if (A == 1 && numeroSorteado== 3)
                {
                    Console.Write("Player 1 venceu!\n");
                    vitorias = vitorias + 1;
                    derrotas1 = derrotas1 = 1;
                    Console.Write("======== RANKING ========\n");
                    Console.Write($" {nome3} : {vitorias} Vitorias, {derrotas} Derrotas, {empates} Empates. \n");
                    Console.Write($" Maquina : {vitorias1} Vitorias, {derrotas1} Derrotas, {empates1} Empates. ");
                }
                


            }
        }
    }
}