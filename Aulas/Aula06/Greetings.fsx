module Greetings =
    let makeHello (vip: string list) (name: string) : string =
        if List.contains name vip then
            $"Welcome, {name}!"
        else
            $"Hello, {name}."

    type DayPeriod = 
        | Morning 
        | Afternoon 
        | Evening

    let salute (period: DayPeriod) : string =
        match period with
            | Morning -> "Good Morning!"
            | Afternoon -> "Good Afternoon!"
            | Evening -> "Good Evening!"


let vipList = ["Alice"; "Bob"; "Charlie"; "Douglas"]

printfn "%s" (Greetings.makeHello vipList "Ed")
printfn "%s" (Greetings.makeHello vipList "Douglas")

printfn "%s" (Greetings.salute Greetings.Afternoon)
