namespace FraactionModulationPracticeOOP
{
    public class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator;

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void Print()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        public Fraction Sum(Fraction otherFraction)
        {
            int commonDenominator = Denominator * otherFraction.Denominator;
            int resultNominator = Numerator * otherFraction.Denominator + otherFraction.Numerator * Denominator;

            Fraction result = new Fraction(resultNominator, commonDenominator);
            return result;
        }

        public Fraction Sum(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Sum(otherFraction);
            return result;
        }
        
        public Fraction Difference(Fraction otherFraction)
        {
            int commonDenominator = Denominator * otherFraction.Denominator;
            int resultNominator = Numerator * otherFraction.Denominator - otherFraction.Numerator * Denominator;

            Fraction result = new Fraction(resultNominator, commonDenominator);
            return result;
        }

        public Fraction Difference(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Difference(otherFraction);
            return result;
        }

        public Fraction Multiply(Fraction otherFraction)
        {
            Fraction result = new Fraction(Numerator * otherFraction.Numerator, Denominator * otherFraction.Denominator);
            return result;
        }

        public Fraction Multiply(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Multiply(otherFraction);
            return result;
        }

        public Fraction Divide(Fraction otherFraction)
        {
            Fraction result = new Fraction(Numerator * otherFraction.Denominator, Denominator * otherFraction.Numerator);
            return result;
        }

        public Fraction Divide(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Divide(otherFraction);
            return result;
        }
    }
}
