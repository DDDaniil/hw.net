module hw5.Calculator

    let Calculate val1 operation val2 =
        let a = val1 |> double
        let b = val2 |> double
        match operation with
        | "+" -> a + b
        | "-" -> a - b
        | "*" -> a * b
        | "/" -> a / b