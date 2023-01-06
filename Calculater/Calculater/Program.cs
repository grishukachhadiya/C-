// See https://aka.ms/new-console-template for more information
float num1 = 0; float num2 = 0;

Console.WriteLine("\t\t\t   Calculator");
Console.WriteLine("\t\t\t -------------------\n");


Console.WriteLine("Enter no. 1 : ");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter no. 2 : ");
num2 = float.Parse(Console.ReadLine());


Console.WriteLine("\n Chooe Operations");
Console.WriteLine("1. add");
Console.WriteLine("2. sub");
Console.WriteLine("3. mul");
Console.WriteLine("4. div");


switch(Console.ReadLine())
{
    case "1":
        Console.WriteLine(" result : " + (num1 + num2));
        break;

    case "2":
        Console.WriteLine(" result : " + (num1 - num2));
        break;

    case "3":
        Console.WriteLine(" result : " + (num1 * num2));
        break;

    case "4":
        Console.WriteLine(" result : " + (num1 / num2));
        break;
    default: Console.WriteLine("This number is not a Correct Number");

        break;

}






