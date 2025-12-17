namespace FraactionModulationPracticeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 2);
            fraction1.Print();
            Fraction fraction2 = new Fraction(1, 3);
            fraction2.Print();

            Fraction result = fraction1.Sum(fraction2);
            result.Print();
            
            result = fraction1.Difference(fraction2);
            result.Print();

            result = fraction1.Multiply(fraction2);
            result.Print();

            result = fraction1.Divide(fraction2);
            result.Print();

            Fraction number = new Fraction(25);
            number.Print();

            Fraction number2 = new Fraction(100, 50);
            number2.Print();

            Fraction number3 = new Fraction(6, 8);
            number3.Print();
        }
    }
}
