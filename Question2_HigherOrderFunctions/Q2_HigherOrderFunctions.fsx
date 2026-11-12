// Two input lists
let list1 = [1; 2; 3; 4; 5]
let list2 = [6; 7; 8; 9; 10]

// 1. List.map - Square every element

printfn "---- List.map: Square Numbers ----"

let squares1 =
    List.map (fun x -> x * x) list1

let squares2 =
    List.map (fun x -> x * x) list2

printfn "List 1: %A" list1
printfn "Squares: %A" squares1

printfn "List 2: %A" list2
printfn "Squares: %A" squares2


// 2. List.filter - Select even numbers

printfn "\n---- List.filter: Even Numbers ----"

let even1 =
    List.filter (fun x -> x % 2 = 0) list1

let even2 =
    List.filter (fun x -> x % 2 = 0) list2

printfn "List 1: %A" list1
printfn "Even Numbers: %A" even1

printfn "List 2: %A" list2
printfn "Even Numbers: %A" even2


// 3. List.fold - Calculate sum of elements

printfn "\n---- List.fold: Sum of Numbers ----"

let sum1 =
    List.fold (fun acc x -> acc + x) 0 list1

let sum2 =
    List.fold (fun acc x -> acc + x) 0 list2

printfn "List 1: %A" list1
printfn "Sum: %d" sum1

printfn "List 2: %A" list2
printfn "Sum: %d" sum2
