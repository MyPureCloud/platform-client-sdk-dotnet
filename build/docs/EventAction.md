---
title: EventAction
---
## ININ.PureCloudApi.Model.EventAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the action. | |
| **State** | **string** | Current state of the action (e.g. qualified, succeeded, errored). | [optional] |
| **MediaType** | **string** | The media type used to deliver the action (e.g. email, webhook). | [optional] |
| **Prompt** | **string** | Prompt of the action to be displayed/sent to the visitor. | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
{: class="table table-striped"}


