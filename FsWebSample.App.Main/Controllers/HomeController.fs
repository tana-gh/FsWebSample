namespace FsWebSample.App.Main.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open System.Diagnostics
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

type HomeHelloReq = {
    Name : string
}

type HomeHelloRes = {
    Hello : string
}

[<ApiController>]
[<Route("api/home")>]
type HomeController (logger : ILogger<HomeController>) =
    inherit Controller()

    [<Route("hello")>]
    [<HttpPost>]
    member this.Hello([<FromBody>] json : HomeHelloReq) =
        {
            Hello = $"Hello, {json.Name}!"
        }
