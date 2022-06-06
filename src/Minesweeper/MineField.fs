namespace Minesweeper

type Width = int
type Height = int
type MineItems<'a> = Map<(int*int), MineItem<'a>>

type MineField =
    | Setup of Width * Height
    | Playing of Width * Height 

module MineField =
    let start v =
        match v with
        | Setup (w, h) -> Playing (w, h)
        
