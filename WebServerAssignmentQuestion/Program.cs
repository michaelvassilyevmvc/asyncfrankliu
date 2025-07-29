﻿Console.WriteLine("Server is running. Type 'exit' to stop.");
while (true)
{
    string? input = Console.ReadLine();
    if (input?.ToLower() == "exit")
    {
        break;
    }

    ProcessInput(input);
}

static void ProcessInput(string input)
{
    Thread.Sleep(2000);
    Console.WriteLine($"Processed input: {input}");
}