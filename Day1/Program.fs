// Learn more about F# at http://fsharp.org
module Day1Program

open System
open System.IO
open System.Linq
open Common


let frequencyChanges = Common.readLines "input.txt" |> Seq.map Int32.Parse

let applyFrequencyChange frequency change = 
      frequency + change

let calculateFrequencyChanges startingFrequency changes = 
    let mutable result = startingFrequency
    for change in changes do
         let resultChange = applyFrequencyChange result change
         result <- resultChange
    result

[<EntryPoint>]
let main argv =
    let startingFrequency = 0
    let result = calculateFrequencyChanges startingFrequency frequencyChanges
    
    printfn "%i" result
    Console.ReadKey() |> ignore
    0 // return an integer exit code