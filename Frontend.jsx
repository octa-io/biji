import { Record, Union } from "./fable_modules/fable-library-js.4.24.0/Types.js";
import { int32_type, record_type, union_type } from "./fable_modules/fable-library-js.4.24.0/Reflection.js";
import { ProcessDropArg_$ctor, DragAndDropData_$ctor, tryParseFloat32, tryParseInt32, ProcessDropArg_$reflection } from "./Frontend.Core.jsx";
import { Stack$1__Push_2B595, Stack$1__Pop, Stack$1_$ctor } from "./fable_modules/fable-library-js.4.24.0/System.Collections.Generic.js";
import { createUniqueId } from "solid-js";
import { createStore } from "solid-js/store";
import { item as item_1, removeAt, append, map as map_3, insertAt } from "./fable_modules/fable-library-js.4.24.0/Array.js";
import { Oxpecker_Solid_BindingsModule_SolidStoreSetter$1__SolidStoreSetter$1_get_Path, BindingsModule_SolidStorePath$2__Update_2B594 } from "./fable_modules/Oxpecker.Solid.0.4.0/SolidBindings.fs.js";
import { BindingsModule_SolidStorePath$2__get_Path, BindingsModule_SolidStorePath$2__get_Setter, BindingsModule_SolidStorePath$2_$ctor_Z6B4E7989 } from "./fable_modules/Oxpecker.Solid.0.4.0/./SolidBindings.fs.js";
import { int32ToString, equals } from "./fable_modules/fable-library-js.4.24.0/Util.js";
import { some, defaultArg } from "./fable_modules/fable-library-js.4.24.0/Option.js";
import { iterate, map as map_4, delay as delay_13, toList, iterateIndexed } from "./fable_modules/fable-library-js.4.24.0/Seq.js";
import { isNullOrEmpty } from "./fable_modules/fable-library-js.4.24.0/String.js";
import { rangeDouble } from "./fable_modules/fable-library-js.4.24.0/Range.js";
import { render } from "solid-js/web";

export const JSON$ = JSON;

export class DragAndDrop_DragItemKind extends Union {
    constructor(tag, fields) {
        super();
        this.tag = tag;
        this.fields = fields;
    }
    cases() {
        return ["Unit", "Template"];
    }
}

export function DragAndDrop_DragItemKind_$reflection() {
    return union_type("Biji.Frontend.DragAndDrop.DragItemKind", [], DragAndDrop_DragItemKind, () => [[], []]);
}

export class DragAndDrop_DropKind extends Union {
    constructor(tag, fields) {
        super();
        this.tag = tag;
        this.fields = fields;
    }
    cases() {
        return ["Normal", "AsBuilt", "SpeedKit"];
    }
}

export function DragAndDrop_DropKind_$reflection() {
    return union_type("Biji.Frontend.DragAndDrop.DropKind", [], DragAndDrop_DropKind, () => [[], [], []]);
}

export class DragAndDrop_Model extends Record {
    constructor(DropZoneKind) {
        super();
        this.DropZoneKind = DropZoneKind;
    }
}

export function DragAndDrop_Model_$reflection() {
    return record_type("Biji.Frontend.DragAndDrop.Model", [], DragAndDrop_Model, () => [["DropZoneKind", DragAndDrop_DropKind_$reflection()]]);
}

export class DragAndDrop_Msg extends Union {
    constructor(tag, fields) {
        super();
        this.tag = tag;
        this.fields = fields;
    }
    cases() {
        return ["Drop", "DelDagItem"];
    }
}

export function DragAndDrop_Msg_$reflection() {
    return union_type("Biji.Frontend.DragAndDrop.Msg", [], DragAndDrop_Msg, () => [[["index", int32_type], ["Item2", ProcessDropArg_$reflection()]], [["index", int32_type]]]);
}

export const DragAndDrop_draggingItems = Stack$1_$ctor();

export const DragAndDrop_dragArr = [{
    Id: createUniqueId(),
    Kind: new DragAndDrop_DragItemKind(0, []),
    Name: "Drag Item",
}, {
    Id: createUniqueId(),
    Kind: new DragAndDrop_DragItemKind(1, []),
    Name: "Drag Template",
}];

export function DragAndDrop_dropArr0() {
    return [];
}

export function DragAndDrop_dropArr1() {
    return [];
}

export const DragAndDrop_patternInput$004051$002D106 = createStore({
    dragArray: DragAndDrop_dragArr,
    dropZone0: DragAndDrop_dropArr0(),
    dropZone1: DragAndDrop_dropArr1(),
});

export const DragAndDrop_store = DragAndDrop_patternInput$004051$002D106[0];

export const DragAndDrop_setStore = DragAndDrop_patternInput$004051$002D106[1];

export function DragAndDrop_addDropItem(arg, dropZone) {
    let Id, Name;
    return insertAt(0, (Id = createUniqueId(), (Name = (arg.partNumber), {
        Description: arg.description,
        Id: Id,
        Name: Name,
    })), dropZone);
}

export function DragAndDrop_handleMessage(msg) {
    let this$_1, array_2_1, this$_2, array_2_2, this$, array_2;
    if (msg.tag === 0) {
        const idx_1 = msg.fields[0] | 0;
        const arg = msg.fields[1];
        if (idx_1 === 0) {
            const updater_1 = DragAndDrop_addDropItem(arg, DragAndDrop_store.dropZone0);
            BindingsModule_SolidStorePath$2__Update_2B594((this$_1 = Oxpecker_Solid_BindingsModule_SolidStoreSetter$1__SolidStoreSetter$1_get_Path(DragAndDrop_setStore), BindingsModule_SolidStorePath$2_$ctor_Z6B4E7989(BindingsModule_SolidStorePath$2__get_Setter(this$_1), (array_2_1 = map_3((value_1) => value_1, ["dropZone0"]), append(BindingsModule_SolidStorePath$2__get_Path(this$_1), array_2_1)))), updater_1);
        }
        else {
            const updater_2 = DragAndDrop_addDropItem(arg, DragAndDrop_store.dropZone1);
            BindingsModule_SolidStorePath$2__Update_2B594((this$_2 = Oxpecker_Solid_BindingsModule_SolidStoreSetter$1__SolidStoreSetter$1_get_Path(DragAndDrop_setStore), BindingsModule_SolidStorePath$2_$ctor_Z6B4E7989(BindingsModule_SolidStorePath$2__get_Setter(this$_2), (array_2_2 = map_3((value_2) => value_2, ["dropZone1"]), append(BindingsModule_SolidStorePath$2__get_Path(this$_2), array_2_2)))), updater_2);
        }
        const patternInput = Stack$1__Pop(DragAndDrop_draggingItems);
        const it = patternInput[1];
        const idx_2 = patternInput[0] | 0;
        if (equals(it.Kind, new DragAndDrop_DragItemKind(0, []))) {
            DragAndDrop_dispatch(new DragAndDrop_Msg(1, [idx_2]));
        }
    }
    else {
        const idx = msg.fields[0] | 0;
        const updater = removeAt(idx, DragAndDrop_store.dragArray);
        BindingsModule_SolidStorePath$2__Update_2B594((this$ = Oxpecker_Solid_BindingsModule_SolidStoreSetter$1__SolidStoreSetter$1_get_Path(DragAndDrop_setStore), BindingsModule_SolidStorePath$2_$ctor_Z6B4E7989(BindingsModule_SolidStorePath$2__get_Setter(this$), (array_2 = map_3((value) => value, ["dragArray"]), append(BindingsModule_SolidStorePath$2__get_Path(this$), array_2)))), updater);
    }
}

export function DragAndDrop_dispatch(msg) {
    DragAndDrop_handleMessage(msg);
}

export function DragAndDrop_dropItemList(items) {
    return <ul>
        <For each={items}>
            {(item, index) => {
                let copyOfStruct;
                return <li class="drag-item"
                    draggable="true">
                    <article class="dropped-item"
                        data-index={(copyOfStruct = index(), int32ToString(copyOfStruct))}
                        data-assignmentSource="RankedMatchFO"
                        data-partnumber="B-01283"
                        data-description="BASE PLATE - PIPE RETAINER"
                        data-uom="EA"
                        data-quantity="6"
                        data-partStatus="Active"
                        data-replacedBy="">
                        <header>
                            <h1 class="text-center text-neutral-300 text-4xl m-6">
                                {item.Name}
                            </h1>
                        </header>
                        <span class="field-label">
                            Name: 
                        </span>
                        <span class="field-value">
                            {item.Name}
                        </span>
                        <span class="field-label">
                            Description: 
                        </span>
                        <span class="field-value">
                            {item.Description}
                        </span>
                    </article>
                </li>;
            }}
        </For>
    </ul>;
}

export function DragAndDrop_startDrag(event, attrib, entity, assignmentSource, description, uom, quantity, partStatus, replacedBy) {
    const target = event.target;
    const index = target.getAttribute(attrib);
    const entityId = target.getAttribute(entity);
    const assignmentSourceId = target.getAttribute(assignmentSource);
    const descriptionText = target.getAttribute(description);
    const uomText = target.getAttribute(uom);
    const quantityValue = target.getAttribute(quantity);
    const partStatusValue = target.getAttribute(partStatus);
    const replacedByValue = target.getAttribute(replacedBy);
    const entityId_1 = defaultArg(tryParseInt32(entityId), 0) | 0;
    const quantityValue_1 = defaultArg(tryParseFloat32(quantityValue), 0);
    let ddd;
    let returnVal = DragAndDropData_$ctor();
    returnVal.partNumber=index;
    returnVal.entityIdValue=entityId_1;
    returnVal.itemSource=assignmentSourceId;
    returnVal.description=descriptionText;
    returnVal.uom=uomText;
    returnVal.quantity=quantityValue_1;
    returnVal.partStatus=partStatusValue;
    returnVal.replacedBy=replacedByValue;
    ddd = returnVal;
    const data = JSON$.stringify(ddd);
    console.log(some(data));
    event.dataTransfer.setData("text/plain", data);
    return ddd;
}

export function DragAndDrop_handleDragStart(e, idx) {
    DragAndDrop_startDrag(e, "data-index", "data-entityId", "data-assignmentSource", "data-description", "data-uom", "data-quantity", "data-partStatus", "data-replacedBy");
    Stack$1__Push_2B595(DragAndDrop_draggingItems, [idx, item_1(idx, DragAndDrop_store.dragArray)]);
}

export function DragAndDrop_dragItemList(items) {
    return <ul>
        <For each={items}>
            {(item, index) => <li class="drag-item"
                draggable="true"
                onDragStart={(e) => {
                    DragAndDrop_handleDragStart(e, index());
                }}
                data-assignmentSource="RankedMatchFO"
                data-partnumber="B-01283"
                data-description="BASE PLATE - PIPE RETAINER"
                data-uom="EA"
                data-quantity="6"
                data-partStatus="Active"
                data-replacedBy="">
                <span style="display:none">
                    {index()}
                </span>
                <span class="field-label">
                    Name: 
                </span>
                <span class="field-value">
                    {item.Name}
                </span>
                {equals(item.Kind, new DragAndDrop_DragItemKind(0, [])) ? <>
                    <span class="field-space">
                        &nbsp
                    </span>
                    <button onClick={(_arg) => {
                            DragAndDrop_dispatch(new DragAndDrop_Msg(1, [index()]));
                        }}>
                        Remove
                    </button>
                </> : ((value) => {
                })}
            </li>}
        </For>
    </ul>;
}

export function DragAndDrop_App() {
    return <article class="bg-neutral-900 p-5 rounded-lg shadow w-full max-w-md">
        <header>
            <h1 class="text-center text-neutral-300 text-4xl m-6">
                Drop
            </h1>
        </header>
        <div id="drop-target-0"
            class="drop-zone">
            {DragAndDrop_dropItemList(DragAndDrop_store.dropZone0)}
        </div>
        <div id="drop-target-1"
            class="drop-zone">
            {DragAndDrop_dropItemList(DragAndDrop_store.dropZone1)}
        </div>
        <div>
            <div id="drag-source"
                class="drag-zone">
                {DragAndDrop_dragItemList(DragAndDrop_store.dragArray)}
            </div>
        </div>
    </article>;
}

export function DragAndDrop_Root() {
    return <>
        {DragAndDrop_App()}
    </>;
}

export function DragAndDrop_setupDragDropWithDispatch(dispatch) {
    const n = document.querySelectorAll(".drop-zone");
    iterateIndexed((idx, dropZone) => {
        dropZone.addEventListener("dragover", (e) => {
            const event = e;
            event.preventDefault();
            event.dataTransfer.dropEffect = "move";
            dropZone.classList.add("drag-over");
            const dragData = event.dataTransfer.getData("text/plain");
            if (isNullOrEmpty(dragData)) {
                console.log(some("No PartNumber Found (dragover)"));
            }
            else {
                const x = JSON$.parse(dragData);
                console.log(some("PartNumber"));
                console.log(some(x.partNumber));
            }
        });
        dropZone.addEventListener("dragleave", (e_1) => {
            console.trace(some(e_1));
            dropZone.classList.remove("drag-over");
        });
        dropZone.addEventListener("drop", (e_2) => {
            let copyOfStruct, copyOfStruct_1;
            const event_1 = e_2;
            event_1.preventDefault();
            dropZone.classList.remove("drag-over");
            const dragData_1 = event_1.dataTransfer.getData("text/plain");
            const x_1 = JSON$.parse(dragData_1);
            console.log(some("PartNumber"));
            console.log(some(x_1.partNumber));
            const groupIndex = dropZone.getAttribute("data-groupIndex");
            const lineIndex = dropZone.getAttribute("data-lineIndex");
            let arg;
            let returnVal = ProcessDropArg_$ctor();
            returnVal.partNumber=(x_1.partNumber);
            returnVal.groupIndexValue=groupIndex;
            returnVal.lineIndexValue=lineIndex;
            returnVal.entityIdValue=((copyOfStruct = (x_1.entityIdValue), int32ToString(copyOfStruct)));
            returnVal.itemSource=(x_1.itemSource);
            returnVal.description=(x_1.description);
            returnVal.uom=(x_1.uom);
            returnVal.quantity=((copyOfStruct_1 = (x_1.quantity), copyOfStruct_1.toString()));
            returnVal.partStatus=(x_1.partNumber);
            returnVal.replacedBy=(x_1.replacedBy);
            arg = returnVal;
            dispatch(new DragAndDrop_Msg(0, [idx, arg]));
        });
    }, toList(delay_13(() => map_4((i) => n.item(i), rangeDouble(0, 1, n.length - 1)))));
}

export function DragAndDrop_setupDragDropWith(dotNetHelper) {
    const n = document.querySelectorAll(".drop-zone");
    iterate((dropZone) => {
        dropZone.addEventListener("dragover", (e) => {
            const event = e;
            event.preventDefault();
            event.dataTransfer.dropEffect = "move";
            dropZone.classList.add("drag-over");
            const dragData = event.dataTransfer.getData("text/plain");
            const x = JSON$.parse(dragData);
            console.log(some("PartNumber"));
            console.log(some(x.partNumber));
        });
        dropZone.addEventListener("dragleave", (_arg) => {
            dropZone.classList.remove("drag-over");
        });
        dropZone.addEventListener("drop", (e_1) => {
            let copyOfStruct, copyOfStruct_1;
            const event_1 = e_1;
            event_1.preventDefault();
            dropZone.classList.remove("drag-over");
            const dragData_1 = event_1.dataTransfer.getData("text/plain");
            const x_1 = JSON$.parse(dragData_1);
            console.log(some("PartNumber"));
            console.log(some(x_1.partNumber));
            const groupIndex = dropZone.getAttribute("data-groupIndex");
            const lineIndex = dropZone.getAttribute("data-lineIndex");
            let arg;
            let returnVal = ProcessDropArg_$ctor();
            returnVal.partNumber=(x_1.partNumber);
            returnVal.groupIndexValue=groupIndex;
            returnVal.lineIndexValue=lineIndex;
            returnVal.entityIdValue=((copyOfStruct = (x_1.entityIdValue), int32ToString(copyOfStruct)));
            returnVal.itemSource=(x_1.itemSource);
            returnVal.description=(x_1.description);
            returnVal.uom=(x_1.uom);
            returnVal.quantity=((copyOfStruct_1 = (x_1.quantity), copyOfStruct_1.toString()));
            returnVal.partStatus=(x_1.partNumber);
            returnVal.replacedBy=(x_1.replacedBy);
            arg = returnVal;
            const args = [];
            void (args.push(some(arg)));
            dotNetHelper.invokeMethodAsync("ProcessDrop", ...args);
        });
    }, toList(delay_13(() => map_4((i) => n.item(i), rangeDouble(0, 1, n.length)))));
}

export function DragAndDrop_run() {
    render(DragAndDrop_Root, document.getElementById("root"));
    DragAndDrop_setupDragDropWithDispatch((msg) => {
        DragAndDrop_dispatch(msg);
    });
}

