open System
open System.Collections.Generic

type Part = {PartNumber: string}

type PartEntry =
    { Part: Part
      Quantity: int }
    

type KitSet =
    { KitId: string
      LineItem: Set<PartEntry> }
      
type StaticKit =
    { KitId: string
      LineItem: Set<PartEntry> }
      
type EditableKit =
    { KitId:string
      Part:ResizeArray<PartEntry> }
      
type Kit = 
    | AsBuilt of StaticKit
    | SpeedKit of EditableKit
    
type PartLine =
    | Part
    | Kit