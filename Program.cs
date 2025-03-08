using CreatingTaskFromScratch;

Console.WriteLine($"Starting Thread id: {Environment.CurrentManagedThreadId}");

CustomTask.Run(() =>
    {
        Console.WriteLine($"First CustomTask Thread id: {Environment.CurrentManagedThreadId}");
    }).Wait();

CustomTask.Delay(TimeSpan.FromSeconds(1)).Wait();

CustomTask.Run(() =>
{
    Console.WriteLine($"Second CustomTask Thread id: {Environment.CurrentManagedThreadId}");
}).Wait();