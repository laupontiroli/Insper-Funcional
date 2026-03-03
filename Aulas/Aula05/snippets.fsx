// let apply_twice f x = f (f x)
// let double x = x * 2
// let square x = x * x
// let show_result x = printfn "%d" x
// show_result (apply_twice double 3)
// show_result (apply_twice square 2)

// let calculaDistancia x1 y1 x2 y2 =
//     let dx = x2 - x1
//     let dy = y2 - y1
//     printfn "x1: %f, y1: %f, x2: %f, y2: %f" x1 y1 x2 y2
//     sqrt (dx * dx + dy * dy)


// let distanciaDaOrigem =
//     calculaDistancia 0.0 0.0

// let raio = distanciaDaOrigem 3.0 4.0
// printfn "O raio é: %f" raio

// let double_list_and_print lst =
//     lst
//     |> List.map (fun x -> x * 2)
//     |> List.iter (printf "%d ")

// let double_list_and_print' lst =
//     let double_lst = List.map (fun x -> x * 2) lst
//     List.iter (printf "%d ") double_lst

// double_list_and_print [ 1; 2; 3 ]
// double_list_and_print' [ 1; 2; 3 ]


// let isEven x = x % 2 = 0
// let showNumber x = printfn "%d" x
// let someList = [ 0..9 ]

// let showEvenNumbers lst =
//     lst |> List.filter isEven |> List.iter showNumber

// showEvenNumbers someList


// let accumulate value_so_far new_value = value_so_far + new_value

// let sumList lst = List.fold accumulate 0 lst

// // Outra forma de criar uma lista: list comprehensions!
// let someList = [ for i in 1..5 -> 2 * i ] (* [2; 4; 6; 8; 10] *)

// printfn "%d" (sumList someList) (* 30 *)
