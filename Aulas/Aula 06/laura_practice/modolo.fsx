module Greetings =
    let makeHello (vip : string list) (name: string) = 

        if List.contains name vip then 
            $"Hello, {name}"
        else 
            $"Welcome, {name}!"
    
    type DayPeriod = 
        | Morning
        | Afternoon
        | Evening
    
    let salute (period:DayPeriod) : string= 
        match period with
        | Morning -> "Good morning!"
        | Afternoon -> "Good afternoon!"
        | Evening -> "Good evening!"
    



    

    


        