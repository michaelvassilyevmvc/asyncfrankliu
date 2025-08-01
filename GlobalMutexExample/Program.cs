string filePath = "counter.txt";

// Mutex используется там где ресурсам пользуется одновременно несколько программ
// т.е. несколько процессов
// Процесс состоит из потоков
// Если одновременно пользуется несколько потоков испольуем lock либо Monitor
using (Mutex mutex = new Mutex(false, $"GlobalFileMutex:{filePath}"))
{
    for (int i = 0; i < 10000; i++)
    {
        // Запускаем mutex
        mutex.WaitOne();
        try
        {
            int counter = ReadCounter(filePath);
            counter++;
            WriteCounter(filePath, counter);
        }
        finally
        {
            // Обязательно его надо закрыть
            mutex.ReleaseMutex();
        }
    }
}

Console.WriteLine("Process finished");
Console.ReadLine();

int ReadCounter(string filePath)
{
    using (var stream = new FileStream(filePath,
               FileMode.OpenOrCreate,
               FileAccess.Read,
               FileShare.ReadWrite))
    {
        using (var reader = new StreamReader(stream))
        {
            string content = reader.ReadToEnd();
            return string.IsNullOrEmpty(content) ? 0 : int.Parse(content);
        }
    }
}

void WriteCounter(string filePath, int counter)
{
    using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
    using (var writer = new StreamWriter(stream))
    {
        writer.Write(counter);
    }
}