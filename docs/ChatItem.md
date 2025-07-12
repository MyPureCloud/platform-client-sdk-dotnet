# ChatItem

## ININ.PureCloudApi.Model.ChatItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Open** | **bool?** | If the chat is open | |
| **Favorite** | [**ChatFavorite**](ChatFavorite) | The favorite entity for the chat, only appears if the chat is favorited | [optional] |
| **Images** | [**List&lt;Image&gt;**](Image) | Avatar images for the chat | [optional] |
| **DateLastMessage** | **DateTime?** | The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateClosed** | **DateTime?** | The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **User** | [**ChatUserRef**](ChatUserRef) | The other 1on1 user | [optional] |
| **Room** | [**Room**](Room) | The room of the chat | [optional] |
| **ChatType** | **string** | The type of chat | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
