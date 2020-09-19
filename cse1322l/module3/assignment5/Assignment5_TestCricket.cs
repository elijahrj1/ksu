using System;

namespace Assignment5
{
    class TestCricket
    {
        static void Main(string[] args)
        {
            Environment jimmyEnv = new Environment(60);
            Cricket jimmy = new Cricket();
            Console.WriteLine("Normal cricket: " + jimmyEnv.GetTemp() + " degrees yields " + jimmy.GetChirpCount(jimmyEnv) + " chirps per minute");

            Environment jerryEnv = new Environment(70);
            ClemsonCricket jerry = new ClemsonCricket();
            Console.WriteLine("Clemson cricket: " + jerryEnv.GetTemp() + " degrees yields " + jerry.GetChirpCount(jerryEnv) + " chirps per minute");

        }
    }
}
