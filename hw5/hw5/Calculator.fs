module hw5.Calculator

    type Valid<'a> =
            | Some of 'a
            | None of string
    let Calculate (arg1: decimal) (operation: string) (arg2: decimal) =
                match operation with
                | "+" -> Some (arg1 + arg2)
                | "-" -> Some (arg1 - arg2) 
                | "*" -> Some (arg1 * arg2) 
                | "/" ->
                    match arg2|>int32 with
                    | 0 -> None "DivisionByZero"
                    | _ -> Some ( arg1 / arg2)