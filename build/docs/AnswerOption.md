# AnswerOption

## ININ.PureCloudApi.Model.AnswerOption

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **BuiltInType** | **string** | The built-in type of this answer option. Only used for built-in answer options such as selection states for Multiple Select answer options. Possible values include: Selected, Unselected | [optional] |
| **Text** | **string** |  | [optional] |
| **Value** | **int?** |  | [optional] |
| **AssistanceConditions** | [**List&lt;AssistanceCondition&gt;**](AssistanceCondition) | List of assistance conditions which are combined together with a logical AND operator. Eg ( assistanceCondtion1 &amp;&amp; assistanceCondition2 ) wherein assistanceCondition could be ( EXISTS topic1 || topic2 || ... ) or (NOTEXISTS topic3 || topic4 || ...). | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
