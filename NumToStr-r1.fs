module NumToStrR1

open System.Text

[<Literal>]
let BASE_10 = 10.0

let rec appendImp (value: float) (acc: ResizeArray<string>) =
    let valfun v =
        $"{int(v % BASE_10)}"
    match value with
    | value when value < 0 ->
        acc.Add("-")
        let v = (-value)
        if v < 0 then
            acc.Add("9223373036854775808")
        else
            appendImp v acc
    | value when value >= 10 ->
        acc.Add(valfun value)
        appendImp (value / BASE_10) acc
    | _ -> acc.Add(valfun value)

let appendLong (value: float) (out: StringBuilder) =
    let print value =
        Printf.bprintf out "%s" value
    let acc = ResizeArray<string>()
    appendImp value acc
    if acc[0] = "-" then
        acc.Add("-")
        acc.RemoveAt(0)
    acc |> Seq.rev |> Seq.iter(fun x -> print x)
    out

let input = -400
let sb = StringBuilder()
let sb' = appendLong input sb
printfn "%s" (sb'.ToString())
