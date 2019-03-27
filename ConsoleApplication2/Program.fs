module FirstTaskAtCodePros

//Function that Remove any number >=1000  depending on number of digits
let  RemoveLargeNumber (numbers: string [] ) : string [] =
    let fourdigitnumbers =  numbers |> Array.filter (fun x -> x.Length > 3)
    // Change arrays to sets then subtract them and return the final array
    let orignalSet = set numbers
    let fourdigitset = set fourdigitnumbers
    let finalset = orignalSet - fourdigitset
    let finalnmbers = finalset |> Array.ofSeq
    finalnmbers
//Function that raise excpetion if there is negtive number    
let  negtiveNumber (numbers: string [] ) : int =
    let returncode=0
    // Filter the array and find all string contain negtie sign
    let negtivenumber = numbers |> Array.filter (fun x -> x.Contains("-"))
    if negtivenumber.Length = 0 then
        returncode
    else
         let allNegtiveString = negtivenumber |> String.concat ", "
         let errorMeesage= "negatives not allowed " + allNegtiveString
         raise (System.InvalidOperationException(errorMeesage))
         
let add (inputString: string ) : int =
    let zero =0
    // add \n as delmeter 
    let mutable del = [|',';'\n'|]
    // If the input is empty return zero
    if  inputString.Equals("") then
        zero
    // Split the input depending on comma
    else
        let mutable datastring = inputString
        // if the input start with // then  find the new delimeter
        if inputString.[0].Equals('/')  then
            // Split depend on \n and take the first item
            let splitOnNewLine = inputString.Split([|'\n'|])
            let firstline  = splitOnNewLine.[0]
            // Remove // and add the new delimeter to delimeter array
            let newdel = firstline.Replace("//","")
            del <- [|newdel.[0]|]
            datastring <- splitOnNewLine.[1]
        // Call  a  function that should throw expection if there is a negtive number and surounded it by {try  with} module -Like Try and Catch in Java-
        try
            // Split depend on the array of delmeters then find the sum of there element
            let numbers = datastring.Split(del)
            // this will throw expection if it  find negtive number otherwise it will continue
            let flag = negtiveNumber numbers
            let filteredNumber = RemoveLargeNumber numbers
            let summtion  = Array.sumBy int  filteredNumber
            summtion
        with
        | Failure(msg) -> printfn "%s" msg; 0;
        
      
        