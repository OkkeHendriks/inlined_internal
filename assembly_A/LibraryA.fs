namespace assembly_A

open System.Runtime.CompilerServices

module private referenceModuleInternal =
    exception ATestException

    module internal referenceModulePublic =
        let something = true

