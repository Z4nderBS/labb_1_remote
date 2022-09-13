//================================================
// Mat-Mats Logistik v. 1.3
//================================================

bool isRunning = true;

while (isRunning)
{
    DisplayMenu();

    ReadInput();
}

void DisplayMenu()
{
    string title = "======MAT-MATS LOGISTIK======";
    string firstLine = "1. Registrera ny leverans";
    string secondLine = "2. Beställ mer";
    string thirdLine = "3. Ny inventering";
    string lastLine = "4. Stäng";

    Console.WriteLine($"{title}\n{firstLine}\n{secondLine}\n{thirdLine}\n{lastLine}");
    Console.Write(">\n");

}

void ReadInput()
{
   
    try
    {
        switch (Int32.Parse(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("Skönt. Då slipper vi ringa och klaga på att varorna inte levereras i tid.");
                break;
            case 2:
                Console.WriteLine("Hellre mer i lager än för lite...");
                OrderMore();
                break;
            case 3:
                Console.WriteLine("Vad väntar du på? Börja inventera hyllorna!");
                break;
            case 4:
                isRunning = false;
                Console.WriteLine("Bra jobbat. Ses imorgon.");
                break;
            default:
                break;
        }
    }
    catch (Exception)
    {
        string error = "Error: du skrev inte in ett nummer";
        Console.WriteLine(error);
    }
   
}

void OrderMore()
{
    Console.WriteLine("vad behövs beställas?");
    string order = Console.ReadLine();
    Console.WriteLine($"beställer mer {order}\n");
}