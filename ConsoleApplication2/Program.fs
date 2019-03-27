module FirstTaskAtCodePros
let add (inputString: string ) : int =
    let zero =0
    // add \n as delmeter 
    let del = [|',';'\n'|]
    // If the input is empty return zero
    if  inputString.Equals("") then
        zero
    // Split the input depending on comma
    else
         let numbers = inputString.Split(del)
         let summtion  = Array.sumBy int  numbers
         summtion
        
      
        