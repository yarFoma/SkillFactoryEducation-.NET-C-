//Console.WriteLine("Цикл while");

//int k = 0;

//while (k < 0)
//{
//    Console.WriteLine(k);
    
//    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
    
//    switch (Console.ReadLine())
//    {
//        case "red":
//            Console.BackgroundColor = ConsoleColor.Red;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is red!");
//            break;

//        case "green":
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is green!");
//            break;

//        default:
//            Console.BackgroundColor = ConsoleColor.Cyan;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is cyan!");
//            break;
//    }
        
//    k++;
//}

//Console.WriteLine("Цикл do");

//int t = 0;

//do
//{
//    Console.WriteLine(t);

//    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

//    switch (Console.ReadLine())
//    {
//        case "red":
//            Console.BackgroundColor = ConsoleColor.Red;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is red!");
//            break;

//        case "green":
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is green!");
//            break;

//        default:
//            Console.BackgroundColor = ConsoleColor.Cyan;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is cyan!");
//            break;
//    }
    
//    t++;
//}while (t < 0);


int k = 0;

while (true)
{
    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
    Console.WriteLine(k);

    var text = Console.ReadLine();

    switch (Console.ReadLine())
    {
        case "red":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red!");
            break;

        case "green":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
            break;

        case "cyan":
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");
            break;
         default:
            continue;

    }

    if (text == "stop")
    {
        Console.WriteLine("Цикл остановлен");
        break;
    }
       

    k++;

}