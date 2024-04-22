using System.Collections;

internal static class Program
{
    public static async Task Main(string[] args)
    {
        var timeout = Task.Delay(5000); // do not wait for user input more than 5 sec
        var userInputTask = ReadConsoleInputAsNumber("Please type number...");
        var result = await Task.WhenAny(timeout, userInputTask);
        
        if (result == timeout)
        {
            Console.WriteLine("You did not type any number, exiting... =(");
            return;
        }

        var number = await userInputTask;
        // process number

    }


    private static Task<int> WaitForUserInput(TaskCompletionSource<int> taskCompletionSource)
    {
        var result = Console.ReadLine();

        if(Int32.TryParse(result, out var resultInt))
        {
            taskCompletionSource.SetResult(resultInt);
            return taskCompletionSource.Task;
        }

        taskCompletionSource.SetException(new InvalidOperationException(result));

        return taskCompletionSource.Task;
    }


    public static Task<int> ReadConsoleInputAsNumber(string message)
    {
        var tcs = new TaskCompletionSource<int>();
        Console.WriteLine(message);

        return Task.Run(() =>
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number:");
                }
            }
        });
    }
}