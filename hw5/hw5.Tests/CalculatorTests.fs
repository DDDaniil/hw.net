module CalculatorTests

open hw5.Calculator
open Xunit

open hw5

[<Theory>]
[<InlineData(1 ,"+", 1, 2)>]
[<InlineData(2 ,"-", 1, 1)>]
[<InlineData(2 ,"*", 2, 4)>]
[<InlineData(2 ,"/", 1, 1)>]

let ``CalculateSuccess`` (arg1 ,operation, arg2, expect) =
    let res = Calculate arg1 operation arg2
    Assert.Equal(res, Some expect)
    
[<Theory>]
[<InlineData(1 ,"/", 0, "DividingByZero")>]
[<InlineData(2 ,"/", 0, "DividingByZero")>]

let ``DividingByZero`` (arg1 ,operation, arg2, expect) =
    
    let res = Calculate arg1 operation arg2
    
    Assert.Equal(res, None expect)

