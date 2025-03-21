// List of names
let names = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// Filter names containing the letter "I" and concatenate them using fold
let concatenatedNamesWithI =
    names
    |> List.filter (fun name -> name.Contains("I"))  // Filter names that contain the letter "I"
    |> List.fold (fun acc name -> acc + name) ""     // Concatenate filtered names using fold

// Print the concatenated names
printfn "Concatenated names with 'I': %s" concatenatedNamesWithI

[<EntryPoint>]
let main argv =
    0 // Return an integer exit code
