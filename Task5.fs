// Create a sequence of first 700 positive integers
let numbers = Seq.init 700 (fun i -> i + 1)
let numberList = Seq.toList numbers

// Filter out multiples of both 7 and 5, then sum them
let filteredSum = 
    numberList
    |> List.filter (fun x -> x % 7 = 0 && x % 5 = 0)
    |> List.fold (+) 0

// Print result
printfn "Sum of filtered numbers: %d" filteredSum

[<EntryPoint>]
let main argv =
    // Your logic will already run above
    0 // return an integer exit code
