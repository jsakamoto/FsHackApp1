namespace FsWeb.Controllers

open System.Web.Mvc
open FsWeb.Models

[<HandleError>]
type GuitarsController() =
    inherit Controller()
    member this.Index() =
        seq { yield {Id=System.Guid.NewGuid(); Name="Gibson Les Paul"} 
              yield {Id=System.Guid.NewGuid(); Name="Martin D-28"} }
        |> this.View
