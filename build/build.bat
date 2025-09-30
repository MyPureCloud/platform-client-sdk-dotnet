@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319


if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://nuget.org/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\PureCloudPlatform.Client.V2\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.13.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.112.0.0\lib\net45\RestSharp.dll bin\RestSharp.dll
copy packages\WebSocketSharp.1.0.3-rc11\lib\websocket-sharp.dll bin\websocket-sharp.dll;
copy packages\System.Text.Json.8.0.5\lib\net462\System.Text.Json.dll bin\System.Text.Json.dll;
copy packages\System.Text.Encodings.Web.8.0.0\lib\net462\System.Text.Encodings.Web.dll bin\System.Text.Encodings.Web.dll;
copy packages\System.Threading.Tasks.Extensions.4.5.4\lib\net461\System.Threading.Tasks.Extensions.dll bin\System.Threading.Tasks.Extensions.dll;
copy packages\System.Runtime.CompilerServices.Unsafe.6.0.0\lib\net461\System.Runtime.CompilerServices.Unsafe.dll bin\System.Runtime.CompilerServices.Unsafe.dll;



%CSCPATH%\csc /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll;bin\websocket-sharp.dll;bin\System.Text.Json.dll;bin\System.Text.Encodings.Web.dll;bin\System.Threading.Tasks.Extensions.dll /target:library /out:bin\PureCloudPlatform.Client.V2.dll /recurse:src\PureCloudPlatform.Client.V2\*.cs /doc:bin\PureCloudPlatform.Client.V2.xml
