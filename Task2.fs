// Tail recursion to calculate the product of all elements of a list
let rec productTailRecursive lst acc =
    match lst with
    | [] -> acc
    | head :: tail -> productTailRecursive tail (acc * head)

// Example usage
let numbers = [1; 2; 3; 4; 5]
let resultProduct = productTailRecursive numbers 1 // 1*2*3*4*5 = 120
printfn "Product of list: %d" resultProduct

[<EntryPoint>]
let main argv =
    // Your logic will already run above
    0 // return an integer exit code
