using System;

namespace GissaTalet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            int randTal = rand.Next(1,50);
            int talInt = 0;
            int points = 0;
            Console.WriteLine("Hej! Gissa talet mellan 1-50");
            
            while(true)
            {
                
                string talet = Console.ReadLine();

                try
                {
                    talInt = Convert.ToInt32(talet);
                }

                catch(Exception)
                { 
                    Console.WriteLine("Felmeddelande: Skriv in endast siffror");       
                    continue;
                }   
                
                if(talInt == randTal)
                {
                    points++;
                    Console.WriteLine($"Grattis, du gissade rätt, talet var {talInt}. Du försökte {points} antal gånger");
                    break;

                }
                else if(talInt > randTal)
                {
                    Console.WriteLine("Lägre");
                    points++;
                    
                }
                else if(talInt < randTal)
                {
                    Console.WriteLine("Högre");
                    points++;
                    
                }
            }
        }
    }
}
