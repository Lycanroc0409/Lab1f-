open System

// Function to apply the exponent to the value
let power (exponent: float) (value: float) = value ** exponent

// Partial application for square and cube
let square = power 2.0
let cube = power 3.0

// Invoking square and cube
let resultSquare = square 4.0 // 4^2 = 16.0
let resultCube = cube 4.0 // 4^3 = 64.0

// Print results with correct format
printfn "Square result: %f" resultSquare
printfn "Cube result: %f" resultCube

[<EntryPoint>]
let main argv =
    // Your logic will already run above
    0 // return an integer exit code
