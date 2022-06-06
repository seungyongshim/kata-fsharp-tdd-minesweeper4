namespace Minesweeper

open System

type Cell =
    | Number of int
    | Bomb

module Cell = 
    let char = function
    | Bomb -> '*'
    | Number i -> Convert.ToChar(i + (int)'0')

