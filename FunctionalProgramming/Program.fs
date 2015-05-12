// https://www.hackerrank.com/challenges/missing-numbers-fp

open System

let t = Console.In.ReadLine() |> int

let rec gcd (x : int) (y : int) =
    let max = Math.Max(x, y)
    let min = Math.Min(x, y)

    if (max % min = 0) then min
    else gcd min (max % min)

for i in 1..t do
    let pair = Console.In.ReadLine().Split(' ')
    let m = pair.[0] |> int
    let l = pair.[1] |> int

    let g = gcd m l

    let top = g |> float |> Math.Sqrt |> Math.Floor |> int

    let mutable counter = 0
    for i in 1..top do
        if g % i = 0 then counter <- counter + 1

    counter <- counter * 2
    if top * top = g then counter <- counter - 1

    printfn "%d" counter