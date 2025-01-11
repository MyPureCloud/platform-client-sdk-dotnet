# DialerAction

## ININ.PureCloudApi.Model.DialerAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of this DialerAction. | |
| **ActionTypeName** | **string** | Additional type specification for this DialerAction. | |
| **UpdateOption** | **string** | Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE. | [optional] |
| **Properties** | **Dictionary&lt;string, string&gt;** | A map of key-value pairs pertinent to the DialerAction. Different types of DialerActions require different properties. MODIFY_CONTACT_ATTRIBUTE with an updateOption of SET takes a contact column as the key and accepts any value. SCHEDULE_CALLBACK takes a key &#39;callbackOffset&#39; that specifies how far in the future the callback should be scheduled, in minutes. SET_CALLER_ID takes two keys: &#39;callerAddress&#39;, which should be the caller id phone number, and &#39;callerName&#39;. For either key, you can also specify a column on the contact to get the value from. To do this, specify &#39;contact.Column&#39;, where &#39;Column&#39; is the name of the contact column from which to get the value. SET_SKILLS takes a key &#39;skills&#39; with an array of skill ids wrapped into a string (Example: {&#39;skills&#39;: &#39;[&#39;skillIdHere&#39;]&#39;} ). | [optional] |
| **DataAction** | [**DomainEntityRef**](DomainEntityRef) | The Data Action to use for this action. Required for a dataActionBehavior. | [optional] |
| **ContactColumnToDataActionFieldMappings** | [**List&lt;ContactColumnToDataActionFieldMapping&gt;**](ContactColumnToDataActionFieldMapping) | A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionBehavior. | [optional] |
| **ContactIdField** | **string** | The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionBehavior. | [optional] |
| **CallAnalysisResultField** | **string** | The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionBehavior. | [optional] |
| **AgentWrapupField** | **string** | The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionBehavior. | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
