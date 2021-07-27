using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ClassLibrary
{
    public class Math : IMath
    {
        public int Add(int AddNumber1, int AddNumber2)
        {
            return AddNumber1 + AddNumber2;
        }

        public int Subtract(int SubtractNumber1, int SubtractNumber2)
        {
            return SubtractNumber1 - SubtractNumber2;
        }

        public int Multiply(int MultiplyNumber1, int MultiplyNumber2)
        {
            return MultiplyNumber1 * MultiplyNumber2;
        }

        public int Divide(int DivideNumber1, int DivideNumber2)
        {
            return DivideNumber1 / DivideNumber2;
        }

        public IEnumerable<string> FamousMathematicians()
        {
            var json = @"[ 
                { ""Name"": ""Archimedes"" },  
                { ""Name"": ""Euclid"" },
                { ""Name"": ""Isaac Newton"" },  
                { ""Name"": ""Pythagoras"" }, 
                { ""Name"": ""Rene Descartes"" }
            ]";
            
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MathematicianDto>>(json);

            return data.Select(i => i.Name).ToList();
        }
    }
}
