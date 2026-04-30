open Greetings

let dotnet_langs = [ "C#"; "F#"; "VB.NET" ]
let greetDotNet = Greet.makeHello dotnet_langs

printfn "%s" (greetDotNet "F#")
printfn "%s" (greetDotNet "Python")

let salutation = Greet.salute Morning
printfn "%s" salutation

let farewell = Greet.goodbye dotnet_langs "F#"
printfn "%s" farewell
