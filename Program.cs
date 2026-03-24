using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

public class SyncApiCaller
{
    private static readonly HttpClient _client = new HttpClient();

    // NOTE: GetStringAsync() is already an async method — it returns a Task<string>.
    // Your job: rewrite RunSync() so all 5 requests run asynchronously.
    public static void RunSync()
    {
        var sw = Stopwatch.StartNew();

        Console.WriteLine("=== SYNC VERSION ===");

        // Each .Result call blocks the calling thread until the response arrives.
        string users    = _client.GetStringAsync("https://jsonplaceholder.typicode.com/users/1").Result;
        Console.WriteLine($"[{sw.ElapsedMilliseconds}ms] Fetched user");

        string posts    = _client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1").Result;
        Console.WriteLine($"[{sw.ElapsedMilliseconds}ms] Fetched post");

        string comments = _client.GetStringAsync("https://jsonplaceholder.typicode.com/comments/1").Result;
        Console.WriteLine($"[{sw.ElapsedMilliseconds}ms] Fetched comment");

        string todos    = _client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1").Result;
        Console.WriteLine($"[{sw.ElapsedMilliseconds}ms] Fetched todo");

        string albums   = _client.GetStringAsync("https://jsonplaceholder.typicode.com/albums/1").Result;
        Console.WriteLine($"[{sw.ElapsedMilliseconds}ms] Fetched album");

        sw.Stop();
        Console.WriteLine($"Sync total: {sw.ElapsedMilliseconds}ms\n");
    }
}

// ============================================================
//  Entry point
// ============================================================
public class Program
{
    public static async Task Main()
    {
        SyncApiCaller.RunSync();

        // TODO: Call your async version here
        // await SyncApiCaller.RunAsync();
    }
}
