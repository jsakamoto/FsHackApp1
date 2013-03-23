namespace FsWeb.Controllers

open System.Web.Mvc
open FsWeb.Models

[<HandleError>]
type GuitarsController() =
    inherit Controller()
    member this.Index() =
        seq { yield Guitar(Name="Gibson Les Paul")
              yield Guitar(Name="Martin D-28") }
        |> this.View
