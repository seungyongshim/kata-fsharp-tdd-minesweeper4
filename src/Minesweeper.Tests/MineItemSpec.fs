module MineItemSpec

open System
open Xunit
open Minesweeper
open MineItem

[<Fact>]
let ``커버상태`` () =
    let sut = Covered (Number 0)
    let ret = (Cell.char, sut) ||> char 
    Assert.Equal('.', ret)

