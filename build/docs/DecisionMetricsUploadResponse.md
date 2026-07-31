# DecisionMetricsUploadResponse

## ININ.PureCloudApi.Model.DecisionMetricsUploadResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UploadKey** | **string** | The key to pass to the secondary request to start processing of the upload | [optional] |
| **Url** | **string** | The url to which to PUT the upload body | [optional] |
| **Headers** | **Dictionary&lt;string, string&gt;** | Required headers for the PUT request to the url | [optional] |
| **UploadBodySchema** | [**DecisionMetricsUploadSchema**](DecisionMetricsUploadSchema) | Always null. Defines the schema of the json body to be PUT to the url. The json body should be gzip encoded before uploading | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
