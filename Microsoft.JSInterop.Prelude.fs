namespace Microsoft.JSInterop

module Prelude =
    open Fable.Core
    open Fable.Core.JsInterop

    type Blob = class end

    type ReadableStream = class end

    //// Define generic ReadableStream type
    //type [<AllowNullLiteral>] ReadableStream<'R> =
    //    abstract ReadableStream: unit -> ReadableStream<'R>

    //// Define constructors for ReadableStream with multiple overloads
    //[<Import("ReadableStream", "globalThis")>]
    //type ReadableStreamConstructor =
    //    abstract Create: underlyingSource: UnderlyingByteSource * ?strategy: {| highWaterMark: float option |} -> ReadableStream<Uint8Array>
    //    abstract Create: underlyingSource: UnderlyingDefaultSource<'R> * ?strategy: QueuingStrategy<'R> -> ReadableStream<'R>
    //    abstract Create: ?underlyingSource: UnderlyingSource<'R> * ?strategy: QueuingStrategy<'R> -> ReadableStream<'R>

    //// Reference the global ReadableStream
    //[<Import("ReadableStream", "globalThis")>]
    //let ReadableStream: ReadableStreamConstructor = jsNative

    //// Helper Types
    //type UnderlyingByteSource =
    //    abstract start: controller: ReadableStreamDefaultController -> unit
    //    abstract pull: controller: ReadableStreamDefaultController -> unit
    //    abstract cancel: reason: obj -> unit

    //type UnderlyingDefaultSource<'R> =
    //    abstract start: controller: ReadableStreamDefaultController<'R> -> unit
    //    abstract pull: controller: ReadableStreamDefaultController<'R> -> unit
    //    abstract cancel: reason: obj -> unit

    //type UnderlyingSource<'R> =
    //    abstract start: controller: ReadableStreamDefaultController<'R> -> unit
    //    abstract pull: controller: ReadableStreamDefaultController<'R> -> unit
    //    abstract cancel: reason: obj -> unit

    //type QueuingStrategy<'R> =
    //    abstract highWaterMark: float option
    //    abstract size: ('R -> float) option





    ////type ReadableStreamIteratorOptions =
    ////    abstract member preventCancel: bool


    ////type ReadableStreamAsyncIterator<'T> =
    ////    abstract member next: unit -> 'T

    ////type ReadableStream<'R> =
    ////    abstract member values: options: ReadableStreamIteratorOptions -> ReadableStreamAsyncIterator<'R>

    ////interface ReadableStream<R = any> {
    ////    [Symbol.asyncIterator](options?: ReadableStreamIteratorOptions): ReadableStreamAsyncIterator<R>;
    ////    values(options?: ReadableStreamIteratorOptions): ReadableStreamAsyncIterator<R>;
    ////}