open System

let printGreeting name =
    printfn "Hello %s from F#" name

[<EntryPoint>]
let main argv =
    printGreeting "Dan"
    0 // return an integer exit code
