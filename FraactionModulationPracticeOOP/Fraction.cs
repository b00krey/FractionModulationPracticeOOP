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
    }
}
