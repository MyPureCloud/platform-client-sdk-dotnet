# ActionTemplate

## ININ.PureCloudApi.Model.ActionTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the action template. | |
| **Description** | **string** | Description of the action template&#39;s functionality. | [optional] |
| **Version** | **int?** | The version of the action template. | [optional] |
| **MediaType** | **string** | Media type of action described by the action template. | |
| **State** | **string** | Whether the action template is currently active, inactive or deleted. | |
| **ContentOffer** | [**ContentOffer**](ContentOffer) | Properties used to configure an action of type content offer | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Date when action template was created in ISO-8601 format. | [optional] |
| **ModifiedDate** | **DateTime?** | Date when action template was last modified in ISO-8601 format. | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
