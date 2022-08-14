// For more information see https://aka.ms/fsharp-console-apps

open System

[<EntryPoint>]
let main argv =
  let mutable person = "John"
  if argv.Length >0 then
     person <- argv[0]
  printfn "Hello from %s" person
  0
