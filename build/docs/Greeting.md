---
title: Greeting
---
## ININ.PureCloudApi.Model.Greeting

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** | Greeting type | |
| **OwnerType** | **string** | Greeting owner type | |
| **Owner** | [**DomainEntity**](DomainEntity.html) | Greeting owner | |
| **AudioFile** | [**GreetingAudioFile**](GreetingAudioFile.html) |  | [optional] |
| **AudioTTS** | **string** |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


