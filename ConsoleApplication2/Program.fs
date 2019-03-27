module FirstTaskAtCodePros
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
        // Split depend on the array of delmeters then find the sum of there element    
        let numbers = datastring.Split(del)
        let summtion  = Array.sumBy int  numbers
        summtion
        
      
        