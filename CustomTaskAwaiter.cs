using System.Runtime.CompilerServices;

namespace CreatingTaskFromScratch;

public readonly struct CustomTaskAwaiter : INotifyCompletion
{
    private readonly CustomTask _task;

    internal CustomTaskAwaiter(CustomTask task) => _task = task;

    public bool IsCompleted => _task.IsCompleted;
    public void OnCompleted(Action continuation) => _task.ContinueWith(continuation);
    public CustomTaskAwaiter GetAwaiter() => this;
    public void GetResult() => _task.Wait();
}