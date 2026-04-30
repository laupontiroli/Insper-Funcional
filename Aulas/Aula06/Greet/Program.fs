open Greetings

let vipList = ["Alice"; "Bob"; "Charlie"; "Douglas"]

printfn "%s" (Greetings.makeHello vipList "Ed")
printfn "%s" (Greetings.makeHello vipList "Douglas")

printfn "%s" (Greetings.salute Greetings.DayPeriod.Afternoon)
