module Tests

open System
open Xunit
open Minesweeper

[<Fact>]
let ``My test`` () =
    let sut = cell {
        return! Bomb
    }
    Assert.Equal(Bomb, sut)
