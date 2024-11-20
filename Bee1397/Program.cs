using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite a quantidade de jogadas: ");
            int NumJogadas = int.Parse(Console.ReadLine());

            if (NumJogadas == 0)
                break;

            int pontosOg = 0;
            int pontosFilho = 0;

            for (int i = 0; i < NumJogadas; i++)
            {
                string[] entradaNumeros = Console.ReadLine().Split(' ');
                int A = int.Parse(entradaNumeros[0]);
                int B = int.Parse(entradaNumeros[1]);

                
                if (A > B)
                {
                    pontosOg++;  
                }
                else if (B > A)
                {
                    pontosFilho++;  
                }

            }

            Console.WriteLine($"Pontos OG: {pontosOg}; Pontos Filho:{pontosFilho}");
        }
    }
}
