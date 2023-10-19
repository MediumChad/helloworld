using System.Xml;

class Hiearth
{
    static void Main()
    {
        Console.WriteLine("What's your name:");
        string nombre = Console.ReadLine();
        string number = Console.ReadLine();
        bool isEven = IsNumberEven(number);

        if(isEven)
        {
            nombre = "chad";
        }

        Console.WriteLine("fuck off " + nombre);

        bool IsNumberEven(string strNumber)
        {
            int convertedNumber = Convert.ToInt32(strNumber);
            int remainder = convertedNumber % 2;
            if (remainder == 0)
            {
                return true;
            }
            else { return false; }
        }
    }

}