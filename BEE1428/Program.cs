using System;

class Program
{
    static void Main(string[] args)
    {
        int numTestes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numTestes; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);


            int sondaLinha = (n - 2) / 3;
            if ((n - 2) % 3 != 0)
            {
                sondaLinha ++;
            }

            int sondaColuna = (m - 2) / 3;
            if ((m - 2) % 3 != 0)
            {
                sondaColuna++;
            }

            int sondasTotal = sondaLinha + sondaColuna;

            Console.WriteLine($"Total de sondas: {sondasTotal}");
        }
    }
}