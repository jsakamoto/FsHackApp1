namespace FsWeb.Controllers
open System
open System.Web.Mvc
open FsWeb.Models
open FsWeb.Repositories
open Repository

[<HandleError>]
type GuitarsController(context:IDisposable, ?repository) =
    inherit Controller()

    let fromRepository = 
        match repository with
        |Some v -> v
        |_-> (context :?> FsMvcAppEntities).Guitars |> Repository.get

    new() = new GuitarsController(new FsMvcAppEntities())

    member this.Index() =
        getAll() |> fromRepository
        |> this.View

    override x.Dispose disposing =
        context.Dispose()
        base.Dispose disposing