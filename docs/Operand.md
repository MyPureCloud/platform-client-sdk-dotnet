# Operand

## ININ.PureCloudApi.Model.Operand

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The Operand type of the category | |
| **Occurrence** | **int?** | The minimum number of occurrences of the defined operand type | [optional] |
| **Inverted** | **bool?** | Applies a NOT modifier to the operand group | [optional] |
| **Term** | [**Term**](Term) | Filter interaction by word(s) | [optional] |
| **TopicId** | **string** | Filter interaction by topic ID | [optional] |
| **VoiceSecondsPosition** | [**OperandPosition**](OperandPosition) | Dictates when the operand must occur in a voice interaction | [optional] |
| **DigitalWordsPosition** | [**OperandPosition**](OperandPosition) | Dictates when the operand must occur in a digital interaction | [optional] |
| **InfixOperator** | [**InfixOperator**](InfixOperator) | Defines a logical operation that is applied on the current operand, against the following operand | [optional] |
| **Operands** | [**List&lt;Operand&gt;**](Operand) | Contains a new level of operands | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
