module Biji.Frontend

open System
open Browser
open Browser.Types
open Fable.Core
open Biji.Frontend.Core
open Oxpecker.Solid
open System.Collections.Generic

let JSON = JS.JSON

module DragAndDrop =
    type Dispatch<'Msg> = 'Msg -> unit
    type DragItemKind =
        | Unit
        | Template
    type DragItem = {|
        Id: string
        Name: string
        Kind: DragItemKind
    |}
    type DropItem = {|
        Id: string
        Name: string
        Description: string
    |}
    type DropKind =
        | Normal
        | AsBuilt
        | SpeedKit
    type Model = { DropZoneKind: DropKind }
    type Msg =
        | Drop of index: int * ProcessDropArg
        | DelDagItem of index: int
    let draggingItems = Stack<(int * DragItem)>()
    let dragArr = [|
        {|
            Id = createUniqueId()
            Name = "Drag Item"
            Kind = Unit
        |}
        {|
            Id = createUniqueId()
            Name = "Drag Template"
            Kind = Template
        |}
    |]
    let dropArr0 = [||]
    let dropArr1 = [||]
    let store, setStore =
        createStore {|
            dragArray = dragArr
            dropZone0 = dropArr0
            dropZone1 = dropArr1
        |}

    let addDropItem (arg: ProcessDropArg) dropZone =
        dropZone
        |> Array.insertAt 0 {|
            Id = createUniqueId()
            Name = arg.PartNumber
            Description = arg.Description
        |}
    //let handleDrop (arg: ProcessDropArg) dropZone =
    //    dropZone (store)
    //    |> Array.insertAt 0 {|
    //        Id = createUniqueId ()
    //        Name = arg.PartNumber
    //        Description = arg.Description
    //    |}
    //    |> setStore.Path.Map(dropZone).Update
    let rec handleMessage msg =
        match msg with
        | DelDagItem idx -> store.dragArray |> Array.removeAt idx |> setStore.Path.Map(_.dragArray).Update
        | Drop(idx, arg) ->
            if idx = 0 then
                store.dropZone0 |> addDropItem arg |> setStore.Path.Map(_.dropZone0).Update
            else
                store.dropZone1 |> addDropItem arg |> setStore.Path.Map(_.dropZone1).Update
            let idx, it = draggingItems.Pop()
            if it.Kind = Unit then
                dispatch(DelDagItem idx)
    and dispatch msg =
        handleMessage msg
    //let init =
    //    setupDragDrop ()
    //    {DropZoneKind = DropKind.Normal}, Cmd.none
    //let update msg model =
    //    match msg with
    //    | Drop(idx, arg) -> model

    [<SolidComponent>]
    let dropItemList (items: DropItem array) =
        ul() {
            For(each = items) {
                yield
                    fun item index ->
                        li(class' = "drag-item", draggable = "true") {
                            article(class' = "dropped-item")
                                .data("index", index().ToString())
                                .data("assignmentSource", "RankedMatchFO")
                                .data("partnumber", "B-01283")
                                .data("description", "BASE PLATE - PIPE RETAINER")
                                .data("uom", "EA")
                                .data("quantity", "6")
                                .data("partStatus", "Active")
                                .data("replacedBy", "") {
                                header() { h1(class' = "text-center text-neutral-300 text-4xl m-6") { item.Name } }
                                span(class' = "field-label") { "Name: " }
                                span(class' = "field-value") { item.Name }
                                span(class' = "field-label") { "Description: " }
                                span(class' = "field-value") { item.Description }
                            }
                        }
            }
        }

    let startDrag (event: DragEvent) attrib entity assignmentSource description uom quantity partStatus replacedBy =
        let target = event.target :?> HTMLElement
        let index = target.getAttribute attrib
        let entityId = target.getAttribute entity
        let assignmentSourceId = target.getAttribute assignmentSource
        let descriptionText = target.getAttribute description
        let uomText = target.getAttribute uom
        let quantityValue = target.getAttribute quantity
        let partStatusValue = target.getAttribute partStatus
        let replacedByValue = target.getAttribute replacedBy

        let entityId = tryParseInt32 entityId |> Option.defaultValue 0
        let quantityValue = tryParseFloat32 quantityValue |> Option.defaultValue 0.0f

        let ddd =
            DragAndDropData(
                PartNumber = index,
                EntityIdValue = entityId,
                ItemSource = assignmentSourceId,
                Description = descriptionText,
                Uom = uomText,
                Quantity = quantityValue,
                PartStatus = partStatusValue,
                ReplacedBy = replacedByValue
            )

        let data = JSON.stringify ddd
        console.log data
        event.dataTransfer.setData("text/plain", data) |> ignore
        ddd

    let handleDragStart (e: DragEvent) idx =
        startDrag
            e
            "data-index"
            "data-entityId"
            "data-assignmentSource"
            "data-description"
            "data-uom"
            "data-quantity"
            "data-partStatus"
            "data-replacedBy"
        |> ignore
        draggingItems.Push(idx, store.dragArray[idx])

    [<SolidComponent>]
    let dragItemList (items: DragItem array) =
        ul() {
            For(each = items) {
                yield
                    fun item index ->
                        li(
                            class' = "drag-item",
                            draggable = "true",
                            onDragStart = fun e -> index() |> handleDragStart e
                        )
                            .data("assignmentSource", "RankedMatchFO")
                            .data("partnumber", "B-01283")
                            .data("description", "BASE PLATE - PIPE RETAINER")
                            .data("uom", "EA")
                            .data("quantity", "6")
                            .data("partStatus", "Active")
                            .data("replacedBy", "") {
                            span(style = "display:none") { index() }
                            span(class' = "field-label") { "Name: " }
                            span(class' = "field-value") { item.Name }

                            if item.Kind = Unit then
                                Fragment() {
                                    span(class' = "field-space") { "&nbsp" }
                                    button(onClick = fun _ -> (DelDagItem(index())) |> dispatch) { "Remove" }
                                }
                        }
            }
        }
    // let view model dispatch =
    //     let x = {| Id = createUniqueId(); Name = "Drag Source"; Kind = Unit |}
    //     dragItemList [| x |]

    [<SolidComponent>]
    let App () =
        article(class' = "bg-neutral-900 p-5 rounded-lg shadow w-full max-w-md") {
            header() { h1(class' = "text-center text-neutral-300 text-4xl m-6") { "Drop" } }
            div(id = "drop-target-0", class' = "drop-zone") { dropItemList store.dropZone0 }
            div(id = "drop-target-1", class' = "drop-zone") { dropItemList store.dropZone1 }
            div() { div(id = "drag-source", class' = "drag-zone") { dragItemList store.dragArray } }
        }

    [<SolidComponent>]
    let Root () =
        Fragment() { App() }

    let setupDragDropWithDispatch dispatch =
        let n = document.querySelectorAll ".drop-zone"

        [
            for i = 0 to n.length - 1 do
                yield n.item i
        ]
        |> Seq.cast<Element>
        |> Seq.iteri(fun idx dropZone ->
            dropZone.addEventListener(
                "dragover",
                fun e ->
                    let event = e :?> DragEvent
                    event.preventDefault() // Necessary to allow dropping
                    event.dataTransfer.dropEffect <- "move"
                    dropZone.classList.add "drag-over"
                    let dragData = event.dataTransfer.getData "text/plain"

                    if String.IsNullOrEmpty dragData then
                        console.log "No PartNumber Found (dragover)"
                    else
                        let x = JSON.parse dragData :?> DragAndDropData
                        console.log "PartNumber"
                        console.log x.PartNumber
            )

            dropZone.addEventListener("dragleave", fun _ -> dropZone.classList.remove "drag-over")

            dropZone.addEventListener(
                "drop",
                fun e ->
                    let event = e :?> DragEvent
                    event.preventDefault()
                    dropZone.classList.remove "drag-over"
                    let dragData = event.dataTransfer.getData "text/plain"
                    let x = JSON.parse dragData :?> DragAndDropData
                    console.log "PartNumber"
                    console.log x.PartNumber
                    let groupIndex = dropZone.getAttribute "data-groupIndex"
                    let lineIndex = dropZone.getAttribute "data-lineIndex"

                    let arg =
                        ProcessDropArg(
                            PartNumber = x.PartNumber,
                            GroupIndexValue = groupIndex,
                            LineIndexValue = lineIndex,
                            EntityIdValue = x.EntityIdValue.ToString(),
                            ItemSource = x.ItemSource,
                            Description = x.Description,
                            Uom = x.Uom,
                            Quantity = x.Quantity.ToString(),
                            PartStatus = x.PartNumber,
                            ReplacedBy = x.ReplacedBy
                        )

                    Drop(idx, arg) |> dispatch
            ))

    let setupDragDropWith (dotNetHelper: Microsoft.JSInterop.DotNet.DotNetObject) =
        let n = document.querySelectorAll ".drop-zone"

        [
            for i = 0 to n.length do
                yield n.item i
        ]
        |> Seq.cast<HTMLElement>
        |> Seq.iter(fun dropZone ->
            dropZone.addEventListener(
                "dragover",
                fun e ->
                    let event = e :?> DragEvent
                    event.preventDefault() // Necessary to allow dropping
                    event.dataTransfer.dropEffect <- "move"
                    dropZone.classList.add "drag-over"
                    let dragData = event.dataTransfer.getData "text/plain"
                    let x = JSON.parse dragData :?> DragAndDropData
                    console.log "PartNumber"
                    console.log x.PartNumber
            )

            dropZone.addEventListener("dragleave", fun _ -> dropZone.classList.remove "drag-over")

            dropZone.addEventListener(
                "drop",
                fun e ->
                    let event = e :?> DragEvent
                    event.preventDefault()
                    dropZone.classList.remove "drag-over"

                    let dragData = event.dataTransfer.getData "text/plain"
                    let x = JSON.parse dragData :?> DragAndDropData
                    console.log "PartNumber"
                    console.log x.PartNumber
                    let groupIndex = dropZone.getAttribute "data-groupIndex"
                    let lineIndex = dropZone.getAttribute "data-lineIndex"

                    let arg =
                        ProcessDropArg(
                            PartNumber = x.PartNumber,
                            GroupIndexValue = groupIndex,
                            LineIndexValue = lineIndex,
                            EntityIdValue = x.EntityIdValue.ToString(),
                            ItemSource = x.ItemSource,
                            Description = x.Description,
                            Uom = x.Uom,
                            Quantity = x.Quantity.ToString(),
                            PartStatus = x.PartNumber,
                            ReplacedBy = x.ReplacedBy
                        )

                    let args = ResizeArray<obj option>()
                    args.Add(Some arg)
                    dotNetHelper.invokeMethodAsync("ProcessDrop", args) |> ignore
            ))

    let run () =
        render(Root, document.getElementById "root")
        setupDragDropWithDispatch dispatch

// Program.mkProgram init update view
// |> Program.run
