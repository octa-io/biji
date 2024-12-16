module Biji.Frontend.Core

open System
open Fable.Core

[<AllowNullLiteral>]
type DragAndDropData =
    val mutable private partNumber: string
    val mutable private entityIdValue: int
    val mutable private itemSource: string
    val mutable private description: string
    val mutable private uom: string
    val mutable private quantity: float32
    val mutable private partStatus: string
    val mutable private replacedBy: string

    new() = {
        partNumber = String.Empty
        entityIdValue = 0
        itemSource = String.Empty
        description = String.Empty
        uom = String.Empty
        quantity = 0f
        partStatus = String.Empty
        replacedBy = String.Empty
    }

    [<EmitProperty("partNumber")>]
    member self.PartNumber
        with get () = self.partNumber
        and set (value) = self.partNumber <- value

    [<EmitProperty("entityIdValue")>]
    member self.EntityIdValue
        with get () = self.entityIdValue
        and set (value) = self.entityIdValue <- value

    [<EmitProperty("itemSource")>]
    member self.ItemSource
        with get () = self.itemSource
        and set (value) = self.itemSource <- value

    [<EmitProperty("description")>]
    member self.Description
        with get () = self.description
        and set (value) = self.description <- value

    [<EmitProperty("uom")>]
    member self.Uom
        with get () = self.uom
        and set (value) = self.uom <- value

    [<EmitProperty("quantity")>]
    member self.Quantity
        with get () = self.quantity
        and set (value) = self.quantity <- value

    [<EmitProperty("partStatus")>]
    member self.PartStatus
        with get () = self.partStatus
        and set (value) = self.partStatus <- value

    [<EmitProperty("replacedBy")>]
    member self.ReplacedBy
        with get () = self.replacedBy
        and set (value) = self.replacedBy <- value

[<AllowNullLiteral>]
type ProcessDropArg =
    val mutable private partNumber: string
    val mutable private groupIndexValue: string
    val mutable private lineIndexValue: string
    val mutable private entityIdValue: string
    val mutable private itemSource: string
    val mutable private description: string
    val mutable private uom: string
    val mutable private quantity: string
    val mutable private partStatus: string
    val mutable private replacedBy: string

    new() =
        {
            partNumber = String.Empty
            groupIndexValue = String.Empty
            lineIndexValue = String.Empty
            entityIdValue = String.Empty
            itemSource = String.Empty
            description = String.Empty
            uom = String.Empty
            quantity = String.Empty
            partStatus = String.Empty
            replacedBy = String.Empty
        }

    [<EmitProperty("partNumber")>]
    member self.PartNumber
        with get () = self.partNumber
        and set (value) = self.partNumber <- value

    [<EmitProperty("groupIndexValue")>]
    member self.GroupIndexValue
        with get () = self.groupIndexValue
        and set (value) = self.groupIndexValue <- value

    [<EmitProperty("lineIndexValue")>]
    member self.LineIndexValue
        with get () = self.lineIndexValue
        and set (value) = self.lineIndexValue <- value

    [<EmitProperty("entityIdValue")>]
    member self.EntityIdValue
        with get () = self.entityIdValue
        and set (value) = self.entityIdValue <- value

    [<EmitProperty("itemSource")>]
    member self.ItemSource
        with get () = self.itemSource
        and set (value) = self.itemSource <- value

    [<EmitProperty("description")>]
    member self.Description
        with get () = self.description
        and set (value) = self.description <- value

    [<EmitProperty("uom")>]
    member self.Uom
        with get () = self.uom
        and set (value) = self.uom <- value

    [<EmitProperty("quantity")>]
    member self.Quantity
        with get () = self.quantity
        and set (value) = self.quantity <- value

    [<EmitProperty("partStatus")>]
    member self.PartStatus
        with get () = self.partStatus
        and set (value) = self.partStatus <- value

    [<EmitProperty("replacedBy")>]
    member self.ReplacedBy
        with get () = self.replacedBy
        and set (value) = self.replacedBy <- value

let tryParseInt32 (input: string) : int option =
    match Int32.TryParse(input) with
    | true, value -> Some value
    | false, _ -> None

let tryParseFloat32 (input: string) : float32 option =
    match Single.TryParse(input) with
    | true, value -> Some value
    | false, _ -> None
