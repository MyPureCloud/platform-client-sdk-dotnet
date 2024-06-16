---
title: Operand
---
## ININ.PureCloudApi.Model.Operand

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The Operand type of the category | |
| **Occurrence** | **int?** | The minimum number of occurrences of the defined operand type | [optional] |
| **Inverted** | **bool?** | Applies a NOT modifier to the operand group | [optional] |
| **Term** | [**Term**](Term.html) | Filter interaction by word(s) | [optional] |
| **TopicId** | **string** | Filter interaction by topic ID | [optional] |
| **VoiceSecondsPosition** | [**OperandPosition**](OperandPosition.html) | Dictates when the operand must occur in a voice interaction | [optional] |
| **DigitalWordsPosition** | [**OperandPosition**](OperandPosition.html) | Dictates when the operand must occur in a digital interaction | [optional] |
| **InfixOperator** | [**InfixOperator**](InfixOperator.html) | Defines a logical operation that is applied on the current operand, against the following operand | [optional] |
| **Operands** | [**List&lt;Operand&gt;**](Operand.html) | Contains a new level of operands | [optional] |
{: class="table table-striped"}


