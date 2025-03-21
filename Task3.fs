// Tail recursion to calculate the product of all odd numbers
let rec oddProductTailRecursive n acc =
    if n <= 0 then acc
    else oddProductTailRecursive (n - 2) (acc * n)

// Example usage
let oddResult = oddProductTailRecursive 11 1 // 11*9*7*5*3*1 = 10395
printfn "Product of odd numbers: %d" oddResult

[<EntryPoint>]
let main argv =
    // Your logic will already run above
    0 // return an integer exit code
