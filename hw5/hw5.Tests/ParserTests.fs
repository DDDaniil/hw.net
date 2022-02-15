module ParserTests

open hw5.Parser
open hw5.Calculator
open Xunit


[<Theory>]
[<InlineData("1", "+", "2", 1, "+", 2 )>]
[<InlineData("2", "-", "1.1", 2, "-", 1.1 )>]
[<InlineData("2", "*", "0.002", 2, "*", 0.002 )>]
[<InlineData("2", "/", "5", 2, "/", 5 )>]
let ``ParseValidArgsAndOperations``(val1, operation, val2, expectArg1, expectOp, expectArg2) =
    let arg1, op, arg2 = TryParseArgs [|val1; operation; val2|]
    Assert.Equal(arg1, Some expectArg1)
    Assert.Equal(op, Some expectOp)
    Assert.Equal(arg2, Some expectArg2)

[<Theory>]
[<InlineData("2", "aaa", "3", 2, "aaa", 3 )>]
[<InlineData("2", "", "1.1", 2, "", 1.1 )>]
let ``ParseInvalidOperations``(val1, operation, val2, expectArg1, expectOp, expectArg2) =
    let arg1, op, arg2 = TryParseArgs [|val1; operation; val2|]
    Assert.Equal(op, None "NotSupportedOperation")
    
[<Theory>]
[<InlineData("aa", "+", "3", "?", "+", 3 )>]
[<InlineData("", "-", "3", "?", "-", 3 )>]
let ``ParseInvalidArgs``(val1, operation, val2, expectArg1, expectOp, expectArg2) =
    let arg1, op, arg2 = TryParseArgs [|val1; operation; val2|]
    Assert.Equal(arg1, None "InvalidArgument")
