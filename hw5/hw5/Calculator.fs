module hw5.Calculator 

    let Calculate val1 operation val2 =
        let a = val1 |> int
        let b = val2 |> int
        match operation with
        | "+" -> a + b
        | "-" -> a - b
        | "*" -> a * b
        | "/" -> a / b
    