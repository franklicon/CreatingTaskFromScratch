using CreatingTaskFromScratch;

Console.WriteLine($"Starting Thread id: {Environment.CurrentManagedThreadId}");

CustomTask.Run(() =>
    {
        Console.WriteLine($"First CustomTask Thread id: {Environment.CurrentManagedThreadId}");
    }).Wait();

CustomTask.Run(() =>
{
    Console.WriteLine($"Second CustomTask Thread id: {Environment.CurrentManagedThreadId}");
}).Wait();