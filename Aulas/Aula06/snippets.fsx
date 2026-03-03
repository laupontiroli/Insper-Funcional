module MathUtils =
    let square x = x * x
    let cube x = x * x * x

    type DayOfWeek =
        | Monday
        | Tuesday
        | Wednesday
        | Thursday
        | Friday
        | Saturday
        | Sunday

    module ComplexNumbers =
        type Complex = float * float

        let add (a: Complex) (b: Complex) =
            let (a1, a2) = a
            let (b1, b2) = b
            (a1 + b1, a2 + b2)

        let multiply (a: Complex) (b: Complex) =
            let (a1, a2) = a
            let (b1, b2) = b
            (a1 * b1 - a2 * b2, a1 * b2 + a2 * b1)

        let conjugate (a: Complex) =
            let (a1, a2) = a
            (a1, -a2)


// uso:
MathUtils.square 4 // 16
MathUtils.cube 3 // 27

let x = (3.0, 4.0)
let xconj = MathUtils.ComplexNumbers.conjugate x

let square_mag = MathUtils.ComplexNumbers.multiply x xconj