module Program

open Implementation
open Xunit

let [<Fact>] Day1Part1() = Assert.Equal (7, Day1.Part1 @"199
200
208
210
200
207
240
269
260
263")



let [<EntryPoint>] main _ = 0