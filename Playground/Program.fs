module Neils.FSharp.Program

open Neils.FSharp
open Neils.FSharp.Exponentiator

[<EntryPoint>]
let main args =
    
    let input = 5
    let squared = square input
    printfn "square of %d is %d" input squared

    let plus3 = Adder.add3' squared
    printfn "%d + 3 is %d" squared plus3

    printfn "<enter> to quit"
    System.Console.ReadLine() |> ignore

    0

