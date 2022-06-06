namespace Minesweeper

open System

type Cell =
    | Bomb
    | Number of int

module Cell =
    let init = Number 0

    let char = function
    | Bomb -> '*'
    | Number i -> Convert.ToChar(i + (int)'0')

