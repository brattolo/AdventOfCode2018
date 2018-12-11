// Learn more about F# at http://fsharp.org
module Day2Program

open System
open System.Collections.Generic
            
let boxIds = Common.readLines "input.txt" |> Seq.map(fun x -> x.ToString())
let mutable finalScore = 0

let perRowOfUniqueCountOfDuplicateLetters = new List<seq<int>>()
let createCollectionOfUniqueCountOfDuplicateLetters collection =
    collection 
        |> Seq.countBy(fun x -> x) 
        |> Seq.map(fun (_, count) -> count)
        |> Seq.filter(fun count -> count > 1) 
        |> Seq.distinct

let countAllUniqueCountsAndCombineResult collection = 
        perRowOfUniqueCountOfDuplicateLetters
            |> Seq.map(fun (counts) -> counts)
            |> Seq.concat
            |> Seq.countBy(fun x -> x)
            |> Seq.map(fun (_, count) -> count)
            |> Seq.fold (*) 1

[<EntryPoint>]
let main argv =
    for boxId in boxIds do 
        let uniqueCountOfDuplicateLetters = createCollectionOfUniqueCountOfDuplicateLetters boxId
        perRowOfUniqueCountOfDuplicateLetters.Add(uniqueCountOfDuplicateLetters)

    let score = countAllUniqueCountsAndCombineResult perRowOfUniqueCountOfDuplicateLetters

    printfn "%i" score

    Console.ReadKey() |> ignore
    0 // return an integer exit code
