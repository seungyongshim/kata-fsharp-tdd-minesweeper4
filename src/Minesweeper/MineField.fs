namespace Minesweeper

type Width = int
type Height = int
type MineItems<'a> = Map<(int*int), MineItem<'a>>

type MineField =
    | Setup of Width * Height
    | Playing of Width * Height * MineItems<Cell>

module MineField =
    let start v =
        match v with
        | Setup (w, h) -> Playing (w, h, seq {
            for y in 1..h do
            for x in 1..w do
            yield ((y, x), Covered Cell.init)
        } |> Map.ofSeq)
        
    let rec click v pos =
        match v with
        | Setup _ -> start v
        | Playing (w, h, z) ->
            let clicked = z.Change (pos, Option.map MineItem.click)
            Playing (w, h, clicked)
