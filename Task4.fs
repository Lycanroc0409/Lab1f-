// Using map to trim all spaces from a list of strings
let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let trimmedNames = names |> List.map (fun name -> name.Trim())

// Print results
trimmedNames |> List.iter (fun name -> printfn "%s" name)

[<EntryPoint>]
let main argv =
    // Your logic will already run above
    0 // return an integer exit code
