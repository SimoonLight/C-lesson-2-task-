// See https://aka.ms/new-console-template for more information

int first_choice = 0;

int select_menu = 0;

double sum = 0;


    if (select_menu == 0)
    {
        firstMenu(ref first_choice);
    }

    double num1 = 0;
    double num2 = 0;
    bool isDiv = false;
    if (first_choice == 3)
    {
        isDiv = true;
    }
    Enter_numbers(isDiv, ref num1, ref num2);
    switch (first_choice)
    {
        case 0:
            sum = Toplama(num1, num2);
            break;
        case 1:
            sum = Cixma(num1, num2);
            break;
        case 2:
            sum = Vurma(num1, num2);
            break;
        case 3:
            sum = Bolme(num1, num2);
            break;
        default:
            break;
    }


Console.Clear();
Console.WriteLine("\t\t\t\n\n\n Calculator\n\n\n\t\t\t");
Console.WriteLine( "Sum : "+sum);
void firstMenu(ref int choice)
{
    bool check_while = true;
    while (check_while)
    {
        Console.Clear();
        Console.WriteLine("\t\t\t\n\n\n Welcome Calculator\n\n\n\t\t\t");
        switch (choice)
        {
            case 0:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Toplama");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cixma");
                Console.WriteLine("Vurma");
                Console.WriteLine("Bolme");
                break;
            case 1:
                Console.WriteLine("Toplama");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cixma");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vurma");
                Console.WriteLine("Bolme");
                break;
            case 2:
                Console.WriteLine("Toplama");
                Console.WriteLine("Cixma");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vurma");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Bolme");
                break;
            case 3:
                Console.WriteLine("Toplama");
                Console.WriteLine("Cixma");
                Console.WriteLine("Vurma");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bolme");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            default:
                break;
        }

        ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.UpArrow)
        {
            if (choice == 0)
            {
                choice = 3;
            }
            else
            {
                choice -= 1;
            }
        }
        else if (key.Key == ConsoleKey.DownArrow)
        {
            if (choice == 3)
            {
                choice = 0;
            }
            else
            {
                choice += 1;
            }
        }
        else if (key.Key == ConsoleKey.Enter)
        {
            check_while = false;
            break;
        }

    }


}

void Enter_numbers(bool div, ref double num1, ref double num2)
{
EnterAgain:
    Console.Clear();
    Console.WriteLine("\t\t\t\n\n\n Welcome Calculator\n\n\n\t\t\t");
    Console.Write(" Enter first number : ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Enter second number : ");
    num2 = Convert.ToInt32(Console.ReadLine());
    if (div == true && num2 == 0)
    {
        Console.WriteLine("\t\t\t\n\n\nWRONG\n\n\n\t\t\t");
        Thread.Sleep(1000);
        goto EnterAgain;
    }
}

double Toplama(double num1, double num2)
{
    double sum = num1 + num2;
    return sum;
}

double Cixma(double num1, double num2)
{
    double sum = num1 - num2;
    return sum;
}

double Vurma(double num1, double num2)
{
    double sum = num1 * num2;
    return sum;
}

double Bolme(double num1, double num2)
{
    double sum = num1 / num2;
    return sum;
}

