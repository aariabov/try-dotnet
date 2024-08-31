using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args = null)
        {
            //Console.WriteLine(string.Join(",", args));
            var region = args[1];
            switch (region)
            {
                case "intro":
                    Intro();
                    break;
            }
        }
        
        public static void Intro()
        {
            #region intro
            Console.WriteLine("Hello 111!");
            #endregion
        }
    }
}
