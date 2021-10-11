﻿module hw4.Parser

module Parser =
    let isSupported (operation : string) =
        match operation with
            | "+" -> true
            | "-" -> true
            | "*" -> true
            | "/" -> true
            | _ -> false
    let TryToParse (args : string[]) (val1 : outref<int>) (operation : outref<string>) (val2 : outref<int>) =
        let isVal1Int = System.Int32.TryParse(args.[0], &val1)
        let operation = args.[1]
        let isVal2Int = System.Int32.TryParse(args.[2], &val2)
        if (not isVal1Int && not isVal2Int) then
            printf$"{args.[0]}{args.[1]}{args.[2]} is not a valid calculation syntax"
            1
        elif not (isSupported args.[1]) then
            printf $"{args.[0]} {args.[1]} {args.[2]} invalid arguments"
            2
        else 0  
        
    
