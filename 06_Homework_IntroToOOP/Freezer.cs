using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Homework_IntroToOOP
{
    partial class Freezer
    {
        public void Print()
        {
            Console.WriteLine($"Model : {model} \nHeight : {height} \nWidth : {width} \nLength : {length} \n Weight : {weight}");
        }
        public override string ToString()
        {
            return $"Model : {model} \nHeight : {height} \nWidth : {width} \nLength : {length} \n Weight : {weight}";
        }
    }
}
