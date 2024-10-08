#!/usr/bin/env bash
frameworkVersion=net45
netfx=${frameworkVersion#net}

wget -nc "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe";
mozroots --import --sync
mono nuget.exe install src/PureCloudPlatform.Client.V2/packages.config -o packages -NoCache -Verbosity detailed;
mkdir -p bin;

cp packages/ini-parser.2.5.2/lib/net20/INIFileParser.dll bin/INIFileParser.dll;
cp packages/Newtonsoft.Json.13.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.112.0.0/lib/net45/RestSharp.dll bin/RestSharp.dll;
cp packages/WebSocketSharp.1.0.3-rc11/lib/websocket-sharp.dll bin/websocket-sharp.dll;
cp packages/System.Text.Json.8.0.4/lib/net462/System.Text.Json.dll bin/System.Text.Json.dll;
cp packages/System.Text.Encodings.Web.7.0.0/lib/net462/System.Text.Encodings.Web.dll bin/System.Text.Encodings.Web.dll;
cp packages/System.Threading.Tasks.Extensions.4.5.4/lib/net461/System.Threading.Tasks.Extensions.dll bin/System.Threading.Tasks.Extensions.dll;
cp packages/System.Runtime.CompilerServices.Unsafe.4.5.3/lib/net461/System.Runtime.CompilerServices.Unsafe.dll bin/System.Runtime.CompilerServices.Unsafe.dll;

mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
bin/websocket-sharp.dll,\
bin/INIFileParser.dll,\
System.Net.Http.dll,\
bin/System.Text.Json.dll,\
bin/System.Text.Encodings.Web.dll,\
bin/System.Threading.Tasks.Extensions.dll,\
System.Runtime.Serialization.dll \
System.Runtime.Serialization.dll \
-target:library \
-out:bin/PureCloudPlatform.Client.V2.dll \
-recurse:'src/PureCloudPlatform.Client.V2/*.cs' \
-doc:bin/PureCloudPlatform.Client.V2.xml \
-platform:anycpu
