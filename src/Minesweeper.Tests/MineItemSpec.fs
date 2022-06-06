module MineItemSpec

open System
open Xunit
open Minesweeper
open MineItem

[<Fact>]
let ``커버상태`` () =
    let sut = Covered (Number 0)
    let ret = sut |> char Cell.char
    Assert.Equal('.', ret)

