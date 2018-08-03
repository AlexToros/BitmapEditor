namespace Calculating

type Class1() = class
    
    member this.PrintHello(name) = "Hello " + name + "!" 
    member this.X = "F#"

end

module Say =
    let hello name = "Hello " + name + "!"
