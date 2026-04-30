module Tests

open System
open Xunit
open Greetings


[<Fact>]
let ``makeHello for non-VIP should return a greeting "Hello, <name>."`` () =
    let vipList = [ "Alice"; "Bob" ]
    let name = "Charlie"

    let result = Greet.makeHello vipList name
    let expected = $"Hello, {name}."

    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)

[<Fact>]
let ``makeHello for VIP should return a greeting "Welcome, <name>!"`` () =
    let vipList = [ "Alice"; "Bob" ]
    let name = "Alice"

    let result = Greet.makeHello vipList name
    let expected = $"Welcome, {name}!"

    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)

[<Fact>]
let ``salute for Morning should return "Good Morning!"`` () =
    let result = Greet.salute Morning
    let expected = "Good Morning!"

    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)

[<Fact>]
let ``salute for Afternoon should return "Good Afternoon!"`` () =
    let result = Greet.salute Afternoon
    let expected = "Good Afternoon!"

    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)

[<Fact>]
let ``salute for Evening should return "Good Evening!"`` () =
    let result = Greet.salute Evening
    let expected = "Good Evening!"

    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)

[<Fact>]
let ``goodbye for a vip should return "Goodbye, <name>! See you soon!"`` () =
    let vipList = [ "Alice"; "Bob" ]
    let name = "Alice"

    let result = Greet.goodbye vipList name
    let expected = $"Goodbye, {name}! See you soon!"

    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)

[<Fact>]
let ``goodbye for a non-vip should return "Goodbye, <name>."`` () =
    let vipList = [ "Alice"; "Bob" ]
    let name = "Charlie"

    let result = Greet.goodbye vipList name
    let expected = $"Goodbye, {name}."

    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)
