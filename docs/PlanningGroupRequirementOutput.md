# PlanningGroupRequirementOutput

## ININ.PureCloudApi.Model.PlanningGroupRequirementOutput

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the planning group to which this output applies | |
| **Intervals** | **List&lt;int?&gt;** | List of interval values that correspond with the requirements granularity that was requested | [optional] |
| **ErrorDetails** | [**List&lt;LongTermRequirementsErrorDetail&gt;**](LongTermRequirementsErrorDetail) | Error details if the intervals cannot be provided for this planning group because of missing data or internal error | [optional] |
| **ServiceGoalDetails** | [**LongTermRequirementsServiceGoalDetail**](LongTermRequirementsServiceGoalDetail) | The service goal details used to generate the requirements | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
