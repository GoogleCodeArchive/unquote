﻿module Swensen.ClearTest.UnitTests
// Learn more about F# at http://fsharp.net


//    <@ "hello".
//    <@ "hello".Chars(1) @>

open System.Collections.Generic

type SparseMatrix() =
    let mutable table = new Dictionary<(int * int), float>()
    member this.Item
        with get(key1, key2) = table.[(key1, key2)]
        and set (key1, key2) value = table.[(key1, key2)] <- value

let matrix1 = new SparseMatrix()
for i in 1..1000 do
    matrix1.[i, i] <- float i * float i

[<EntryPoint>]
let main args =
    sprintExpr <@  List.mapi (fun i j -> i + j) @> =? "List.mapi (fun i j -> i + j)"  
    0
