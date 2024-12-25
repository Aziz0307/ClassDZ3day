using System;

namespace ClassDZHday3
{
     class BitovayaTechinka
    {
        private string brend;
        protected int moshnostUstroystva;
        public int sostoyasnieUstroystva;

        public string Brend
        {
            get { return brend; }
            set { brend = value; }
        }

        public int MoshnostUstroystva
        {
            get { return moshnostUstroystva; }
            set { moshnostUstroystva = value; }
        }

        public void Turn()
        {
            if (sostoyasnieUstroystva == 1)
            {
                Console.WriteLine("Ustroystva vklecheno.");
            }
            else if (sostoyasnieUstroystva == 0)
            {
                Console.WriteLine("Ustroystva viklecheno.");
            }
            else
            {
                Console.WriteLine("Sostoyasnie Ustroystva dolzhno = 0 ili 1.");
            }
        }
    }
    
    class Kholodelnik : BitovayaTechinka
    {
        public Kholodelnik()
        {
            Brend = "Samsung";
            moshnostUstroystva = 350;
            sostoyasnieUstroystva = 1;
        }
    }

    class StiralnayaMashina : BitovayaTechinka
    {
        public StiralnayaMashina()
        {
            Brend = "LG"; 
            moshnostUstroystva = 250;
            sostoyasnieUstroystva = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kholodelnik kholodelnik = new Kholodelnik();
            StiralnayaMashina stiralnayaMashina = new StiralnayaMashina();
            Console.WriteLine($"Kholodelnik brend = {kholodelnik.Brend}     Moshnost = {kholodelnik.MoshnostUstroystva }");
            kholodelnik.Turn();
            Console.WriteLine($"Stiralnaya mashina brend = {stiralnayaMashina.Brend}     Moshnost = {stiralnayaMashina.MoshnostUstroystva }");
            stiralnayaMashina.Turn();
        }
    }
}