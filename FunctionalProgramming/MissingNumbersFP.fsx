// https://www.hackerrank.com/challenges/missing-numbers-fp

open System

Console.In.ReadLine() |> ignore
let a = Console.In.ReadLine().Split(' ') |> Array.map int
Console.In.ReadLine() |> ignore
let b = Console.In.ReadLine().Split(' ') |> Array.map int 


let bMax = Array.max b
let bMin = Array.min b

let counts : int array = Array.zeroCreate (bMax - bMin + 1)

for n in b do
    counts.[n - bMin] <- counts.[n - bMin] + 1

for n in a do
    counts.[n - bMin] <- counts.[n - bMin] - 1

for i in 0..counts.Length-1 do
    if counts.[i] > 0 then printf "%d " (i + bMin)

printfn ""