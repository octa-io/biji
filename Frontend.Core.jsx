import { class_type } from "./fable_modules/fable-library-js.4.24.0/Reflection.js";
import { tryParse } from "./fable_modules/fable-library-js.4.24.0/Int32.js";
import { FSharpRef } from "./fable_modules/fable-library-js.4.24.0/Types.js";
import { tryParse as tryParse_1 } from "./fable_modules/fable-library-js.4.24.0/Double.js";

export class DragAndDropData {
    constructor(partNumber, entityIdValue, itemSource, description, uom, quantity, partStatus, replacedBy) {
        this.partNumber = partNumber;
        this.entityIdValue = (entityIdValue | 0);
        this.itemSource = itemSource;
        this.description = description;
        this.uom = uom;
        this.quantity = quantity;
        this.partStatus = partStatus;
        this.replacedBy = replacedBy;
    }
}

export function DragAndDropData_$reflection() {
    return class_type("Biji.Frontend.Core.DragAndDropData", undefined, DragAndDropData);
}

export function DragAndDropData_$ctor() {
    return new DragAndDropData("", 0, "", "", "", 0, "", "");
}

export class ProcessDropArg {
    constructor(partNumber, groupIndexValue, lineIndexValue, entityIdValue, itemSource, description, uom, quantity, partStatus, replacedBy) {
        this.partNumber = partNumber;
        this.groupIndexValue = groupIndexValue;
        this.lineIndexValue = lineIndexValue;
        this.entityIdValue = entityIdValue;
        this.itemSource = itemSource;
        this.description = description;
        this.uom = uom;
        this.quantity = quantity;
        this.partStatus = partStatus;
        this.replacedBy = replacedBy;
    }
}

export function ProcessDropArg_$reflection() {
    return class_type("Biji.Frontend.Core.ProcessDropArg", undefined, ProcessDropArg);
}

export function ProcessDropArg_$ctor() {
    return new ProcessDropArg("", "", "", "", "", "", "", "", "", "");
}

export function tryParseInt32(input) {
    let matchValue;
    let outArg = 0;
    matchValue = [tryParse(input, 511, false, 32, new FSharpRef(() => outArg, (v) => {
        outArg = (v | 0);
    })), outArg];
    if (matchValue[0]) {
        const value = matchValue[1] | 0;
        return value;
    }
    else {
        return undefined;
    }
}

export function tryParseFloat32(input) {
    let matchValue;
    let outArg = 0;
    matchValue = [tryParse_1(input, new FSharpRef(() => outArg, (v) => {
        outArg = v;
    })), outArg];
    if (matchValue[0]) {
        const value = matchValue[1];
        return value;
    }
    else {
        return undefined;
    }
}

