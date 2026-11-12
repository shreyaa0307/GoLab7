
open System
open System.Diagnostics

// Task 1
let task1 = async {
    printfn "Task 1: Started"

    do! Async.Sleep(2000)

    printfn "Task 1: Completed"

    return "Task 1 Result: Data fetched successfully"
}

// Task 2
let task2 = async {
    printfn "Task 2: Started"

    do! Async.Sleep(1000)

    printfn "Task 2: Completed"

    return "Task 2 Result: Data processed successfully"
}

// Task 3
let task3 = async {
    printfn "Task 3: Started"

    do! Async.Sleep(1500)

    printfn "Task 3: Completed"

    return "Task 3 Result: Report generated successfully"
}

// Execute all three tasks concurrently
printfn "Starting parallel execution...\n"

let stopwatch = Stopwatch.StartNew()

let results =
    [task1; task2; task3]
    |> Async.Parallel
    |> Async.RunSynchronously

stopwatch.Stop()

// Display all results
printfn "\nAll tasks completed!"
printfn "\nCollected Results:"

results
|> Array.iter (printfn "%s")

printfn "\nTotal Execution Time: %d ms"
    stopwatch.ElapsedMilliseconds
