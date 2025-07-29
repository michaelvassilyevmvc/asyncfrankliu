Queue<string?> requestQueue = new Queue<string?>();

// 2. Start the requests queue monitoring thread
Thread monitorThread = new Thread(MonitorQueue);
monitorThread.Start();

Console.WriteLine("Server is running. Type 'exit' to stop.");
while (true)
{
    string? input = Console.ReadLine();
    if (input?.ToLower() == "exit")
    {
        break;
    }
    requestQueue.Enqueue(input);
}

void MonitorQueue()
{
    while (true)
    {
        if (requestQueue.Count > 0)
        {
            string? input = requestQueue.Dequeue();
            Thread processingThread = new Thread(() => ProcessInput(input));
            processingThread.Start();
        }
        Thread.Sleep(100);
        
        
    }
}

// 3. Processing the request
void ProcessInput(string input)
{
    Thread.Sleep(2000);
    Console.WriteLine($"Processed input: {input}");
}
