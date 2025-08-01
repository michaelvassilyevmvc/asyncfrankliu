Queue<string?> requestQueue = new Queue<string?>();
int availableTickets = 10;
object ticketsLock = new object();

// 2. Start the requests queue monitoring thread
Thread monitorThread = new Thread(MonitorQueue);
monitorThread.Start();

Console.WriteLine("Server is running. \r\n Type 'b' to book a ticket. \r\n Type 'c' to cancel.\r\n Type 'exit' to stop.");
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
            Thread processingThread = new Thread(() => ProcessBooking(input));
            processingThread.Start();
        }
        Thread.Sleep(100);
        
        
    }
}

// 3. Processing the request
void ProcessBooking(string input)
{
    if (Monitor.TryEnter(ticketsLock, 2000))
    {

        try
        {
            Thread.Sleep(3000);

            if (input == "b")
            {
                if (availableTickets > 0)
                {
                    availableTickets--;
                    Console.WriteLine();
                    Console.WriteLine($"Your seat is booked. {availableTickets} seats are still available.");
                }
                else
                {
                    Console.WriteLine("Tickets are not available.");
                }
            }
            else if (input == "c")
            {
                if (availableTickets < 10)
                {
                    availableTickets++;
                    Console.WriteLine();
                    Console.WriteLine($"Your booking is caceled. {availableTickets} seats are available.");
                }
                else
                {
                    Console.WriteLine($"Error. You cannot cancel a booking at this time.");
                }
            }
        }
        finally
        {
            Monitor.Exit(ticketsLock);
        }
    }
    else
    {
        Console.WriteLine("System is busy. Please wait");
    }
}
