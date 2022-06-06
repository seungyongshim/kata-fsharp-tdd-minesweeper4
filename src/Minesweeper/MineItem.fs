namespace Minesweeper

type MineItem<'a> =
    | Covered of 'a
    | Uncovered of 'a

module MineItem =
    let char f = function
        | Covered _ -> '.'
        | Uncovered c -> f c

    let click v =
        match v with
        | Covered c -> Uncovered c 
        | Uncovered _ -> v
