using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisePerfomance
{
    public class StringTest
    {
        string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", };
        [Benchmark]

        public string WithStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in numbers)
            {
                stringBuilder.Append(s);
                stringBuilder.Append(" ");
            }
            return stringBuilder.ToString();

            //int proizvedenie = 0;
            //foreach (int var in numbers)
            //{
            //    proizvedenie *= var;
            //}
            //return proizvedenie;
        }
        [Benchmark]

        public string WithConcatenation()
        {
            string result = "";
            foreach (string s in numbers) result = result + s + " ";
            return result;
        }
        [Benchmark]

        public string WithInterpolation()
        {
            string result = "";
            foreach (string s in numbers) result = $"{result}{s}";
            return result;
        }
    }
}
