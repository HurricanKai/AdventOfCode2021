namespace Implementation

open System

type Day1 =
    
    static member Part1 (input : string) =
        let notNullOrWhiteSpace p = not (String.IsNullOrWhiteSpace p) 
        input.Split '\n'
        |> Seq.ofArray
        |> Seq.filter notNullOrWhiteSpace
        |> Seq.pairwise
        |> Seq.filter (fun (a, b) -> a < b)
        |> Seq.length