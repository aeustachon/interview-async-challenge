# Async/Await Interview Challenge

## Setup
Open this repo in a GitHub Codespace, then run:
```
dotnet run
```

## Tasks

The code in `Program.cs` contains a synchronous method `RunSync()` that makes 5 sequential HTTP requests.

### 1. Avoid Blocking
Rewrite `RunSync()` as a new method `RunAsync()` that avoids using `.Result`. The method should properly `await` the asynchronous operations.

### 2. Maximize Concurrency
Ensure all 5 HTTP requests run **concurrently** rather than sequentially to minimize total execution time.

### Running
```
dotnet run
```

You should see the sync version take ~2-3 seconds total (sequential requests). Your async version should complete in roughly the time of a single request.
