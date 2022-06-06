namespace Minesweeper

type MineItem<'T> =
    | Covered of 'T
    | Uncovered of 'T

module MineItem =
    open Cell

    let char = function
        | Uncovered c -> c |> char
        | Covered _ -> '.'

    let click v =
        match v with
        | Covered c -> Uncovered c
        | Uncovered _ -> v
