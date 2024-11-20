using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        int quantNum = int.Parse(Console.ReadLine());

        Dictionary<int, int> frequencia = new Dictionary<int, int>();

        for (int i = 0; i < quantNum; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (frequencia.ContainsKey(num))
            {
                frequencia[num]++;
            }
            else
            {
                frequencia[num] = 1;
            }
        }


        List<int> keys = new List<int>(frequencia.Keys);
        keys.Sort();

        foreach (int key in keys)
        {
            Console.WriteLine($"{key} {frequencia[key]}");
        }
    }
}