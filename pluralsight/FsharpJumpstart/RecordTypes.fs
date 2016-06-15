#if INTERACTIVE
#else
module RecordTypes
#endif

type Person = 
    {
        FirstName : string
        LastName : string
    }

let person = { FirstName = "Neils" ; LastName = "Christoffersen" }

printfn "%s, %s" person.LastName person.FirstName

let person2 = { person with FirstName = "Fred" }

let person3 = { FirstName = "Neils" ; LastName = "Christoffersen" }

