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
> A below method simulates a long-running task by delaying for 1 second in each iteration of a loop. 
  The CancellationToken is passed as a parameter, and we use the `ThrowIfCancellationRequested()` method to stop 
  the operation if a cancellation request is received.
 

 
> Now, if we cancel the request after a certain period of time, the ongoing operation will be interrupted and 
  will not proceed with further processing. This ensures that the operation stops as soon as the cancellation request is made.
 

•	If the CancellationToken is not canceled, the process will execute to completion without interruption. The operation will continue until it has finished, and it will not stop prematurely.
 
