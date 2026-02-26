
let rec list_length xs = 
    match xs with
    | [] -> 0
    | head :: tail -> 1 + list_length tail   


let rec list_max_iem xs = 
    match xs with
    | [] -> failwith "Empty list has no maximum element"
    | [x] -> x
    | head :: tail -> 
        let max_tail = list_max_iem tail 
        if head > max_tail then head else max_tail

 
