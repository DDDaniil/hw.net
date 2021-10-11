module hw4.Calculator 

let Calcul val1 operation val2 =
    let a = val1 |> double
    let b = val2 |> double
    match operation with
    | "+" -> a + b
    | "-" -> a - b
    | "*" -> a * b
    | "/" -> a / b

