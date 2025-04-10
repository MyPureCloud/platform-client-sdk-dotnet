# Worktype

## ININ.PureCloudApi.Model.Worktype

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Worktype. | [optional] |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The description of the Worktype. | [optional] |
| **DateCreated** | **DateTime?** | The creation date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The modified date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DefaultWorkbin** | [**WorkbinReference**](WorkbinReference) | The default Workbin for Workitems created from the Worktype. | [optional] |
| **DefaultStatus** | [**WorkitemStatusReference**](WorkitemStatusReference) | The default status for Workitems created from the Worktype. | [optional] |
| **Statuses** | [**List&lt;WorkitemStatus&gt;**](WorkitemStatus) | The list of possible statuses for Workitems created from the Worktype. | [optional] |
| **DefaultDurationSeconds** | **int?** | The default duration in seconds for Workitems created from the Worktype. | [optional] |
| **DefaultExpirationSeconds** | **int?** | The default expiration time in seconds for Workitems created from the Worktype. | [optional] |
| **DefaultDueDurationSeconds** | **int?** | The default due duration in seconds for Workitems created from the Worktype. | [optional] |
| **DefaultPriority** | **int?** | The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000. | [optional] |
| **DefaultLanguage** | [**LanguageReference**](LanguageReference) | The default language for Workitems created from the Worktype. | [optional] |
| **DefaultTtlSeconds** | **int?** | The default time to time to live in seconds for Workitems created from the Worktype. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The id of the User who modified the Worktype. | [optional] |
| **DefaultQueue** | [**WorkitemQueueReference**](WorkitemQueueReference) | The default queue for Workitems created from the Worktype. | [optional] |
| **DefaultSkills** | [**List&lt;RoutingSkillReference&gt;**](RoutingSkillReference) | The default skills for Workitems created from the Worktype. | [optional] |
| **AssignmentEnabled** | **bool?** | When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false. | [optional] |
| **Schema** | [**WorkitemSchema**](WorkitemSchema) | The schema defining the custom attributes for Workitems created from the Worktype. | [optional] |
| **ServiceLevelTarget** | **int?** | The target service level for Workitems created from the Worktype. The default value is 100. | [optional] |
| **RuleSettings** | [**WorkitemRuleSettings**](WorkitemRuleSettings) | Settings for the worktypes rules. | [optional] |
| **Flow** | [**WorkitemFlowReference**](WorkitemFlowReference) | The flow associated with the Worktype. | [optional] |
| **DefaultScript** | [**WorkitemScriptReference**](WorkitemScriptReference) | The default script for Workitems created from the Worktype. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
