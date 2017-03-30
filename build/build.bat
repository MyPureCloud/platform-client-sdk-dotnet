@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319


if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://nuget.org/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\PureCloudPlatform.Client.V2\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.9.0.1\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.2.3\lib\net45\RestSharp.dll bin\RestSharp.dll

%CSCPATH%\csc /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll /target:library /out:bin\PureCloudPlatform.Client.V2.dll /recurse:src\PureCloudPlatform.Client.V2\*.cs /doc:bin\PureCloudPlatform.Client.V2.xml
