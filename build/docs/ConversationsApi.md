---
title: ConversationsApi
---
## PureCloudPlatform.Client.V2.Api.ConversationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteConversationParticipantCode**](ConversationsApi.html#deleteconversationparticipantcode) | **DELETE** /api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode} | Delete a code used to add a communication to this participant |
| [**DeleteConversationsCallParticipantConsult**](ConversationsApi.html#deleteconversationscallparticipantconsult) | **DELETE** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Cancel the transfer |
| [**DeleteConversationsEmailMessagesDraftAttachment**](ConversationsApi.html#deleteconversationsemailmessagesdraftattachment) | **DELETE** /api/v2/conversations/emails/{conversationId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**GetAnalyticsConversationDetails**](ConversationsApi.html#getanalyticsconversationdetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetConversation**](ConversationsApi.html#getconversation) | **GET** /api/v2/conversations/{conversationId} | Get conversation |
| [**GetConversationParticipantWrapup**](ConversationsApi.html#getconversationparticipantwrapup) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationParticipantWrapupcodes**](ConversationsApi.html#getconversationparticipantwrapupcodes) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversations**](ConversationsApi.html#getconversations) | **GET** /api/v2/conversations | Get conversations |
| [**GetConversationsCall**](ConversationsApi.html#getconversationscall) | **GET** /api/v2/conversations/calls/{conversationId} | Get call conversation |
| [**GetConversationsCallParticipantWrapup**](ConversationsApi.html#getconversationscallparticipantwrapup) | **GET** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallParticipantWrapupcodes**](ConversationsApi.html#getconversationscallparticipantwrapupcodes) | **GET** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallback**](ConversationsApi.html#getconversationscallback) | **GET** /api/v2/conversations/callbacks/{conversationId} | Get callback conversation |
| [**GetConversationsCallbackParticipantWrapup**](ConversationsApi.html#getconversationscallbackparticipantwrapup) | **GET** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallbackParticipantWrapupcodes**](ConversationsApi.html#getconversationscallbackparticipantwrapupcodes) | **GET** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallbacks**](ConversationsApi.html#getconversationscallbacks) | **GET** /api/v2/conversations/callbacks | Get callback conversations |
| [**GetConversationsCalls**](ConversationsApi.html#getconversationscalls) | **GET** /api/v2/conversations/calls | Get recent conversations |
| [**GetConversationsCallsHistory**](ConversationsApi.html#getconversationscallshistory) | **GET** /api/v2/conversations/calls/history | Get call history |
| [**GetConversationsCallsMaximumconferenceparties**](ConversationsApi.html#getconversationscallsmaximumconferenceparties) | **GET** /api/v2/conversations/calls/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**GetConversationsChat**](ConversationsApi.html#getconversationschat) | **GET** /api/v2/conversations/chats/{conversationId} | Get chat conversation |
| [**GetConversationsChatParticipantWrapup**](ConversationsApi.html#getconversationschatparticipantwrapup) | **GET** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsChatParticipantWrapupcodes**](ConversationsApi.html#getconversationschatparticipantwrapupcodes) | **GET** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsChats**](ConversationsApi.html#getconversationschats) | **GET** /api/v2/conversations/chats | Get recent chat conversations |
| [**GetConversationsCobrowsesession**](ConversationsApi.html#getconversationscobrowsesession) | **GET** /api/v2/conversations/cobrowsesessions/{conversationId} | Get cobrowse conversation |
| [**GetConversationsCobrowsesessionParticipantWrapup**](ConversationsApi.html#getconversationscobrowsesessionparticipantwrapup) | **GET** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCobrowsesessionParticipantWrapupcodes**](ConversationsApi.html#getconversationscobrowsesessionparticipantwrapupcodes) | **GET** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCobrowsesessions**](ConversationsApi.html#getconversationscobrowsesessions) | **GET** /api/v2/conversations/cobrowsesessions | Get recent cobrowse conversations |
| [**GetConversationsEmail**](ConversationsApi.html#getconversationsemail) | **GET** /api/v2/conversations/emails/{conversationId} | Get email conversation |
| [**GetConversationsEmailMessage**](ConversationsApi.html#getconversationsemailmessage) | **GET** /api/v2/conversations/emails/{conversationId}/messages/{messageId} | Get conversation message |
| [**GetConversationsEmailMessages**](ConversationsApi.html#getconversationsemailmessages) | **GET** /api/v2/conversations/emails/{conversationId}/messages | Get conversation messages |
| [**GetConversationsEmailMessagesDraft**](ConversationsApi.html#getconversationsemailmessagesdraft) | **GET** /api/v2/conversations/emails/{conversationId}/messages/draft | Get conversation draft reply |
| [**GetConversationsEmailParticipantWrapup**](ConversationsApi.html#getconversationsemailparticipantwrapup) | **GET** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsEmailParticipantWrapupcodes**](ConversationsApi.html#getconversationsemailparticipantwrapupcodes) | **GET** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsEmails**](ConversationsApi.html#getconversationsemails) | **GET** /api/v2/conversations/emails | Get recent email conversations |
| [**PatchConversationParticipant**](ConversationsApi.html#patchconversationparticipant) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**PatchConversationParticipantAttributes**](ConversationsApi.html#patchconversationparticipantattributes) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCall**](ConversationsApi.html#patchconversationscall) | **PATCH** /api/v2/conversations/calls/{conversationId} | Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants |
| [**PatchConversationsCallParticipant**](ConversationsApi.html#patchconversationscallparticipant) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallParticipantAttributes**](ConversationsApi.html#patchconversationscallparticipantattributes) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallParticipantCommunication**](ConversationsApi.html#patchconversationscallparticipantcommunication) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCallParticipantConsult**](ConversationsApi.html#patchconversationscallparticipantconsult) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Change who can speak |
| [**PatchConversationsCallback**](ConversationsApi.html#patchconversationscallback) | **PATCH** /api/v2/conversations/callbacks/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCallbackParticipant**](ConversationsApi.html#patchconversationscallbackparticipant) | **PATCH** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallbackParticipantAttributes**](ConversationsApi.html#patchconversationscallbackparticipantattributes) | **PATCH** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallbackParticipantCommunication**](ConversationsApi.html#patchconversationscallbackparticipantcommunication) | **PATCH** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsChat**](ConversationsApi.html#patchconversationschat) | **PATCH** /api/v2/conversations/chats/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsChatParticipant**](ConversationsApi.html#patchconversationschatparticipant) | **PATCH** /api/v2/conversations/chats/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsChatParticipantAttributes**](ConversationsApi.html#patchconversationschatparticipantattributes) | **PATCH** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsChatParticipantCommunication**](ConversationsApi.html#patchconversationschatparticipantcommunication) | **PATCH** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCobrowsesession**](ConversationsApi.html#patchconversationscobrowsesession) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCobrowsesessionParticipant**](ConversationsApi.html#patchconversationscobrowsesessionparticipant) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCobrowsesessionParticipantAttributes**](ConversationsApi.html#patchconversationscobrowsesessionparticipantattributes) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCobrowsesessionParticipantCommunication**](ConversationsApi.html#patchconversationscobrowsesessionparticipantcommunication) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsEmail**](ConversationsApi.html#patchconversationsemail) | **PATCH** /api/v2/conversations/emails/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsEmailParticipant**](ConversationsApi.html#patchconversationsemailparticipant) | **PATCH** /api/v2/conversations/emails/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsEmailParticipantAttributes**](ConversationsApi.html#patchconversationsemailparticipantattributes) | **PATCH** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsEmailParticipantCommunication**](ConversationsApi.html#patchconversationsemailparticipantcommunication) | **PATCH** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PostAnalyticsConversationDetailsProperties**](ConversationsApi.html#postanalyticsconversationdetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostAnalyticsConversationsAggregatesQuery**](ConversationsApi.html#postanalyticsconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostAnalyticsConversationsDetailsQuery**](ConversationsApi.html#postanalyticsconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostConversationParticipantCallbacks**](ConversationsApi.html#postconversationparticipantcallbacks) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/callbacks | Create a new callback for the specified participant on the conversation. |
| [**PostConversationParticipantReplace**](ConversationsApi.html#postconversationparticipantreplace) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCall**](ConversationsApi.html#postconversationscall) | **POST** /api/v2/conversations/calls/{conversationId} | Add a new call to a conversation |
| [**PostConversationsCallParticipantConsult**](ConversationsApi.html#postconversationscallparticipantconsult) | **POST** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**PostConversationsCallParticipantMonitor**](ConversationsApi.html#postconversationscallparticipantmonitor) | **POST** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostConversationsCallParticipantReplace**](ConversationsApi.html#postconversationscallparticipantreplace) | **POST** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallParticipants**](ConversationsApi.html#postconversationscallparticipants) | **POST** /api/v2/conversations/calls/{conversationId}/participants | Add participants to a conversation |
| [**PostConversationsCallbackParticipantReplace**](ConversationsApi.html#postconversationscallbackparticipantreplace) | **POST** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallbacks**](ConversationsApi.html#postconversationscallbacks) | **POST** /api/v2/conversations/callbacks | Create a Callback |
| [**PostConversationsCalls**](ConversationsApi.html#postconversationscalls) | **POST** /api/v2/conversations/calls | Create a call conversation |
| [**PostConversationsChatParticipantReplace**](ConversationsApi.html#postconversationschatparticipantreplace) | **POST** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsChats**](ConversationsApi.html#postconversationschats) | **POST** /api/v2/conversations/chats | Create a web chat conversation |
| [**PostConversationsCobrowsesessionParticipantReplace**](ConversationsApi.html#postconversationscobrowsesessionparticipantreplace) | **POST** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmailMessages**](ConversationsApi.html#postconversationsemailmessages) | **POST** /api/v2/conversations/emails/{conversationId}/messages | Send an email reply |
| [**PostConversationsEmailParticipantReplace**](ConversationsApi.html#postconversationsemailparticipantreplace) | **POST** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmails**](ConversationsApi.html#postconversationsemails) | **POST** /api/v2/conversations/emails | Create an email conversation |
| [**PostConversationsFaxes**](ConversationsApi.html#postconversationsfaxes) | **POST** /api/v2/conversations/faxes | Create Fax Conversation |
| [**PutConversationsEmailMessagesDraft**](ConversationsApi.html#putconversationsemailmessagesdraft) | **PUT** /api/v2/conversations/emails/{conversationId}/messages/draft | Update conversation draft reply |
{: class="table table-striped"}

<a name="deleteconversationparticipantcode"></a>

## void DeleteConversationParticipantCode (string conversationId, string participantId, string addCommunicationCode)

Delete a code used to add a communication to this participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationParticipantCodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var addCommunicationCode = addCommunicationCode_example;  // string | addCommunicationCode

            try
            {
                // Delete a code used to add a communication to this participant
                apiInstance.DeleteConversationParticipantCode(conversationId, participantId, addCommunicationCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationParticipantCode: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **addCommunicationCode** | **string**| addCommunicationCode |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationscallparticipantconsult"></a>

## void DeleteConversationsCallParticipantConsult (string conversationId, string participantId)

Cancel the transfer



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsCallParticipantConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Cancel the transfer
                apiInstance.DeleteConversationsCallParticipantConsult(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsemailmessagesdraftattachment"></a>

## void DeleteConversationsEmailMessagesDraftAttachment (string conversationId, string attachmentId)

Delete attachment from draft



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsEmailMessagesDraftAttachmentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var attachmentId = attachmentId_example;  // string | attachmentId

            try
            {
                // Delete attachment from draft
                apiInstance.DeleteConversationsEmailMessagesDraftAttachment(conversationId, attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsEmailMessagesDraftAttachment: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **attachmentId** | **string**| attachmentId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getanalyticsconversationdetails"></a>

## [**AnalyticsConversation**](AnalyticsConversation.html) GetAnalyticsConversationDetails (string conversationId)

Get a conversation by id



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get a conversation by id
                AnalyticsConversation result = apiInstance.GetAnalyticsConversationDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationDetails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversation**](AnalyticsConversation.html)

<a name="getconversation"></a>

## [**Conversation**](Conversation.html) GetConversation (string conversationId)

Get conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            {
                // Get conversation
                Conversation result = apiInstance.GetConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="getconversationparticipantwrapup"></a>

## [**WrapupCode**](WrapupCode.html) GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                WrapupCode result = apiInstance.GetConversationParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getconversationparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationParticipantWrapupcodes (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversations"></a>

## [**ConversationEntityListing**](ConversationEntityListing.html) GetConversations (string communicationType = null)

Get conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var communicationType = communicationType_example;  // string | Call or Chat communication filtering (optional) 

            try
            {
                // Get conversations
                ConversationEntityListing result = apiInstance.GetConversations(communicationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **communicationType** | **string**| Call or Chat communication filtering | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationEntityListing**](ConversationEntityListing.html)

<a name="getconversationscall"></a>

## [**CallConversation**](CallConversation.html) GetConversationsCall (string conversationId)

Get call conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get call conversation
                CallConversation result = apiInstance.GetConversationsCall(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCall: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**CallConversation**](CallConversation.html)

<a name="getconversationscallparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetConversationsCallParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetConversationsCallParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getconversationscallparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCallParticipantWrapupcodes (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsCallParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscallback"></a>

## [**CallbackConversation**](CallbackConversation.html) GetConversationsCallback (string conversationId)

Get callback conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get callback conversation
                CallbackConversation result = apiInstance.GetConversationsCallback(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallback: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**CallbackConversation**](CallbackConversation.html)

<a name="getconversationscallbackparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetConversationsCallbackParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetConversationsCallbackParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbackParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getconversationscallbackparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCallbackParticipantWrapupcodes (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsCallbackParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbackParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscallbacks"></a>

## [**CallbackConversationEntityListing**](CallbackConversationEntityListing.html) GetConversationsCallbacks ()

Get callback conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbacksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get callback conversations
                CallbackConversationEntityListing result = apiInstance.GetConversationsCallbacks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbacks: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CallbackConversationEntityListing**](CallbackConversationEntityListing.html)

<a name="getconversationscalls"></a>

## [**CallConversationEntityListing**](CallConversationEntityListing.html) GetConversationsCalls ()

Get recent conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get recent conversations
                CallConversationEntityListing result = apiInstance.GetConversationsCalls();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCalls: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CallConversationEntityListing**](CallConversationEntityListing.html)

<a name="getconversationscallshistory"></a>

## [**CallConversationEntityListing**](CallConversationEntityListing.html) GetConversationsCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null)

Get call history



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var interval = interval_example;  // string | Interval string; format is ISO-8601. Separate start and end times with forward slash '/' (optional) 

            try
            {
                // Get call history
                CallConversationEntityListing result = apiInstance.GetConversationsCallsHistory(pageSize, pageNumber, interval);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallsHistory: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **interval** | **string**| Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; | [optional]  |
{: class="table table-striped"}

### Return type

[**CallConversationEntityListing**](CallConversationEntityListing.html)

<a name="getconversationscallsmaximumconferenceparties"></a>

## [**MaxParticipants**](MaxParticipants.html) GetConversationsCallsMaximumconferenceparties ()

Get the maximum number of participants that this user can have on a conference



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsMaximumconferencepartiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get the maximum number of participants that this user can have on a conference
                MaxParticipants result = apiInstance.GetConversationsCallsMaximumconferenceparties();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallsMaximumconferenceparties: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**MaxParticipants**](MaxParticipants.html)

<a name="getconversationschat"></a>

## [**ChatConversation**](ChatConversation.html) GetConversationsChat (string conversationId)

Get chat conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get chat conversation
                ChatConversation result = apiInstance.GetConversationsChat(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChat: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="getconversationschatparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetConversationsChatParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetConversationsChatParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getconversationschatparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsChatParticipantWrapupcodes (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsChatParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationschats"></a>

## [**ChatConversationEntityListing**](ChatConversationEntityListing.html) GetConversationsChats ()

Get recent chat conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get recent chat conversations
                ChatConversationEntityListing result = apiInstance.GetConversationsChats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChats: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ChatConversationEntityListing**](ChatConversationEntityListing.html)

<a name="getconversationscobrowsesession"></a>

## [**CobrowseConversation**](CobrowseConversation.html) GetConversationsCobrowsesession (string conversationId)

Get cobrowse conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get cobrowse conversation
                CobrowseConversation result = apiInstance.GetConversationsCobrowsesession(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesession: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**CobrowseConversation**](CobrowseConversation.html)

<a name="getconversationscobrowsesessionparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetConversationsCobrowsesessionParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetConversationsCobrowsesessionParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessionParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getconversationscobrowsesessionparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCobrowsesessionParticipantWrapupcodes (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsCobrowsesessionParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessionParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscobrowsesessions"></a>

## [**CobrowseConversationEntityListing**](CobrowseConversationEntityListing.html) GetConversationsCobrowsesessions ()

Get recent cobrowse conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get recent cobrowse conversations
                CobrowseConversationEntityListing result = apiInstance.GetConversationsCobrowsesessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CobrowseConversationEntityListing**](CobrowseConversationEntityListing.html)

<a name="getconversationsemail"></a>

## [**EmailConversation**](EmailConversation.html) GetConversationsEmail (string conversationId)

Get email conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get email conversation
                EmailConversation result = apiInstance.GetConversationsEmail(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmail: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="getconversationsemailmessage"></a>

## [**EmailMessage**](EmailMessage.html) GetConversationsEmailMessage (string conversationId, string messageId)

Get conversation message



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId

            try
            {
                // Get conversation message
                EmailMessage result = apiInstance.GetConversationsEmailMessage(conversationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessage: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getconversationsemailmessages"></a>

## [**EmailMessageListing**](EmailMessageListing.html) GetConversationsEmailMessages (string conversationId)

Get conversation messages



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get conversation messages
                EmailMessageListing result = apiInstance.GetConversationsEmailMessages(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**EmailMessageListing**](EmailMessageListing.html)

<a name="getconversationsemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) GetConversationsEmailMessagesDraft (string conversationId)

Get conversation draft reply



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessagesDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get conversation draft reply
                EmailMessage result = apiInstance.GetConversationsEmailMessagesDraft(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getconversationsemailparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetConversationsEmailParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetConversationsEmailParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getconversationsemailparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsEmailParticipantWrapupcodes (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsEmailParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationsemails"></a>

## [**EmailConversationEntityListing**](EmailConversationEntityListing.html) GetConversationsEmails ()

Get recent email conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get recent email conversations
                EmailConversationEntityListing result = apiInstance.GetConversationsEmails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EmailConversationEntityListing**](EmailConversationEntityListing.html)

<a name="patchconversationparticipant"></a>

## void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body)

Update a participant.

Update conversation participant.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            {
                // Update a participant.
                apiInstance.PatchConversationParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationparticipantattributes"></a>

## void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscall"></a>

## [**Conversation**](Conversation.html) PatchConversationsCall (string conversationId, Conversation body)

Update a conversation by setting it's recording state, merging in other conversations to create a conference, or disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by setting it's recording state, merging in other conversations to create a conference, or disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCall(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCall: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscallparticipant"></a>

## void PatchConversationsCallParticipant (string conversationId, string participantId, MediaParticipantRequest body)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant request

            try
            {
                // Update conversation participant
                apiInstance.PatchConversationsCallParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallparticipantattributes"></a>

## void PatchConversationsCallParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsCallParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsCallParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsCallParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationscallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PatchConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransferUpdate body)

Change who can speak



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferUpdate(); // ConsultTransferUpdate | new speak to

            try
            {
                // Change who can speak
                ConsultTransferResponse result = apiInstance.PatchConversationsCallParticipantConsult(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate.html)| new speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="patchconversationscallback"></a>

## [**Conversation**](Conversation.html) PatchConversationsCallback (string conversationId, Conversation body)

Update a conversation by disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCallback(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallback: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscallbackparticipant"></a>

## void PatchConversationsCallbackParticipant (string conversationId, string participantId, MediaParticipantRequest body)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant
                apiInstance.PatchConversationsCallbackParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallbackparticipantattributes"></a>

## void PatchConversationsCallbackParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsCallbackParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallbackparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsCallbackParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsCallbackParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationschat"></a>

## [**Conversation**](Conversation.html) PatchConversationsChat (string conversationId, Conversation body)

Update a conversation by disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsChat(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChat: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationschatparticipant"></a>

## void PatchConversationsChatParticipant (string conversationId, string participantId, MediaParticipantRequest body)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            {
                // Update conversation participant
                apiInstance.PatchConversationsChatParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationschatparticipantattributes"></a>

## void PatchConversationsChatParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsChatParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationschatparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsChatParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsChatParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationscobrowsesession"></a>

## [**Conversation**](Conversation.html) PatchConversationsCobrowsesession (string conversationId, Conversation body)

Update a conversation by disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCobrowsesession(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesession: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscobrowsesessionparticipant"></a>

## void PatchConversationsCobrowsesessionParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            {
                // Update conversation participant
                apiInstance.PatchConversationsCobrowsesessionParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscobrowsesessionparticipantattributes"></a>

## void PatchConversationsCobrowsesessionParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsCobrowsesessionParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscobrowsesessionparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsCobrowsesessionParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsCobrowsesessionParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationsemail"></a>

## [**Conversation**](Conversation.html) PatchConversationsEmail (string conversationId, Conversation body)

Update a conversation by disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsEmail(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmail: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationsemailparticipant"></a>

## void PatchConversationsEmailParticipant (string conversationId, string participantId, MediaParticipantRequest body)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            {
                // Update conversation participant
                apiInstance.PatchConversationsEmailParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsemailparticipantattributes"></a>

## void PatchConversationsEmailParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsEmailParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsemailparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsEmailParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsEmailParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="postanalyticsconversationdetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)

Index conversation properties



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationDetailsPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new PropertyIndexRequest(); // PropertyIndexRequest | request

            try
            {
                // Index conversation properties
                PropertyIndexRequest result = apiInstance.PostAnalyticsConversationDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationDetailsProperties: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postanalyticsconversationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostAnalyticsConversationsAggregatesQuery (AggregationQuery body)

Query for conversation aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new AggregationQuery(); // AggregationQuery | query

            try
            {
                // Query for conversation aggregates
                AggregateQueryResponse result = apiInstance.PostAnalyticsConversationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postanalyticsconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostAnalyticsConversationsDetailsQuery (ConversationQuery body)

Query for conversation details



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsDetailsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new ConversationQuery(); // ConversationQuery | query

            try
            {
                // Query for conversation details
                AnalyticsConversationQueryResponse result = apiInstance.PostAnalyticsConversationsDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsDetailsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationQuery**](ConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postconversationparticipantcallbacks"></a>

## void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null)

Create a new callback for the specified participant on the conversation.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantCallbacksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new CreateCallbackCommand(); // CreateCallbackCommand |  (optional) 

            try
            {
                // Create a new callback for the specified participant on the conversation.
                apiInstance.PostConversationParticipantCallbacks(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantCallbacks: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantreplace"></a>

## void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscall"></a>

## [**Conversation**](Conversation.html) PostConversationsCall (string conversationId, CallCommand body)

Add a new call to a conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new CallCommand(); // CallCommand | Conversation

            try
            {
                // Add a new call to a conversation
                Conversation result = apiInstance.PostConversationsCall(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCall: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**CallCommand**](CallCommand.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postconversationscallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransfer body)

Initiate and update consult transfer



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransfer(); // ConsultTransfer | Destination address & initial speak to

            try
            {
                // Initiate and update consult transfer
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantConsult(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransfer**](ConsultTransfer.html)| Destination address &amp; initial speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postconversationscallparticipantmonitor"></a>

## void PostConversationsCallParticipantMonitor (string conversationId, string participantId)

Listen in on the conversation from the point of view of a given participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantMonitorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Listen in on the conversation from the point of view of a given participant.
                apiInstance.PostConversationsCallParticipantMonitor(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantMonitor: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipantreplace"></a>

## void PostConversationsCallParticipantReplace (string conversationId, string participantId, TransferRequest body)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCallParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipants"></a>

## [**Conversation**](Conversation.html) PostConversationsCallParticipants (string conversationId, Conversation body)

Add participants to a conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Add participants to a conversation
                Conversation result = apiInstance.PostConversationsCallParticipants(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipants: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postconversationscallbackparticipantreplace"></a>

## void PostConversationsCallbackParticipantReplace (string conversationId, string participantId, TransferRequest body)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbackParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCallbackParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbackParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallbacks"></a>

## [**CreateCallbackResponse**](CreateCallbackResponse.html) PostConversationsCallbacks (CreateCallbackCommand body)

Create a Callback



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbacksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new CreateCallbackCommand(); // CreateCallbackCommand | Callback

            try
            {
                // Create a Callback
                CreateCallbackResponse result = apiInstance.PostConversationsCallbacks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbacks: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand.html)| Callback |  |
{: class="table table-striped"}

### Return type

[**CreateCallbackResponse**](CreateCallbackResponse.html)

<a name="postconversationscalls"></a>

## [**CreateCallResponse**](CreateCallResponse.html) PostConversationsCalls (CreateCallRequest body)

Create a call conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new CreateCallRequest(); // CreateCallRequest | Call request

            try
            {
                // Create a call conversation
                CreateCallResponse result = apiInstance.PostConversationsCalls(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCalls: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallRequest**](CreateCallRequest.html)| Call request |  |
{: class="table table-striped"}

### Return type

[**CreateCallResponse**](CreateCallResponse.html)

<a name="postconversationschatparticipantreplace"></a>

## void PostConversationsChatParticipantReplace (string conversationId, string participantId, TransferRequest body)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsChatParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationschats"></a>

## [**ChatConversation**](ChatConversation.html) PostConversationsChats (CreateWebChatRequest body)

Create a web chat conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new CreateWebChatRequest(); // CreateWebChatRequest | Create web chat request

            try
            {
                // Create a web chat conversation
                ChatConversation result = apiInstance.PostConversationsChats(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChats: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateWebChatRequest**](CreateWebChatRequest.html)| Create web chat request |  |
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="postconversationscobrowsesessionparticipantreplace"></a>

## void PostConversationsCobrowsesessionParticipantReplace (string conversationId, string participantId, TransferRequest body = null)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCobrowsesessionParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCobrowsesessionParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCobrowsesessionParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsemailmessages"></a>

## [**EmailMessage**](EmailMessage.html) PostConversationsEmailMessages (string conversationId, EmailMessage body)

Send an email reply



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new EmailMessage(); // EmailMessage | Reply

            try
            {
                // Send an email reply
                EmailMessage result = apiInstance.PostConversationsEmailMessages(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Reply |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="postconversationsemailparticipantreplace"></a>

## void PostConversationsEmailParticipantReplace (string conversationId, string participantId, TransferRequest body)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsEmailParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsemails"></a>

## [**EmailConversation**](EmailConversation.html) PostConversationsEmails (CreateEmailRequest body)

Create an email conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new CreateEmailRequest(); // CreateEmailRequest | Create email request

            try
            {
                // Create an email conversation
                EmailConversation result = apiInstance.PostConversationsEmails(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateEmailRequest**](CreateEmailRequest.html)| Create email request |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="postconversationsfaxes"></a>

## [**FaxSendResponse**](FaxSendResponse.html) PostConversationsFaxes (FaxSendRequest body)

Create Fax Conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsFaxesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new FaxSendRequest(); // FaxSendRequest | Fax

            try
            {
                // Create Fax Conversation
                FaxSendResponse result = apiInstance.PostConversationsFaxes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsFaxes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FaxSendRequest**](FaxSendRequest.html)| Fax |  |
{: class="table table-striped"}

### Return type

[**FaxSendResponse**](FaxSendResponse.html)

<a name="putconversationsemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) PutConversationsEmailMessagesDraft (string conversationId, EmailMessage body)

Update conversation draft reply



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsEmailMessagesDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new EmailMessage(); // EmailMessage | Draft

            try
            {
                // Update conversation draft reply
                EmailMessage result = apiInstance.PutConversationsEmailMessagesDraft(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Draft |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

