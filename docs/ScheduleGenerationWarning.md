# ScheduleGenerationWarning

## ININ.PureCloudApi.Model.ScheduleGenerationWarning

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | ID of the user in the warning | [optional] |
| **UserNotLicensed** | **bool?** | Whether the user does not have the appropriate license to be scheduled | [optional] |
| **UnableToMeetMaxDays** | **bool?** | Whether the number of scheduled days exceeded the maximum days to schedule defined in the agent work plan | [optional] |
| **UnableToScheduleRequiredDays** | **List&lt;string&gt;** | Days indicated as required to work in agent work plan where no viable shift was found to schedule | [optional] |
| **UnableToMeetMinPaidForTheWeek** | **bool?** | Whether the schedule did not meet the minimum paid time for the week defined in the agent work plan | [optional] |
| **UnableToMeetMaxPaidForTheWeek** | **bool?** | Whether the schedule exceeded the maximum paid time for the week defined in the agent work plan | [optional] |
| **NoNeedDays** | **List&lt;string&gt;** | Days agent was scheduled but there was no need to meet. The scheduled days have no effect on service levels | [optional] |
| **ShiftsTooCloseTogether** | **bool?** | Whether the schedule did not meet the minimum time between shifts defined in the agent work plan | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
