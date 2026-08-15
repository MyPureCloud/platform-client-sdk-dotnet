# AgenticVirtualAgentRepetitionCheck

## ININ.PureCloudApi.Model.AgenticVirtualAgentRepetitionCheck

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Whether this check looks for repetition in user messages or agent responses. | |
| **Messages** | **int?** | The number of prior messages of the specified type to compare for repetition. | |
| **Similarity** | **string** | The similarity category compared to the Levenshtein result that triggers this check&#39;s instruction. | |
| **Instruction** | **string** | The instruction added to the virtual agent&#39;s turn when message similarity matches the configured category. | |



_PureCloudPlatform.Client.V2 270.0.0_
