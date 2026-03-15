    Console.WriteLine("Welcome")
    Console.WriteLine("Enter the path to the folder:");
    string folderPath = Console.ReadLine();

    // Отримуємо файли 
    string[] files = Directory.GetFiles(folderPath);

    Console.WriteLine("File list:");

    foreach (string file in files)
    {
        Console.WriteLine(file);
    }

    Console.WriteLine("Press any key to close");
    Console.ReadKey();
