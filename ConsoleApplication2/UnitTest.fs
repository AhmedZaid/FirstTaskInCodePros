module ConsoleApplication2.UnitTest

open System
open NUnit.Framework

[<TestFixture>]
type TestClass() = 

    [<Test>]
    member this.Empty() = 
        let res = FirstTaskAtCodePros.add ""
        Assert.AreEqual(res, 0)

    [<Test>]
    member this.OneArgument() = 
        let res = FirstTaskAtCodePros.add "15"
        Assert.AreEqual(res, 15)

    [<Test>]
    member this.SimpleTwoArgument() = 
        let res = FirstTaskAtCodePros.add "2,5"
        Assert.AreEqual(res, 7)
        
    [<Test>]
    member this.UnlimtedArgument() = 
        let res = FirstTaskAtCodePros.add "2,5,13,4"
        Assert.AreEqual(res, 24)

    [<Test>]
    member this.NewLineDelimeter() = 
        let res = FirstTaskAtCodePros.add "9\n4,7"
        Assert.AreEqual(res, 20)