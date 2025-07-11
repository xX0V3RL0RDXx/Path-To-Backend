Console.WriteLine("Welcome \nChose option:\n0) Sum\n1) Sub\n2) Div\n3) Mul\n4) Pow");
int userInput = Int32.Parse(Console.ReadLine());

Console.WriteLine("A:");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("B:");
double b = double.Parse(Console.ReadLine());

double result = 0;

switch (userInput)
{
    case 0:
        result = a + b;
        break;
    case 1:
        result = a - b; 
        break;
    case 2:
        result = a / b; 
        break;
    case 3:
        result = a * b;
        break;
    case 4:
        for (int i = 1; i<b;i++)
        {
            result += a * a;
        }
        break;
    default: break;
}

Console.WriteLine(result);
