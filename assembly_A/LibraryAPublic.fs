namespace assembly_A

open System.Runtime.CompilerServices

module referenceModulePublic =
    open referenceModuleInternal

    let makeException () =
        raise ATestException

    [<MethodImpl(MethodImplOptions.AggressiveInlining)>]
    let makeExceptionAggressiveInlining () =
        raise ATestException

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let makeExceptionNoInlining () =
        raise ATestException