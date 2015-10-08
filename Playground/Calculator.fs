namespace Neils.FSharp

module Adder =
   
    let add x y = x + y

    let add' x y = 
        let result = 
            add x y
        result

    let add3 x = add x 3

    let add3' x = add3 x    

module Exponentiator =
    let square x = x * x
