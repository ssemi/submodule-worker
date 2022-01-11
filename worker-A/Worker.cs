using common_module;

namespace Worker_A;

public class Worker : IWorker
{
    public Task RunAsync(string message)
    {
        Console.WriteLine(message + " Worker-A");
        
        return Task.CompletedTask;
    }
}

