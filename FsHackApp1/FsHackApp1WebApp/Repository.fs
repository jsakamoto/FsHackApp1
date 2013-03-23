namespace FsWeb.Repositories
open System
open System.Linq

module Repository =
    let get (source:IQueryable<_>) queryFn =
        queryFn source |> Seq.toList

    let getAll () =
        fun s -> query { for x in s do select x }