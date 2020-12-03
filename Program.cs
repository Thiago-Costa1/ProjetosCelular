using System;
using Nova_pasta.Classes;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Celular Celular1 = new Celular();

            Console.WriteLine("");
            Console.WriteLine("-----Sistema de celular-----");
            Console.WriteLine("");

            Console.WriteLine("Por favor, informe as características de seu celular antes de começar: ");
            Console.WriteLine("");
            Console.Write("Qual é o modelo de seu celular? ");
            string modelo = Console.ReadLine();

            Console.Write("Qual é a cor do seu celular? ");
            string cor = Console.ReadLine();

            Console.Write("Qual é o tamanho de seu celular (digite a quantidade de polegadas)? ");
            double tamanho = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Por favor, informe se o celular está ligado: S/N ");
            string resposta = Console.ReadLine();


            if (resposta.ToLower() == "s")
            {

                Celular1.ligado = true;
                Console.WriteLine("Seu celular está ligado! ");

                Console.WriteLine("");
                Console.WriteLine("Informe qual ação deseja fazer a seguir: ");
                Console.WriteLine("");
                Console.WriteLine("[1] - Fazer ligação ");
                Console.WriteLine("[2] - Enviar mensagem ");
                int escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {


                    case 1:
                        Console.WriteLine("Digite um número para telefonar: ");
                        int fazerLigacao = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Escreva uma mensagem: ");
                        string enviarMensagem = Console.ReadLine();
                        break;


                }

            }
            else if (resposta.ToLower() == "n")
            {
                Celular1.ligado = false;
                Console.WriteLine("Seu celular está desligado!");


            }


        }
    }
}
