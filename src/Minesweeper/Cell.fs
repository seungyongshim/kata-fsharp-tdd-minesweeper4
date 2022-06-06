namespace Minesweeper

open System

type Cell =
    | Bomb
    | Number of int

module Cell = 
    let char = function
    | Bomb -> '*'
    | Number i -> Convert.ToChar(i + (int)'0')

