namespace FsWeb.Controllers

open System.Web.Mvc
open FsWeb.Models
open FsWeb.Repositories

[<HandleError>]
type GuitarsController(repository : GuitarsRepository) =
    inherit Controller()

    new() = new GuitarsController(GuitarsRepository())

    member this.Index() =
        repository.GetAll()
        |> this.View
