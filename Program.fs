// Define the list of names
let names = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// Filter names that contain the letter 'I' (case insensitive)
let filteredNames = 
    names 
    |> List.filter (fun name -> name.Contains("I", System.StringComparison.OrdinalIgnoreCase))

// Use List.fold to concatenate the filtered names with a comma and space
let concatenatedNames = 
    filteredNames 
    |> List.fold (fun acc name -> 
        if acc = "" then name // If accumulator is empty, just take the name
        else acc + ", " + name) ""

// Print the result
printfn "Concatenated Names: %s" concatenatedNames