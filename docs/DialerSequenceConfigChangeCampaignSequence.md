# DialerSequenceConfigChangeCampaignSequence

## ININ.PureCloudApi.Model.DialerSequenceConfigChangeCampaignSequence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaigns** | [**List&lt;DialerSequenceConfigChangeUriReference&gt;**](DialerSequenceConfigChangeUriReference) | the ordered list of campaign identifiers | [optional] |
| **CurrentCampaign** | **long?** | the zero-based index of the current campaign in the campaigns list | [optional] |
| **Status** | **string** |  | [optional] |
| **StopMessage** | **string** | if a sequence has unexpectedly stopped, this message provides the reason | [optional] |
| **Repeat** | **bool?** | indicates if a sequence is to repeat from the beginning after the last campaign completes; default is false | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **GetAdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
