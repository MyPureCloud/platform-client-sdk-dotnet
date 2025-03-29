# WorktypeCreate

## ININ.PureCloudApi.Model.WorktypeCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Worktype. Valid length between 3 and 256 characters. | |
| **DefaultWorkbinId** | **string** | The ID of the default Workbin for Workitems created from the Worktype. | |
| **DefaultDurationSeconds** | **int?** | The default duration in seconds for Workitems created from the Worktype. Maximum of 365 days. | [optional] |
| **DefaultExpirationSeconds** | **int?** | The default expiration time in seconds for Workitems created from the Worktype. Maximum of 365 days. | [optional] |
| **DefaultDueDurationSeconds** | **int?** | The default due duration in seconds for Workitems created from the Worktype. Maximum of 365 days. | [optional] |
| **DefaultPriority** | **int?** | The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000. | [optional] |
| **DefaultTtlSeconds** | **int?** | The default time to time to live in seconds for Workitems created from the Worktype. The valid range is between 1 and 365 days. | [optional] |
| **AssignmentEnabled** | **bool?** | When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false. | [optional] |
| **SchemaId** | **string** | The ID of the custom attribute schema for Workitems created from the Worktype. Must be a valid UUID. | [optional] |
| **ServiceLevelTarget** | **int?** | The target service level for Workitems created from the Worktype. The default value is 100. | [optional] |
| **RuleSettings** | [**WorkitemRuleSettings**](WorkitemRuleSettings) | Settings for the worktypes rules. | [optional] |
| **Description** | **string** | The description of the Worktype. Maximum length of 512 characters. | [optional] |
| **DivisionId** | **string** | The ID of the division the Worktype belongs to. Defaults to the default Workbin division ID. The Worktype must be in the same division as its default Workbin. | [optional] |
| **DisableDefaultStatusCreation** | **bool?** | Set to true to disable default status creation. Default statuses are created with the Worktype by default | [optional] |
| **SchemaVersion** | **int?** | The version of the Worktypes custom attribute schema. The latest schema version will be used if this property is not set. | [optional] |
| **DefaultQueueId** | **string** | The ID of the default queue for Workitems created from the Worktype. Must be a valid UUID. | [optional] |
| **DefaultLanguageId** | **string** | The ID of the default language for Workitems created from the Worktype. Must be a valid UUID. | [optional] |
| **DefaultSkillIds** | **List&lt;string&gt;** | The IDs of the default skills for Workitems created from the Worktype. Must be valid UUIDs. Maximum of 20 IDs | [optional] |
| **DefaultScriptId** | **string** | The default script for Workitems created from the Worktype. Must be a valid UUID. | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
