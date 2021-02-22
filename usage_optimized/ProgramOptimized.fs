open assembly_A.referenceModulePublic

[<EntryPoint>]
let main _ =
    makeException ()
    makeExceptionAggressiveInlining ()
    makeExceptionNoInlining ()
    0
