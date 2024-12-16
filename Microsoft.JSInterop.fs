// ts2fable 0.7.1
module rec Microsoft.JSInterop
open Microsoft.JSInterop.Prelude
open System
open Fable.Core
open Fable.Core.JS

type Function = System.Action

let [<Import("*","@microsoft/dotnet-js-interop/dist/Microsoft.JSInterop")>] dotNet: DotNet.IExports = jsNative

module DotNet =
    type [<AllowNullLiteral>] IExports =
        /// <summary>Creates a .NET call dispatcher to use for handling invocations between JavaScript and a .NET runtime.</summary>
        /// <param name="dotNetCallDispatcher">An object that can dispatch calls from JavaScript to a .NET runtime.</param>
        abstract attachDispatcher: dotNetCallDispatcher: DotNetCallDispatcher -> ICallDispatcher
        /// <summary>Adds a JSON reviver callback that will be used when parsing arguments received from .NET.</summary>
        /// <param name="reviver">The reviver to add.</param>
        abstract attachReviver: reviver: JsonReviver -> unit
        /// <summary>Invokes the specified .NET public method synchronously. Not all hosting scenarios support
        /// synchronous invocation, so if possible use invokeMethodAsync instead.</summary>
        /// <param name="assemblyName">The short name (without key/version or .dll extension) of the .NET assembly containing the method.</param>
        /// <param name="methodIdentifier">The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.</param>
        /// <param name="args">Arguments to pass to the method, each of which must be JSON-serializable.</param>
        abstract invokeMethod: assemblyName: string * methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> 'T
        /// <summary>Invokes the specified .NET public method asynchronously.</summary>
        /// <param name="assemblyName">The short name (without key/version or .dll extension) of the .NET assembly containing the method.</param>
        /// <param name="methodIdentifier">The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.</param>
        /// <param name="args">Arguments to pass to the method, each of which must be JSON-serializable.</param>
        abstract invokeMethodAsync: assemblyName: string * methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> Promise<'T>
        /// <summary>Creates a JavaScript object reference that can be passed to .NET via interop calls.</summary>
        /// <param name="jsObject">The JavaScript Object used to create the JavaScript object reference.</param>
        abstract createJSObjectReference: jsObject: obj option -> obj option
        /// <summary>Creates a JavaScript data reference that can be passed to .NET via interop calls.</summary>
        /// <param name="streamReference">The ArrayBufferView or Blob used to create the JavaScript stream reference.</param>
        abstract createJSStreamReference: streamReference: U4<ArrayBuffer, ArrayBufferView, Blob, obj option> -> obj option
        /// <summary>Disposes the given JavaScript object reference.</summary>
        /// <param name="jsObjectReference">The JavaScript Object reference.</param>
        abstract disposeJSObjectReference: jsObjectReference: obj option -> unit
        abstract CallDispatcher: CallDispatcherStatic
        abstract findJSFunction: identifier: string * targetInstanceId: float -> Function
        abstract disposeJSObjectReferenceById: id: float -> unit
        abstract DotNetObject: DotNetObjectStatic

    type [<AllowNullLiteral>] JsonReviver =
        [<Emit "$0($1...)">] abstract Invoke: key: obj option * value: obj option -> obj option

    type [<RequireQualifiedAccess>] JSCallResultType =
        | Default = 0
        | JSObjectReference = 1
        | JSStreamReference = 2
        | JSVoidResult = 3

    /// Represents the ability to dispatch calls from JavaScript to a .NET runtime.
    type [<AllowNullLiteral>] DotNetCallDispatcher =
        /// <summary>Optional. If implemented, invoked by the runtime to perform a synchronous call to a .NET method.</summary>
        /// <param name="assemblyName">The short name (without key/version or .dll extension) of the .NET assembly holding the method to invoke. The value may be null when invoking instance methods.</param>
        /// <param name="methodIdentifier">The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.</param>
        /// <param name="dotNetObjectId">If given, the call will be to an instance method on the specified DotNetObject. Pass null or undefined to call static methods.</param>
        /// <param name="argsJson">JSON representation of arguments to pass to the method.</param>
        abstract invokeDotNetFromJS: assemblyName: string option * methodIdentifier: string * dotNetObjectId: float option * argsJson: string -> string option
        /// <summary>Invoked by the runtime to begin an asynchronous call to a .NET method.</summary>
        /// <param name="callId">A value identifying the asynchronous operation. This value should be passed back in a later call from .NET to JS.</param>
        /// <param name="assemblyName">The short name (without key/version or .dll extension) of the .NET assembly holding the method to invoke. The value may be null when invoking instance methods.</param>
        /// <param name="methodIdentifier">The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.</param>
        /// <param name="dotNetObjectId">If given, the call will be to an instance method on the specified DotNetObject. Pass null to call static methods.</param>
        /// <param name="argsJson">JSON representation of arguments to pass to the method.</param>
        abstract beginInvokeDotNetFromJS: callId: float * assemblyName: string option * methodIdentifier: string * dotNetObjectId: float option * argsJson: string -> unit
        /// <summary>Invoked by the runtime to complete an asynchronous JavaScript function call started from .NET</summary>
        /// <param name="callId">A value identifying the asynchronous operation.</param>
        /// <param name="resultOrError">The serialized result or the serialized error from the async operation.</param>
        abstract endInvokeJSFromDotNet: callId: float * succeeded: bool * resultOrError: obj option -> unit
        /// <summary>Invoked by the runtime to transfer a byte array from JS to .NET.</summary>
        /// <param name="id">The identifier for the byte array used during revival.</param>
        /// <param name="data">The byte array being transferred for eventual revival.</param>
        abstract sendByteArray: id: float * data: Uint8Array -> unit

    /// Represents the ability to facilitate function call dispatching between JavaScript and a .NET runtime.
    type [<AllowNullLiteral>] ICallDispatcher =
        /// <summary>Invokes the specified synchronous JavaScript function.</summary>
        /// <param name="identifier">Identifies the globally-reachable function to invoke.</param>
        /// <param name="argsJson">JSON representation of arguments to be passed to the function.</param>
        /// <param name="resultType">The type of result expected from the JS interop call.</param>
        /// <param name="targetInstanceId">The instance ID of the target JS object.</param>
        abstract invokeJSFromDotNet: identifier: string * argsJson: string * resultType: JSCallResultType * targetInstanceId: float -> string option
        /// <summary>Invokes the specified synchronous or asynchronous JavaScript function.</summary>
        /// <param name="asyncHandle">A value identifying the asynchronous operation. This value will be passed back in a later call to endInvokeJSFromDotNet.</param>
        /// <param name="identifier">Identifies the globally-reachable function to invoke.</param>
        /// <param name="argsJson">JSON representation of arguments to be passed to the function.</param>
        /// <param name="resultType">The type of result expected from the JS interop call.</param>
        /// <param name="targetInstanceId">The ID of the target JS object instance.</param>
        abstract beginInvokeJSFromDotNet: asyncHandle: float * identifier: string * argsJson: string option * resultType: JSCallResultType * targetInstanceId: float -> unit
        /// <summary>Receives notification that an async call from JS to .NET has completed.</summary>
        /// <param name="asyncCallId">The identifier supplied in an earlier call to beginInvokeDotNetFromJS.</param>
        /// <param name="success">A flag to indicate whether the operation completed successfully.</param>
        /// <param name="resultJsonOrExceptionMessage">Either the operation result as JSON, or an error message.</param>
        abstract endInvokeDotNetFromJS: asyncCallId: string * success: bool * resultJsonOrExceptionMessage: string -> unit
        /// <summary>Invokes the specified .NET public static method synchronously. Not all hosting scenarios support
        /// synchronous invocation, so if possible use invokeMethodAsync instead.</summary>
        /// <param name="assemblyName">The short name (without key/version or .dll extension) of the .NET assembly containing the method.</param>
        /// <param name="methodIdentifier">The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.</param>
        /// <param name="args">Arguments to pass to the method, each of which must be JSON-serializable.</param>
        abstract invokeDotNetStaticMethod: assemblyName: string * methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> 'T
        /// <summary>Invokes the specified .NET public static method asynchronously.</summary>
        /// <param name="assemblyName">The short name (without key/version or .dll extension) of the .NET assembly containing the method.</param>
        /// <param name="methodIdentifier">The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.</param>
        /// <param name="args">Arguments to pass to the method, each of which must be JSON-serializable.</param>
        abstract invokeDotNetStaticMethodAsync: assemblyName: string * methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> Promise<'T>
        /// <summary>Receives notification that a byte array is being transferred from .NET to JS.</summary>
        /// <param name="id">The identifier for the byte array used during revival.</param>
        /// <param name="data">The byte array being transferred for eventual revival.</param>
        abstract receiveByteArray: id: float * data: Uint8Array -> unit
        /// <summary>Supplies a stream of data being sent from .NET.</summary>
        /// <param name="streamId">The identifier previously passed to JSRuntime's BeginTransmittingStream in .NET code.</param>
        /// <param name="stream">The stream data.</param>
        abstract supplyDotNetStream: streamId: float * stream: ReadableStream -> unit

    type [<AllowNullLiteral>] CallDispatcher =
        inherit ICallDispatcher
        abstract getDotNetCallDispatcher: unit -> DotNetCallDispatcher
        /// Invokes the specified synchronous JavaScript function.
        abstract invokeJSFromDotNet: identifier: string * argsJson: string * resultType: JSCallResultType * targetInstanceId: float -> string option
        /// Invokes the specified synchronous or asynchronous JavaScript function.
        abstract beginInvokeJSFromDotNet: asyncHandle: float * identifier: string * argsJson: string option * resultType: JSCallResultType * targetInstanceId: float -> unit
        /// Receives notification that an async call from JS to .NET has completed.
        abstract endInvokeDotNetFromJS: asyncCallId: string * success: bool * resultJsonOrExceptionMessage: string -> unit
        /// Invokes the specified .NET public static method synchronously. Not all hosting scenarios support
        /// synchronous invocation, so if possible use invokeMethodAsync instead.
        abstract invokeDotNetStaticMethod: assemblyName: string * methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> 'T
        /// Invokes the specified .NET public static method asynchronously.
        abstract invokeDotNetStaticMethodAsync: assemblyName: string * methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> Promise<'T>
        abstract invokeDotNetMethod: assemblyName: string option * methodIdentifier: string * dotNetObjectId: float option * args: ResizeArray<obj option> option -> 'T
        abstract invokeDotNetMethodAsync: assemblyName: string option * methodIdentifier: string * dotNetObjectId: float option * args: ResizeArray<obj option> option -> Promise<'T>
        /// Receives notification that a byte array is being transferred from .NET to JS.
        abstract receiveByteArray: id: float * data: Uint8Array -> unit
        abstract processByteArray: id: float -> Uint8Array option
        /// Supplies a stream of data being sent from .NET.
        abstract supplyDotNetStream: streamId: float * stream: ReadableStream -> unit
        abstract getDotNetStreamPromise: streamId: float -> Promise<ReadableStream>

    type [<AllowNullLiteral>] CallDispatcherStatic =
        [<Emit "new $0($1...)">] abstract Create: _dotNetCallDispatcher: DotNetCallDispatcher -> CallDispatcher

    type [<AllowNullLiteral>] DotNetObject =
        abstract invokeMethod: methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> 'T
        abstract invokeMethodAsync: methodIdentifier: string * [<ParamArray>] args: ResizeArray<obj option> -> Promise<'T>
        abstract dispose: unit -> unit
        abstract serializeAsArg: unit -> DotNetObjectSerializeAsArgReturn

    type [<AllowNullLiteral>] DotNetObjectSerializeAsArgReturn =
        abstract __dotNetObject: float with get, set

    type [<AllowNullLiteral>] DotNetObjectStatic =
        [<Emit "new $0($1...)">] abstract Create: _id: float * _callDispatcher: CallDispatcher -> DotNetObject
