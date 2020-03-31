using System;
using System.Numerics;
using System.Text;
using System.Text.Json;

namespace dotnetcoreconsole
{
    class Program
    {
        static void Main(string[] args)
        {


            TestJsonArray();
            // Decimal2Hex();
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void TestJsonArray()
        {
            JsonDocument jd = JsonDocument.Parse("{\"result\":[{\"ID\": \"1\"},{\"ID\": \"2\"}]}");
            foreach(JsonElement e in jd.RootElement.GetProperty("result").EnumerateArray())
            {
                Console.WriteLine(e.GetProperty("ID").GetString());
            }
        }

        static void Decimal2Hex()
        {
            /*
                Convert decimal value to hex
            */
            string s = "0003003";
            Decimal decValue = Decimal.Parse(s.Substring(s.Length-5, 3));
            var bigValue = new BigInteger(decValue);
            Console.WriteLine(string.Format("0x{0}",bigValue.ToString("X")));
            
        }
    }
}
