using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            UseTheMagicHat();

            Console.ReadLine();
        }
 
        private static void UseTheMagicHat()
        {
            MagicHat<Rabbit> hat = new MagicHat<Rabbit>();
            hat.Put(new Rabbit { Name = "Fluffy" });
            hat.Put(new Rabbit { Name = "Muffy" });

            Rabbit firstRabbit = hat.Pull();
            Console.WriteLine(firstRabbit.Name);

            hat.Fill();
            hat.Disappear();

        }
    }
}
