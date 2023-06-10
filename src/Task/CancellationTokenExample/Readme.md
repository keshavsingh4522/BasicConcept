## Cancellation Token
- It provides a simple and efficient way to manage cancellation of long-running or asynchronous tasks.
- It allows you to cancel an operation cooperatively, meaning that the operation itself monitors the cancellation request and stops executing when it is requested.
- This helps in avoiding unnecessary work and improving the responsiveness of your application.

Example:
> Consider a scenario where you have an application that downloads large files from the internet. 
  The user might want to cancel the download operation if it takes too long. 
  You can use a CancellationToken to handle this cancellation request.

- To request cancellation, call the Cancel method on the CancellationTokenSource:

```c#
cancellationTokenSource.Cancel();
```

- Let us understand with example, using code:
```c#
    [HttpGet("longrunningtask")]
    public async Task<IActionResult> LongRunningTask(CancellationToken cancellationToken)
    {
        try
        {
            int iterations = 20;

            for (int i = 0; i < iterations; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                _logger.LogInformation($"Iteration {i + 1} of {iterations} completed.");
            }

            return Ok("Long-running task completed successfully.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Download cancelled.");
            return Ok("Long-running task cancelled successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Response.StatusCode = 500;
            return Ok("Inernal error.");
        }
    }
```
> A below method simulates a long-running task by delaying for 1 second in each iteration of a loop. 
  The CancellationToken is passed as a parameter, and we use the `ThrowIfCancellationRequested()` method to stop 
  the operation if a cancellation request is received.
 
 ![PIC_01](https://github.com/keshavsingh4522/BasicConcept/assets/43788985/03c14edd-3394-4b19-a12d-21b3f999907a)
 
> Now, if we cancel the request after a certain period of time, the ongoing operation will be interrupted and 
  will not proceed with further processing. This ensures that the operation stops as soon as the cancellation request is made.
 

> If the CancellationToken is not canceled, the process will execute to completion without interruption. 
  The operation will continue until it has finished, and it will not stop prematurely.
 
 ![PIC_02](https://github.com/keshavsingh4522/BasicConcept/assets/43788985/f6722c0d-458f-4ad4-8232-6889448ff6e5)

## Document
- [Link]()