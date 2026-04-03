# LongTermRequirements

## ININ.PureCloudApi.Model.LongTermRequirements

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ForecastMetadata** | [**ForecastMetadata**](ForecastMetadata) | Forecast metadata | |
| **DateGenerationStarted** | **DateTime?** | Date the generation of the requirements started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Months** | [**List&lt;YearMonth&gt;**](YearMonth) | The list of months covered by the long-term staffing requirements, formatted as yyyy-MM | [optional] |
| **RequirementResults** | [**List&lt;PlanningGroupRequirementOutput&gt;**](PlanningGroupRequirementOutput) | List of planning group outputs | |



_PureCloudPlatform.Client.V2 261.0.0_
