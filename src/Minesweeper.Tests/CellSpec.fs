module CellSpec

open System
open Xunit
open Minesweeper
open Cell

[<Fact>]
let ``폭탄을 별로 표시 하기`` () =
    let sut = Bomb
    let ret = sut |> char
    Assert.Equal('*', ret)

[<Fact>]
let ``1을 숫자로 표시하기``() =
    let sut = Number 1
    let ret = sut |> char
    Assert.Equal('1', ret);
