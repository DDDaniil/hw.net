module hw5.Parser

open hw5.Calculator
    type ValidBuilder() =
        member this.Bind(x, f) = 
            match x with
            | Some x -> f x
            | None x -> None x
         member this.Return x = x
         member this.ReturnFrom x = Some x

    let maybe = ValidBuilder()

    let TryParseArgs (args: string[])  =
        let ParseValue (x: string)  =
            try Some (x |> decimal) with
            | _ -> None "InvalidArgument"
            
        let IsOperationSupported operation =
            match operation with
            | "+" -> Some "+"
            | "-" -> Some "-"
            | "*"  -> Some "*"
            | "/"  -> Some "/"
            | _ -> None "NotSupportedOperation"
        ParseValue args.[0], IsOperationSupported args.[1], ParseValue args.[2]