namespace Minesweeper

type Cell =
    | Number of int
    | Bomb


type CellBuilder() =
    member x.ReturnFrom(value) = value


[<AutoOpen>]
module Cell = 
    let cell = new CellBuilder()

