namespace TutorialsEU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float myFloat = 32.57f;
            int myInteger;

            //explicit convertion
            myInteger = (int)myFloat;

            //implicit convertion
            double myDouble = myFloat;
            long myLong = myInteger;

            //type convertion
            string myString = myFloat.ToString();

            //parsing strings into integers

            string myFirst = "15";
            int myFirstInt = Int32.Parse(myFirst);
            string mySecond = "17";
            int mySecondInt = Int32.Parse(mySecond);
           
            int results = myFirstInt + mySecondInt;

            Console.WriteLine(results);
            Console.Read();
        }
    }
}
