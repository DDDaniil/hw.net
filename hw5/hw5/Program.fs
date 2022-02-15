module hw5.Program

open hw5.Calculator
open hw5.Parser


let main args =
    
    let result = maybe{
        let arg1, operation, arg2 = TryParseArgs args
        let! val1 = arg1
        let! val2 = arg2
        let! op = operation
        let res = Calculate val1 op val2
        return! res
    }
    match result with
    | Some result -> printfn  $"{args.[0]} {args.[1]} {args.[2]} = {result}"
    | None result  -> printfn  $"Program has ended with {result} exception" 
    0
        
    