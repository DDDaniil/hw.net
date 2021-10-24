module hw5.Program
open hw5.Parser
open hw5.Calculator

[<EntryPoint>]
let Main args =
    let mutable val1 = 1
    let mutable val2 = 2
    let mutable operation = "+"
    let parseRes = Parser.TryToParse args &val1 &operation &val2
    if parseRes <> 0 then
            printf $"Result: {Calculator.Calculate val1 operation val2}"
            0
    else
        printf$"invalid arguments"
        int parseRes