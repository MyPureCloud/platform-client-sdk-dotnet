# DmarcResult

## ININ.PureCloudApi.Model.DmarcResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The DMARC status of this domain | |
| **DetectedPolicy** | **string** | The DMARC policy that was detected in the associated DNS record, if one is present | [optional] |
| **DateChecked** | **DateTime?** | The date of the most recent check of the domain&#39;s DMARC DNS record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Records** | [**List&lt;Record&gt;**](Record) | The minimum DMARC DNS record that Genesys Cloud recommends | |



_PureCloudPlatform.Client.V2 257.0.0_
