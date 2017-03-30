---
title: CampaignSequence
---
## ININ.PureCloudApi.Model.CampaignSequence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Campaigns** | [**List&lt;UriReference&gt;**](UriReference.html) | the ordered list of campaign identifiers | |
| **CurrentCampaign** | **int?** | the zero-based index of the current campaign in the campaigns list | |
| **Status** | **string** | status of the sequence | |
| **StopMessage** | **string** | if a sequence has unexpectedly stopped, this message provides the reason | [optional] |
| **Repeat** | **bool?** | indicates if a sequence is to repeat from the beginning after the last campaign completes; default is false | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


