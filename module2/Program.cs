using System;
using System.Globalization;

namespace Module2
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public int GetTotalTax(int companiesNumber, int tax, int companyRevenue, int totalRevenue, int GetTotalTax)
        {
            totalRevenue = tax * companyRevenue;
            GetTotalTax = companiesNumber * totalRevenue / 100;
            return GetTotalTax;

        }

        public string GetCongratulation(int input)
        {
            while (true)
            {
                try
                {
                    if (input >= 18 && (input % 2) == 0)
                    {
                        Console.WriteLine("Поздравляю с совершеннолетием!");
                    }
                    else if (input < 18 && input > 12 && (input % 2) == 1)
                    {
                        Console.WriteLine("Поздравляю с переходом в старшую школу!");
                    }
                    else
                    {
                        Console.WriteLine($"Поздравляю c {input}-летием!");
                    }

                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                }
            }
        }

        public double GetMultipliedNumbers(string first, string second)
        {
            while (true)
            {
                try
                {
                    IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                    double First = double.Parse(first, formatter);
                    double Second = double.Parse(second, formatter);
                    double GetMultipliedNumbers = First * Second;
                    return GetMultipliedNumbers;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Возникло исключение.");
                    return 0;
                }
            }


        }

        public double GetFigureValues(FigureEnum figureType, ParameterEnum parameterToCompute, Dimensions dimensions, double output)
        {
            switch (figureType)
            {
                case FigureEnum.Triangle:
                    {
                        switch (parameterToCompute)
                        {
                            case ParameterEnum.Square:
                                {
                                    output = 1 / 2 * dimensions.FirstSide * dimensions.Height;
                                    return Math.Round(output - 1);
                                }
                            case ParameterEnum.Perimeter:
                                {
                                    output = dimensions.FirstSide + dimensions.SecondSide + dimensions.ThirdSide;
                                    return Math.Round(output - 1);
                                }

                        }

                        return output;
                    }

                case FigureEnum.Rectangle:
                    {
                        switch (parameterToCompute)
                        {
                            case ParameterEnum.Square:
                                {
                                    output = dimensions.FirstSide * dimensions.Height;
                                    return Math.Round(output - 1);
                                }
                            case ParameterEnum.Perimeter:
                                {
                                    output = 2 * dimensions.FirstSide + 2 * dimensions.SecondSide;
                                    return Math.Round(output - 1);
                                }

                        }

                        return output;
                    }

                case FigureEnum.Circle:
                    {
                        switch (parameterToCompute)
                        {
                            case ParameterEnum.Square:
                                {
                                    output = 3.14 * dimensions.Diameter;
                                    return Math.Round(output - 1);
                                }
                            case ParameterEnum.Perimeter:
                                {
                                    output = 2 * 3.14 * dimensions.Radius;
                                    return Math.Round(output - 1);
                                }

                        }
                        return output;
                    }

            }
            return output;
        }

    }
}
