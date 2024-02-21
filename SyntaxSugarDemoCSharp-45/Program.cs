namespace SyntaxSugarDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicit Typing
            int number = 10;
            string name = "test";
            int num;

            //Inferred Typing
            var thing = true;
            var otherThing = 12.0m;

            //Inline If/ Ternary Operator

            var age = 29;

            Console.WriteLine(age >= 18 ? "You're an adult." : age < 5 ? "You're a baby." : "You're a minor.");

            //String Interpolation vs Concatenation

            var middleInitial = 'S';

            Console.WriteLine($"Brandon {middleInitial} Bowman");
            Console.WriteLine("Brandon" + " " + middleInitial + " " + "Bowman");

        }
    }
}
