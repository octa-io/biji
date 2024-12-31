module NumToStrR0

open System.Text

[<Literal>]
let BASE_10 = 10.0

let rec appendImp (value: float) (tail: string list) : string list =
    let valfun v =
        $"{int(v % BASE_10)}"
    match value with
    | value when value < 0 ->
        let x = "-"
        let v = (-value)
        if v < 0 then
            x :: [ "9223373036854775808" ]
        else
            appendImp v (x :: tail)
    | value when value >= 10 -> (valfun value) :: appendImp (value / BASE_10) tail
    | _ -> (valfun value) :: tail

let appendLong (value: float) (out: StringBuilder) =
    let print value =
        Printf.bprintf out "%s" value
    appendImp value [] |> List.rev |> List.iter(fun x -> print x)
    out

let input = -400
let sb = StringBuilder()
let sb' = appendLong input sb
printfn "%s" (sb'.ToString())
