# ContactListFilterRange

## ININ.PureCloudApi.Model.ContactListFilterRange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Min** | **string** | The minimum value of the range. Required for the operator BETWEEN. | [optional] |
| **Max** | **string** | The maximum value of the range. Required for the operator BETWEEN. | [optional] |
| **MinInclusive** | **bool?** | Whether or not to include the minimum in the range. | [optional] |
| **MaxInclusive** | **bool?** | Whether or not to include the maximum in the range. | [optional] |
| **InSet** | **List&lt;string&gt;** | A set of values that the contact data should be in. Required for the IN operator. | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
