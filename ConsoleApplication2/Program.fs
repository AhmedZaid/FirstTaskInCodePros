module FirstTaskAtCodePros
let add (inputString: string ) : int =
    let zero =0
    let del = ','
    // If the input is empty return zero
    if  inputString.Equals("") then
        zero
    // if the input is a number , return it !
    elif System.Text.RegularExpressions.Regex.IsMatch ( inputString , "^[0-9]") then
        int (inputString)
    // Split the input depending on comma
    else
         let numbers = inputString.Split(del)
         let summtion = int(numbers.[0])+ int(numbers.[1])
         summtion
        
      
        