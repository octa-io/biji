open Browser
open Fable.Core.JsInterop

importAll "./app.css"

let div = document.createElement "div"
div.innerHTML <- ". . ."
document.body.appendChild div |> ignore
