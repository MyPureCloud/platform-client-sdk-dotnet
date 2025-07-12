# Greeting

## ININ.PureCloudApi.Model.Greeting

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** | Greeting type | |
| **OwnerType** | **string** | Greeting owner type | |
| **Owner** | [**DomainEntity**](DomainEntity) | Greeting owner | |
| **AudioFile** | [**GreetingAudioFile**](GreetingAudioFile) |  | [optional] |
| **AudioTTS** | **string** |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
