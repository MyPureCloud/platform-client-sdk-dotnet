# AlertSummary

## ININ.PureCloudApi.Model.AlertSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Entities** | [**List&lt;AlertSummaryEntity&gt;**](AlertSummaryEntity) | The entities who violated the rule condition over the duration of the alert. | |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef) | The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics. | [optional] |
| **MetricType** | **string** | The metric type that is monitored. | |
| **EntitiesAreTeamMembers** | **bool?** | Flag that indicated whether or not the alert is for a rule with a condition for all members of a team. | |



_PureCloudPlatform.Client.V2 254.0.0_
