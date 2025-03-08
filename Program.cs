using CreatingTaskFromScratch;

Console.WriteLine($"Starting Thread id: {Environment.CurrentManagedThreadId}");

await CustomTask.Run(() =>
{
    Console.WriteLine($"First CustomTask Thread id: {Environment.CurrentManagedThreadId}");
});

CustomTask.Delay(TimeSpan.FromSeconds(2)).Wait();

await CustomTask.Run(() =>
{
    Console.WriteLine($"Second CustomTask Thread id: {Environment.CurrentManagedThreadId}");
});