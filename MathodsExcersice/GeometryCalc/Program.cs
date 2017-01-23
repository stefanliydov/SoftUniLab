using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine().ToLower();
            if( typeOfFigure== "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Calculation(side, height, typeOfFigure);
            }
            else if( typeOfFigure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Calculation(width, height, typeOfFigure);
            }
            else if( typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Calculation(side, typeOfFigure);
            }
            else if( typeOfFigure== "circle")
            {
                double  radius = double.Parse(Console.ReadLine());
                Calculation(radius, typeOfFigure);
            }


        }
        public static void Calculation(double num, double height, string typeOfFigure)
        {
            double area = 0;
            switch (typeOfFigure)
            {
                case "triangle":
                    Console.WriteLine("{0:f2}", (area = num*height/2));break;
                case "rectangle":
                    Console.WriteLine("{0:f2}", area = num*height);break;
            }
        }
        public static void Calculation(double num, string typeOfFigure)
        {
            double area = 0;
            switch (typeOfFigure)
            {
                case "square":
                    Console.WriteLine("{0:f2}", (area = num * num)); break;
                case "circle":
                    Console.WriteLine("{0:f2}", area = num * num * Math.PI); break;
            }
        }
    }
}
