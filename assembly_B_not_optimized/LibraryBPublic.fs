namespace assembly_B_not_optimized

open System.Runtime.CompilerServices

module referenceModulePublicB =
    open referenceModuleInternalB

    let makeExceptionB () =
        raise TestExceptionFromB

    [<MethodImpl(MethodImplOptions.AggressiveInlining)>]
    let makeExceptionAggressiveInliningB () =
        raise TestExceptionFromB

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let makeExceptionNoInliningB () =
        raise TestExceptionFromB