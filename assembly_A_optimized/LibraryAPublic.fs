namespace assembly_A_optimized

open System.Runtime.CompilerServices

module referenceModulePublicA =
    open referenceModuleInternalA

    let makeExceptionA () =
        raise TestExceptionA

    [<MethodImpl(MethodImplOptions.AggressiveInlining)>]
    let makeExceptionAggressiveInliningA () =
        raise TestExceptionA

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let makeExceptionNoInliningA () =
        raise TestExceptionA