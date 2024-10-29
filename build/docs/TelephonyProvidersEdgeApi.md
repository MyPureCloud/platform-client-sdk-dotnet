# TelephonyProvidersEdgeApi

## PureCloudPlatform.Client.V2.Api.TelephonyProvidersEdgeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteTelephonyProvidersEdge**](#DeleteTelephonyProvidersEdge) | **Delete** /api/v2/telephony/providers/edges/{edgeId} | Delete a edge. |
| [**DeleteTelephonyProvidersEdgeLogicalinterface**](#DeleteTelephonyProvidersEdgeLogicalinterface) | **Delete** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Delete an edge logical interface |
| [**DeleteTelephonyProvidersEdgeSoftwareupdate**](#DeleteTelephonyProvidersEdgeSoftwareupdate) | **Delete** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Cancels any in-progress update for this edge. |
| [**DeleteTelephonyProvidersEdgesAlertablepresences**](#DeleteTelephonyProvidersEdgesAlertablepresences) | **Delete** /api/v2/telephony/providers/edges/alertablepresences | Deletes alertable presences overrides. |
| [**DeleteTelephonyProvidersEdgesCertificateauthority**](#DeleteTelephonyProvidersEdgesCertificateauthority) | **Delete** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Delete a certificate authority. |
| [**DeleteTelephonyProvidersEdgesDidpool**](#DeleteTelephonyProvidersEdgesDidpool) | **Delete** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Delete a DID Pool by ID. |
| [**DeleteTelephonyProvidersEdgesEdgegroup**](#DeleteTelephonyProvidersEdgesEdgegroup) | **Delete** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Delete an edge group. |
| [**DeleteTelephonyProvidersEdgesExtensionpool**](#DeleteTelephonyProvidersEdgesExtensionpool) | **Delete** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Delete an extension pool by ID |
| [**DeleteTelephonyProvidersEdgesPhone**](#DeleteTelephonyProvidersEdgesPhone) | **Delete** /api/v2/telephony/providers/edges/phones/{phoneId} | Delete a Phone by ID |
| [**DeleteTelephonyProvidersEdgesPhonebasesetting**](#DeleteTelephonyProvidersEdgesPhonebasesetting) | **Delete** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Delete a Phone Base Settings by ID |
| [**DeleteTelephonyProvidersEdgesSite**](#DeleteTelephonyProvidersEdgesSite) | **Delete** /api/v2/telephony/providers/edges/sites/{siteId} | Delete a Site by ID |
| [**DeleteTelephonyProvidersEdgesSiteOutboundroute**](#DeleteTelephonyProvidersEdgesSiteOutboundroute) | **Delete** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes/{outboundRouteId} | Delete Outbound Route |
| [**DeleteTelephonyProvidersEdgesTrunkbasesetting**](#DeleteTelephonyProvidersEdgesTrunkbasesetting) | **Delete** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Delete a Trunk Base Settings object by ID |
| [**GetTelephonyProvidersEdge**](#GetTelephonyProvidersEdge) | **Get** /api/v2/telephony/providers/edges/{edgeId} | Get edge. |
| [**GetTelephonyProvidersEdgeDiagnosticNslookup**](#GetTelephonyProvidersEdgeDiagnosticNslookup) | **Get** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/nslookup | Get networking-related information from an Edge for a target IP or host. |
| [**GetTelephonyProvidersEdgeDiagnosticPing**](#GetTelephonyProvidersEdgeDiagnosticPing) | **Get** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/ping | Get networking-related information from an Edge for a target IP or host. |
| [**GetTelephonyProvidersEdgeDiagnosticRoute**](#GetTelephonyProvidersEdgeDiagnosticRoute) | **Get** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/route | Get networking-related information from an Edge for a target IP or host. |
| [**GetTelephonyProvidersEdgeDiagnosticTracepath**](#GetTelephonyProvidersEdgeDiagnosticTracepath) | **Get** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/tracepath | Get networking-related information from an Edge for a target IP or host. |
| [**GetTelephonyProvidersEdgeLogicalinterface**](#GetTelephonyProvidersEdgeLogicalinterface) | **Get** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Get an edge logical interface |
| [**GetTelephonyProvidersEdgeLogicalinterfaces**](#GetTelephonyProvidersEdgeLogicalinterfaces) | **Get** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Get edge logical interfaces. |
| [**GetTelephonyProvidersEdgeLogsJob**](#GetTelephonyProvidersEdgeLogsJob) | **Get** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId} | Get an Edge logs job. |
| [**GetTelephonyProvidersEdgeMetrics**](#GetTelephonyProvidersEdgeMetrics) | **Get** /api/v2/telephony/providers/edges/{edgeId}/metrics | Get the edge metrics. |
| [**GetTelephonyProvidersEdgePhysicalinterface**](#GetTelephonyProvidersEdgePhysicalinterface) | **Get** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces/{interfaceId} | Get edge physical interface. |
| [**GetTelephonyProvidersEdgePhysicalinterfaces**](#GetTelephonyProvidersEdgePhysicalinterfaces) | **Get** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces | Retrieve a list of all configured physical interfaces from a specific edge. |
| [**GetTelephonyProvidersEdgeSetuppackage**](#GetTelephonyProvidersEdgeSetuppackage) | **Get** /api/v2/telephony/providers/edges/{edgeId}/setuppackage | Get the setup package for a locally deployed edge device. This is needed to complete the setup process for the virtual edge. |
| [**GetTelephonyProvidersEdgeSoftwareupdate**](#GetTelephonyProvidersEdgeSoftwareupdate) | **Get** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Gets software update status information about any edge. |
| [**GetTelephonyProvidersEdgeSoftwareversions**](#GetTelephonyProvidersEdgeSoftwareversions) | **Get** /api/v2/telephony/providers/edges/{edgeId}/softwareversions | Gets all the available software versions for this edge. |
| [**GetTelephonyProvidersEdgeTrunks**](#GetTelephonyProvidersEdgeTrunks) | **Get** /api/v2/telephony/providers/edges/{edgeId}/trunks | Get the list of available trunks for the given Edge. |
| [**GetTelephonyProvidersEdges**](#GetTelephonyProvidersEdges) | **Get** /api/v2/telephony/providers/edges | Get the list of edges. |
| [**GetTelephonyProvidersEdgesAlertablepresences**](#GetTelephonyProvidersEdgesAlertablepresences) | **Get** /api/v2/telephony/providers/edges/alertablepresences | Get the list alertable presences. The &#39;type&#39; query parameter can be used to If there are any overrides, this is the list of overrides; if there are no overrides, it is the default list. |
| [**GetTelephonyProvidersEdgesCertificateauthorities**](#GetTelephonyProvidersEdgesCertificateauthorities) | **Get** /api/v2/telephony/providers/edges/certificateauthorities | Get the list of certificate authorities. |
| [**GetTelephonyProvidersEdgesCertificateauthority**](#GetTelephonyProvidersEdgesCertificateauthority) | **Get** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Get a certificate authority. |
| [**GetTelephonyProvidersEdgesDid**](#GetTelephonyProvidersEdgesDid) | **Get** /api/v2/telephony/providers/edges/dids/{didId} | Get a DID by ID. |
| [**GetTelephonyProvidersEdgesDidpool**](#GetTelephonyProvidersEdgesDidpool) | **Get** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Get a DID Pool by ID. |
| [**GetTelephonyProvidersEdgesDidpools**](#GetTelephonyProvidersEdgesDidpools) | **Get** /api/v2/telephony/providers/edges/didpools | Get a listing of DID Pools |
| [**GetTelephonyProvidersEdgesDidpoolsDids**](#GetTelephonyProvidersEdgesDidpoolsDids) | **Get** /api/v2/telephony/providers/edges/didpools/dids | Get a listing of unassigned and/or assigned numbers in a set of DID Pools. |
| [**GetTelephonyProvidersEdgesDids**](#GetTelephonyProvidersEdgesDids) | **Get** /api/v2/telephony/providers/edges/dids | Get a listing of DIDs |
| [**GetTelephonyProvidersEdgesEdgegroup**](#GetTelephonyProvidersEdgesEdgegroup) | **Get** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Get edge group. |
| [**GetTelephonyProvidersEdgesEdgegroupEdgetrunkbase**](#GetTelephonyProvidersEdgesEdgegroupEdgetrunkbase) | **Get** /api/v2/telephony/providers/edges/edgegroups/{edgegroupId}/edgetrunkbases/{edgetrunkbaseId} | Gets the edge trunk base associated with the edge group |
| [**GetTelephonyProvidersEdgesEdgegroups**](#GetTelephonyProvidersEdgesEdgegroups) | **Get** /api/v2/telephony/providers/edges/edgegroups | Get the list of edge groups. |
| [**GetTelephonyProvidersEdgesEdgeversionreport**](#GetTelephonyProvidersEdgesEdgeversionreport) | **Get** /api/v2/telephony/providers/edges/edgeversionreport | Get the edge version report. |
| [**GetTelephonyProvidersEdgesExpired**](#GetTelephonyProvidersEdgesExpired) | **Get** /api/v2/telephony/providers/edges/expired | List of edges more than 4 edge versions behind the latest software. |
| [**GetTelephonyProvidersEdgesExtension**](#GetTelephonyProvidersEdgesExtension) | **Get** /api/v2/telephony/providers/edges/extensions/{extensionId} | Get an extension by ID. |
| [**GetTelephonyProvidersEdgesExtensionpool**](#GetTelephonyProvidersEdgesExtensionpool) | **Get** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Get an extension pool by ID |
| [**GetTelephonyProvidersEdgesExtensionpools**](#GetTelephonyProvidersEdgesExtensionpools) | **Get** /api/v2/telephony/providers/edges/extensionpools | Get a listing of extension pools |
| [**GetTelephonyProvidersEdgesExtensionpoolsDivisionviews**](#GetTelephonyProvidersEdgesExtensionpoolsDivisionviews) | **Get** /api/v2/telephony/providers/edges/extensionpools/divisionviews | Get a pageable list of basic extension pool objects filterable by query parameters. |
| [**GetTelephonyProvidersEdgesExtensions**](#GetTelephonyProvidersEdgesExtensions) | **Get** /api/v2/telephony/providers/edges/extensions | Get a listing of extensions |
| [**GetTelephonyProvidersEdgesLine**](#GetTelephonyProvidersEdgesLine) | **Get** /api/v2/telephony/providers/edges/lines/{lineId} | Get a Line by ID |
| [**GetTelephonyProvidersEdgesLinebasesetting**](#GetTelephonyProvidersEdgesLinebasesetting) | **Get** /api/v2/telephony/providers/edges/linebasesettings/{lineBaseId} | Get a line base settings object by ID |
| [**GetTelephonyProvidersEdgesLinebasesettings**](#GetTelephonyProvidersEdgesLinebasesettings) | **Get** /api/v2/telephony/providers/edges/linebasesettings | Get a listing of line base settings objects |
| [**GetTelephonyProvidersEdgesLines**](#GetTelephonyProvidersEdgesLines) | **Get** /api/v2/telephony/providers/edges/lines | Get a list of Lines |
| [**GetTelephonyProvidersEdgesLinesTemplate**](#GetTelephonyProvidersEdgesLinesTemplate) | **Get** /api/v2/telephony/providers/edges/lines/template | Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance |
| [**GetTelephonyProvidersEdgesLogicalinterfaces**](#GetTelephonyProvidersEdgesLogicalinterfaces) | **Get** /api/v2/telephony/providers/edges/logicalinterfaces | Get edge logical interfaces. |
| [**GetTelephonyProvidersEdgesMediastatisticsConversation**](#GetTelephonyProvidersEdgesMediastatisticsConversation) | **Get** /api/v2/telephony/providers/edges/mediastatistics/conversations/{conversationId} | Get media endpoint statistics events. |
| [**GetTelephonyProvidersEdgesMediastatisticsConversationCommunication**](#GetTelephonyProvidersEdgesMediastatisticsConversationCommunication) | **Get** /api/v2/telephony/providers/edges/mediastatistics/conversations/{conversationId}/communications/{communicationId} | Get media endpoint statistics event. |
| [**GetTelephonyProvidersEdgesMetrics**](#GetTelephonyProvidersEdgesMetrics) | **Get** /api/v2/telephony/providers/edges/metrics | Get the metrics for a list of edges. |
| [**GetTelephonyProvidersEdgesOutboundroutes**](#GetTelephonyProvidersEdgesOutboundroutes) | **Get** /api/v2/telephony/providers/edges/outboundroutes | Get outbound routes |
| [**GetTelephonyProvidersEdgesPhone**](#GetTelephonyProvidersEdgesPhone) | **Get** /api/v2/telephony/providers/edges/phones/{phoneId} | Get a Phone by ID |
| [**GetTelephonyProvidersEdgesPhonebasesetting**](#GetTelephonyProvidersEdgesPhonebasesetting) | **Get** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Get a Phone Base Settings object by ID |
| [**GetTelephonyProvidersEdgesPhonebasesettings**](#GetTelephonyProvidersEdgesPhonebasesettings) | **Get** /api/v2/telephony/providers/edges/phonebasesettings | Get a list of Phone Base Settings objects |
| [**GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases**](#GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases) | **Get** /api/v2/telephony/providers/edges/phonebasesettings/availablemetabases | Get a list of available makes and models to create a new Phone Base Settings |
| [**GetTelephonyProvidersEdgesPhonebasesettingsTemplate**](#GetTelephonyProvidersEdgesPhonebasesettingsTemplate) | **Get** /api/v2/telephony/providers/edges/phonebasesettings/template | Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance |
| [**GetTelephonyProvidersEdgesPhones**](#GetTelephonyProvidersEdgesPhones) | **Get** /api/v2/telephony/providers/edges/phones | Get a list of Phone Instances. A maximum of 10,000 results is returned when filtering the results or sorting by a field other than the ID. Sorting by only the ID has no result limit. Each filter supports a wildcard, *, as a value to search for partial values. |
| [**GetTelephonyProvidersEdgesPhonesTemplate**](#GetTelephonyProvidersEdgesPhonesTemplate) | **Get** /api/v2/telephony/providers/edges/phones/template | Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance |
| [**GetTelephonyProvidersEdgesPhysicalinterfaces**](#GetTelephonyProvidersEdgesPhysicalinterfaces) | **Get** /api/v2/telephony/providers/edges/physicalinterfaces | Get physical interfaces for edges. |
| [**GetTelephonyProvidersEdgesSite**](#GetTelephonyProvidersEdgesSite) | **Get** /api/v2/telephony/providers/edges/sites/{siteId} | Get a Site by ID. |
| [**GetTelephonyProvidersEdgesSiteNumberplan**](#GetTelephonyProvidersEdgesSiteNumberplan) | **Get** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/{numberPlanId} | Get a Number Plan by ID. |
| [**GetTelephonyProvidersEdgesSiteNumberplans**](#GetTelephonyProvidersEdgesSiteNumberplans) | **Get** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Get the list of Number Plans for this Site. Only fetches the first 200 records. |
| [**GetTelephonyProvidersEdgesSiteNumberplansClassifications**](#GetTelephonyProvidersEdgesSiteNumberplansClassifications) | **Get** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/classifications | Get a list of Classifications for this Site |
| [**GetTelephonyProvidersEdgesSiteOutboundroute**](#GetTelephonyProvidersEdgesSiteOutboundroute) | **Get** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes/{outboundRouteId} | Get an outbound route |
| [**GetTelephonyProvidersEdgesSiteOutboundroutes**](#GetTelephonyProvidersEdgesSiteOutboundroutes) | **Get** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes | Get outbound routes |
| [**GetTelephonyProvidersEdgesSiteSiteconnections**](#GetTelephonyProvidersEdgesSiteSiteconnections) | **Get** /api/v2/telephony/providers/edges/sites/{siteId}/siteconnections | Get site connections for a site. |
| [**GetTelephonyProvidersEdgesSites**](#GetTelephonyProvidersEdgesSites) | **Get** /api/v2/telephony/providers/edges/sites | Get the list of Sites. |
| [**GetTelephonyProvidersEdgesTimezones**](#GetTelephonyProvidersEdgesTimezones) | **Get** /api/v2/telephony/providers/edges/timezones | Get a list of Edge-compatible time zones |
| [**GetTelephonyProvidersEdgesTrunk**](#GetTelephonyProvidersEdgesTrunk) | **Get** /api/v2/telephony/providers/edges/trunks/{trunkId} | Get a Trunk by ID |
| [**GetTelephonyProvidersEdgesTrunkMetrics**](#GetTelephonyProvidersEdgesTrunkMetrics) | **Get** /api/v2/telephony/providers/edges/trunks/{trunkId}/metrics | Get the trunk metrics. |
| [**GetTelephonyProvidersEdgesTrunkbasesetting**](#GetTelephonyProvidersEdgesTrunkbasesetting) | **Get** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Get a Trunk Base Settings object by ID |
| [**GetTelephonyProvidersEdgesTrunkbasesettings**](#GetTelephonyProvidersEdgesTrunkbasesettings) | **Get** /api/v2/telephony/providers/edges/trunkbasesettings | Get Trunk Base Settings listing |
| [**GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases**](#GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases) | **Get** /api/v2/telephony/providers/edges/trunkbasesettings/availablemetabases | Get a list of available makes and models to create a new Trunk Base Settings |
| [**GetTelephonyProvidersEdgesTrunkbasesettingsTemplate**](#GetTelephonyProvidersEdgesTrunkbasesettingsTemplate) | **Get** /api/v2/telephony/providers/edges/trunkbasesettings/template | Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance |
| [**GetTelephonyProvidersEdgesTrunks**](#GetTelephonyProvidersEdgesTrunks) | **Get** /api/v2/telephony/providers/edges/trunks | Get the list of available trunks. |
| [**GetTelephonyProvidersEdgesTrunksMetrics**](#GetTelephonyProvidersEdgesTrunksMetrics) | **Get** /api/v2/telephony/providers/edges/trunks/metrics | Get the metrics for a list of trunks. |
| [**GetTelephonyProvidersEdgesTrunkswithrecording**](#GetTelephonyProvidersEdgesTrunkswithrecording) | **Get** /api/v2/telephony/providers/edges/trunkswithrecording | Get Counts of trunks that have recording disabled or enabled |
| [**PatchTelephonyProvidersEdgesSiteSiteconnections**](#PatchTelephonyProvidersEdgesSiteSiteconnections) | **Patch** /api/v2/telephony/providers/edges/sites/{siteId}/siteconnections | Disable site connections for a site. |
| [**PostTelephonyProvidersEdgeDiagnosticNslookup**](#PostTelephonyProvidersEdgeDiagnosticNslookup) | **Post** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/nslookup | Nslookup request command to collect networking-related information from an Edge for a target IP or host. |
| [**PostTelephonyProvidersEdgeDiagnosticPing**](#PostTelephonyProvidersEdgeDiagnosticPing) | **Post** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/ping | Ping Request command to collect networking-related information from an Edge for a target IP or host. |
| [**PostTelephonyProvidersEdgeDiagnosticRoute**](#PostTelephonyProvidersEdgeDiagnosticRoute) | **Post** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/route | Route request command to collect networking-related information from an Edge for a target IP or host. |
| [**PostTelephonyProvidersEdgeDiagnosticTracepath**](#PostTelephonyProvidersEdgeDiagnosticTracepath) | **Post** /api/v2/telephony/providers/edges/{edgeId}/diagnostic/tracepath | Tracepath request command to collect networking-related information from an Edge for a target IP or host. |
| [**PostTelephonyProvidersEdgeLogicalinterfaces**](#PostTelephonyProvidersEdgeLogicalinterfaces) | **Post** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Create an edge logical interface. |
| [**PostTelephonyProvidersEdgeLogsJobUpload**](#PostTelephonyProvidersEdgeLogsJobUpload) | **Post** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId}/upload | Request that the specified fileIds be uploaded from the Edge. |
| [**PostTelephonyProvidersEdgeLogsJobs**](#PostTelephonyProvidersEdgeLogsJobs) | **Post** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs | Create a job to upload a list of Edge logs. |
| [**PostTelephonyProvidersEdgeReboot**](#PostTelephonyProvidersEdgeReboot) | **Post** /api/v2/telephony/providers/edges/{edgeId}/reboot | Reboot an Edge |
| [**PostTelephonyProvidersEdgeSoftwareupdate**](#PostTelephonyProvidersEdgeSoftwareupdate) | **Post** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Starts a software update for this edge. |
| [**PostTelephonyProvidersEdgeStatuscode**](#PostTelephonyProvidersEdgeStatuscode) | **Post** /api/v2/telephony/providers/edges/{edgeId}/statuscode | Take an Edge in or out of service |
| [**PostTelephonyProvidersEdgeUnpair**](#PostTelephonyProvidersEdgeUnpair) | **Post** /api/v2/telephony/providers/edges/{edgeId}/unpair | Unpair an Edge |
| [**PostTelephonyProvidersEdges**](#PostTelephonyProvidersEdges) | **Post** /api/v2/telephony/providers/edges | Create an edge. |
| [**PostTelephonyProvidersEdgesAddressvalidation**](#PostTelephonyProvidersEdgesAddressvalidation) | **Post** /api/v2/telephony/providers/edges/addressvalidation | Validates a street address |
| [**PostTelephonyProvidersEdgesCertificateauthorities**](#PostTelephonyProvidersEdgesCertificateauthorities) | **Post** /api/v2/telephony/providers/edges/certificateauthorities | Create a certificate authority. |
| [**PostTelephonyProvidersEdgesDidpools**](#PostTelephonyProvidersEdgesDidpools) | **Post** /api/v2/telephony/providers/edges/didpools | Create a new DID pool |
| [**PostTelephonyProvidersEdgesEdgegroups**](#PostTelephonyProvidersEdgesEdgegroups) | **Post** /api/v2/telephony/providers/edges/edgegroups | Create an edge group. |
| [**PostTelephonyProvidersEdgesExtensionpools**](#PostTelephonyProvidersEdgesExtensionpools) | **Post** /api/v2/telephony/providers/edges/extensionpools | Create a new extension pool |
| [**PostTelephonyProvidersEdgesPhoneReboot**](#PostTelephonyProvidersEdgesPhoneReboot) | **Post** /api/v2/telephony/providers/edges/phones/{phoneId}/reboot | Reboot a Phone |
| [**PostTelephonyProvidersEdgesPhonebasesettings**](#PostTelephonyProvidersEdgesPhonebasesettings) | **Post** /api/v2/telephony/providers/edges/phonebasesettings | Create a new Phone Base Settings object |
| [**PostTelephonyProvidersEdgesPhones**](#PostTelephonyProvidersEdgesPhones) | **Post** /api/v2/telephony/providers/edges/phones | Create a new Phone |
| [**PostTelephonyProvidersEdgesPhonesReboot**](#PostTelephonyProvidersEdgesPhonesReboot) | **Post** /api/v2/telephony/providers/edges/phones/reboot | Reboot Multiple Phones |
| [**PostTelephonyProvidersEdgesSiteOutboundroutes**](#PostTelephonyProvidersEdgesSiteOutboundroutes) | **Post** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes | Create outbound route |
| [**PostTelephonyProvidersEdgesSites**](#PostTelephonyProvidersEdgesSites) | **Post** /api/v2/telephony/providers/edges/sites | Create a Site. |
| [**PostTelephonyProvidersEdgesTrunkbasesettings**](#PostTelephonyProvidersEdgesTrunkbasesettings) | **Post** /api/v2/telephony/providers/edges/trunkbasesettings | Create a Trunk Base Settings object |
| [**PutTelephonyProvidersEdge**](#PutTelephonyProvidersEdge) | **Put** /api/v2/telephony/providers/edges/{edgeId} | Update a edge. |
| [**PutTelephonyProvidersEdgeLogicalinterface**](#PutTelephonyProvidersEdgeLogicalinterface) | **Put** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Update an edge logical interface. |
| [**PutTelephonyProvidersEdgesAlertablepresences**](#PutTelephonyProvidersEdgesAlertablepresences) | **Put** /api/v2/telephony/providers/edges/alertablepresences | Creates or updates alertable presences overrides. |
| [**PutTelephonyProvidersEdgesCertificateauthority**](#PutTelephonyProvidersEdgesCertificateauthority) | **Put** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Update a certificate authority. |
| [**PutTelephonyProvidersEdgesDidpool**](#PutTelephonyProvidersEdgesDidpool) | **Put** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Update a DID Pool by ID. |
| [**PutTelephonyProvidersEdgesEdgegroup**](#PutTelephonyProvidersEdgesEdgegroup) | **Put** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Update an edge group. |
| [**PutTelephonyProvidersEdgesEdgegroupEdgetrunkbase**](#PutTelephonyProvidersEdgesEdgegroupEdgetrunkbase) | **Put** /api/v2/telephony/providers/edges/edgegroups/{edgegroupId}/edgetrunkbases/{edgetrunkbaseId} | Update the edge trunk base associated with the edge group |
| [**PutTelephonyProvidersEdgesExtensionpool**](#PutTelephonyProvidersEdgesExtensionpool) | **Put** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Update an extension pool by ID |
| [**PutTelephonyProvidersEdgesPhone**](#PutTelephonyProvidersEdgesPhone) | **Put** /api/v2/telephony/providers/edges/phones/{phoneId} | Update a Phone by ID |
| [**PutTelephonyProvidersEdgesPhonebasesetting**](#PutTelephonyProvidersEdgesPhonebasesetting) | **Put** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Update a Phone Base Settings by ID |
| [**PutTelephonyProvidersEdgesSite**](#PutTelephonyProvidersEdgesSite) | **Put** /api/v2/telephony/providers/edges/sites/{siteId} | Update a Site by ID. |
| [**PutTelephonyProvidersEdgesSiteNumberplans**](#PutTelephonyProvidersEdgesSiteNumberplans) | **Put** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Update the list of Number Plans. A user can update maximum 200 number plans at a time. |
| [**PutTelephonyProvidersEdgesSiteOutboundroute**](#PutTelephonyProvidersEdgesSiteOutboundroute) | **Put** /api/v2/telephony/providers/edges/sites/{siteId}/outboundroutes/{outboundRouteId} | Update outbound route |
| [**PutTelephonyProvidersEdgesSiteSiteconnections**](#PutTelephonyProvidersEdgesSiteSiteconnections) | **Put** /api/v2/telephony/providers/edges/sites/{siteId}/siteconnections | Update site connections for a site. |
| [**PutTelephonyProvidersEdgesTrunkbasesetting**](#PutTelephonyProvidersEdgesTrunkbasesetting) | **Put** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Update a Trunk Base Settings object by ID |



## DeleteTelephonyProvidersEdge

> void DeleteTelephonyProvidersEdge (string edgeId)


Delete a edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            { 
                // Delete a edge.
                apiInstance.DeleteTelephonyProvidersEdge(edgeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdge: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgeLogicalinterface

> void DeleteTelephonyProvidersEdgeLogicalinterface (string edgeId, string interfaceId)


Delete an edge logical interface

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            { 
                // Delete an edge logical interface
                apiInstance.DeleteTelephonyProvidersEdgeLogicalinterface(edgeId, interfaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgeLogicalinterface: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgeSoftwareupdate

> void DeleteTelephonyProvidersEdgeSoftwareupdate (string edgeId)


Cancels any in-progress update for this edge.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgeSoftwareupdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            { 
                // Cancels any in-progress update for this edge.
                apiInstance.DeleteTelephonyProvidersEdgeSoftwareupdate(edgeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgeSoftwareupdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesAlertablepresences

> void DeleteTelephonyProvidersEdgesAlertablepresences ()


Deletes alertable presences overrides.

Requires ANY permissions: 

* telephony:alertablePresences:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesAlertablepresencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            { 
                // Deletes alertable presences overrides.
                apiInstance.DeleteTelephonyProvidersEdgesAlertablepresences();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesAlertablepresences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesCertificateauthority

> void DeleteTelephonyProvidersEdgesCertificateauthority (string certificateId)


Delete a certificate authority.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesCertificateauthorityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            { 
                // Delete a certificate authority.
                apiInstance.DeleteTelephonyProvidersEdgesCertificateauthority(certificateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesCertificateauthority: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesDidpool

> void DeleteTelephonyProvidersEdgesDidpool (string didPoolId)


Delete a DID Pool by ID.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesDidpoolExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            { 
                // Delete a DID Pool by ID.
                apiInstance.DeleteTelephonyProvidersEdgesDidpool(didPoolId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesDidpool: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesEdgegroup

> void DeleteTelephonyProvidersEdgesEdgegroup (string edgeGroupId)


Delete an edge group.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesEdgegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID

            try
            { 
                // Delete an edge group.
                apiInstance.DeleteTelephonyProvidersEdgesEdgegroup(edgeGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesExtensionpool

> void DeleteTelephonyProvidersEdgesExtensionpool (string extensionPoolId)


Delete an extension pool by ID

Requires ALL permissions: 

* telephony:extensionPool:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesExtensionpoolExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            { 
                // Delete an extension pool by ID
                apiInstance.DeleteTelephonyProvidersEdgesExtensionpool(extensionPoolId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesExtensionpool: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesPhone

> void DeleteTelephonyProvidersEdgesPhone (string phoneId)


Delete a Phone by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesPhoneExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID

            try
            { 
                // Delete a Phone by ID
                apiInstance.DeleteTelephonyProvidersEdgesPhone(phoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesPhonebasesetting

> void DeleteTelephonyProvidersEdgesPhonebasesetting (string phoneBaseId)


Delete a Phone Base Settings by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesPhonebasesettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID

            try
            { 
                // Delete a Phone Base Settings by ID
                apiInstance.DeleteTelephonyProvidersEdgesPhonebasesetting(phoneBaseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesPhonebasesetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesSite

> void DeleteTelephonyProvidersEdgesSite (string siteId)


Delete a Site by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesSiteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            { 
                // Delete a Site by ID
                apiInstance.DeleteTelephonyProvidersEdgesSite(siteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesSite: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesSiteOutboundroute

> void DeleteTelephonyProvidersEdgesSiteOutboundroute (string siteId, string outboundRouteId)


Delete Outbound Route

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesSiteOutboundrouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            { 
                // Delete Outbound Route
                apiInstance.DeleteTelephonyProvidersEdgesSiteOutboundroute(siteId, outboundRouteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesSiteOutboundroute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **outboundRouteId** | **string**| Outbound route ID |  |

### Return type

void (empty response body)


## DeleteTelephonyProvidersEdgesTrunkbasesetting

> void DeleteTelephonyProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId)


Delete a Trunk Base Settings object by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTelephonyProvidersEdgesTrunkbasesettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID

            try
            { 
                // Delete a Trunk Base Settings object by ID
                apiInstance.DeleteTelephonyProvidersEdgesTrunkbasesetting(trunkBaseSettingsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteTelephonyProvidersEdgesTrunkbasesetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |

### Return type

void (empty response body)


## GetTelephonyProvidersEdge

> [**Edge**](Edge) GetTelephonyProvidersEdge (string edgeId, List<string> expand = null)


Get edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 

            try
            { 
                // Get edge.
                Edge result = apiInstance.GetTelephonyProvidersEdge(edgeId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdge: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **expand** | [**List<string>**](string)| Fields to expand in the response, comma-separated | [optional] <br />**Values**: site |

### Return type

[**Edge**](Edge)


## GetTelephonyProvidersEdgeDiagnosticNslookup

> [**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse) GetTelephonyProvidersEdgeDiagnosticNslookup (string edgeId)


Get networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeDiagnosticNslookupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            { 
                // Get networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnosticResponse result = apiInstance.GetTelephonyProvidersEdgeDiagnosticNslookup(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeDiagnosticNslookup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |

### Return type

[**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse)


## GetTelephonyProvidersEdgeDiagnosticPing

> [**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse) GetTelephonyProvidersEdgeDiagnosticPing (string edgeId)


Get networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeDiagnosticPingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            { 
                // Get networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnosticResponse result = apiInstance.GetTelephonyProvidersEdgeDiagnosticPing(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeDiagnosticPing: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |

### Return type

[**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse)


## GetTelephonyProvidersEdgeDiagnosticRoute

> [**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse) GetTelephonyProvidersEdgeDiagnosticRoute (string edgeId)


Get networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeDiagnosticRouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            { 
                // Get networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnosticResponse result = apiInstance.GetTelephonyProvidersEdgeDiagnosticRoute(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeDiagnosticRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |

### Return type

[**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse)


## GetTelephonyProvidersEdgeDiagnosticTracepath

> [**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse) GetTelephonyProvidersEdgeDiagnosticTracepath (string edgeId)


Get networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeDiagnosticTracepathExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            { 
                // Get networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnosticResponse result = apiInstance.GetTelephonyProvidersEdgeDiagnosticTracepath(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeDiagnosticTracepath: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |

### Return type

[**EdgeNetworkDiagnosticResponse**](EdgeNetworkDiagnosticResponse)


## GetTelephonyProvidersEdgeLogicalinterface

> [**DomainLogicalInterface**](DomainLogicalInterface) GetTelephonyProvidersEdgeLogicalinterface (string edgeId, string interfaceId, List<string> expand = null)


Get an edge logical interface

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            { 
                // Get an edge logical interface
                DomainLogicalInterface result = apiInstance.GetTelephonyProvidersEdgeLogicalinterface(edgeId, interfaceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLogicalinterface: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
| **expand** | [**List<string>**](string)| Field to expand in the response | [optional] <br />**Values**: externalTrunkBaseAssignments, phoneTrunkBaseAssignments |

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface)


## GetTelephonyProvidersEdgeLogicalinterfaces

> [**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing) GetTelephonyProvidersEdgeLogicalinterfaces (string edgeId, List<string> expand = null)


Get edge logical interfaces.

Retrieve a list of all configured logical interfaces from a specific edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLogicalinterfacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            { 
                // Get edge logical interfaces.
                LogicalInterfaceEntityListing result = apiInstance.GetTelephonyProvidersEdgeLogicalinterfaces(edgeId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLogicalinterfaces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **expand** | [**List<string>**](string)| Field to expand in the response | [optional] <br />**Values**: externalTrunkBaseAssignments, phoneTrunkBaseAssignments |

### Return type

[**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing)


## GetTelephonyProvidersEdgeLogsJob

> [**EdgeLogsJob**](EdgeLogsJob) GetTelephonyProvidersEdgeLogsJob (string edgeId, string jobId)


Get an Edge logs job.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeLogsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var jobId = jobId_example;  // string | Job ID

            try
            { 
                // Get an Edge logs job.
                EdgeLogsJob result = apiInstance.GetTelephonyProvidersEdgeLogsJob(edgeId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeLogsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **jobId** | **string**| Job ID |  |

### Return type

[**EdgeLogsJob**](EdgeLogsJob)


## GetTelephonyProvidersEdgeMetrics

> [**EdgeMetrics**](EdgeMetrics) GetTelephonyProvidersEdgeMetrics (string edgeId)


Get the edge metrics.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeMetricsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            { 
                // Get the edge metrics.
                EdgeMetrics result = apiInstance.GetTelephonyProvidersEdgeMetrics(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |

### Return type

[**EdgeMetrics**](EdgeMetrics)


## GetTelephonyProvidersEdgePhysicalinterface

> [**DomainPhysicalInterface**](DomainPhysicalInterface) GetTelephonyProvidersEdgePhysicalinterface (string edgeId, string interfaceId)


Get edge physical interface.

Retrieve a physical interface from a specific edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgePhysicalinterfaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            { 
                // Get edge physical interface.
                DomainPhysicalInterface result = apiInstance.GetTelephonyProvidersEdgePhysicalinterface(edgeId, interfaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgePhysicalinterface: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |

### Return type

[**DomainPhysicalInterface**](DomainPhysicalInterface)


## GetTelephonyProvidersEdgePhysicalinterfaces

> [**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing) GetTelephonyProvidersEdgePhysicalinterfaces (string edgeId)


Retrieve a list of all configured physical interfaces from a specific edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgePhysicalinterfacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            { 
                // Retrieve a list of all configured physical interfaces from a specific edge.
                PhysicalInterfaceEntityListing result = apiInstance.GetTelephonyProvidersEdgePhysicalinterfaces(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgePhysicalinterfaces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |

### Return type

[**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing)


## GetTelephonyProvidersEdgeSetuppackage

> [**VmPairingInfo**](VmPairingInfo) GetTelephonyProvidersEdgeSetuppackage (string edgeId)


Get the setup package for a locally deployed edge device. This is needed to complete the setup process for the virtual edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeSetuppackageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            { 
                // Get the setup package for a locally deployed edge device. This is needed to complete the setup process for the virtual edge.
                VmPairingInfo result = apiInstance.GetTelephonyProvidersEdgeSetuppackage(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeSetuppackage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |

### Return type

[**VmPairingInfo**](VmPairingInfo)


## GetTelephonyProvidersEdgeSoftwareupdate

> [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto) GetTelephonyProvidersEdgeSoftwareupdate (string edgeId)


Gets software update status information about any edge.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeSoftwareupdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            { 
                // Gets software update status information about any edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.GetTelephonyProvidersEdgeSoftwareupdate(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeSoftwareupdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto)


## GetTelephonyProvidersEdgeSoftwareversions

> [**DomainEdgeSoftwareVersionDtoEntityListing**](DomainEdgeSoftwareVersionDtoEntityListing) GetTelephonyProvidersEdgeSoftwareversions (string edgeId)


Gets all the available software versions for this edge.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeSoftwareversionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            { 
                // Gets all the available software versions for this edge.
                DomainEdgeSoftwareVersionDtoEntityListing result = apiInstance.GetTelephonyProvidersEdgeSoftwareversions(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeSoftwareversions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |

### Return type

[**DomainEdgeSoftwareVersionDtoEntityListing**](DomainEdgeSoftwareVersionDtoEntityListing)


## GetTelephonyProvidersEdgeTrunks

> [**TrunkEntityListing**](TrunkEntityListing) GetTelephonyProvidersEdgeTrunks (string edgeId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string trunkBaseId = null, string trunkType = null)


Get the list of available trunks for the given Edge.

Trunks are created by assigning trunk base settings to an Edge or Edge Group.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgeTrunksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var trunkBaseId = trunkBaseId_example;  // string | Filter by Trunk Base Ids (optional) 
            var trunkType = trunkType_example;  // string | Filter by a Trunk type (optional) 

            try
            { 
                // Get the list of available trunks for the given Edge.
                TrunkEntityListing result = apiInstance.GetTelephonyProvidersEdgeTrunks(edgeId, pageNumber, pageSize, sortBy, sortOrder, trunkBaseId, trunkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgeTrunks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **trunkBaseId** | **string**| Filter by Trunk Base Ids | [optional]  |
| **trunkType** | **string**| Filter by a Trunk type | [optional] <br />**Values**: EXTERNAL, PHONE, EDGE |

### Return type

[**TrunkEntityListing**](TrunkEntityListing)


## GetTelephonyProvidersEdges

> [**EdgeEntityListing**](EdgeEntityListing) GetTelephonyProvidersEdges (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null, bool? managed = null, bool? showCloudMedia = null)


Get the list of edges.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var edgeGroupId = edgeGroupId_example;  // string | Filter by edgeGroup.id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var managed = true;  // bool? | Filter by managed (optional) 
            var showCloudMedia = true;  // bool? | True to show the cloud media devices in the result. (optional)  (default to true)

            try
            { 
                // Get the list of edges.
                EdgeEntityListing result = apiInstance.GetTelephonyProvidersEdges(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy, managed, showCloudMedia);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdges: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **edgeGroupId** | **string**| Filter by edgeGroup.id | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **managed** | **bool?**| Filter by managed | [optional]  |
| **showCloudMedia** | **bool?**| True to show the cloud media devices in the result. | [optional] [default to true] |

### Return type

[**EdgeEntityListing**](EdgeEntityListing)


## GetTelephonyProvidersEdgesAlertablepresences

> [**AlertablePresences**](AlertablePresences) GetTelephonyProvidersEdgesAlertablepresences (string type = null)


Get the list alertable presences. The 'type' query parameter can be used to If there are any overrides, this is the list of overrides; if there are no overrides, it is the default list.

Requires ANY permissions: 

* telephony:alertablePresences:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesAlertablepresencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var type = type_example;  // string |  (optional) 

            try
            { 
                // Get the list alertable presences. The 'type' query parameter can be used to If there are any overrides, this is the list of overrides; if there are no overrides, it is the default list.
                AlertablePresences result = apiInstance.GetTelephonyProvidersEdgesAlertablepresences(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesAlertablepresences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**|  | [optional] <br />**Values**: defaults, overrides |

### Return type

[**AlertablePresences**](AlertablePresences)


## GetTelephonyProvidersEdgesCertificateauthorities

> [**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing) GetTelephonyProvidersEdgesCertificateauthorities ()


Get the list of certificate authorities.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesCertificateauthoritiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            { 
                // Get the list of certificate authorities.
                CertificateAuthorityEntityListing result = apiInstance.GetTelephonyProvidersEdgesCertificateauthorities();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesCertificateauthorities: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing)


## GetTelephonyProvidersEdgesCertificateauthority

> [**DomainCertificateAuthority**](DomainCertificateAuthority) GetTelephonyProvidersEdgesCertificateauthority (string certificateId)


Get a certificate authority.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesCertificateauthorityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            { 
                // Get a certificate authority.
                DomainCertificateAuthority result = apiInstance.GetTelephonyProvidersEdgesCertificateauthority(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesCertificateauthority: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority)


## GetTelephonyProvidersEdgesDid

> [**DID**](DID) GetTelephonyProvidersEdgesDid (string didId)


Get a DID by ID.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didId = didId_example;  // string | DID ID

            try
            { 
                // Get a DID by ID.
                DID result = apiInstance.GetTelephonyProvidersEdgesDid(didId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDid: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |

### Return type

[**DID**](DID)


## GetTelephonyProvidersEdgesDidpool

> [**DIDPool**](DIDPool) GetTelephonyProvidersEdgesDidpool (string didPoolId)


Get a DID Pool by ID.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidpoolExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            { 
                // Get a DID Pool by ID.
                DIDPool result = apiInstance.GetTelephonyProvidersEdgesDidpool(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDidpool: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |

### Return type

[**DIDPool**](DIDPool)


## GetTelephonyProvidersEdgesDidpools

> [**DIDPoolEntityListing**](DIDPoolEntityListing) GetTelephonyProvidersEdgesDidpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> id = null)


Get a listing of DID Pools

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidpoolsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "number")
            var id = new List<string>(); // List<string> | Filter by a specific list of ID's (optional) 

            try
            { 
                // Get a listing of DID Pools
                DIDPoolEntityListing result = apiInstance.GetTelephonyProvidersEdgesDidpools(pageSize, pageNumber, sortBy, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDidpools: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "number"] |
| **id** | [**List<string>**](string)| Filter by a specific list of ID&#39;s | [optional]  |

### Return type

[**DIDPoolEntityListing**](DIDPoolEntityListing)


## GetTelephonyProvidersEdgesDidpoolsDids

> [**DIDNumberEntityListing**](DIDNumberEntityListing) GetTelephonyProvidersEdgesDidpoolsDids (string type, List<string> id = null, string numberMatch = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null)


Get a listing of unassigned and/or assigned numbers in a set of DID Pools.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidpoolsDidsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var type = type_example;  // string | The type of numbers to return.
            var id = new List<string>(); // List<string> | Filter by a specific list of DID Pools.  If this is not provided, numbers from all DID Pools will be returned. (optional) 
            var numberMatch = numberMatch_example;  // string | A number to filter the results by. (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ascending")

            try
            { 
                // Get a listing of unassigned and/or assigned numbers in a set of DID Pools.
                DIDNumberEntityListing result = apiInstance.GetTelephonyProvidersEdgesDidpoolsDids(type, id, numberMatch, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDidpoolsDids: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| The type of numbers to return. | <br />**Values**: ASSIGNED_AND_UNASSIGNED, UNASSIGNED |
| **id** | [**List<string>**](string)| Filter by a specific list of DID Pools.  If this is not provided, numbers from all DID Pools will be returned. | [optional]  |
| **numberMatch** | **string**| A number to filter the results by. | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ascending"] |

### Return type

[**DIDNumberEntityListing**](DIDNumberEntityListing)


## GetTelephonyProvidersEdgesDids

> [**DIDEntityListing**](DIDEntityListing) GetTelephonyProvidersEdgesDids (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null, string ownerId = null, string didPoolId = null, List<string> id = null)


Get a listing of DIDs

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesDidsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "number")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var phoneNumber = phoneNumber_example;  // string | Filter by phoneNumber (optional) 
            var ownerId = ownerId_example;  // string | Filter by the owner of a phone number (optional) 
            var didPoolId = didPoolId_example;  // string | Filter by the DID Pool assignment (optional) 
            var id = new List<string>(); // List<string> | Filter by a specific list of ID's (optional) 

            try
            { 
                // Get a listing of DIDs
                DIDEntityListing result = apiInstance.GetTelephonyProvidersEdgesDids(pageSize, pageNumber, sortBy, sortOrder, phoneNumber, ownerId, didPoolId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesDids: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "number"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **phoneNumber** | **string**| Filter by phoneNumber | [optional]  |
| **ownerId** | **string**| Filter by the owner of a phone number | [optional]  |
| **didPoolId** | **string**| Filter by the DID Pool assignment | [optional]  |
| **id** | [**List<string>**](string)| Filter by a specific list of ID&#39;s | [optional]  |

### Return type

[**DIDEntityListing**](DIDEntityListing)


## GetTelephonyProvidersEdgesEdgegroup

> [**EdgeGroup**](EdgeGroup) GetTelephonyProvidersEdgesEdgegroup (string edgeGroupId, List<string> expand = null)


Get edge group.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID
            var expand = new List<string>(); // List<string> | Fields to expand in the response (optional) 

            try
            { 
                // Get edge group.
                EdgeGroup result = apiInstance.GetTelephonyProvidersEdgesEdgegroup(edgeGroupId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **expand** | [**List<string>**](string)| Fields to expand in the response | [optional] <br />**Values**: phoneTrunkBases, edgeTrunkBaseAssignment |

### Return type

[**EdgeGroup**](EdgeGroup)


## GetTelephonyProvidersEdgesEdgegroupEdgetrunkbase

> [**EdgeTrunkBase**](EdgeTrunkBase) GetTelephonyProvidersEdgesEdgegroupEdgetrunkbase (string edgegroupId, string edgetrunkbaseId)


Gets the edge trunk base associated with the edge group

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgegroupEdgetrunkbaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgegroupId = edgegroupId_example;  // string | Edge Group ID
            var edgetrunkbaseId = edgetrunkbaseId_example;  // string | Edge Trunk Base ID

            try
            { 
                // Gets the edge trunk base associated with the edge group
                EdgeTrunkBase result = apiInstance.GetTelephonyProvidersEdgesEdgegroupEdgetrunkbase(edgegroupId, edgetrunkbaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgegroupEdgetrunkbase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgegroupId** | **string**| Edge Group ID |  |
| **edgetrunkbaseId** | **string**| Edge Trunk Base ID |  |

### Return type

[**EdgeTrunkBase**](EdgeTrunkBase)


## GetTelephonyProvidersEdgesEdgegroups

> [**EdgeGroupEntityListing**](EdgeGroupEntityListing) GetTelephonyProvidersEdgesEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, bool? managed = null)


Get the list of edge groups.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgegroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var managed = true;  // bool? | Filter by managed (optional) 

            try
            { 
                // Get the list of edge groups.
                EdgeGroupEntityListing result = apiInstance.GetTelephonyProvidersEdgesEdgegroups(pageSize, pageNumber, name, sortBy, managed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgegroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **managed** | **bool?**| Filter by managed | [optional]  |

### Return type

[**EdgeGroupEntityListing**](EdgeGroupEntityListing)


## GetTelephonyProvidersEdgesEdgeversionreport

> [**EdgeVersionReport**](EdgeVersionReport) GetTelephonyProvidersEdgesEdgeversionreport ()


Get the edge version report.

The report will not have consistent data about the edge version(s) until all edges have been reset.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesEdgeversionreportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            { 
                // Get the edge version report.
                EdgeVersionReport result = apiInstance.GetTelephonyProvidersEdgesEdgeversionreport();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesEdgeversionreport: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EdgeVersionReport**](EdgeVersionReport)


## GetTelephonyProvidersEdgesExpired

> [**ExpiredEdgeListing**](ExpiredEdgeListing) GetTelephonyProvidersEdgesExpired ()


List of edges more than 4 edge versions behind the latest software.

Requires ANY permissions: 

* telephony:plugin:all
* internal:edge:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExpiredExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            { 
                // List of edges more than 4 edge versions behind the latest software.
                ExpiredEdgeListing result = apiInstance.GetTelephonyProvidersEdgesExpired();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExpired: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ExpiredEdgeListing**](ExpiredEdgeListing)


## GetTelephonyProvidersEdgesExtension

> [**Extension**](Extension) GetTelephonyProvidersEdgesExtension (string extensionId)


Get an extension by ID.

Requires ANY permissions: 

* telephony:extensionPool:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionId = extensionId_example;  // string | Extension ID

            try
            { 
                // Get an extension by ID.
                Extension result = apiInstance.GetTelephonyProvidersEdgesExtension(extensionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtension: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |

### Return type

[**Extension**](Extension)


## GetTelephonyProvidersEdgesExtensionpool

> [**ExtensionPool**](ExtensionPool) GetTelephonyProvidersEdgesExtensionpool (string extensionPoolId)


Get an extension pool by ID

Requires ALL permissions: 

* telephony:extensionPool:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionpoolExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            { 
                // Get an extension pool by ID
                ExtensionPool result = apiInstance.GetTelephonyProvidersEdgesExtensionpool(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtensionpool: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |

### Return type

[**ExtensionPool**](ExtensionPool)


## GetTelephonyProvidersEdgesExtensionpools

> [**ExtensionPoolEntityListing**](ExtensionPoolEntityListing) GetTelephonyProvidersEdgesExtensionpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)


Get a listing of extension pools

Requires ALL permissions: 

* telephony:extensionPool:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionpoolsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var number = number_example;  // string | Deprecated, filtering by number not supported (optional) 

            try
            { 
                // Get a listing of extension pools
                ExtensionPoolEntityListing result = apiInstance.GetTelephonyProvidersEdgesExtensionpools(pageSize, pageNumber, sortBy, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtensionpools: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional]  |
| **number** | **string**| Deprecated, filtering by number not supported | [optional]  |

### Return type

[**ExtensionPoolEntityListing**](ExtensionPoolEntityListing)


## GetTelephonyProvidersEdgesExtensionpoolsDivisionviews

> [**ExtensionPoolDivisionViewEntityListing**](ExtensionPoolDivisionViewEntityListing) GetTelephonyProvidersEdgesExtensionpoolsDivisionviews (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, List<string> divisionId = null)


Get a pageable list of basic extension pool objects filterable by query parameters.

This returns extension pools consisting of name and division. If one or more IDs are specified, the search will fetch flow outcomes that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ALL permissions: 

* telephony:extensionPool:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionpoolsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var id = new List<string>(); // List<string> | ID of the Extension Pools to filter by. (optional) 
            var name = name_example;  // string | Name of the Extension Pools to filter by. (optional) 
            var divisionId = new List<string>(); // List<string> | List of divisionIds on which to filter. (optional) 

            try
            { 
                // Get a pageable list of basic extension pool objects filterable by query parameters.
                ExtensionPoolDivisionViewEntityListing result = apiInstance.GetTelephonyProvidersEdgesExtensionpoolsDivisionviews(pageNumber, pageSize, sortBy, sortOrder, id, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtensionpoolsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **id** | [**List<string>**](string)| ID of the Extension Pools to filter by. | [optional]  |
| **name** | **string**| Name of the Extension Pools to filter by. | [optional]  |
| **divisionId** | [**List<string>**](string)| List of divisionIds on which to filter. | [optional]  |

### Return type

[**ExtensionPoolDivisionViewEntityListing**](ExtensionPoolDivisionViewEntityListing)


## GetTelephonyProvidersEdgesExtensions

> [**ExtensionEntityListing**](ExtensionEntityListing) GetTelephonyProvidersEdgesExtensions (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)


Get a listing of extensions

Requires ANY permissions: 

* telephony:extensionPool:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesExtensionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "number")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var number = number_example;  // string | Filter by number (optional) 

            try
            { 
                // Get a listing of extensions
                ExtensionEntityListing result = apiInstance.GetTelephonyProvidersEdgesExtensions(pageSize, pageNumber, sortBy, sortOrder, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesExtensions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "number"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **number** | **string**| Filter by number | [optional]  |

### Return type

[**ExtensionEntityListing**](ExtensionEntityListing)


## GetTelephonyProvidersEdgesLine

> [**Line**](Line) GetTelephonyProvidersEdgesLine (string lineId)


Get a Line by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineId = lineId_example;  // string | Line ID

            try
            { 
                // Get a Line by ID
                Line result = apiInstance.GetTelephonyProvidersEdgesLine(lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineId** | **string**| Line ID |  |

### Return type

[**Line**](Line)


## GetTelephonyProvidersEdgesLinebasesetting

> [**LineBase**](LineBase) GetTelephonyProvidersEdgesLinebasesetting (string lineBaseId)


Get a line base settings object by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinebasesettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineBaseId = lineBaseId_example;  // string | Line base ID

            try
            { 
                // Get a line base settings object by ID
                LineBase result = apiInstance.GetTelephonyProvidersEdgesLinebasesetting(lineBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLinebasesetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseId** | **string**| Line base ID |  |

### Return type

[**LineBase**](LineBase)


## GetTelephonyProvidersEdgesLinebasesettings

> [**LineBaseEntityListing**](LineBaseEntityListing) GetTelephonyProvidersEdgesLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> expand = null)


Get a listing of line base settings objects

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinebasesettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 

            try
            { 
                // Get a listing of line base settings objects
                LineBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesLinebasesettings(pageNumber, pageSize, sortBy, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLinebasesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **expand** | [**List<string>**](string)| Fields to expand in the response, comma-separated | [optional] <br />**Values**: properties |

### Return type

[**LineBaseEntityListing**](LineBaseEntityListing)


## GetTelephonyProvidersEdgesLines

> [**LineEntityListing**](LineEntityListing) GetTelephonyProvidersEdgesLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)


Get a list of Lines

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to "name")
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated. The edgeGroup value is deprecated. (optional) 

            try
            { 
                // Get a list of Lines
                LineEntityListing result = apiInstance.GetTelephonyProvidersEdgesLines(pageSize, pageNumber, name, sortBy, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Value by which to sort | [optional] [default to "name"] |
| **expand** | [**List<string>**](string)| Fields to expand in the response, comma-separated. The edgeGroup value is deprecated. | [optional] <br />**Values**: properties, site, edgeGroup, primaryEdge, secondaryEdge, edges, assignedUser |

### Return type

[**LineEntityListing**](LineEntityListing)


## GetTelephonyProvidersEdgesLinesTemplate

> [**Line**](Line) GetTelephonyProvidersEdgesLinesTemplate (string lineBaseSettingsId)


Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLinesTemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineBaseSettingsId = lineBaseSettingsId_example;  // string | The id of a Line Base Settings object upon which to base this Line

            try
            { 
                // Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
                Line result = apiInstance.GetTelephonyProvidersEdgesLinesTemplate(lineBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLinesTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseSettingsId** | **string**| The id of a Line Base Settings object upon which to base this Line |  |

### Return type

[**Line**](Line)


## GetTelephonyProvidersEdgesLogicalinterfaces

> [**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing) GetTelephonyProvidersEdgesLogicalinterfaces (string edgeIds, List<string> expand = null)


Get edge logical interfaces.

Retrieve the configured logical interfaces for a list edges. Only 100 edges can be requested at a time.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesLogicalinterfacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeIds = edgeIds_example;  // string | Comma separated list of Edge Id's
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            { 
                // Get edge logical interfaces.
                LogicalInterfaceEntityListing result = apiInstance.GetTelephonyProvidersEdgesLogicalinterfaces(edgeIds, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesLogicalinterfaces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeIds** | **string**| Comma separated list of Edge Id&#39;s |  |
| **expand** | [**List<string>**](string)| Field to expand in the response | [optional] <br />**Values**: externalTrunkBaseAssignments, phoneTrunkBaseAssignments |

### Return type

[**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing)


## GetTelephonyProvidersEdgesMediastatisticsConversation

> [**MediaStatisticsListing**](MediaStatisticsListing) GetTelephonyProvidersEdgesMediastatisticsConversation (string conversationId)


Get media endpoint statistics events.

GetTelephonyProvidersEdgesMediastatisticsConversation is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesMediastatisticsConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var conversationId = conversationId_example;  // string | Identifier of the conversation

            try
            { 
                // Get media endpoint statistics events.
                MediaStatisticsListing result = apiInstance.GetTelephonyProvidersEdgesMediastatisticsConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesMediastatisticsConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Identifier of the conversation |  |

### Return type

[**MediaStatisticsListing**](MediaStatisticsListing)


## GetTelephonyProvidersEdgesMediastatisticsConversationCommunication

> [**MediaStatistics**](MediaStatistics) GetTelephonyProvidersEdgesMediastatisticsConversationCommunication (string conversationId, string communicationId)


Get media endpoint statistics event.

GetTelephonyProvidersEdgesMediastatisticsConversationCommunication is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesMediastatisticsConversationCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var conversationId = conversationId_example;  // string | Identifier of the conversation
            var communicationId = communicationId_example;  // string | Identifier of the media session

            try
            { 
                // Get media endpoint statistics event.
                MediaStatistics result = apiInstance.GetTelephonyProvidersEdgesMediastatisticsConversationCommunication(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesMediastatisticsConversationCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Identifier of the conversation |  |
| **communicationId** | **string**| Identifier of the media session |  |

### Return type

[**MediaStatistics**](MediaStatistics)


## GetTelephonyProvidersEdgesMetrics

> [**List&lt;EdgeMetrics&gt;**](EdgeMetrics) GetTelephonyProvidersEdgesMetrics (string edgeIds)


Get the metrics for a list of edges.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesMetricsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeIds = edgeIds_example;  // string | Comma separated list of Edge Id's. Maximum of 100 edge ids allowed.

            try
            { 
                // Get the metrics for a list of edges.
                List<EdgeMetrics> result = apiInstance.GetTelephonyProvidersEdgesMetrics(edgeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeIds** | **string**| Comma separated list of Edge Id&#39;s. Maximum of 100 edge ids allowed. |  |

### Return type

[**List<EdgeMetrics>**](EdgeMetrics)


## GetTelephonyProvidersEdgesOutboundroutes

> [**OutboundRouteEntityListing**](OutboundRouteEntityListing) GetTelephonyProvidersEdgesOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string externalTrunkBasesIds = null, string sortBy = null)


Get outbound routes

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesOutboundroutesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var externalTrunkBasesIds = externalTrunkBasesIds_example;  // string | Filter by externalTrunkBases.ids (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")

            try
            { 
                // Get outbound routes
                OutboundRouteEntityListing result = apiInstance.GetTelephonyProvidersEdgesOutboundroutes(pageSize, pageNumber, name, siteId, externalTrunkBasesIds, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesOutboundroutes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **externalTrunkBasesIds** | **string**| Filter by externalTrunkBases.ids | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |

### Return type

[**OutboundRouteEntityListing**](OutboundRouteEntityListing)


## GetTelephonyProvidersEdgesPhone

> [**Phone**](Phone) GetTelephonyProvidersEdgesPhone (string phoneId)


Get a Phone by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhoneExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID

            try
            { 
                // Get a Phone by ID
                Phone result = apiInstance.GetTelephonyProvidersEdgesPhone(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |

### Return type

[**Phone**](Phone)


## GetTelephonyProvidersEdgesPhonebasesetting

> [**PhoneBase**](PhoneBase) GetTelephonyProvidersEdgesPhonebasesetting (string phoneBaseId)


Get a Phone Base Settings object by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID

            try
            { 
                // Get a Phone Base Settings object by ID
                PhoneBase result = apiInstance.GetTelephonyProvidersEdgesPhonebasesetting(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |

### Return type

[**PhoneBase**](PhoneBase)


## GetTelephonyProvidersEdgesPhonebasesettings

> [**PhoneBaseEntityListing**](PhoneBaseEntityListing) GetTelephonyProvidersEdgesPhonebasesettings (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null, string name = null)


Get a list of Phone Base Settings objects

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 
            var name = name_example;  // string | Name (optional) 

            try
            { 
                // Get a list of Phone Base Settings objects
                PhoneBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesPhonebasesettings(pageSize, pageNumber, sortBy, sortOrder, expand, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **expand** | [**List<string>**](string)| Fields to expand in the response, comma-separated | [optional] <br />**Values**: properties, lines |
| **name** | **string**| Name | [optional]  |

### Return type

[**PhoneBaseEntityListing**](PhoneBaseEntityListing)


## GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases

> [**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing) GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null)


Get a list of available makes and models to create a new Phone Base Settings

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of available makes and models to create a new Phone Base Settings
                PhoneMetaBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesettingsAvailablemetabases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing)


## GetTelephonyProvidersEdgesPhonebasesettingsTemplate

> [**PhoneBase**](PhoneBase) GetTelephonyProvidersEdgesPhonebasesettingsTemplate (string phoneMetabaseId)


Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonebasesettingsTemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneMetabaseId = phoneMetabaseId_example;  // string | The id of a metabase object upon which to base this Phone Base Settings

            try
            { 
                // Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
                PhoneBase result = apiInstance.GetTelephonyProvidersEdgesPhonebasesettingsTemplate(phoneMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonebasesettingsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneMetabaseId** | **string**| The id of a metabase object upon which to base this Phone Base Settings |  |

### Return type

[**PhoneBase**](PhoneBase)


## GetTelephonyProvidersEdgesPhones

> [**PhoneEntityListing**](PhoneEntityListing) GetTelephonyProvidersEdgesPhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string webRtcUserId = null, string phoneBaseSettingsId = null, string linesLoggedInUserId = null, string linesDefaultForUserId = null, string phoneHardwareId = null, string linesId = null, string linesName = null, string name = null, string statusOperationalStatus = null, string secondaryStatusOperationalStatus = null, List<string> expand = null, List<string> fields = null)


Get a list of Phone Instances. A maximum of 10,000 results is returned when filtering the results or sorting by a field other than the ID. Sorting by only the ID has no result limit. Each filter supports a wildcard, *, as a value to search for partial values.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | The field to sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var webRtcUserId = webRtcUserId_example;  // string | Filter by webRtcUser.id (optional) 
            var phoneBaseSettingsId = phoneBaseSettingsId_example;  // string | Filter by phoneBaseSettings.id (optional) 
            var linesLoggedInUserId = linesLoggedInUserId_example;  // string | Filter by lines.loggedInUser.id (optional) 
            var linesDefaultForUserId = linesDefaultForUserId_example;  // string | Filter by lines.defaultForUser.id (optional) 
            var phoneHardwareId = phoneHardwareId_example;  // string | Filter by phone_hardwareId (optional) 
            var linesId = linesId_example;  // string | Filter by lines.id (optional) 
            var linesName = linesName_example;  // string | Filter by lines.name (optional) 
            var name = name_example;  // string | Name of the Phone to filter by, comma-separated (optional) 
            var statusOperationalStatus = statusOperationalStatus_example;  // string | The primary status to filter by (optional) 
            var secondaryStatusOperationalStatus = secondaryStatusOperationalStatus_example;  // string | The secondary status to filter by (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 
            var fields = new List<string>(); // List<string> | Fields and properties to get, comma-separated (optional) 

            try
            { 
                // Get a list of Phone Instances. A maximum of 10,000 results is returned when filtering the results or sorting by a field other than the ID. Sorting by only the ID has no result limit. Each filter supports a wildcard, *, as a value to search for partial values.
                PhoneEntityListing result = apiInstance.GetTelephonyProvidersEdgesPhones(pageNumber, pageSize, sortBy, sortOrder, siteId, webRtcUserId, phoneBaseSettingsId, linesLoggedInUserId, linesDefaultForUserId, phoneHardwareId, linesId, linesName, name, statusOperationalStatus, secondaryStatusOperationalStatus, expand, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhones: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| The field to sort by | [optional] [default to name]<br />**Values**: id, name, status.operationalStatus, secondaryStatus.operationalStatus |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **webRtcUserId** | **string**| Filter by webRtcUser.id | [optional]  |
| **phoneBaseSettingsId** | **string**| Filter by phoneBaseSettings.id | [optional]  |
| **linesLoggedInUserId** | **string**| Filter by lines.loggedInUser.id | [optional]  |
| **linesDefaultForUserId** | **string**| Filter by lines.defaultForUser.id | [optional]  |
| **phoneHardwareId** | **string**| Filter by phone_hardwareId | [optional]  |
| **linesId** | **string**| Filter by lines.id | [optional]  |
| **linesName** | **string**| Filter by lines.name | [optional]  |
| **name** | **string**| Name of the Phone to filter by, comma-separated | [optional]  |
| **statusOperationalStatus** | **string**| The primary status to filter by | [optional]  |
| **secondaryStatusOperationalStatus** | **string**| The secondary status to filter by | [optional]  |
| **expand** | [**List<string>**](string)| Fields to expand in the response, comma-separated | [optional] <br />**Values**: properties, site, status, status.primaryEdgesStatus, status.secondaryEdgesStatus, phoneBaseSettings, lines |
| **fields** | [**List<string>**](string)| Fields and properties to get, comma-separated | [optional] <br />**Values**: webRtcUser, properties.*, lines.loggedInUser, lines.defaultForUser |

### Return type

[**PhoneEntityListing**](PhoneEntityListing)


## GetTelephonyProvidersEdgesPhonesTemplate

> [**Phone**](Phone) GetTelephonyProvidersEdgesPhonesTemplate (string phoneBaseSettingsId)


Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhonesTemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseSettingsId = phoneBaseSettingsId_example;  // string | The id of a Phone Base Settings object upon which to base this Phone

            try
            { 
                // Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
                Phone result = apiInstance.GetTelephonyProvidersEdgesPhonesTemplate(phoneBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhonesTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseSettingsId** | **string**| The id of a Phone Base Settings object upon which to base this Phone |  |

### Return type

[**Phone**](Phone)


## GetTelephonyProvidersEdgesPhysicalinterfaces

> [**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing) GetTelephonyProvidersEdgesPhysicalinterfaces (string edgeIds)


Get physical interfaces for edges.

Retrieves a list of all configured physical interfaces for a list of edges. Only 100 edges can be requested at a time.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesPhysicalinterfacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeIds = edgeIds_example;  // string | Comma separated list of Edge Id's

            try
            { 
                // Get physical interfaces for edges.
                PhysicalInterfaceEntityListing result = apiInstance.GetTelephonyProvidersEdgesPhysicalinterfaces(edgeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesPhysicalinterfaces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeIds** | **string**| Comma separated list of Edge Id&#39;s |  |

### Return type

[**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing)


## GetTelephonyProvidersEdgesSite

> [**Site**](Site) GetTelephonyProvidersEdgesSite (string siteId)


Get a Site by ID.

Requires ANY permissions: 

* telephony:plugin:all
* telephony:sites:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            { 
                // Get a Site by ID.
                Site result = apiInstance.GetTelephonyProvidersEdgesSite(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSite: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |

### Return type

[**Site**](Site)


## GetTelephonyProvidersEdgesSiteNumberplan

> [**NumberPlan**](NumberPlan) GetTelephonyProvidersEdgesSiteNumberplan (string siteId, string numberPlanId)


Get a Number Plan by ID.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteNumberplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var numberPlanId = numberPlanId_example;  // string | Number Plan ID

            try
            { 
                // Get a Number Plan by ID.
                NumberPlan result = apiInstance.GetTelephonyProvidersEdgesSiteNumberplan(siteId, numberPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteNumberplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **numberPlanId** | **string**| Number Plan ID |  |

### Return type

[**NumberPlan**](NumberPlan)


## GetTelephonyProvidersEdgesSiteNumberplans

> [**List&lt;NumberPlan&gt;**](NumberPlan) GetTelephonyProvidersEdgesSiteNumberplans (string siteId)


Get the list of Number Plans for this Site. Only fetches the first 200 records.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteNumberplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            { 
                // Get the list of Number Plans for this Site. Only fetches the first 200 records.
                List<NumberPlan> result = apiInstance.GetTelephonyProvidersEdgesSiteNumberplans(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteNumberplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |

### Return type

[**List<NumberPlan>**](NumberPlan)


## GetTelephonyProvidersEdgesSiteNumberplansClassifications

> **List&lt;string&gt;** GetTelephonyProvidersEdgesSiteNumberplansClassifications (string siteId, string classification = null)


Get a list of Classifications for this Site

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteNumberplansClassificationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var classification = classification_example;  // string | Classification (optional) 

            try
            { 
                // Get a list of Classifications for this Site
                List<string> result = apiInstance.GetTelephonyProvidersEdgesSiteNumberplansClassifications(siteId, classification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteNumberplansClassifications: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **classification** | **string**| Classification | [optional]  |

### Return type

**List<string>**


## GetTelephonyProvidersEdgesSiteOutboundroute

> [**OutboundRouteBase**](OutboundRouteBase) GetTelephonyProvidersEdgesSiteOutboundroute (string siteId, string outboundRouteId)


Get an outbound route

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteOutboundrouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            { 
                // Get an outbound route
                OutboundRouteBase result = apiInstance.GetTelephonyProvidersEdgesSiteOutboundroute(siteId, outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteOutboundroute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **outboundRouteId** | **string**| Outbound route ID |  |

### Return type

[**OutboundRouteBase**](OutboundRouteBase)


## GetTelephonyProvidersEdgesSiteOutboundroutes

> [**OutboundRouteBaseEntityListing**](OutboundRouteBaseEntityListing) GetTelephonyProvidersEdgesSiteOutboundroutes (string siteId, int? pageSize = null, int? pageNumber = null, string name = null, string externalTrunkBasesIds = null, string sortBy = null)


Get outbound routes

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteOutboundroutesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var externalTrunkBasesIds = externalTrunkBasesIds_example;  // string | externalTrunkBases.ids (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")

            try
            { 
                // Get outbound routes
                OutboundRouteBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesSiteOutboundroutes(siteId, pageSize, pageNumber, name, externalTrunkBasesIds, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteOutboundroutes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **externalTrunkBasesIds** | **string**| externalTrunkBases.ids | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |

### Return type

[**OutboundRouteBaseEntityListing**](OutboundRouteBaseEntityListing)


## GetTelephonyProvidersEdgesSiteSiteconnections

> [**SiteConnections**](SiteConnections) GetTelephonyProvidersEdgesSiteSiteconnections (string siteId)


Get site connections for a site.

Requires ANY permissions: 

* telephony:plugin:all
* telephony:sites:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSiteSiteconnectionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            { 
                // Get site connections for a site.
                SiteConnections result = apiInstance.GetTelephonyProvidersEdgesSiteSiteconnections(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSiteSiteconnections: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |

### Return type

[**SiteConnections**](SiteConnections)


## GetTelephonyProvidersEdgesSites

> [**SiteEntityListing**](SiteEntityListing) GetTelephonyProvidersEdgesSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null, bool? managed = null, List<string> expand = null)


Get the list of Sites.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesSitesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var name = name_example;  // string | Name (optional) 
            var locationId = locationId_example;  // string | Location Id (optional) 
            var managed = true;  // bool? | Filter by managed (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 

            try
            { 
                // Get the list of Sites.
                SiteEntityListing result = apiInstance.GetTelephonyProvidersEdgesSites(pageSize, pageNumber, sortBy, sortOrder, name, locationId, managed, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesSites: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **name** | **string**| Name | [optional]  |
| **locationId** | **string**| Location Id | [optional]  |
| **managed** | **bool?**| Filter by managed | [optional]  |
| **expand** | [**List<string>**](string)| Fields to expand in the response, comma-separated | [optional] <br />**Values**: edges, location, primarySites, secondarySites |

### Return type

[**SiteEntityListing**](SiteEntityListing)


## GetTelephonyProvidersEdgesTimezones

> [**TimeZoneEntityListing**](TimeZoneEntityListing) GetTelephonyProvidersEdgesTimezones (int? pageSize = null, int? pageNumber = null)


Get a list of Edge-compatible time zones

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTimezonesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 1000)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Edge-compatible time zones
                TimeZoneEntityListing result = apiInstance.GetTelephonyProvidersEdgesTimezones(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTimezones: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 1000] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**TimeZoneEntityListing**](TimeZoneEntityListing)


## GetTelephonyProvidersEdgesTrunk

> [**Trunk**](Trunk) GetTelephonyProvidersEdgesTrunk (string trunkId)


Get a Trunk by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkId = trunkId_example;  // string | Trunk ID

            try
            { 
                // Get a Trunk by ID
                Trunk result = apiInstance.GetTelephonyProvidersEdgesTrunk(trunkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkId** | **string**| Trunk ID |  |

### Return type

[**Trunk**](Trunk)


## GetTelephonyProvidersEdgesTrunkMetrics

> [**TrunkMetrics**](TrunkMetrics) GetTelephonyProvidersEdgesTrunkMetrics (string trunkId)


Get the trunk metrics.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkMetricsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkId = trunkId_example;  // string | Trunk Id

            try
            { 
                // Get the trunk metrics.
                TrunkMetrics result = apiInstance.GetTelephonyProvidersEdgesTrunkMetrics(trunkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkId** | **string**| Trunk Id |  |

### Return type

[**TrunkMetrics**](TrunkMetrics)


## GetTelephonyProvidersEdgesTrunkbasesetting

> [**TrunkBase**](TrunkBase) GetTelephonyProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId, bool? ignoreHidden = null)


Get a Trunk Base Settings object by ID

Managed properties will not be returned unless the user is assigned the internal:trunk:edit permission.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID
            var ignoreHidden = true;  // bool? | Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. (optional) 

            try
            { 
                // Get a Trunk Base Settings object by ID
                TrunkBase result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesetting(trunkBaseSettingsId, ignoreHidden);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
| **ignoreHidden** | **bool?**| Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. | [optional]  |

### Return type

[**TrunkBase**](TrunkBase)


## GetTelephonyProvidersEdgesTrunkbasesettings

> [**TrunkBaseEntityListing**](TrunkBaseEntityListing) GetTelephonyProvidersEdgesTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, bool? recordingEnabled = null, bool? ignoreHidden = null, bool? managed = null, List<string> expand = null, string name = null)


Get Trunk Base Settings listing

Managed properties will not be returned unless the user is assigned the internal:trunk:edit permission.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var recordingEnabled = true;  // bool? | Filter trunks by recording enabled (optional) 
            var ignoreHidden = true;  // bool? | Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. (optional) 
            var managed = true;  // bool? | Filter by managed (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 
            var name = name_example;  // string | Name of the TrunkBase to filter by (optional) 

            try
            { 
                // Get Trunk Base Settings listing
                TrunkBaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesettings(pageNumber, pageSize, sortBy, sortOrder, recordingEnabled, ignoreHidden, managed, expand, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **recordingEnabled** | **bool?**| Filter trunks by recording enabled | [optional]  |
| **ignoreHidden** | **bool?**| Set this to true to not receive trunk properties that are meant to be hidden or for internal system usage only. | [optional]  |
| **managed** | **bool?**| Filter by managed | [optional]  |
| **expand** | [**List<string>**](string)| Fields to expand in the response, comma-separated | [optional] <br />**Values**: properties |
| **name** | **string**| Name of the TrunkBase to filter by | [optional]  |

### Return type

[**TrunkBaseEntityListing**](TrunkBaseEntityListing)


## GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases

> [**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing) GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null)


Get a list of available makes and models to create a new Trunk Base Settings

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var type = type_example;  // string |  (optional) 
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var pageNumber = 56;  // int? |  (optional)  (default to 1)

            try
            { 
                // Get a list of available makes and models to create a new Trunk Base Settings
                TrunkMetabaseEntityListing result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases(type, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesettingsAvailablemetabases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**|  | [optional] <br />**Values**: EXTERNAL, PHONE, EDGE |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |

### Return type

[**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing)


## GetTelephonyProvidersEdgesTrunkbasesettingsTemplate

> [**TrunkBase**](TrunkBase) GetTelephonyProvidersEdgesTrunkbasesettingsTemplate (string trunkMetabaseId)


Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkbasesettingsTemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkMetabaseId = trunkMetabaseId_example;  // string | The id of a metabase object upon which to base this Trunk Base Settings

            try
            { 
                // Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
                TrunkBase result = apiInstance.GetTelephonyProvidersEdgesTrunkbasesettingsTemplate(trunkMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkbasesettingsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkMetabaseId** | **string**| The id of a metabase object upon which to base this Trunk Base Settings |  |

### Return type

[**TrunkBase**](TrunkBase)


## GetTelephonyProvidersEdgesTrunks

> [**TrunkEntityListing**](TrunkEntityListing) GetTelephonyProvidersEdgesTrunks (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string edgeId = null, string trunkBaseId = null, string trunkType = null)


Get the list of available trunks.

Trunks are created by assigning trunk base settings to an Edge or Edge Group.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var edgeId = edgeId_example;  // string | Filter by Edge Ids (optional) 
            var trunkBaseId = trunkBaseId_example;  // string | Filter by Trunk Base Ids (optional) 
            var trunkType = trunkType_example;  // string | Filter by a Trunk type (optional) 

            try
            { 
                // Get the list of available trunks.
                TrunkEntityListing result = apiInstance.GetTelephonyProvidersEdgesTrunks(pageNumber, pageSize, sortBy, sortOrder, edgeId, trunkBaseId, trunkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **edgeId** | **string**| Filter by Edge Ids | [optional]  |
| **trunkBaseId** | **string**| Filter by Trunk Base Ids | [optional]  |
| **trunkType** | **string**| Filter by a Trunk type | [optional] <br />**Values**: EXTERNAL, PHONE, EDGE |

### Return type

[**TrunkEntityListing**](TrunkEntityListing)


## GetTelephonyProvidersEdgesTrunksMetrics

> [**List&lt;TrunkMetrics&gt;**](TrunkMetrics) GetTelephonyProvidersEdgesTrunksMetrics (string trunkIds)


Get the metrics for a list of trunks.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunksMetricsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkIds = trunkIds_example;  // string | Comma separated list of Trunk Id's

            try
            { 
                // Get the metrics for a list of trunks.
                List<TrunkMetrics> result = apiInstance.GetTelephonyProvidersEdgesTrunksMetrics(trunkIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunksMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkIds** | **string**| Comma separated list of Trunk Id&#39;s |  |

### Return type

[**List<TrunkMetrics>**](TrunkMetrics)


## GetTelephonyProvidersEdgesTrunkswithrecording

> [**TrunkRecordingEnabledCount**](TrunkRecordingEnabledCount) GetTelephonyProvidersEdgesTrunkswithrecording (string trunkType = null)


Get Counts of trunks that have recording disabled or enabled

Requires ANY permissions: 

* recording:retentionPolicy:view
* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonyProvidersEdgesTrunkswithrecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkType = trunkType_example;  // string | The type of this trunk base. (optional) 

            try
            { 
                // Get Counts of trunks that have recording disabled or enabled
                TrunkRecordingEnabledCount result = apiInstance.GetTelephonyProvidersEdgesTrunkswithrecording(trunkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetTelephonyProvidersEdgesTrunkswithrecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkType** | **string**| The type of this trunk base. | [optional] <br />**Values**: EXTERNAL, PHONE, EDGE |

### Return type

[**TrunkRecordingEnabledCount**](TrunkRecordingEnabledCount)


## PatchTelephonyProvidersEdgesSiteSiteconnections

> [**SiteConnections**](SiteConnections) PatchTelephonyProvidersEdgesSiteSiteconnections (string siteId, DisableSiteConnectionsRequest body)


Disable site connections for a site.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTelephonyProvidersEdgesSiteSiteconnectionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new DisableSiteConnectionsRequest(); // DisableSiteConnectionsRequest | Site

            try
            { 
                // Disable site connections for a site.
                SiteConnections result = apiInstance.PatchTelephonyProvidersEdgesSiteSiteconnections(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PatchTelephonyProvidersEdgesSiteSiteconnections: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**DisableSiteConnectionsRequest**](DisableSiteConnectionsRequest)| Site |  |

### Return type

[**SiteConnections**](SiteConnections)


## PostTelephonyProvidersEdgeDiagnosticNslookup

> [**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic) PostTelephonyProvidersEdgeDiagnosticNslookup (string edgeId, EdgeNetworkDiagnosticRequest body)


Nslookup request command to collect networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeDiagnosticNslookupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id
            var body = new EdgeNetworkDiagnosticRequest(); // EdgeNetworkDiagnosticRequest | request payload to get network diagnostic

            try
            { 
                // Nslookup request command to collect networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnostic result = apiInstance.PostTelephonyProvidersEdgeDiagnosticNslookup(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeDiagnosticNslookup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |
| **body** | [**EdgeNetworkDiagnosticRequest**](EdgeNetworkDiagnosticRequest)| request payload to get network diagnostic |  |

### Return type

[**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic)


## PostTelephonyProvidersEdgeDiagnosticPing

> [**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic) PostTelephonyProvidersEdgeDiagnosticPing (string edgeId, EdgeNetworkDiagnosticRequest body)


Ping Request command to collect networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeDiagnosticPingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id
            var body = new EdgeNetworkDiagnosticRequest(); // EdgeNetworkDiagnosticRequest | request payload to get network diagnostic

            try
            { 
                // Ping Request command to collect networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnostic result = apiInstance.PostTelephonyProvidersEdgeDiagnosticPing(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeDiagnosticPing: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |
| **body** | [**EdgeNetworkDiagnosticRequest**](EdgeNetworkDiagnosticRequest)| request payload to get network diagnostic |  |

### Return type

[**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic)


## PostTelephonyProvidersEdgeDiagnosticRoute

> [**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic) PostTelephonyProvidersEdgeDiagnosticRoute (string edgeId, EdgeNetworkDiagnosticRequest body)


Route request command to collect networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeDiagnosticRouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id
            var body = new EdgeNetworkDiagnosticRequest(); // EdgeNetworkDiagnosticRequest | request payload to get network diagnostic

            try
            { 
                // Route request command to collect networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnostic result = apiInstance.PostTelephonyProvidersEdgeDiagnosticRoute(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeDiagnosticRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |
| **body** | [**EdgeNetworkDiagnosticRequest**](EdgeNetworkDiagnosticRequest)| request payload to get network diagnostic |  |

### Return type

[**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic)


## PostTelephonyProvidersEdgeDiagnosticTracepath

> [**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic) PostTelephonyProvidersEdgeDiagnosticTracepath (string edgeId, EdgeNetworkDiagnosticRequest body)


Tracepath request command to collect networking-related information from an Edge for a target IP or host.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeDiagnosticTracepathExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id
            var body = new EdgeNetworkDiagnosticRequest(); // EdgeNetworkDiagnosticRequest | request payload to get network diagnostic

            try
            { 
                // Tracepath request command to collect networking-related information from an Edge for a target IP or host.
                EdgeNetworkDiagnostic result = apiInstance.PostTelephonyProvidersEdgeDiagnosticTracepath(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeDiagnosticTracepath: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |
| **body** | [**EdgeNetworkDiagnosticRequest**](EdgeNetworkDiagnosticRequest)| request payload to get network diagnostic |  |

### Return type

[**EdgeNetworkDiagnostic**](EdgeNetworkDiagnostic)


## PostTelephonyProvidersEdgeLogicalinterfaces

> [**DomainLogicalInterface**](DomainLogicalInterface) PostTelephonyProvidersEdgeLogicalinterfaces (string edgeId, DomainLogicalInterface body)


Create an edge logical interface.

Create

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeLogicalinterfacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface | Logical interface

            try
            { 
                // Create an edge logical interface.
                DomainLogicalInterface result = apiInstance.PostTelephonyProvidersEdgeLogicalinterfaces(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeLogicalinterfaces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface)| Logical interface |  |

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface)


## PostTelephonyProvidersEdgeLogsJobUpload

> void PostTelephonyProvidersEdgeLogsJobUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body)


Request that the specified fileIds be uploaded from the Edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeLogsJobUploadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var jobId = jobId_example;  // string | Job ID
            var body = new EdgeLogsJobUploadRequest(); // EdgeLogsJobUploadRequest | Log upload request

            try
            { 
                // Request that the specified fileIds be uploaded from the Edge.
                apiInstance.PostTelephonyProvidersEdgeLogsJobUpload(edgeId, jobId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeLogsJobUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **jobId** | **string**| Job ID |  |
| **body** | [**EdgeLogsJobUploadRequest**](EdgeLogsJobUploadRequest)| Log upload request |  |

### Return type

void (empty response body)


## PostTelephonyProvidersEdgeLogsJobs

> [**EdgeLogsJobResponse**](EdgeLogsJobResponse) PostTelephonyProvidersEdgeLogsJobs (string edgeId, EdgeLogsJobRequest body)


Create a job to upload a list of Edge logs.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeLogsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeLogsJobRequest(); // EdgeLogsJobRequest | EdgeLogsJobRequest

            try
            { 
                // Create a job to upload a list of Edge logs.
                EdgeLogsJobResponse result = apiInstance.PostTelephonyProvidersEdgeLogsJobs(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeLogsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeLogsJobRequest**](EdgeLogsJobRequest)| EdgeLogsJobRequest |  |

### Return type

[**EdgeLogsJobResponse**](EdgeLogsJobResponse)


## PostTelephonyProvidersEdgeReboot

> **string** PostTelephonyProvidersEdgeReboot (string edgeId, EdgeRebootParameters body = null)


Reboot an Edge

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeRebootExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeRebootParameters(); // EdgeRebootParameters | Parameters for the edge reboot (optional) 

            try
            { 
                // Reboot an Edge
                string result = apiInstance.PostTelephonyProvidersEdgeReboot(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeReboot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeRebootParameters**](EdgeRebootParameters)| Parameters for the edge reboot | [optional]  |

### Return type

**string**


## PostTelephonyProvidersEdgeSoftwareupdate

> [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto) PostTelephonyProvidersEdgeSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body)


Starts a software update for this edge.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeSoftwareupdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainEdgeSoftwareUpdateDto(); // DomainEdgeSoftwareUpdateDto | Software update request

            try
            { 
                // Starts a software update for this edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.PostTelephonyProvidersEdgeSoftwareupdate(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeSoftwareupdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto)| Software update request |  |

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto)


## PostTelephonyProvidersEdgeStatuscode

> **string** PostTelephonyProvidersEdgeStatuscode (string edgeId, EdgeServiceStateRequest body = null)


Take an Edge in or out of service

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeStatuscodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeServiceStateRequest(); // EdgeServiceStateRequest | Edge Service State (optional) 

            try
            { 
                // Take an Edge in or out of service
                string result = apiInstance.PostTelephonyProvidersEdgeStatuscode(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeStatuscode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeServiceStateRequest**](EdgeServiceStateRequest)| Edge Service State | [optional]  |

### Return type

**string**


## PostTelephonyProvidersEdgeUnpair

> **string** PostTelephonyProvidersEdgeUnpair (string edgeId)


Unpair an Edge

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgeUnpairExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            { 
                // Unpair an Edge
                string result = apiInstance.PostTelephonyProvidersEdgeUnpair(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgeUnpair: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |

### Return type

**string**


## PostTelephonyProvidersEdges

> [**Edge**](Edge) PostTelephonyProvidersEdges (Edge body)


Create an edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Edge(); // Edge | Edge

            try
            { 
                // Create an edge.
                Edge result = apiInstance.PostTelephonyProvidersEdges(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdges: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Edge**](Edge)| Edge |  |

### Return type

[**Edge**](Edge)


## PostTelephonyProvidersEdgesAddressvalidation

> [**ValidateAddressResponse**](ValidateAddressResponse) PostTelephonyProvidersEdgesAddressvalidation (ValidateAddressRequest body)


Validates a street address

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesAddressvalidationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new ValidateAddressRequest(); // ValidateAddressRequest | Address

            try
            { 
                // Validates a street address
                ValidateAddressResponse result = apiInstance.PostTelephonyProvidersEdgesAddressvalidation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesAddressvalidation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ValidateAddressRequest**](ValidateAddressRequest)| Address |  |

### Return type

[**ValidateAddressResponse**](ValidateAddressResponse)


## PostTelephonyProvidersEdgesCertificateauthorities

> [**DomainCertificateAuthority**](DomainCertificateAuthority) PostTelephonyProvidersEdgesCertificateauthorities (DomainCertificateAuthority body)


Create a certificate authority.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesCertificateauthoritiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | CertificateAuthority

            try
            { 
                // Create a certificate authority.
                DomainCertificateAuthority result = apiInstance.PostTelephonyProvidersEdgesCertificateauthorities(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesCertificateauthorities: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority)| CertificateAuthority |  |

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority)


## PostTelephonyProvidersEdgesDidpools

> [**DIDPool**](DIDPool) PostTelephonyProvidersEdgesDidpools (DIDPool body)


Create a new DID pool

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesDidpoolsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new DIDPool(); // DIDPool | DID pool

            try
            { 
                // Create a new DID pool
                DIDPool result = apiInstance.PostTelephonyProvidersEdgesDidpools(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesDidpools: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DIDPool**](DIDPool)| DID pool |  |

### Return type

[**DIDPool**](DIDPool)


## PostTelephonyProvidersEdgesEdgegroups

> [**EdgeGroup**](EdgeGroup) PostTelephonyProvidersEdgesEdgegroups (EdgeGroup body)


Create an edge group.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesEdgegroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup

            try
            { 
                // Create an edge group.
                EdgeGroup result = apiInstance.PostTelephonyProvidersEdgesEdgegroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesEdgegroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EdgeGroup**](EdgeGroup)| EdgeGroup |  |

### Return type

[**EdgeGroup**](EdgeGroup)


## PostTelephonyProvidersEdgesExtensionpools

> [**ExtensionPool**](ExtensionPool) PostTelephonyProvidersEdgesExtensionpools (ExtensionPool body)


Create a new extension pool

Requires ALL permissions: 

* telephony:extensionPool:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesExtensionpoolsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool

            try
            { 
                // Create a new extension pool
                ExtensionPool result = apiInstance.PostTelephonyProvidersEdgesExtensionpools(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesExtensionpools: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExtensionPool**](ExtensionPool)| ExtensionPool |  |

### Return type

[**ExtensionPool**](ExtensionPool)


## PostTelephonyProvidersEdgesPhoneReboot

> void PostTelephonyProvidersEdgesPhoneReboot (string phoneId)


Reboot a Phone

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhoneRebootExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone Id

            try
            { 
                // Reboot a Phone
                apiInstance.PostTelephonyProvidersEdgesPhoneReboot(phoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhoneReboot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone Id |  |

### Return type

void (empty response body)


## PostTelephonyProvidersEdgesPhonebasesettings

> [**PhoneBase**](PhoneBase) PostTelephonyProvidersEdgesPhonebasesettings (PhoneBase body)


Create a new Phone Base Settings object

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhonebasesettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new PhoneBase(); // PhoneBase | Phone base settings

            try
            { 
                // Create a new Phone Base Settings object
                PhoneBase result = apiInstance.PostTelephonyProvidersEdgesPhonebasesettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhonebasesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhoneBase**](PhoneBase)| Phone base settings |  |

### Return type

[**PhoneBase**](PhoneBase)


## PostTelephonyProvidersEdgesPhones

> [**Phone**](Phone) PostTelephonyProvidersEdgesPhones (Phone body)


Create a new Phone

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhonesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Phone(); // Phone | Phone

            try
            { 
                // Create a new Phone
                Phone result = apiInstance.PostTelephonyProvidersEdgesPhones(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhones: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Phone**](Phone)| Phone |  |

### Return type

[**Phone**](Phone)


## PostTelephonyProvidersEdgesPhonesReboot

> void PostTelephonyProvidersEdgesPhonesReboot (PhonesReboot body)


Reboot Multiple Phones

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesPhonesRebootExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new PhonesReboot(); // PhonesReboot | Phones

            try
            { 
                // Reboot Multiple Phones
                apiInstance.PostTelephonyProvidersEdgesPhonesReboot(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesPhonesReboot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhonesReboot**](PhonesReboot)| Phones |  |

### Return type

void (empty response body)


## PostTelephonyProvidersEdgesSiteOutboundroutes

> [**OutboundRouteBase**](OutboundRouteBase) PostTelephonyProvidersEdgesSiteOutboundroutes (string siteId, OutboundRouteBase body)


Create outbound route

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesSiteOutboundroutesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new OutboundRouteBase(); // OutboundRouteBase | OutboundRoute

            try
            { 
                // Create outbound route
                OutboundRouteBase result = apiInstance.PostTelephonyProvidersEdgesSiteOutboundroutes(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesSiteOutboundroutes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**OutboundRouteBase**](OutboundRouteBase)| OutboundRoute |  |

### Return type

[**OutboundRouteBase**](OutboundRouteBase)


## PostTelephonyProvidersEdgesSites

> [**Site**](Site) PostTelephonyProvidersEdgesSites (Site body)


Create a Site.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesSitesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Site(); // Site | Site

            try
            { 
                // Create a Site.
                Site result = apiInstance.PostTelephonyProvidersEdgesSites(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesSites: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Site**](Site)| Site |  |

### Return type

[**Site**](Site)


## PostTelephonyProvidersEdgesTrunkbasesettings

> [**TrunkBase**](TrunkBase) PostTelephonyProvidersEdgesTrunkbasesettings (TrunkBase body)


Create a Trunk Base Settings object

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonyProvidersEdgesTrunkbasesettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new TrunkBase(); // TrunkBase | Trunk base settings

            try
            { 
                // Create a Trunk Base Settings object
                TrunkBase result = apiInstance.PostTelephonyProvidersEdgesTrunkbasesettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostTelephonyProvidersEdgesTrunkbasesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrunkBase**](TrunkBase)| Trunk base settings |  |

### Return type

[**TrunkBase**](TrunkBase)


## PutTelephonyProvidersEdge

> [**Edge**](Edge) PutTelephonyProvidersEdge (string edgeId, Edge body)


Update a edge.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new Edge(); // Edge | Edge

            try
            { 
                // Update a edge.
                Edge result = apiInstance.PutTelephonyProvidersEdge(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdge: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**Edge**](Edge)| Edge |  |

### Return type

[**Edge**](Edge)


## PutTelephonyProvidersEdgeLogicalinterface

> [**DomainLogicalInterface**](DomainLogicalInterface) PutTelephonyProvidersEdgeLogicalinterface (string edgeId, string interfaceId, DomainLogicalInterface body)


Update an edge logical interface.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface | Logical interface

            try
            { 
                // Update an edge logical interface.
                DomainLogicalInterface result = apiInstance.PutTelephonyProvidersEdgeLogicalinterface(edgeId, interfaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgeLogicalinterface: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface)| Logical interface |  |

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface)


## PutTelephonyProvidersEdgesAlertablepresences

> void PutTelephonyProvidersEdgesAlertablepresences (AlertablePresences body)


Creates or updates alertable presences overrides.

Requires ANY permissions: 

* telephony:alertablePresences:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesAlertablepresencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new AlertablePresences(); // AlertablePresences | Alertable Presences Overrides

            try
            { 
                // Creates or updates alertable presences overrides.
                apiInstance.PutTelephonyProvidersEdgesAlertablepresences(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesAlertablepresences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AlertablePresences**](AlertablePresences)| Alertable Presences Overrides |  |

### Return type

void (empty response body)


## PutTelephonyProvidersEdgesCertificateauthority

> [**DomainCertificateAuthority**](DomainCertificateAuthority) PutTelephonyProvidersEdgesCertificateauthority (string certificateId, DomainCertificateAuthority body)


Update a certificate authority.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesCertificateauthorityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | Certificate authority

            try
            { 
                // Update a certificate authority.
                DomainCertificateAuthority result = apiInstance.PutTelephonyProvidersEdgesCertificateauthority(certificateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesCertificateauthority: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority)| Certificate authority |  |

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority)


## PutTelephonyProvidersEdgesDidpool

> [**DIDPool**](DIDPool) PutTelephonyProvidersEdgesDidpool (string didPoolId, DIDPool body)


Update a DID Pool by ID.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesDidpoolExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID
            var body = new DIDPool(); // DIDPool | DID pool

            try
            { 
                // Update a DID Pool by ID.
                DIDPool result = apiInstance.PutTelephonyProvidersEdgesDidpool(didPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesDidpool: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
| **body** | [**DIDPool**](DIDPool)| DID pool |  |

### Return type

[**DIDPool**](DIDPool)


## PutTelephonyProvidersEdgesEdgegroup

> [**EdgeGroup**](EdgeGroup) PutTelephonyProvidersEdgesEdgegroup (string edgeGroupId, EdgeGroup body)


Update an edge group.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesEdgegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup

            try
            { 
                // Update an edge group.
                EdgeGroup result = apiInstance.PutTelephonyProvidersEdgesEdgegroup(edgeGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **body** | [**EdgeGroup**](EdgeGroup)| EdgeGroup |  |

### Return type

[**EdgeGroup**](EdgeGroup)


## PutTelephonyProvidersEdgesEdgegroupEdgetrunkbase

> [**EdgeTrunkBase**](EdgeTrunkBase) PutTelephonyProvidersEdgesEdgegroupEdgetrunkbase (string edgegroupId, string edgetrunkbaseId, EdgeTrunkBase body)


Update the edge trunk base associated with the edge group

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesEdgegroupEdgetrunkbaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgegroupId = edgegroupId_example;  // string | Edge Group ID
            var edgetrunkbaseId = edgetrunkbaseId_example;  // string | Edge Trunk Base ID
            var body = new EdgeTrunkBase(); // EdgeTrunkBase | EdgeTrunkBase

            try
            { 
                // Update the edge trunk base associated with the edge group
                EdgeTrunkBase result = apiInstance.PutTelephonyProvidersEdgesEdgegroupEdgetrunkbase(edgegroupId, edgetrunkbaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesEdgegroupEdgetrunkbase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgegroupId** | **string**| Edge Group ID |  |
| **edgetrunkbaseId** | **string**| Edge Trunk Base ID |  |
| **body** | [**EdgeTrunkBase**](EdgeTrunkBase)| EdgeTrunkBase |  |

### Return type

[**EdgeTrunkBase**](EdgeTrunkBase)


## PutTelephonyProvidersEdgesExtensionpool

> [**ExtensionPool**](ExtensionPool) PutTelephonyProvidersEdgesExtensionpool (string extensionPoolId, ExtensionPool body)


Update an extension pool by ID

Requires ALL permissions: 

* telephony:extensionPool:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesExtensionpoolExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool

            try
            { 
                // Update an extension pool by ID
                ExtensionPool result = apiInstance.PutTelephonyProvidersEdgesExtensionpool(extensionPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesExtensionpool: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
| **body** | [**ExtensionPool**](ExtensionPool)| ExtensionPool |  |

### Return type

[**ExtensionPool**](ExtensionPool)


## PutTelephonyProvidersEdgesPhone

> [**Phone**](Phone) PutTelephonyProvidersEdgesPhone (string phoneId, Phone body)


Update a Phone by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesPhoneExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID
            var body = new Phone(); // Phone | Phone

            try
            { 
                // Update a Phone by ID
                Phone result = apiInstance.PutTelephonyProvidersEdgesPhone(phoneId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
| **body** | [**Phone**](Phone)| Phone |  |

### Return type

[**Phone**](Phone)


## PutTelephonyProvidersEdgesPhonebasesetting

> [**PhoneBase**](PhoneBase) PutTelephonyProvidersEdgesPhonebasesetting (string phoneBaseId, PhoneBase body)


Update a Phone Base Settings by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesPhonebasesettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID
            var body = new PhoneBase(); // PhoneBase | Phone base settings

            try
            { 
                // Update a Phone Base Settings by ID
                PhoneBase result = apiInstance.PutTelephonyProvidersEdgesPhonebasesetting(phoneBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesPhonebasesetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
| **body** | [**PhoneBase**](PhoneBase)| Phone base settings |  |

### Return type

[**PhoneBase**](PhoneBase)


## PutTelephonyProvidersEdgesSite

> [**Site**](Site) PutTelephonyProvidersEdgesSite (string siteId, Site body)


Update a Site by ID.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesSiteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new Site(); // Site | Site

            try
            { 
                // Update a Site by ID.
                Site result = apiInstance.PutTelephonyProvidersEdgesSite(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesSite: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**Site**](Site)| Site |  |

### Return type

[**Site**](Site)


## PutTelephonyProvidersEdgesSiteNumberplans

> [**List&lt;NumberPlan&gt;**](NumberPlan) PutTelephonyProvidersEdgesSiteNumberplans (string siteId, List<NumberPlan> body)


Update the list of Number Plans. A user can update maximum 200 number plans at a time.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesSiteNumberplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new List<NumberPlan>(); // List<NumberPlan> | List of number plans

            try
            { 
                // Update the list of Number Plans. A user can update maximum 200 number plans at a time.
                List<NumberPlan> result = apiInstance.PutTelephonyProvidersEdgesSiteNumberplans(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesSiteNumberplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**List<NumberPlan>**](NumberPlan)| List of number plans |  |

### Return type

[**List<NumberPlan>**](NumberPlan)


## PutTelephonyProvidersEdgesSiteOutboundroute

> [**OutboundRouteBase**](OutboundRouteBase) PutTelephonyProvidersEdgesSiteOutboundroute (string siteId, string outboundRouteId, OutboundRouteBase body)


Update outbound route

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesSiteOutboundrouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID
            var body = new OutboundRouteBase(); // OutboundRouteBase | OutboundRoute

            try
            { 
                // Update outbound route
                OutboundRouteBase result = apiInstance.PutTelephonyProvidersEdgesSiteOutboundroute(siteId, outboundRouteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesSiteOutboundroute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **outboundRouteId** | **string**| Outbound route ID |  |
| **body** | [**OutboundRouteBase**](OutboundRouteBase)| OutboundRoute |  |

### Return type

[**OutboundRouteBase**](OutboundRouteBase)


## PutTelephonyProvidersEdgesSiteSiteconnections

> [**SiteConnections**](SiteConnections) PutTelephonyProvidersEdgesSiteSiteconnections (string siteId, SiteConnections body)


Update site connections for a site.

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesSiteSiteconnectionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new SiteConnections(); // SiteConnections | Site

            try
            { 
                // Update site connections for a site.
                SiteConnections result = apiInstance.PutTelephonyProvidersEdgesSiteSiteconnections(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesSiteSiteconnections: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**SiteConnections**](SiteConnections)| Site |  |

### Return type

[**SiteConnections**](SiteConnections)


## PutTelephonyProvidersEdgesTrunkbasesetting

> [**TrunkBase**](TrunkBase) PutTelephonyProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId, TrunkBase body)


Update a Trunk Base Settings object by ID

Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTelephonyProvidersEdgesTrunkbasesettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID
            var body = new TrunkBase(); // TrunkBase | Trunk base settings

            try
            { 
                // Update a Trunk Base Settings object by ID
                TrunkBase result = apiInstance.PutTelephonyProvidersEdgesTrunkbasesetting(trunkBaseSettingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutTelephonyProvidersEdgesTrunkbasesetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
| **body** | [**TrunkBase**](TrunkBase)| Trunk base settings |  |

### Return type

[**TrunkBase**](TrunkBase)


_PureCloudPlatform.Client.V2 220.0.0_
