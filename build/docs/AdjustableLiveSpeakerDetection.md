# AdjustableLiveSpeakerDetection

## ININ.PureCloudApi.Model.AdjustableLiveSpeakerDetection

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Mode** | **string** | Modes to tune between speed to live speaker detection vs accuracy. | [optional] |
| **PreconnectDuration** | **string** | ISO 8601 formatted relative duration (e.g., PT30.8427419S for 30.8 seconds), calculated on line connect. | [optional] |
| **EventName** | **string** | The name of the event that triggered the ALSD evaluation (e.g., line.connect, speech.generic). | [optional] |
| **IsPersonLikely** | **bool?** | The output of the ALSD detector, evaluating whether there is likely a person on the call based on the above inputs, and if so, a person is detected early (person disposition name and speech.person analyzer result) and the associated action taken (e.g., speech.person postconnect entry in the disposition table has the action to transfer to a queue). | [optional] |
| **TotalRingbacks** | **int?** | Number of tone.ring.* analyzer events detected during the call (expected mostly during pre-connect but the last ringback tone detection could potentially complete after line connect, which will increment totalRingbacks still). | [optional] |
| **LineConnected** | **bool?** | Protocol line connect received (answered by a person, machine, busy, fax). | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
