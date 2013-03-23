namespace FsWeb.Repositories

type GuitarsRepository() = 
    member x.GetAll() = 
        use context = new FsMvcAppEntities()
        query { for g in context.Guitars do select g }
        |> Seq.toList

    member x.GetByName name =
        use context = new FsMvcAppEntities()
        query { for g in context.Guitars do where (g.Name = name) }
        |> Seq.toList
        