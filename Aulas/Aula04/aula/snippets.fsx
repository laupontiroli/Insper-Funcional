// let rec fat n =
//     match n with
//     | n when n < 0 -> invalidArg "n" "n must be positive"
//     | n when n <= 1 -> 1
//     | n -> n * fat (n - 1)


// let x: int =
//     try
//         fat -2
//     with
//         | :? System.ArgumentException as ex ->
//             printfn "Argument error: %s" ex.Message
//             -1
//         | ex ->
//             printfn "Error: %s" ex.Message
//             reraise()

// let describe_number n =
//     match n with
//     | 0 -> "Zero"
//     | 1 -> "Um"
//     | 2 -> "Dois"
//     | 3 -> "Tres"
//     | 4 -> "Quatro"
//     | 5 -> "Cinco"
//     | _ -> "Outro"

// printfn $"{describe_number -4}"

// type day = Sun | Mon | Tue | Wed | Thu | Fri | Sat

// let int_to_day (i: int) : day =
//     match i % 7 with
//     | 0 -> Sun
//     | 1 -> Mon
//     | 2 -> Tue
//     | 3 -> Wed
//     | 4 -> Thu
//     | 5 -> Fri
//     | 6 -> Sat
//     | _ -> failwith "This should never happen. Maybe n is negative?"

// let rec sum_list lst =
//     match lst with
//     | [] -> 0 (* Lista vazia *)
//     | head :: tail -> head + sum_list tail (* Desempacota head do tail *)

// let my_list = [ 1; 2; 3; 4; 5 ]

// printfn $"{sum_list my_list}"


// let rec duplicate_elements lst =
//     match lst with
//     | [] -> []
//     | head :: tail -> head :: head :: duplicate_elements tail

// let my_list = [ 1; 2; 3 ]
// let my_other_list = [ "a"; "b"; "c" ]

// printfn $"{duplicate_elements my_list}"
// printfn $"{duplicate_elements my_other_list}"

// let my_list = [1; 2; 3]

// my_list @ [4]

// my_list

// let lst = [10; 20; 30; 40; 50]
// let x = lst[2] (* x = 30 *)

// let my_list = [1; 2; 3]
// let x = List.item 2 my_list

// let rec list_length xs =
//     match xs with
//     | [] -> 0
//     | _ :: tail -> 1 + list_length tail

// list_length [1; 2; 3]

// let rec list_max xs =
//     match xs with
//     | [] -> failwith "Lista vazia"
//     | [ x ] -> x
//     | head :: tail -> 
//         let max_tail = list_max tail in
//         if head > max_tail 
//         then 
//             head 
//         else 
//             max_tail

// let rec top_two xs =
//     match xs with
//     | [] -> failwith "Lista vazia"
//     | [ _ ] -> failwith "Lista com só um elemento"
//     | [ x; y ] -> if x > y then (x, y) else (y, x)
//     | head :: tail -> 
//         let x, y = top_two tail in
//         if head > x
//         then
//             (head, x)
//         elif head > y then
//             (x, head)
//         else
//             (x, y)

// let rec second_max xs =
//     let primeiro, segundo = top_two xs
//     segundo

// let descreve_ponto pt =
//     let x, y = pt
//     if x > y then "x é maior"
//     elif y > x then "y é maior"
//     else "São iguais"

// descreve_ponto (2, 2)

type MeuOption = 
    | MeuSome of int
    | MeuNone

let describe_option opt =
    match opt with
    | MeuSome x -> $"MeuSome com valor {x}"
    | MeuNone -> "MeuNone"

describe_option (MeuSome 42)
describe_option MeuNone