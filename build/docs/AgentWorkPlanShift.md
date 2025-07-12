# AgentWorkPlanShift

## ININ.PureCloudApi.Model.AgentWorkPlanShift

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Days** | [**SetWrapperDayOfWeek**](SetWrapperDayOfWeek) | Days of the week applicable for this shift | |
| **FlexibleStartTime** | **bool?** | Whether the start time of the shift is flexible | |
| **ExactStartTimeMinutesFromMidnight** | **int?** | Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false | |
| **EarliestStartTimeMinutesFromMidnight** | **int?** | Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true | |
| **LatestStartTimeMinutesFromMidnight** | **int?** | Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true | |
| **EarliestStopTimeMinutesFromMidnight** | **int?** | This is the earliest time a shift can end | |
| **ConstrainLatestStopTime** | **bool?** | Whether the latest stop time constraint for the shift is enabled | |
| **LatestStopTimeMinutesFromMidnight** | **int?** | Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true | |
| **FlexiblePaidTime** | **bool?** | Whether the paid time setting for the shift is flexible | |
| **ExactPaidTimeMinutes** | **int?** | Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false | |
| **MinimumPaidTimeMinutes** | **int?** | Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true | |
| **MaximumPaidTimeMinutes** | **int?** | Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true | |
| **Activities** | [**List&lt;AgentWorkPlanActivity&gt;**](AgentWorkPlanActivity) | Activities configured for this shift | |



_PureCloudPlatform.Client.V2 238.0.0_
