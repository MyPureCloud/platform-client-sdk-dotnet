# ModelData

## ININ.PureCloudApi.Model.ModelData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DownloadUrls** | **List&lt;string&gt;** | List of URLs to fetch the results of the forecast model. This field is populated only if session state is Complete | [optional] |
| **DownloadResult** | [**List&lt;PlanningGroupModel&gt;**](PlanningGroupModel) | Result will always come via downloadUrls; however the schema is included for documentation | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
