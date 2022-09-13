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

    Console.WriteLine("======MAT-MATS LOGISTIK======\n1. Registrera ny leverans\n2. Beställ mer\n3. Ny inventering\n4. Stäng");
    Console.Write(">");

}

void ReadInput()
{
    switch (Int32.Parse(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Skönt. Då slipper vi ringa och klaga på att varorna inte levereras i tid.");
            break;
        case 2:
            Console.WriteLine("Hellre mer i lager än för lite...");
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