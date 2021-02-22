open assembly_A_optimized.referenceModulePublicA
open assembly_B_not_optimized.referenceModulePublicB

[<EntryPoint>]
/// Optimized
let main _ =
    makeExceptionA ()
    makeExceptionAggressiveInliningA ()
    makeExceptionNoInliningA ()

    makeExceptionB ()
    makeExceptionAggressiveInliningB ()
    makeExceptionNoInliningB ()

    0