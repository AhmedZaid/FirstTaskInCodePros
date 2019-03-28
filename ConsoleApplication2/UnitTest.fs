module ConsoleApplication2.UnitTest

open System
open NUnit.Framework
open FsUnit

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

    [<Test>]
    member this.UserDelimeter() = 
        let res = FirstTaskAtCodePros.add "//?\n1?2"
        Assert.AreEqual(res, 3 )

    [<Test>]
    member this.NegtiveNumber() =  
         (fun () ->  FirstTaskAtCodePros.add "2,-5,3,-4" |> ignore) |> should (throwWithMessage "negatives not allowed -5, -4")  typeof<System.InvalidOperationException>
      
    [<Test>]
    member this.NegtiveNumberSeconndCase() =  
         (fun () ->  FirstTaskAtCodePros.add "//?\n1?2?-9" |> ignore) |> should (throwWithMessage "negatives not allowed -9")  typeof<System.InvalidOperationException>


    [<Test>]
    member this.RemoveNumbersinThousand() = 
        let res = FirstTaskAtCodePros.add "//?\n1?5?1001"
        Assert.AreEqual(res, 6 )
        
    [<Test>]
    member this.StringDelmetier() = 
        let res = FirstTaskAtCodePros.add "//[>>>]\n1>>>7>>>1001"
        Assert.AreEqual(res, 8 )

    [<Test>]
    member this.CharMultiDelmetier() = 
        let res = FirstTaskAtCodePros.add "//[*][;]\n1;2*100"
        Assert.AreEqual(res, 103)
        
    [<Test>]
    member this.StringMultiDelmetier() = 
        let res = FirstTaskAtCodePros.add "//[>>>][\\]\n123>>>7\10"
        Assert.AreEqual(res, 140 )
    