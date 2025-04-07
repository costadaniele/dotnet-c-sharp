<p>Criar projeto no terminal</p>

`dotnet new console`
`dotnet new console -f net8.0 -n DotNetDirectory`

<p>Executar programa</p>

`dotnet run`

<p>System.Text.Json</p>

`dotnet add package System.Text.Json`
`using Newtonsoft.Json;`

<p>Criar API Web básica</p>

`dotnet new webapi -controllers -f net8.0`

<p>Consultar pelo prompt</p>

`dotnet tool install -g Microsoft.dotnet-httprepl`
`httprepl https://localhost:{PORT}`
`ls`
`get`
`delete`
`exit`

<p>Criar pasta</p>

`mkdir Pasta`

<p>Post terminal</p>

`post -c "{"name":"Hawaii", "isGlutenFree":false}"`

<p>Put terminal</p>

`put 3 -c  "{"id": 3, "name":"Hawaiian", "isGlutenFree":false}"`