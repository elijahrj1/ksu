using System;
using System.Text;

namespace assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cypherObject = new Cypher(); 
            cypherObject.cypherMethod();
            cypherObject.reverseMethod();
            Console.Write(cypherObject.ToString());
            Console.WriteLine();
            Console.WriteLine("Input a phrase to be scrambled.");
            string original = Console.ReadLine();
            var testCypherObject = new Cypher(original);
            testCypherObject.cypherMethod();
            testCypherObject.reverseMethod();
            Console.WriteLine(testCypherObject.ToString());
        }
    }

    public class Cypher
    {
        private string original;
        private string encrypted;
        private string decrypted;

        public Cypher()
        {
            original = "cypher";
        }

        public Cypher(string input)
        {
            original = input;
        }

        public void cypherMethod()
        {
            var evens = new StringBuilder();
            var odds = new StringBuilder();

            for (int i = 0; i < original.Length; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    odds.Append(original[i]);
                }
                else
                {
                    evens.Append(original[i]);
                }
            }
            encrypted = odds.ToString() + evens.ToString();
        }

        public void reverseMethod()
        {
            var output = new StringBuilder(encrypted.Length);
            var odds = encrypted.Substring(0, encrypted.Length / 2);
            var evens = encrypted.Substring(encrypted.Length / 2);

            for (int i = 0, oi = -1, oe = -1; i < encrypted.Length; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    output.Append(odds[++oi]);
                }

                else
                {
                    output.Append(evens[++oe]);
                }
            }

            decrypted = output.ToString();
        }

        public string GetOriginal()
        {
            return original;
        }

        public string GetEncrypted()
        {
            return encrypted;
        }

        public string GetDecrypted()
        {
            return decrypted;
        }

        public void SetOriginal(string val)
        {
            original = val;
        }

        public void SetEncrypted(string val)
        {
            encrypted = val;
        }

        public void SetDecrypted(string val)
        {
            decrypted = val;
        }

        public override string ToString()
        {
            return "Original Message: " + original + "\nEncrypted: " + encrypted + "\nDecrypted: " + decrypted;
        }

    }
}
