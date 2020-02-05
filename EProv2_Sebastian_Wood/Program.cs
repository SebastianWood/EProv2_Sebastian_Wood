using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv2_Sebastian_Wood
{
    class Program
    {
        static void Main(string[] args)
        {

            Car cars = new Car(); //cars skapas genom klassen car 

            Car CleanCar = new Car(); //heter cleancar och skapar

            Car ContrabandCar = new Car();
            
            Console.WriteLine("Hur många bilar ska skapas?:");

            Random generator = new Random();
            int r = generator.Next(1, 4);
            
            Console.WriteLine(cars.passengers);
            
            List<string> bilList = new List<string>(); //försökte fixa en list vid namn bilList

            bilList.Add("antal bilar"); //är vad som skrivs ut nedan.

            Console.WriteLine(bilList[0]); //den skriver ut det som står under add. 

            Console.ReadLine(); // en vanlig readline som pausar koden. 

            bilList.RemoveAt(0); //tar bort den från listan.

            bilList.Add("Vi hörs");
            Console.WriteLine(bilList[0]);
            Console.ReadLine();

            int antalBilar = int.Parse(Console.ReadLine()); //antalBilar samlar in all information om hur många bilar man har
            

            if (antalBilar <= 0) //if sats som körs ifall nummret man skrev in är 0 eller lägre. 
            {
                Console.WriteLine("Minst en bil!");

                if (antalBilar <= 0)
                {
                    antalBilar = int.Parse(Console.ReadLine());

                }
                
            }

            if (antalBilar > 0) //förklarar hur många bilar man valde att ha.
            {
                Console.WriteLine("Bra gjort! Du valde:");

                Console.WriteLine("" + antalBilar + " bilar!");

            }






            CleanCar.Examine(); //hann inte med det men skulle vara en metod som körs för att kolla om det är true. 



            // cars.Examine = true; hann inte fixa klart så att den blev true





            //hann inte med det härgit
            Console.WriteLine("Vilken bil vill du titta på, 1 eller 2?");

            string billSiffra = Console.ReadLine();



            if (billSiffra == "1")
            {




            }

            else if (billSiffra == "2")
            {



            }




        }
    }
}
