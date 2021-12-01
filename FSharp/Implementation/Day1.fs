namespace Implementation

open System

type Day1 =
    
    static member Part1 (input : string) =
        let notNullOrWhiteSpace p = not (String.IsNullOrWhiteSpace p) 
        input.Split '\n'
        |> Seq.ofArray
        |> Seq.filter notNullOrWhiteSpace
        |> Seq.map Int32.Parse
        |> Seq.pairwise
        |> Seq.filter (fun (a, b) -> a < b)
        |> Seq.length
    
    static member Part2 (input : string) =
        let notNullOrWhiteSpace p = not (String.IsNullOrWhiteSpace p) 
        input.Split '\n'
        |> Seq.ofArray
        |> Seq.filter notNullOrWhiteSpace
        |> Seq.map Int32.Parse
        |> Seq.map float
        |> Seq.windowed 3
        |> Seq.map Array.average
        |> Seq.pairwise
        |> Seq.filter (fun (a, b) -> a < b)
        |> Seq.length