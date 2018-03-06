using System;

namespace SingletonPatternChocoboiler
{
    public class SingletonChocoBoiler
    {
        public bool Empty { get; set; }
        public bool Boiled { get; set; }

        private static SingletonChocoBoiler Instance;  

        private SingletonChocoBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static SingletonChocoBoiler getInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonChocoBoiler();
            }
            return Instance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fillinf the boiler");
            }
            Console.WriteLine("The boiler is already filled");
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                Console.WriteLine("Draining the boiler");
                Empty = true;
                Boiled = false;
                Console.WriteLine("the drain is empty");

            }

           

        }

        public bool IsEmpty()
        {
            return Empty;
        }

        public bool IsBoiled()
        {
            return Boiled;
        }
    }
}
