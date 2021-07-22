namespace FsWebSample.App.Main.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open System.Diagnostics
open Microsoft.AspNetCore.Mvc
open Microsoft.AspNetCore.Diagnostics;
open Microsoft.Extensions.Logging

type ErrorDevelopmentRes = {
    Message : string
    StackTrace : string
}

type ErrorProductionRes = {
    Message : string
}

[<ApiController>]
[<Route("api/error")>]
type ErrorController (logger : ILogger<ErrorController>) =
    inherit ControllerBase()

    [<Route("error")>]
    member this.Production() =
        this.Problem()
