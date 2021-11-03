using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestada eesnime
            //programm küsib kasutajal sisestada numbrid 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta number 1-3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    for (int i = userName.Length - 1; i >= 0; i--)
                    {
                        Console.Write(userName[i]);
                    }
                    break;
                case '2':
                    Console.WriteLine($"{userName[0]}");
                    break;
                case '3':
                    Console.WriteLine($"Sinu eesnimi on {userName.Length} sümbolit pikk.");
                    break;
            }
        }
    }
}
