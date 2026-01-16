# IntegrationsApi

## PureCloudPlatform.Client.V2.Api.IntegrationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIntegration**](#DeleteIntegration) | **Delete** /api/v2/integrations/{integrationId} | Delete integration. |
| [**DeleteIntegrationsAction**](#DeleteIntegrationsAction) | **Delete** /api/v2/integrations/actions/{actionId} | Delete an Action |
| [**DeleteIntegrationsActionDraft**](#DeleteIntegrationsActionDraft) | **Delete** /api/v2/integrations/actions/{actionId}/draft | Delete a Draft |
| [**DeleteIntegrationsCredential**](#DeleteIntegrationsCredential) | **Delete** /api/v2/integrations/credentials/{credentialId} | Delete a set of credentials |
| [**GetIntegration**](#GetIntegration) | **Get** /api/v2/integrations/{integrationId} | Get integration. |
| [**GetIntegrationConfigCurrent**](#GetIntegrationConfigCurrent) | **Get** /api/v2/integrations/{integrationId}/config/current | Get integration configuration. |
| [**GetIntegrations**](#GetIntegrations) | **Get** /api/v2/integrations | List integrations |
| [**GetIntegrationsAction**](#GetIntegrationsAction) | **Get** /api/v2/integrations/actions/{actionId} | Retrieves a single Action matching id. |
| [**GetIntegrationsActionDraft**](#GetIntegrationsActionDraft) | **Get** /api/v2/integrations/actions/{actionId}/draft | Retrieve a Draft |
| [**GetIntegrationsActionDraftFunction**](#GetIntegrationsActionDraftFunction) | **Get** /api/v2/integrations/actions/{actionId}/draft/function | Get draft function settings for Action |
| [**GetIntegrationsActionDraftSchema**](#GetIntegrationsActionDraftSchema) | **Get** /api/v2/integrations/actions/{actionId}/draft/schemas/{fileName} | Retrieve schema for a Draft based on filename. |
| [**GetIntegrationsActionDraftTemplate**](#GetIntegrationsActionDraftTemplate) | **Get** /api/v2/integrations/actions/{actionId}/draft/templates/{fileName} | Retrieve templates for a Draft based on filename. |
| [**GetIntegrationsActionDraftValidation**](#GetIntegrationsActionDraftValidation) | **Get** /api/v2/integrations/actions/{actionId}/draft/validation | Validate current Draft configuration. |
| [**GetIntegrationsActionFunction**](#GetIntegrationsActionFunction) | **Get** /api/v2/integrations/actions/{actionId}/function | Get published function settings for Action |
| [**GetIntegrationsActionSchema**](#GetIntegrationsActionSchema) | **Get** /api/v2/integrations/actions/{actionId}/schemas/{fileName} | Retrieve schema for an action based on filename. |
| [**GetIntegrationsActionTemplate**](#GetIntegrationsActionTemplate) | **Get** /api/v2/integrations/actions/{actionId}/templates/{fileName} | Retrieve text of templates for an action based on filename. |
| [**GetIntegrationsActions**](#GetIntegrationsActions) | **Get** /api/v2/integrations/actions | Retrieves all actions associated with filters passed in via query param. |
| [**GetIntegrationsActionsCategories**](#GetIntegrationsActionsCategories) | **Get** /api/v2/integrations/actions/categories | Retrieves all categories of available Actions |
| [**GetIntegrationsActionsCertificates**](#GetIntegrationsActionsCertificates) | **Get** /api/v2/integrations/actions/certificates | Retrieves the available mTLS client certificates in use. This endpoint will return inconsistent results while a certificate rotation is in progress. |
| [**GetIntegrationsActionsCertificatesTruststore**](#GetIntegrationsActionsCertificatesTruststore) | **Get** /api/v2/integrations/actions/certificates/truststore | Retrieves basic info about trusted root CA certificates |
| [**GetIntegrationsActionsDrafts**](#GetIntegrationsActionsDrafts) | **Get** /api/v2/integrations/actions/drafts | Retrieves all action drafts associated with the filters passed in via query param. |
| [**GetIntegrationsActionsFunctionsRuntimes**](#GetIntegrationsActionsFunctionsRuntimes) | **Get** /api/v2/integrations/actions/functions/runtimes | Get action function settings for Action |
| [**GetIntegrationsBotconnectorBot**](#GetIntegrationsBotconnectorBot) | **Get** /api/v2/integrations/botconnectors/{integrationId}/bots/{botId} | Get a specific Bot details |
| [**GetIntegrationsBotconnectorBots**](#GetIntegrationsBotconnectorBots) | **Get** /api/v2/integrations/botconnectors/{integrationId}/bots | Get the list of bots for this integration. |
| [**GetIntegrationsBotconnectorBotsSummaries**](#GetIntegrationsBotconnectorBotsSummaries) | **Get** /api/v2/integrations/botconnectors/{integrationId}/bots/summaries | Get the summary list of bots for this integration. |
| [**GetIntegrationsBotconnectorIntegrationIdBot**](#GetIntegrationsBotconnectorIntegrationIdBot) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots/{botId} | Get a specific botConnector bot, plus versions, for this integration |
| [**GetIntegrationsBotconnectorIntegrationIdBotVersions**](#GetIntegrationsBotconnectorIntegrationIdBotVersions) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots/{botId}/versions | Get a list of bot versions for a bot |
| [**GetIntegrationsBotconnectorIntegrationIdBots**](#GetIntegrationsBotconnectorIntegrationIdBots) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots | Get a list of botConnector bots for this integration |
| [**GetIntegrationsBotconnectorIntegrationIdBotsSummaries**](#GetIntegrationsBotconnectorIntegrationIdBotsSummaries) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots/summaries | Get a summary list of botConnector bots for this integration |
| [**GetIntegrationsClientapps**](#GetIntegrationsClientapps) | **Get** /api/v2/integrations/clientapps | List permitted client app integrations for the logged in user |
| [**GetIntegrationsClientappsUnifiedcommunications**](#GetIntegrationsClientappsUnifiedcommunications) | **Get** /api/v2/integrations/clientapps/unifiedcommunications | UC integration client application configuration. |
| [**GetIntegrationsCredential**](#GetIntegrationsCredential) | **Get** /api/v2/integrations/credentials/{credentialId} | Get a single credential with sensitive fields redacted |
| [**GetIntegrationsCredentials**](#GetIntegrationsCredentials) | **Get** /api/v2/integrations/credentials | List multiple sets of credentials |
| [**GetIntegrationsCredentialsListing**](#GetIntegrationsCredentialsListing) | **Get** /api/v2/integrations/credentials/listing | List multiple sets of credentials using cursor-based paging |
| [**GetIntegrationsCredentialsTypes**](#GetIntegrationsCredentialsTypes) | **Get** /api/v2/integrations/credentials/types | List all credential types |
| [**GetIntegrationsSpeechAudioconnector**](#GetIntegrationsSpeechAudioconnector) | **Get** /api/v2/integrations/speech/audioconnector | Get a list of Audio Connector integrations |
| [**GetIntegrationsSpeechAudioconnectorIntegrationId**](#GetIntegrationsSpeechAudioconnectorIntegrationId) | **Get** /api/v2/integrations/speech/audioconnector/{integrationId} | Get an Audio Connector integration |
| [**GetIntegrationsSpeechDialogflowAgent**](#GetIntegrationsSpeechDialogflowAgent) | **Get** /api/v2/integrations/speech/dialogflow/agents/{agentId} | Get details about a Dialogflow agent |
| [**GetIntegrationsSpeechDialogflowAgents**](#GetIntegrationsSpeechDialogflowAgents) | **Get** /api/v2/integrations/speech/dialogflow/agents | Get a list of Dialogflow agents in the customers&#39; Google accounts |
| [**GetIntegrationsSpeechDialogflowcxAgent**](#GetIntegrationsSpeechDialogflowcxAgent) | **Get** /api/v2/integrations/speech/dialogflowcx/agents/{agentId} | Get details about a Dialogflow CX agent |
| [**GetIntegrationsSpeechDialogflowcxAgents**](#GetIntegrationsSpeechDialogflowcxAgents) | **Get** /api/v2/integrations/speech/dialogflowcx/agents | Get a list of Dialogflow CX agents in the customers&#39; Google accounts |
| [**GetIntegrationsSpeechLexBotAlias**](#GetIntegrationsSpeechLexBotAlias) | **Get** /api/v2/integrations/speech/lex/bot/alias/{aliasId} | Get details about a Lex bot alias |
| [**GetIntegrationsSpeechLexBotBotIdAliases**](#GetIntegrationsSpeechLexBotBotIdAliases) | **Get** /api/v2/integrations/speech/lex/bot/{botId}/aliases | Get a list of aliases for a bot in the customer&#39;s AWS accounts |
| [**GetIntegrationsSpeechLexBots**](#GetIntegrationsSpeechLexBots) | **Get** /api/v2/integrations/speech/lex/bots | Get a list of Lex bots in the customers&#39; AWS accounts |
| [**GetIntegrationsSpeechLexv2BotAlias**](#GetIntegrationsSpeechLexv2BotAlias) | **Get** /api/v2/integrations/speech/lexv2/bot/alias/{aliasId} | Get details about a Lex V2 bot alias |
| [**GetIntegrationsSpeechLexv2BotBotIdAliases**](#GetIntegrationsSpeechLexv2BotBotIdAliases) | **Get** /api/v2/integrations/speech/lexv2/bot/{botId}/aliases | Get a list of aliases for a Lex V2 bot |
| [**GetIntegrationsSpeechLexv2Bots**](#GetIntegrationsSpeechLexv2Bots) | **Get** /api/v2/integrations/speech/lexv2/bots | Get a list of Lex V2 bots |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBot**](#GetIntegrationsSpeechNuanceNuanceIntegrationIdBot) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId} | Get a Nuance bot in the specified Integration |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob**](#GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId} | Get the status of an asynchronous Nuance bot GET job |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults**](#GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId}/results | Get the result of an asynchronous Nuance bot GET job |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBots**](#GetIntegrationsSpeechNuanceNuanceIntegrationIdBots) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots | Get a list of Nuance bots available in the specified Integration |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob**](#GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId} | Get the status of an asynchronous Nuance bots GET job |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults**](#GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId}/results | Get the result of an asynchronous Nuance bots GET job |
| [**GetIntegrationsSpeechSttEngine**](#GetIntegrationsSpeechSttEngine) | **Get** /api/v2/integrations/speech/stt/engines/{engineId} | Get details about a STT engine |
| [**GetIntegrationsSpeechSttEngines**](#GetIntegrationsSpeechSttEngines) | **Get** /api/v2/integrations/speech/stt/engines | Get a list of STT engines enabled for org |
| [**GetIntegrationsSpeechTtsEngine**](#GetIntegrationsSpeechTtsEngine) | **Get** /api/v2/integrations/speech/tts/engines/{engineId} | Get details about a TTS engine |
| [**GetIntegrationsSpeechTtsEngineVoice**](#GetIntegrationsSpeechTtsEngineVoice) | **Get** /api/v2/integrations/speech/tts/engines/{engineId}/voices/{voiceId} | Get details about a specific voice for a TTS engine |
| [**GetIntegrationsSpeechTtsEngineVoices**](#GetIntegrationsSpeechTtsEngineVoices) | **Get** /api/v2/integrations/speech/tts/engines/{engineId}/voices | Get a list of voices for a TTS engine |
| [**GetIntegrationsSpeechTtsEngines**](#GetIntegrationsSpeechTtsEngines) | **Get** /api/v2/integrations/speech/tts/engines | Get a list of TTS engines enabled for org |
| [**GetIntegrationsSpeechTtsSettings**](#GetIntegrationsSpeechTtsSettings) | **Get** /api/v2/integrations/speech/tts/settings | Get TTS settings for an org |
| [**GetIntegrationsType**](#GetIntegrationsType) | **Get** /api/v2/integrations/types/{typeId} | Get integration type. |
| [**GetIntegrationsTypeConfigschema**](#GetIntegrationsTypeConfigschema) | **Get** /api/v2/integrations/types/{typeId}/configschemas/{configType} | Get properties config schema for an integration type. |
| [**GetIntegrationsTypes**](#GetIntegrationsTypes) | **Get** /api/v2/integrations/types | List integration types |
| [**GetIntegrationsUnifiedcommunicationsClientapp**](#GetIntegrationsUnifiedcommunicationsClientapp) | **Get** /api/v2/integrations/unifiedcommunications/clientapps/{ucIntegrationId} | UC integration client application configuration. |
| [**GetIntegrationsUnifiedcommunicationsClientapps**](#GetIntegrationsUnifiedcommunicationsClientapps) | **Get** /api/v2/integrations/unifiedcommunications/clientapps | List UC integration client application configurations. |
| [**GetIntegrationsUserapps**](#GetIntegrationsUserapps) | **Get** /api/v2/integrations/userapps | List permitted user app integrations for the logged in user |
| [**PatchIntegration**](#PatchIntegration) | **Patch** /api/v2/integrations/{integrationId} | Update an integration. |
| [**PatchIntegrationsAction**](#PatchIntegrationsAction) | **Patch** /api/v2/integrations/actions/{actionId} | Patch an Action |
| [**PatchIntegrationsActionDraft**](#PatchIntegrationsActionDraft) | **Patch** /api/v2/integrations/actions/{actionId}/draft | Update an existing Draft |
| [**PostIntegrations**](#PostIntegrations) | **Post** /api/v2/integrations | Create an integration. |
| [**PostIntegrationsActionDraft**](#PostIntegrationsActionDraft) | **Post** /api/v2/integrations/actions/{actionId}/draft | Create a new Draft from existing Action |
| [**PostIntegrationsActionDraftFunctionUpload**](#PostIntegrationsActionDraftFunctionUpload) | **Post** /api/v2/integrations/actions/{actionId}/draft/function/upload | Create upload presigned URL for draft function package file. |
| [**PostIntegrationsActionDraftPublish**](#PostIntegrationsActionDraftPublish) | **Post** /api/v2/integrations/actions/{actionId}/draft/publish | Publish a Draft and make it the active Action configuration |
| [**PostIntegrationsActionDraftTest**](#PostIntegrationsActionDraftTest) | **Post** /api/v2/integrations/actions/{actionId}/draft/test | Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActionExecute**](#PostIntegrationsActionExecute) | **Post** /api/v2/integrations/actions/{actionId}/execute | Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. |
| [**PostIntegrationsActionTest**](#PostIntegrationsActionTest) | **Post** /api/v2/integrations/actions/{actionId}/test | Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActions**](#PostIntegrationsActions) | **Post** /api/v2/integrations/actions | Create a new Action. Not supported for &#39;Function Integration&#39; actions. Function integrations must be created as drafts to allow managing of uploading required ZIP function package before they may be used as a published action. |
| [**PostIntegrationsActionsDrafts**](#PostIntegrationsActionsDrafts) | **Post** /api/v2/integrations/actions/drafts | Create a new Draft |
| [**PostIntegrationsBotconnectorsIncomingMessages**](#PostIntegrationsBotconnectorsIncomingMessages) | **Post** /api/v2/integrations/botconnectors/incoming/messages | Send an incoming message to the bot. |
| [**PostIntegrationsBotconnectorsOutgoingMessages**](#PostIntegrationsBotconnectorsOutgoingMessages) | **Post** /api/v2/integrations/botconnectors/outgoing/messages | Send an outgoing message to the end user. |
| [**PostIntegrationsCredentials**](#PostIntegrationsCredentials) | **Post** /api/v2/integrations/credentials | Create a set of credentials |
| [**PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs**](#PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs) | **Post** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs | Get a Nuance bot in the specified Integration asynchronously |
| [**PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs**](#PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs) | **Post** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs | Get a list of Nuance bots in the specified Integration asynchronously |
| [**PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate**](#PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate) | **Post** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/validate | Try out a single credential for a Nuance bot to know if the secret is correct |
| [**PostIntegrationsWebhookEvents**](#PostIntegrationsWebhookEvents) | **Post** /api/v2/integrations/webhooks/{tokenId}/events | Invoke Webhook |
| [**PutIntegrationConfigCurrent**](#PutIntegrationConfigCurrent) | **Put** /api/v2/integrations/{integrationId}/config/current | Update integration configuration. |
| [**PutIntegrationsActionDraftFunction**](#PutIntegrationsActionDraftFunction) | **Put** /api/v2/integrations/actions/{actionId}/draft/function | Update draft function settings. |
| [**PutIntegrationsBotconnectorIntegrationIdBots**](#PutIntegrationsBotconnectorIntegrationIdBots) | **Put** /api/v2/integrations/botconnector/{integrationId}/bots | Set a list of botConnector bots plus versions for this integration |
| [**PutIntegrationsCredential**](#PutIntegrationsCredential) | **Put** /api/v2/integrations/credentials/{credentialId} | Update a set of credentials |
| [**PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings**](#PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings) | **Put** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/settings | Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration |
| [**PutIntegrationsSpeechTtsSettings**](#PutIntegrationsSpeechTtsSettings) | **Put** /api/v2/integrations/speech/tts/settings | Update TTS settings for an org |
| [**PutIntegrationsUnifiedcommunicationThirdpartypresences**](#PutIntegrationsUnifiedcommunicationThirdpartypresences) | **Put** /api/v2/integrations/unifiedcommunications/{ucIntegrationId}/thirdpartypresences | Bulk integration presence ingestion |



## DeleteIntegration

> [**Integration**](Integration) DeleteIntegration (string integrationId)


Delete integration.

Requires ANY permissions: 

* integrations:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntegrationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | Integration Id

            try
            { 
                // Delete integration.
                Integration result = apiInstance.DeleteIntegration(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id |  |

### Return type

[**Integration**](Integration)


## DeleteIntegrationsAction

> void DeleteIntegrationsAction (string actionId)


Delete an Action

Requires ANY permissions: 

* integrations:action:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntegrationsActionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId

            try
            { 
                // Delete an Action
                apiInstance.DeleteIntegrationsAction(actionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegrationsAction: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |

### Return type

void (empty response body)


## DeleteIntegrationsActionDraft

> void DeleteIntegrationsActionDraft (string actionId)


Delete a Draft

Requires ANY permissions: 

* integrations:action:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntegrationsActionDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId

            try
            { 
                // Delete a Draft
                apiInstance.DeleteIntegrationsActionDraft(actionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |

### Return type

void (empty response body)


## DeleteIntegrationsCredential

> void DeleteIntegrationsCredential (string credentialId)


Delete a set of credentials

Requires ANY permissions: 

* integrations:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntegrationsCredentialExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var credentialId = credentialId_example;  // string | Credential ID

            try
            { 
                // Delete a set of credentials
                apiInstance.DeleteIntegrationsCredential(credentialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegrationsCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **credentialId** | **string**| Credential ID |  |

### Return type

void (empty response body)


## GetIntegration

> [**Integration**](Integration) GetIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)


Get integration.

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | Integration Id
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 

            try
            { 
                // Get integration.
                Integration result = apiInstance.GetIntegration(integrationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |

### Return type

[**Integration**](Integration)


## GetIntegrationConfigCurrent

> [**IntegrationConfiguration**](IntegrationConfiguration) GetIntegrationConfigCurrent (string integrationId)


Get integration configuration.

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationConfigCurrentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | Integration Id

            try
            { 
                // Get integration configuration.
                IntegrationConfiguration result = apiInstance.GetIntegrationConfigCurrent(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationConfigCurrent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id |  |

### Return type

[**IntegrationConfiguration**](IntegrationConfiguration)


## GetIntegrations

> [**IntegrationEntityListing**](IntegrationEntityListing) GetIntegrations (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, List<string> ids = null, string integrationType = null, string reportedState = null)


List integrations

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var ids = new List<string>(); // List<string> | Comma-separated list of integration IDs to filter by (max 100) (optional) 
            var integrationType = webhook;  // string | Filter integrations by integration type ID (optional) 
            var reportedState = ACTIVE;  // string | Filter integrations by reported state (case-insensitive) (optional) 

            try
            { 
                // List integrations
                IntegrationEntityListing result = apiInstance.GetIntegrations(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, ids, integrationType, reportedState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **ids** | [**List<string>**](string)| Comma-separated list of integration IDs to filter by (max 100) | [optional]  |
| **integrationType** | **string**| Filter integrations by integration type ID | [optional]  |
| **reportedState** | **string**| Filter integrations by reported state (case-insensitive) | [optional] <br />**Values**: ACTIVE, ACTIVATING, INACTIVE, DEACTIVATING, ERROR |

### Return type

[**IntegrationEntityListing**](IntegrationEntityListing)


## GetIntegrationsAction

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) GetIntegrationsAction (string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null)


Retrieves a single Action matching id.

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var expand = expand_example;  // string | Indicates a field in the response which should be expanded. (optional) 
            var flatten = flatten_example;  // bool? | Indicates the response should be reformatted, based on Architect's flattening format. (optional)  (default to false)
            var includeConfig = includeConfig_example;  // bool? | Return config in response. (optional)  (default to false)

            try
            { 
                // Retrieves a single Action matching id.
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.GetIntegrationsAction(actionId, expand, flatten, includeConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsAction: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **expand** | **string**| Indicates a field in the response which should be expanded. | [optional] <br />**Values**: contract |
| **flatten** | **bool?**| Indicates the response should be reformatted, based on Architect&#39;s flattening format. | [optional] [default to false]<br />**Values**: true, false |
| **includeConfig** | **bool?**| Return config in response. | [optional] [default to false]<br />**Values**: true, false |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## GetIntegrationsActionDraft

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) GetIntegrationsActionDraft (string actionId, string expand = null, bool? flatten = null, bool? includeConfig = null)


Retrieve a Draft

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var expand = expand_example;  // string | Indicates a field in the response which should be expanded. (optional) 
            var flatten = flatten_example;  // bool? | Indicates the response should be reformatted, based on Architect's flattening format. (optional)  (default to false)
            var includeConfig = includeConfig_example;  // bool? | Return config in response. (optional)  (default to false)

            try
            { 
                // Retrieve a Draft
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.GetIntegrationsActionDraft(actionId, expand, flatten, includeConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **expand** | **string**| Indicates a field in the response which should be expanded. | [optional] <br />**Values**: contract |
| **flatten** | **bool?**| Indicates the response should be reformatted, based on Architect&#39;s flattening format. | [optional] [default to false]<br />**Values**: true, false |
| **includeConfig** | **bool?**| Return config in response. | [optional] [default to false]<br />**Values**: true, false |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## GetIntegrationsActionDraftFunction

> [**FunctionConfig**](FunctionConfig) GetIntegrationsActionDraftFunction (string actionId)


Get draft function settings for Action

Requires ANY permissions: 

* integrations:actionFunction:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftFunctionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId

            try
            { 
                // Get draft function settings for Action
                FunctionConfig result = apiInstance.GetIntegrationsActionDraftFunction(actionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraftFunction: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |

### Return type

[**FunctionConfig**](FunctionConfig)


## GetIntegrationsActionDraftSchema

> [**JsonSchemaDocument**](JsonSchemaDocument) GetIntegrationsActionDraftSchema (string actionId, string fileName, bool? flatten = null)


Retrieve schema for a Draft based on filename.

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var fileName = fileName_example;  // string | Name of schema file to be retrieved for this draft.
            var flatten = true;  // bool? | Indicates the response should be reformatted, based on Architect's flattening format. (optional)  (default to false)

            try
            { 
                // Retrieve schema for a Draft based on filename.
                JsonSchemaDocument result = apiInstance.GetIntegrationsActionDraftSchema(actionId, fileName, flatten);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraftSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of schema file to be retrieved for this draft. |  |
| **flatten** | **bool?**| Indicates the response should be reformatted, based on Architect&#39;s flattening format. | [optional] [default to false] |

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument)


## GetIntegrationsActionDraftTemplate

> **string** GetIntegrationsActionDraftTemplate (string actionId, string fileName)


Retrieve templates for a Draft based on filename.

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftTemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var fileName = fileName_example;  // string | Name of template file to be retrieved for this action draft.

            try
            { 
                // Retrieve templates for a Draft based on filename.
                string result = apiInstance.GetIntegrationsActionDraftTemplate(actionId, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraftTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of template file to be retrieved for this action draft. |  |

### Return type

**string**


## GetIntegrationsActionDraftValidation

> [**DraftValidationResult**](DraftValidationResult) GetIntegrationsActionDraftValidation (string actionId)


Validate current Draft configuration.

Requires ANY permissions: 

* integrations:action:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftValidationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId

            try
            { 
                // Validate current Draft configuration.
                DraftValidationResult result = apiInstance.GetIntegrationsActionDraftValidation(actionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraftValidation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |

### Return type

[**DraftValidationResult**](DraftValidationResult)


## GetIntegrationsActionFunction

> [**FunctionConfig**](FunctionConfig) GetIntegrationsActionFunction (string actionId)


Get published function settings for Action

Requires ANY permissions: 

* integrations:actionFunction:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionFunctionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId

            try
            { 
                // Get published function settings for Action
                FunctionConfig result = apiInstance.GetIntegrationsActionFunction(actionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionFunction: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |

### Return type

[**FunctionConfig**](FunctionConfig)


## GetIntegrationsActionSchema

> [**JsonSchemaDocument**](JsonSchemaDocument) GetIntegrationsActionSchema (string actionId, string fileName, bool? flatten = null)


Retrieve schema for an action based on filename.

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var fileName = fileName_example;  // string | Name of schema file to be retrieved for this action.
            var flatten = true;  // bool? | Indicates the response should be reformatted, based on Architect's flattening format. (optional)  (default to false)

            try
            { 
                // Retrieve schema for an action based on filename.
                JsonSchemaDocument result = apiInstance.GetIntegrationsActionSchema(actionId, fileName, flatten);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of schema file to be retrieved for this action. |  |
| **flatten** | **bool?**| Indicates the response should be reformatted, based on Architect&#39;s flattening format. | [optional] [default to false] |

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument)


## GetIntegrationsActionTemplate

> **string** GetIntegrationsActionTemplate (string actionId, string fileName)


Retrieve text of templates for an action based on filename.

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionTemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var fileName = fileName_example;  // string | Name of template file to be retrieved for this action.

            try
            { 
                // Retrieve text of templates for an action based on filename.
                string result = apiInstance.GetIntegrationsActionTemplate(actionId, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of template file to be retrieved for this action. |  |

### Return type

**string**


## GetIntegrationsActions

> [**ActionEntityListing**](ActionEntityListing) GetIntegrationsActions (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)


Retrieves all actions associated with filters passed in via query param.

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var sortBy = sortBy_example;  // string | Root level field name to sort on. (optional) 
            var sortOrder = sortOrder_example;  // string | Direction to sort 'sortBy' field. (optional)  (default to asc)
            var category = category_example;  // string | Filter by category name. (optional) 
            var name = name_example;  // string | Filter by partial or complete action name. (optional) 
            var ids = ids_example;  // string | Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional) 
            var secure = secure_example;  // string | Filter based on 'secure' configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional) 
            var includeAuthActions = includeAuthActions_example;  // string | Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional)  (default to false)

            try
            { 
                // Retrieves all actions associated with filters passed in via query param.
                ActionEntityListing result = apiInstance.GetIntegrationsActions(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, category, name, ids, secure, includeAuthActions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **sortBy** | **string**| Root level field name to sort on. | [optional]  |
| **sortOrder** | **string**| Direction to sort &#39;sortBy&#39; field. | [optional] [default to asc]<br />**Values**: ASC, DESC |
| **category** | **string**| Filter by category name. | [optional]  |
| **name** | **string**| Filter by partial or complete action name. | [optional]  |
| **ids** | **string**| Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. | [optional]  |
| **secure** | **string**| Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. | [optional] <br />**Values**: true, false |
| **includeAuthActions** | **string**| Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. | [optional] [default to false]<br />**Values**: true, false |

### Return type

[**ActionEntityListing**](ActionEntityListing)


## GetIntegrationsActionsCategories

> [**CategoryEntityListing**](CategoryEntityListing) GetIntegrationsActionsCategories (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null)


Retrieves all categories of available Actions

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var sortBy = sortBy_example;  // string | Root level field name to sort on.  Only 'name' is supported on this endpoint. (optional) 
            var sortOrder = sortOrder_example;  // string | Direction to sort 'sortBy' field. (optional)  (default to asc)
            var secure = secure_example;  // string | Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional) 

            try
            { 
                // Retrieves all categories of available Actions
                CategoryEntityListing result = apiInstance.GetIntegrationsActionsCategories(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, secure);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionsCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **sortBy** | **string**| Root level field name to sort on.  Only &#39;name&#39; is supported on this endpoint. | [optional]  |
| **sortOrder** | **string**| Direction to sort &#39;sortBy&#39; field. | [optional] [default to asc]<br />**Values**: ASC, DESC |
| **secure** | **string**| Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. | [optional] <br />**Values**: true, false |

### Return type

[**CategoryEntityListing**](CategoryEntityListing)


## GetIntegrationsActionsCertificates

> [**ActionCertificateListing**](ActionCertificateListing) GetIntegrationsActionsCertificates (string status = null, string type = null)


Retrieves the available mTLS client certificates in use. This endpoint will return inconsistent results while a certificate rotation is in progress.

Requires ANY permissions: 

* integrations:actionCertificate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsCertificatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var status = status_example;  // string | Indicates the validity of the certificate in question. (optional) 
            var type = type_example;  // string | Indicates the type of the certificate. (optional) 

            try
            { 
                // Retrieves the available mTLS client certificates in use. This endpoint will return inconsistent results while a certificate rotation is in progress.
                ActionCertificateListing result = apiInstance.GetIntegrationsActionsCertificates(status, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionsCertificates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **status** | **string**| Indicates the validity of the certificate in question. | [optional] <br />**Values**: Current, Upcoming |
| **type** | **string**| Indicates the type of the certificate. | [optional] <br />**Values**: Client |

### Return type

[**ActionCertificateListing**](ActionCertificateListing)


## GetIntegrationsActionsCertificatesTruststore

> [**TrustedCertificates**](TrustedCertificates) GetIntegrationsActionsCertificatesTruststore ()


Retrieves basic info about trusted root CA certificates

Requires ANY permissions: 

* integrations:actionCertificate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsCertificatesTruststoreExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();

            try
            { 
                // Retrieves basic info about trusted root CA certificates
                TrustedCertificates result = apiInstance.GetIntegrationsActionsCertificatesTruststore();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionsCertificatesTruststore: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**TrustedCertificates**](TrustedCertificates)


## GetIntegrationsActionsDrafts

> [**ActionEntityListing**](ActionEntityListing) GetIntegrationsActionsDrafts (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)


Retrieves all action drafts associated with the filters passed in via query param.

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsDraftsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var sortBy = sortBy_example;  // string | Root level field name to sort on. (optional) 
            var sortOrder = sortOrder_example;  // string | Direction to sort 'sortBy' field. (optional)  (default to asc)
            var category = category_example;  // string | Filter by category name. (optional) 
            var name = name_example;  // string | Filter by partial or complete action name. (optional) 
            var ids = ids_example;  // string | Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. (optional) 
            var secure = secure_example;  // string | Filter based on 'secure' configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. (optional) 
            var includeAuthActions = includeAuthActions_example;  // string | Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional)  (default to false)

            try
            { 
                // Retrieves all action drafts associated with the filters passed in via query param.
                ActionEntityListing result = apiInstance.GetIntegrationsActionsDrafts(pageSize, pageNumber, nextPage, previousPage, sortBy, sortOrder, category, name, ids, secure, includeAuthActions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionsDrafts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **sortBy** | **string**| Root level field name to sort on. | [optional]  |
| **sortOrder** | **string**| Direction to sort &#39;sortBy&#39; field. | [optional] [default to asc]<br />**Values**: ASC, DESC |
| **category** | **string**| Filter by category name. | [optional]  |
| **name** | **string**| Filter by partial or complete action name. | [optional]  |
| **ids** | **string**| Filter by action Id. Can be a comma separated list to request multiple actions.  Limit of 50 Ids. | [optional]  |
| **secure** | **string**| Filter based on &#39;secure&#39; configuration option. True will only return actions marked as secure. False will return only non-secure actions. Do not use filter if you want all Actions. | [optional] <br />**Values**: true, false |
| **includeAuthActions** | **string**| Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. | [optional] [default to false]<br />**Values**: true, false |

### Return type

[**ActionEntityListing**](ActionEntityListing)


## GetIntegrationsActionsFunctionsRuntimes

> [**List&lt;FunctionRuntime&gt;**](FunctionRuntime) GetIntegrationsActionsFunctionsRuntimes ()


Get action function settings for Action

Requires ANY permissions: 

* integrations:actionFunction:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsFunctionsRuntimesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();

            try
            { 
                // Get action function settings for Action
                List<FunctionRuntime> result = apiInstance.GetIntegrationsActionsFunctionsRuntimes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionsFunctionsRuntimes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**List<FunctionRuntime>**](FunctionRuntime)


## GetIntegrationsBotconnectorBot

> [**Bot**](Bot) GetIntegrationsBotconnectorBot (string integrationId, string botId, string version = null)


Get a specific Bot details

GetIntegrationsBotconnectorBot is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integration:botconnector:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsBotconnectorBotExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this group of bots
            var botId = botId_example;  // string | The bot ID for this bot
            var version = version_example;  // string | Specific Version (optional) 

            try
            { 
                // Get a specific Bot details
                Bot result = apiInstance.GetIntegrationsBotconnectorBot(integrationId, botId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsBotconnectorBot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this group of bots |  |
| **botId** | **string**| The bot ID for this bot |  |
| **version** | **string**| Specific Version | [optional]  |

### Return type

[**Bot**](Bot)


## GetIntegrationsBotconnectorBots

> [**BotListing**](BotListing) GetIntegrationsBotconnectorBots (string integrationId, int? pageNumber = null, int? pageSize = null)


Get the list of bots for this integration.

GetIntegrationsBotconnectorBots is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integration:botconnector:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsBotconnectorBotsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this group of bots.
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get the list of bots for this integration.
                BotListing result = apiInstance.GetIntegrationsBotconnectorBots(integrationId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsBotconnectorBots: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this group of bots. |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**BotListing**](BotListing)


## GetIntegrationsBotconnectorBotsSummaries

> [**BotSummaryEntityListing**](BotSummaryEntityListing) GetIntegrationsBotconnectorBotsSummaries (string integrationId, int? pageNumber = null, int? pageSize = null)


Get the summary list of bots for this integration.

GetIntegrationsBotconnectorBotsSummaries is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integration:botconnector:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsBotconnectorBotsSummariesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this group of bots.
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get the summary list of bots for this integration.
                BotSummaryEntityListing result = apiInstance.GetIntegrationsBotconnectorBotsSummaries(integrationId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsBotconnectorBotsSummaries: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this group of bots. |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**BotSummaryEntityListing**](BotSummaryEntityListing)


## GetIntegrationsBotconnectorIntegrationIdBot

> [**BotConnectorBot**](BotConnectorBot) GetIntegrationsBotconnectorIntegrationIdBot (string integrationId, string botId, string version = null)


Get a specific botConnector bot, plus versions, for this integration

Requires ANY permissions: 

* integration:botconnector:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsBotconnectorIntegrationIdBotExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this group of bots
            var botId = botId_example;  // string | The botID for this bot
            var version = version_example;  // string | Specific Version (optional) 

            try
            { 
                // Get a specific botConnector bot, plus versions, for this integration
                BotConnectorBot result = apiInstance.GetIntegrationsBotconnectorIntegrationIdBot(integrationId, botId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsBotconnectorIntegrationIdBot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this group of bots |  |
| **botId** | **string**| The botID for this bot |  |
| **version** | **string**| Specific Version | [optional]  |

### Return type

[**BotConnectorBot**](BotConnectorBot)


## GetIntegrationsBotconnectorIntegrationIdBotVersions

> [**BotConnectorBotVersionSummaryEntityListing**](BotConnectorBotVersionSummaryEntityListing) GetIntegrationsBotconnectorIntegrationIdBotVersions (string integrationId, string botId, int? pageNumber = null, int? pageSize = null)


Get a list of bot versions for a bot

Requires ANY permissions: 

* integration:botconnector:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsBotconnectorIntegrationIdBotVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this bot group
            var botId = botId_example;  // string | The botID for this bot
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get a list of bot versions for a bot
                BotConnectorBotVersionSummaryEntityListing result = apiInstance.GetIntegrationsBotconnectorIntegrationIdBotVersions(integrationId, botId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsBotconnectorIntegrationIdBotVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this bot group |  |
| **botId** | **string**| The botID for this bot |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**BotConnectorBotVersionSummaryEntityListing**](BotConnectorBotVersionSummaryEntityListing)


## GetIntegrationsBotconnectorIntegrationIdBots

> [**BotList**](BotList) GetIntegrationsBotconnectorIntegrationIdBots (string integrationId)


Get a list of botConnector bots for this integration

Requires ANY permissions: 

* integration:botconnector:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsBotconnectorIntegrationIdBotsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this group of bots

            try
            { 
                // Get a list of botConnector bots for this integration
                BotList result = apiInstance.GetIntegrationsBotconnectorIntegrationIdBots(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsBotconnectorIntegrationIdBots: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this group of bots |  |

### Return type

[**BotList**](BotList)


## GetIntegrationsBotconnectorIntegrationIdBotsSummaries

> [**BotConnectorBotSummaryEntityListing**](BotConnectorBotSummaryEntityListing) GetIntegrationsBotconnectorIntegrationIdBotsSummaries (string integrationId, int? pageNumber = null, int? pageSize = null)


Get a summary list of botConnector bots for this integration

Requires ANY permissions: 

* integration:botconnector:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsBotconnectorIntegrationIdBotsSummariesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this group of bots
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get a summary list of botConnector bots for this integration
                BotConnectorBotSummaryEntityListing result = apiInstance.GetIntegrationsBotconnectorIntegrationIdBotsSummaries(integrationId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsBotconnectorIntegrationIdBotsSummaries: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this group of bots |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**BotConnectorBotSummaryEntityListing**](BotConnectorBotSummaryEntityListing)


## GetIntegrationsClientapps

> [**ClientAppEntityListing**](ClientAppEntityListing) GetIntegrationsClientapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)


List permitted client app integrations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsClientappsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 

            try
            { 
                // List permitted client app integrations for the logged in user
                ClientAppEntityListing result = apiInstance.GetIntegrationsClientapps(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsClientapps: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |

### Return type

[**ClientAppEntityListing**](ClientAppEntityListing)


## GetIntegrationsClientappsUnifiedcommunications

> [**UCIntegrationListing**](UCIntegrationListing) GetIntegrationsClientappsUnifiedcommunications (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

UC integration client application configuration.

Deprecated: Please use GET /integrations/unifiedcommunications/clientapps instead. This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.

Requires ANY permissions: 

* integration:unifiedCommunications:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsClientappsUnifiedcommunicationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 

            try
            { 
                // UC integration client application configuration.
                UCIntegrationListing result = apiInstance.GetIntegrationsClientappsUnifiedcommunications(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsClientappsUnifiedcommunications: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |

### Return type

[**UCIntegrationListing**](UCIntegrationListing)


## GetIntegrationsCredential

> [**Credential**](Credential) GetIntegrationsCredential (string credentialId)


Get a single credential with sensitive fields redacted

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsCredentialExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var credentialId = credentialId_example;  // string | Credential ID

            try
            { 
                // Get a single credential with sensitive fields redacted
                Credential result = apiInstance.GetIntegrationsCredential(credentialId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **credentialId** | **string**| Credential ID |  |

### Return type

[**Credential**](Credential)


## GetIntegrationsCredentials

> [**CredentialInfoListing**](CredentialInfoListing) GetIntegrationsCredentials (int? pageNumber = null, int? pageSize = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

List multiple sets of credentials

This endpoint is deprecated. Please see the Listing API (GET /api/v2/integrations/credentials/listing)

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsCredentialsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // List multiple sets of credentials
                CredentialInfoListing result = apiInstance.GetIntegrationsCredentials(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**CredentialInfoListing**](CredentialInfoListing)


## GetIntegrationsCredentialsListing

> [**CredentialInfoCursorListing**](CredentialInfoCursorListing) GetIntegrationsCredentialsListing (string before = null, string after = null, string pageSize = null)


List multiple sets of credentials using cursor-based paging

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsCredentialsListingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // List multiple sets of credentials using cursor-based paging
                CredentialInfoCursorListing result = apiInstance.GetIntegrationsCredentialsListing(before, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsCredentialsListing: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |

### Return type

[**CredentialInfoCursorListing**](CredentialInfoCursorListing)


## GetIntegrationsCredentialsTypes

> [**CredentialTypeListing**](CredentialTypeListing) GetIntegrationsCredentialsTypes ()


List all credential types

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsCredentialsTypesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();

            try
            { 
                // List all credential types
                CredentialTypeListing result = apiInstance.GetIntegrationsCredentialsTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsCredentialsTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CredentialTypeListing**](CredentialTypeListing)


## GetIntegrationsSpeechAudioconnector

> [**AudioConnectorIntegrationEntityListing**](AudioConnectorIntegrationEntityListing) GetIntegrationsSpeechAudioconnector (int? pageNumber = null, int? pageSize = null)


Get a list of Audio Connector integrations

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechAudioconnectorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get a list of Audio Connector integrations
                AudioConnectorIntegrationEntityListing result = apiInstance.GetIntegrationsSpeechAudioconnector(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechAudioconnector: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**AudioConnectorIntegrationEntityListing**](AudioConnectorIntegrationEntityListing)


## GetIntegrationsSpeechAudioconnectorIntegrationId

> [**AudioConnectorIntegration**](AudioConnectorIntegration) GetIntegrationsSpeechAudioconnectorIntegrationId (string integrationId)


Get an Audio Connector integration

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechAudioconnectorIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID

            try
            { 
                // Get an Audio Connector integration
                AudioConnectorIntegration result = apiInstance.GetIntegrationsSpeechAudioconnectorIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechAudioconnectorIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID |  |

### Return type

[**AudioConnectorIntegration**](AudioConnectorIntegration)


## GetIntegrationsSpeechDialogflowAgent

> [**DialogflowAgent**](DialogflowAgent) GetIntegrationsSpeechDialogflowAgent (string agentId)


Get details about a Dialogflow agent

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechDialogflowAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var agentId = agentId_example;  // string | The agent ID

            try
            { 
                // Get details about a Dialogflow agent
                DialogflowAgent result = apiInstance.GetIntegrationsSpeechDialogflowAgent(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechDialogflowAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The agent ID |  |

### Return type

[**DialogflowAgent**](DialogflowAgent)


## GetIntegrationsSpeechDialogflowAgents

> [**DialogflowAgentSummaryEntityListing**](DialogflowAgentSummaryEntityListing) GetIntegrationsSpeechDialogflowAgents (int? pageNumber = null, int? pageSize = null, string name = null)


Get a list of Dialogflow agents in the customers' Google accounts

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechDialogflowAgentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Filter on agent name (optional) 

            try
            { 
                // Get a list of Dialogflow agents in the customers' Google accounts
                DialogflowAgentSummaryEntityListing result = apiInstance.GetIntegrationsSpeechDialogflowAgents(pageNumber, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechDialogflowAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Filter on agent name | [optional]  |

### Return type

[**DialogflowAgentSummaryEntityListing**](DialogflowAgentSummaryEntityListing)


## GetIntegrationsSpeechDialogflowcxAgent

> [**DialogflowCXAgent**](DialogflowCXAgent) GetIntegrationsSpeechDialogflowcxAgent (string agentId)


Get details about a Dialogflow CX agent

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechDialogflowcxAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var agentId = agentId_example;  // string | The agent ID

            try
            { 
                // Get details about a Dialogflow CX agent
                DialogflowCXAgent result = apiInstance.GetIntegrationsSpeechDialogflowcxAgent(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechDialogflowcxAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The agent ID |  |

### Return type

[**DialogflowCXAgent**](DialogflowCXAgent)


## GetIntegrationsSpeechDialogflowcxAgents

> [**DialogflowCXAgentSummaryEntityListing**](DialogflowCXAgentSummaryEntityListing) GetIntegrationsSpeechDialogflowcxAgents (int? pageNumber = null, int? pageSize = null, string name = null)


Get a list of Dialogflow CX agents in the customers' Google accounts

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechDialogflowcxAgentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Filter on agent name (optional) 

            try
            { 
                // Get a list of Dialogflow CX agents in the customers' Google accounts
                DialogflowCXAgentSummaryEntityListing result = apiInstance.GetIntegrationsSpeechDialogflowcxAgents(pageNumber, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechDialogflowcxAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Filter on agent name | [optional]  |

### Return type

[**DialogflowCXAgentSummaryEntityListing**](DialogflowCXAgentSummaryEntityListing)


## GetIntegrationsSpeechLexBotAlias

> [**LexBotAlias**](LexBotAlias) GetIntegrationsSpeechLexBotAlias (string aliasId)


Get details about a Lex bot alias

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechLexBotAliasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var aliasId = aliasId_example;  // string | The alias ID

            try
            { 
                // Get details about a Lex bot alias
                LexBotAlias result = apiInstance.GetIntegrationsSpeechLexBotAlias(aliasId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechLexBotAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **aliasId** | **string**| The alias ID |  |

### Return type

[**LexBotAlias**](LexBotAlias)


## GetIntegrationsSpeechLexBotBotIdAliases

> [**LexBotAliasEntityListing**](LexBotAliasEntityListing) GetIntegrationsSpeechLexBotBotIdAliases (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)


Get a list of aliases for a bot in the customer's AWS accounts

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechLexBotBotIdAliasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var botId = botId_example;  // string | The bot ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var status = status_example;  // string | Filter on alias status (optional) 
            var name = name_example;  // string | Filter on alias name (optional) 

            try
            { 
                // Get a list of aliases for a bot in the customer's AWS accounts
                LexBotAliasEntityListing result = apiInstance.GetIntegrationsSpeechLexBotBotIdAliases(botId, pageNumber, pageSize, status, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechLexBotBotIdAliases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **botId** | **string**| The bot ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **status** | **string**| Filter on alias status | [optional] <br />**Values**: READY, FAILED, BUILDING, NOT_BUILT |
| **name** | **string**| Filter on alias name | [optional]  |

### Return type

[**LexBotAliasEntityListing**](LexBotAliasEntityListing)


## GetIntegrationsSpeechLexBots

> [**LexBotEntityListing**](LexBotEntityListing) GetIntegrationsSpeechLexBots (int? pageNumber = null, int? pageSize = null, string name = null)


Get a list of Lex bots in the customers' AWS accounts

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechLexBotsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Filter on bot name (optional) 

            try
            { 
                // Get a list of Lex bots in the customers' AWS accounts
                LexBotEntityListing result = apiInstance.GetIntegrationsSpeechLexBots(pageNumber, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechLexBots: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Filter on bot name | [optional]  |

### Return type

[**LexBotEntityListing**](LexBotEntityListing)


## GetIntegrationsSpeechLexv2BotAlias

> [**LexV2BotAlias**](LexV2BotAlias) GetIntegrationsSpeechLexv2BotAlias (string aliasId)


Get details about a Lex V2 bot alias

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechLexv2BotAliasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var aliasId = aliasId_example;  // string | The Alias ID

            try
            { 
                // Get details about a Lex V2 bot alias
                LexV2BotAlias result = apiInstance.GetIntegrationsSpeechLexv2BotAlias(aliasId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechLexv2BotAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **aliasId** | **string**| The Alias ID |  |

### Return type

[**LexV2BotAlias**](LexV2BotAlias)


## GetIntegrationsSpeechLexv2BotBotIdAliases

> [**LexV2BotAliasEntityListing**](LexV2BotAliasEntityListing) GetIntegrationsSpeechLexv2BotBotIdAliases (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)


Get a list of aliases for a Lex V2 bot

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechLexv2BotBotIdAliasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var botId = botId_example;  // string | The Bot ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var status = status_example;  // string | Filter on alias status (optional) 
            var name = name_example;  // string | Filter on alias name (optional) 

            try
            { 
                // Get a list of aliases for a Lex V2 bot
                LexV2BotAliasEntityListing result = apiInstance.GetIntegrationsSpeechLexv2BotBotIdAliases(botId, pageNumber, pageSize, status, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechLexv2BotBotIdAliases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **botId** | **string**| The Bot ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **status** | **string**| Filter on alias status | [optional] <br />**Values**: Creating, Available, Deleting, Failed |
| **name** | **string**| Filter on alias name | [optional]  |

### Return type

[**LexV2BotAliasEntityListing**](LexV2BotAliasEntityListing)


## GetIntegrationsSpeechLexv2Bots

> [**LexV2BotEntityListing**](LexV2BotEntityListing) GetIntegrationsSpeechLexv2Bots (int? pageNumber = null, int? pageSize = null, string name = null)


Get a list of Lex V2 bots

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechLexv2BotsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Filter on bot name (optional) 

            try
            { 
                // Get a list of Lex V2 bots
                LexV2BotEntityListing result = apiInstance.GetIntegrationsSpeechLexv2Bots(pageNumber, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechLexv2Bots: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Filter on bot name | [optional]  |

### Return type

[**LexV2BotEntityListing**](LexV2BotEntityListing)


## GetIntegrationsSpeechNuanceNuanceIntegrationIdBot

> [**NuanceBot**](NuanceBot) GetIntegrationsSpeechNuanceNuanceIntegrationIdBot (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null)


Get a Nuance bot in the specified Integration

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechNuanceNuanceIntegrationIdBotExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var botId = botId_example;  // string | The Nuance bot ID to get
            var expand = new List<string>(); // List<string> | expand (optional) 
            var targetChannel = targetChannel_example;  // string | targetChannel (optional) 

            try
            { 
                // Get a Nuance bot in the specified Integration
                NuanceBot result = apiInstance.GetIntegrationsSpeechNuanceNuanceIntegrationIdBot(nuanceIntegrationId, botId, expand, targetChannel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechNuanceNuanceIntegrationIdBot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **botId** | **string**| The Nuance bot ID to get |  |
| **expand** | [**List<string>**](string)| expand | [optional] <br />**Values**: variables, transferNodes, channels, locales |
| **targetChannel** | **string**| targetChannel | [optional] <br />**Values**: digital, voice |

### Return type

[**NuanceBot**](NuanceBot)


## GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob

> [**AsyncJob**](AsyncJob) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob (string nuanceIntegrationId, string botId, string jobId)


Get the status of an asynchronous Nuance bot GET job

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var botId = botId_example;  // string | The Nuance bot ID
            var jobId = jobId_example;  // string | The asynchronous job ID

            try
            { 
                // Get the status of an asynchronous Nuance bot GET job
                AsyncJob result = apiInstance.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob(nuanceIntegrationId, botId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **botId** | **string**| The Nuance bot ID |  |
| **jobId** | **string**| The asynchronous job ID |  |

### Return type

[**AsyncJob**](AsyncJob)


## GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults

> [**NuanceBot**](NuanceBot) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults (string nuanceIntegrationId, string botId, string jobId)


Get the result of an asynchronous Nuance bot GET job

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var botId = botId_example;  // string | The Nuance bot ID
            var jobId = jobId_example;  // string | The asynchronous job ID

            try
            { 
                // Get the result of an asynchronous Nuance bot GET job
                NuanceBot result = apiInstance.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults(nuanceIntegrationId, botId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **botId** | **string**| The Nuance bot ID |  |
| **jobId** | **string**| The asynchronous job ID |  |

### Return type

[**NuanceBot**](NuanceBot)


## GetIntegrationsSpeechNuanceNuanceIntegrationIdBots

> [**NuanceBotEntityListing**](NuanceBotEntityListing) GetIntegrationsSpeechNuanceNuanceIntegrationIdBots (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)


Get a list of Nuance bots available in the specified Integration

If the 'onlyRegisteredBots' param is set, the returned data will only include the Nuance bots which have configured client secrets within the Integration,  otherwise all of the Nuance bots available to the Integration's configured discovery credentials are returned.

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var onlyRegisteredBots = true;  // bool? | Limit bots to the ones configured for Genesys Cloud usage (optional)  (default to true)

            try
            { 
                // Get a list of Nuance bots available in the specified Integration
                NuanceBotEntityListing result = apiInstance.GetIntegrationsSpeechNuanceNuanceIntegrationIdBots(nuanceIntegrationId, pageNumber, pageSize, onlyRegisteredBots);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechNuanceNuanceIntegrationIdBots: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **onlyRegisteredBots** | **bool?**| Limit bots to the ones configured for Genesys Cloud usage | [optional] [default to true] |

### Return type

[**NuanceBotEntityListing**](NuanceBotEntityListing)


## GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob

> [**AsyncJob**](AsyncJob) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob (string nuanceIntegrationId, string jobId)


Get the status of an asynchronous Nuance bots GET job

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var jobId = jobId_example;  // string | The asynchronous job ID

            try
            { 
                // Get the status of an asynchronous Nuance bots GET job
                AsyncJob result = apiInstance.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob(nuanceIntegrationId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **jobId** | **string**| The asynchronous job ID |  |

### Return type

[**AsyncJob**](AsyncJob)


## GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults

> [**NuanceBotEntityListing**](NuanceBotEntityListing) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults (string nuanceIntegrationId, string jobId)


Get the result of an asynchronous Nuance bots GET job

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var jobId = jobId_example;  // string | The asynchronous job ID

            try
            { 
                // Get the result of an asynchronous Nuance bots GET job
                NuanceBotEntityListing result = apiInstance.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults(nuanceIntegrationId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **jobId** | **string**| The asynchronous job ID |  |

### Return type

[**NuanceBotEntityListing**](NuanceBotEntityListing)


## GetIntegrationsSpeechSttEngine

> [**SttEngineEntity**](SttEngineEntity) GetIntegrationsSpeechSttEngine (string engineId)


Get details about a STT engine

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechSttEngineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var engineId = engineId_example;  // string | The engine ID

            try
            { 
                // Get details about a STT engine
                SttEngineEntity result = apiInstance.GetIntegrationsSpeechSttEngine(engineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechSttEngine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **engineId** | **string**| The engine ID |  |

### Return type

[**SttEngineEntity**](SttEngineEntity)


## GetIntegrationsSpeechSttEngines

> [**SttEngineEntityListing**](SttEngineEntityListing) GetIntegrationsSpeechSttEngines (int? pageNumber = null, int? pageSize = null, string name = null)


Get a list of STT engines enabled for org

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechSttEnginesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Filter on engine name (optional) 

            try
            { 
                // Get a list of STT engines enabled for org
                SttEngineEntityListing result = apiInstance.GetIntegrationsSpeechSttEngines(pageNumber, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechSttEngines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Filter on engine name | [optional]  |

### Return type

[**SttEngineEntityListing**](SttEngineEntityListing)


## GetIntegrationsSpeechTtsEngine

> [**TtsEngineEntity**](TtsEngineEntity) GetIntegrationsSpeechTtsEngine (string engineId, bool? includeVoices = null)


Get details about a TTS engine

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechTtsEngineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var engineId = engineId_example;  // string | The engine ID
            var includeVoices = true;  // bool? | Include voices for the engine (optional)  (default to false)

            try
            { 
                // Get details about a TTS engine
                TtsEngineEntity result = apiInstance.GetIntegrationsSpeechTtsEngine(engineId, includeVoices);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechTtsEngine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **engineId** | **string**| The engine ID |  |
| **includeVoices** | **bool?**| Include voices for the engine | [optional] [default to false] |

### Return type

[**TtsEngineEntity**](TtsEngineEntity)


## GetIntegrationsSpeechTtsEngineVoice

> [**TtsVoiceEntity**](TtsVoiceEntity) GetIntegrationsSpeechTtsEngineVoice (string engineId, string voiceId)


Get details about a specific voice for a TTS engine

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechTtsEngineVoiceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var engineId = engineId_example;  // string | The engine ID
            var voiceId = voiceId_example;  // string | The voice ID

            try
            { 
                // Get details about a specific voice for a TTS engine
                TtsVoiceEntity result = apiInstance.GetIntegrationsSpeechTtsEngineVoice(engineId, voiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechTtsEngineVoice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **engineId** | **string**| The engine ID |  |
| **voiceId** | **string**| The voice ID |  |

### Return type

[**TtsVoiceEntity**](TtsVoiceEntity)


## GetIntegrationsSpeechTtsEngineVoices

> [**TtsVoiceEntityListing**](TtsVoiceEntityListing) GetIntegrationsSpeechTtsEngineVoices (string engineId, int? pageNumber = null, int? pageSize = null)


Get a list of voices for a TTS engine

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechTtsEngineVoicesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var engineId = engineId_example;  // string | The engine ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get a list of voices for a TTS engine
                TtsVoiceEntityListing result = apiInstance.GetIntegrationsSpeechTtsEngineVoices(engineId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechTtsEngineVoices: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **engineId** | **string**| The engine ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**TtsVoiceEntityListing**](TtsVoiceEntityListing)


## GetIntegrationsSpeechTtsEngines

> [**TtsEngineEntityListing**](TtsEngineEntityListing) GetIntegrationsSpeechTtsEngines (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null)


Get a list of TTS engines enabled for org

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechTtsEnginesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var includeVoices = true;  // bool? | Include voices for the engine (optional)  (default to false)
            var name = name_example;  // string | Filter on engine name (optional) 
            var language = language_example;  // string | Filter on supported language. If includeVoices=true then the voices are also filtered. (optional) 

            try
            { 
                // Get a list of TTS engines enabled for org
                TtsEngineEntityListing result = apiInstance.GetIntegrationsSpeechTtsEngines(pageNumber, pageSize, includeVoices, name, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechTtsEngines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **includeVoices** | **bool?**| Include voices for the engine | [optional] [default to false] |
| **name** | **string**| Filter on engine name | [optional]  |
| **language** | **string**| Filter on supported language. If includeVoices&#x3D;true then the voices are also filtered. | [optional]  |

### Return type

[**TtsEngineEntityListing**](TtsEngineEntityListing)


## GetIntegrationsSpeechTtsSettings

> [**TtsSettings**](TtsSettings) GetIntegrationsSpeechTtsSettings ()


Get TTS settings for an org

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsSpeechTtsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();

            try
            { 
                // Get TTS settings for an org
                TtsSettings result = apiInstance.GetIntegrationsSpeechTtsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsSpeechTtsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**TtsSettings**](TtsSettings)


## GetIntegrationsType

> [**IntegrationType**](IntegrationType) GetIntegrationsType (string typeId)


Get integration type.

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsTypeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var typeId = typeId_example;  // string | Integration Type Id

            try
            { 
                // Get integration type.
                IntegrationType result = apiInstance.GetIntegrationsType(typeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsType: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **typeId** | **string**| Integration Type Id |  |

### Return type

[**IntegrationType**](IntegrationType)


## GetIntegrationsTypeConfigschema

> [**JsonSchemaDocument**](JsonSchemaDocument) GetIntegrationsTypeConfigschema (string typeId, string configType)


Get properties config schema for an integration type.

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsTypeConfigschemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var typeId = typeId_example;  // string | Integration Type Id
            var configType = configType_example;  // string | Config schema type

            try
            { 
                // Get properties config schema for an integration type.
                JsonSchemaDocument result = apiInstance.GetIntegrationsTypeConfigschema(typeId, configType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsTypeConfigschema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **typeId** | **string**| Integration Type Id |  |
| **configType** | **string**| Config schema type | <br />**Values**: properties, advanced |

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument)


## GetIntegrationsTypes

> [**IntegrationTypeEntityListing**](IntegrationTypeEntityListing) GetIntegrationsTypes (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)


List integration types

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsTypesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 

            try
            { 
                // List integration types
                IntegrationTypeEntityListing result = apiInstance.GetIntegrationsTypes(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |

### Return type

[**IntegrationTypeEntityListing**](IntegrationTypeEntityListing)


## GetIntegrationsUnifiedcommunicationsClientapp

> [**UnifiedCommunicationsIntegration**](UnifiedCommunicationsIntegration) GetIntegrationsUnifiedcommunicationsClientapp (string ucIntegrationId)


UC integration client application configuration.

This endpoint returns basic UI configuration data for the specified Unified Communications integration client application.

Requires ANY permissions: 

* integration:unifiedCommunications:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsUnifiedcommunicationsClientappExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var ucIntegrationId = ucIntegrationId_example;  // string | 3rd Party Service Type

            try
            { 
                // UC integration client application configuration.
                UnifiedCommunicationsIntegration result = apiInstance.GetIntegrationsUnifiedcommunicationsClientapp(ucIntegrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsUnifiedcommunicationsClientapp: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ucIntegrationId** | **string**| 3rd Party Service Type |  |

### Return type

[**UnifiedCommunicationsIntegration**](UnifiedCommunicationsIntegration)


## GetIntegrationsUnifiedcommunicationsClientapps

> [**UnifiedCommunicationsIntegrationListing**](UnifiedCommunicationsIntegrationListing) GetIntegrationsUnifiedcommunicationsClientapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)


List UC integration client application configurations.

This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled.

Requires ANY permissions: 

* integration:unifiedCommunications:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsUnifiedcommunicationsClientappsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 

            try
            { 
                // List UC integration client application configurations.
                UnifiedCommunicationsIntegrationListing result = apiInstance.GetIntegrationsUnifiedcommunicationsClientapps(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsUnifiedcommunicationsClientapps: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |

### Return type

[**UnifiedCommunicationsIntegrationListing**](UnifiedCommunicationsIntegrationListing)


## GetIntegrationsUserapps

> [**UserAppEntityListing**](UserAppEntityListing) GetIntegrationsUserapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null)


List permitted user app integrations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsUserappsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var appHost = appHost_example;  // string | The type of UserApp to filter by (optional) 

            try
            { 
                // List permitted user app integrations for the logged in user
                UserAppEntityListing result = apiInstance.GetIntegrationsUserapps(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, appHost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsUserapps: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **appHost** | **string**| The type of UserApp to filter by | [optional]  |

### Return type

[**UserAppEntityListing**](UserAppEntityListing)


## PatchIntegration

> [**Integration**](Integration) PatchIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null)


Update an integration.

Requires ANY permissions: 

* integrations:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchIntegrationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | Integration Id
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var body = new Integration(); // Integration | Integration Update (optional) 

            try
            { 
                // Update an integration.
                Integration result = apiInstance.PatchIntegration(integrationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchIntegration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **body** | [**Integration**](Integration)| Integration Update | [optional]  |

### Return type

[**Integration**](Integration)


## PatchIntegrationsAction

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) PatchIntegrationsAction (string actionId, UpdateActionInput body)


Patch an Action

Requires ANY permissions: 

* integrations:action:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchIntegrationsActionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new UpdateActionInput(); // UpdateActionInput | Input used to patch the Action.

            try
            { 
                // Patch an Action
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PatchIntegrationsAction(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchIntegrationsAction: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**UpdateActionInput**](UpdateActionInput)| Input used to patch the Action. |  |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## PatchIntegrationsActionDraft

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) PatchIntegrationsActionDraft (string actionId, UpdateDraftInput body)


Update an existing Draft

Requires ANY permissions: 

* integrations:action:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchIntegrationsActionDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new UpdateDraftInput(); // UpdateDraftInput | Input used to patch the Action Draft.

            try
            { 
                // Update an existing Draft
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PatchIntegrationsActionDraft(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**UpdateDraftInput**](UpdateDraftInput)| Input used to patch the Action Draft. |  |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## PostIntegrations

> [**Integration**](Integration) PostIntegrations (CreateIntegrationRequest body = null)


Create an integration.

Requires ANY permissions: 

* integrations:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var body = new CreateIntegrationRequest(); // CreateIntegrationRequest | Integration (optional) 

            try
            { 
                // Create an integration.
                Integration result = apiInstance.PostIntegrations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateIntegrationRequest**](CreateIntegrationRequest)| Integration | [optional]  |

### Return type

[**Integration**](Integration)


## PostIntegrationsActionDraft

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) PostIntegrationsActionDraft (string actionId)


Create a new Draft from existing Action

Requires ANY permissions: 

* integrations:action:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId

            try
            { 
                // Create a new Draft from existing Action
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActionDraft(actionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## PostIntegrationsActionDraftFunctionUpload

> [**FunctionUploadResponse**](FunctionUploadResponse) PostIntegrationsActionDraftFunctionUpload (string actionId, FunctionUploadRequest body)


Create upload presigned URL for draft function package file.

Requires ANY permissions: 

* integrations:actionFunction:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftFunctionUploadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new FunctionUploadRequest(); // FunctionUploadRequest | Input used to request URL upload.

            try
            { 
                // Create upload presigned URL for draft function package file.
                FunctionUploadResponse result = apiInstance.PostIntegrationsActionDraftFunctionUpload(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionDraftFunctionUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**FunctionUploadRequest**](FunctionUploadRequest)| Input used to request URL upload. |  |

### Return type

[**FunctionUploadResponse**](FunctionUploadResponse)


## PostIntegrationsActionDraftPublish

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) PostIntegrationsActionDraftPublish (string actionId, PublishDraftInput body)


Publish a Draft and make it the active Action configuration

Requires ANY permissions: 

* integrations:action:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftPublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new PublishDraftInput(); // PublishDraftInput | Input used to patch the Action.

            try
            { 
                // Publish a Draft and make it the active Action configuration
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActionDraftPublish(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionDraftPublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**PublishDraftInput**](PublishDraftInput)| Input used to patch the Action. |  |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## PostIntegrationsActionDraftTest

> [**TestExecutionResult**](TestExecutionResult) PostIntegrationsActionDraftTest (string actionId, Object body, bool? flatten = null)


Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.

Requires ANY permissions: 

* integrations:action:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftTestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new Object(); // Object | Map of parameters used for variable substitution.
            var flatten = true;  // bool? | Indicates the response should be reformatted, based on Architect's flattening format. (optional)  (default to false)

            try
            { 
                // Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.
                TestExecutionResult result = apiInstance.PostIntegrationsActionDraftTest(actionId, body, flatten);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionDraftTest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**Object**](Object)| Map of parameters used for variable substitution. |  |
| **flatten** | **bool?**| Indicates the response should be reformatted, based on Architect&#39;s flattening format. | [optional] [default to false] |

### Return type

[**TestExecutionResult**](TestExecutionResult)


## PostIntegrationsActionExecute

> **Object** PostIntegrationsActionExecute (string actionId, Object body, bool? flatten = null)


Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.

Requires ANY permissions: 

* integrations:action:execute
* bridge:actions:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionExecuteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new Object(); // Object | Map of parameters used for variable substitution.
            var flatten = true;  // bool? | Indicates the response should be reformatted, based on Architect's flattening format. (optional)  (default to false)

            try
            { 
                // Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.
                Object result = apiInstance.PostIntegrationsActionExecute(actionId, body, flatten);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**Object**](Object)| Map of parameters used for variable substitution. |  |
| **flatten** | **bool?**| Indicates the response should be reformatted, based on Architect&#39;s flattening format. | [optional] [default to false] |

### Return type

**Object**


## PostIntegrationsActionTest

> [**TestExecutionResult**](TestExecutionResult) PostIntegrationsActionTest (string actionId, Object body, bool? flatten = null)


Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.

Requires ANY permissions: 

* integrations:action:execute
* bridge:actions:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionTestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new Object(); // Object | Map of parameters used for variable substitution.
            var flatten = true;  // bool? | Indicates the response should be reformatted, based on Architect's flattening format. (optional)  (default to false)

            try
            { 
                // Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.
                TestExecutionResult result = apiInstance.PostIntegrationsActionTest(actionId, body, flatten);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionTest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**Object**](Object)| Map of parameters used for variable substitution. |  |
| **flatten** | **bool?**| Indicates the response should be reformatted, based on Architect&#39;s flattening format. | [optional] [default to false] |

### Return type

[**TestExecutionResult**](TestExecutionResult)


## PostIntegrationsActions

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) PostIntegrationsActions (PostActionInput body)


Create a new Action. Not supported for 'Function Integration' actions. Function integrations must be created as drafts to allow managing of uploading required ZIP function package before they may be used as a published action.

Requires ANY permissions: 

* integrations:action:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var body = new PostActionInput(); // PostActionInput | Input used to create Action.

            try
            { 
                // Create a new Action. Not supported for 'Function Integration' actions. Function integrations must be created as drafts to allow managing of uploading required ZIP function package before they may be used as a published action.
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PostActionInput**](PostActionInput)| Input used to create Action. |  |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## PostIntegrationsActionsDrafts

> [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action) PostIntegrationsActionsDrafts (PostActionInput body)


Create a new Draft

Requires ANY permissions: 

* integrations:action:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionsDraftsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var body = new PostActionInput(); // PostActionInput | Input used to create Action Draft.

            try
            { 
                // Create a new Draft
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActionsDrafts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionsDrafts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PostActionInput**](PostActionInput)| Input used to create Action Draft. |  |

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action)


## PostIntegrationsBotconnectorsIncomingMessages

> [**IncomingMessageResponse**](IncomingMessageResponse) PostIntegrationsBotconnectorsIncomingMessages (IncomingMessageRequest body)


Send an incoming message to the bot.

PostIntegrationsBotconnectorsIncomingMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integration:botconnector:send

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsBotconnectorsIncomingMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var body = new IncomingMessageRequest(); // IncomingMessageRequest | Incoming Message Request

            try
            { 
                // Send an incoming message to the bot.
                IncomingMessageResponse result = apiInstance.PostIntegrationsBotconnectorsIncomingMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsBotconnectorsIncomingMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**IncomingMessageRequest**](IncomingMessageRequest)| Incoming Message Request |  |

### Return type

[**IncomingMessageResponse**](IncomingMessageResponse)


## PostIntegrationsBotconnectorsOutgoingMessages

> [**OutgoingMessageResponse**](OutgoingMessageResponse) PostIntegrationsBotconnectorsOutgoingMessages (OutgoingMessageRequest body)


Send an outgoing message to the end user.

PostIntegrationsBotconnectorsOutgoingMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integration:botconnector:send

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsBotconnectorsOutgoingMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var body = new OutgoingMessageRequest(); // OutgoingMessageRequest | Outgoing Message Request

            try
            { 
                // Send an outgoing message to the end user.
                OutgoingMessageResponse result = apiInstance.PostIntegrationsBotconnectorsOutgoingMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsBotconnectorsOutgoingMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutgoingMessageRequest**](OutgoingMessageRequest)| Outgoing Message Request |  |

### Return type

[**OutgoingMessageResponse**](OutgoingMessageResponse)


## PostIntegrationsCredentials

> [**CredentialInfo**](CredentialInfo) PostIntegrationsCredentials (Credential body = null)


Create a set of credentials

Requires ANY permissions: 

* integrations:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsCredentialsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var body = new Credential(); // Credential | Credential (optional) 

            try
            { 
                // Create a set of credentials
                CredentialInfo result = apiInstance.PostIntegrationsCredentials(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Credential**](Credential)| Credential | [optional]  |

### Return type

[**CredentialInfo**](CredentialInfo)


## PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs

> [**AsyncJob**](AsyncJob) PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null)


Get a Nuance bot in the specified Integration asynchronously

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var botId = botId_example;  // string | The Nuance bot ID
            var expand = new List<string>(); // List<string> | expand (optional) 
            var body = body_example;  // string | targetChannel (optional) 

            try
            { 
                // Get a Nuance bot in the specified Integration asynchronously
                AsyncJob result = apiInstance.PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs(nuanceIntegrationId, botId, expand, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **botId** | **string**| The Nuance bot ID |  |
| **expand** | [**List<string>**](string)| expand | [optional] <br />**Values**: variables, transferNodes, channels, locales |
| **body** | **string**| targetChannel | [optional]  |

### Return type

[**AsyncJob**](AsyncJob)


## PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs

> [**AsyncJob**](AsyncJob) PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)


Get a list of Nuance bots in the specified Integration asynchronously

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var onlyRegisteredBots = true;  // bool? | Limit bots to the ones configured for Genesys Cloud usage (optional)  (default to true)

            try
            { 
                // Get a list of Nuance bots in the specified Integration asynchronously
                AsyncJob result = apiInstance.PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs(nuanceIntegrationId, pageNumber, pageSize, onlyRegisteredBots);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **onlyRegisteredBots** | **bool?**| Limit bots to the ones configured for Genesys Cloud usage | [optional] [default to true] |

### Return type

[**AsyncJob**](AsyncJob)


## PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate

> void PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate (string nuanceIntegrationId, BotExecutionConfiguration settings)


Try out a single credential for a Nuance bot to know if the secret is correct

Requires ANY permissions: 

* integrations:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var settings = new BotExecutionConfiguration(); // BotExecutionConfiguration | 

            try
            { 
                // Try out a single credential for a Nuance bot to know if the secret is correct
                apiInstance.PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate(nuanceIntegrationId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **settings** | [**BotExecutionConfiguration**](BotExecutionConfiguration)|  |  |

### Return type

void (empty response body)


## PostIntegrationsWebhookEvents

> [**WebhookInvocationResponse**](WebhookInvocationResponse) PostIntegrationsWebhookEvents (string tokenId, Object body)


Invoke Webhook

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsWebhookEventsExample
    {
        public void main()
        { 

            var apiInstance = new IntegrationsApi();
            var tokenId = tokenId_example;  // string | The token of the webhook to be invoked
            var body = new Object(); // Object | Webhook Invocation Payload

            try
            { 
                // Invoke Webhook
                WebhookInvocationResponse result = apiInstance.PostIntegrationsWebhookEvents(tokenId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsWebhookEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tokenId** | **string**| The token of the webhook to be invoked |  |
| **body** | [**Object**](Object)| Webhook Invocation Payload |  |

### Return type

[**WebhookInvocationResponse**](WebhookInvocationResponse)


## PutIntegrationConfigCurrent

> [**IntegrationConfiguration**](IntegrationConfiguration) PutIntegrationConfigCurrent (string integrationId, IntegrationConfiguration body = null)


Update integration configuration.

Requires ANY permissions: 

* integrations:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIntegrationConfigCurrentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | Integration Id
            var body = new IntegrationConfiguration(); // IntegrationConfiguration | Integration Configuration (optional) 

            try
            { 
                // Update integration configuration.
                IntegrationConfiguration result = apiInstance.PutIntegrationConfigCurrent(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PutIntegrationConfigCurrent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id |  |
| **body** | [**IntegrationConfiguration**](IntegrationConfiguration)| Integration Configuration | [optional]  |

### Return type

[**IntegrationConfiguration**](IntegrationConfiguration)


## PutIntegrationsActionDraftFunction

> [**FunctionConfig**](FunctionConfig) PutIntegrationsActionDraftFunction (string actionId, Function body)


Update draft function settings.

Requires ANY permissions: 

* integrations:actionFunction:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIntegrationsActionDraftFunctionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new Function(); // Function | Input used to update function settings.

            try
            { 
                // Update draft function settings.
                FunctionConfig result = apiInstance.PutIntegrationsActionDraftFunction(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PutIntegrationsActionDraftFunction: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**Function**](Function)| Input used to update function settings. |  |

### Return type

[**FunctionConfig**](FunctionConfig)


## PutIntegrationsBotconnectorIntegrationIdBots

> void PutIntegrationsBotconnectorIntegrationIdBots (string integrationId, BotList botList)


Set a list of botConnector bots plus versions for this integration

Requires ANY permissions: 

* integration:botconnector:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIntegrationsBotconnectorIntegrationIdBotsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var integrationId = integrationId_example;  // string | The integration ID for this group of bots
            var botList = new BotList(); // BotList | 

            try
            { 
                // Set a list of botConnector bots plus versions for this integration
                apiInstance.PutIntegrationsBotconnectorIntegrationIdBots(integrationId, botList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PutIntegrationsBotconnectorIntegrationIdBots: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| The integration ID for this group of bots |  |
| **botList** | [**BotList**](BotList)|  |  |

### Return type

void (empty response body)


## PutIntegrationsCredential

> [**CredentialInfo**](CredentialInfo) PutIntegrationsCredential (string credentialId, Credential body = null)


Update a set of credentials

Requires ANY permissions: 

* integrations:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIntegrationsCredentialExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var credentialId = credentialId_example;  // string | Credential ID
            var body = new Credential(); // Credential | Credential (optional) 

            try
            { 
                // Update a set of credentials
                CredentialInfo result = apiInstance.PutIntegrationsCredential(credentialId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PutIntegrationsCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **credentialId** | **string**| Credential ID |  |
| **body** | [**Credential**](Credential)| Credential | [optional]  |

### Return type

[**CredentialInfo**](CredentialInfo)


## PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings

> void PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings (string nuanceIntegrationId, NuanceBotLaunchSettings settings)


Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration

Requires ANY permissions: 

* integrations:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var nuanceIntegrationId = nuanceIntegrationId_example;  // string | The integration ID for this group of bots
            var settings = new NuanceBotLaunchSettings(); // NuanceBotLaunchSettings | 

            try
            { 
                // Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration
                apiInstance.PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings(nuanceIntegrationId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nuanceIntegrationId** | **string**| The integration ID for this group of bots |  |
| **settings** | [**NuanceBotLaunchSettings**](NuanceBotLaunchSettings)|  |  |

### Return type

void (empty response body)


## PutIntegrationsSpeechTtsSettings

> [**TtsSettings**](TtsSettings) PutIntegrationsSpeechTtsSettings (TtsSettings body)


Update TTS settings for an org

Requires ANY permissions: 

* integrations:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIntegrationsSpeechTtsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var body = new TtsSettings(); // TtsSettings | Updated TtsSettings

            try
            { 
                // Update TTS settings for an org
                TtsSettings result = apiInstance.PutIntegrationsSpeechTtsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PutIntegrationsSpeechTtsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TtsSettings**](TtsSettings)| Updated TtsSettings |  |

### Return type

[**TtsSettings**](TtsSettings)


## PutIntegrationsUnifiedcommunicationThirdpartypresences

> **string** PutIntegrationsUnifiedcommunicationThirdpartypresences (string ucIntegrationId, List<UCThirdPartyPresence> body)


Bulk integration presence ingestion

This endpoint accepts bulk presence updates from a 3rd-party presence integration and maps the 3rd-party user to a Genesys Cloud user via the matching email address. The 3rd-party presence value will be mapped to a Genesys Cloud organization presence definition value.

Requires ANY permissions: 

* integration:presence:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutIntegrationsUnifiedcommunicationThirdpartypresencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntegrationsApi();
            var ucIntegrationId = ucIntegrationId_example;  // string | UC Integration ID
            var body = new List<UCThirdPartyPresence>(); // List<UCThirdPartyPresence> | List of User presences

            try
            { 
                // Bulk integration presence ingestion
                string result = apiInstance.PutIntegrationsUnifiedcommunicationThirdpartypresences(ucIntegrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PutIntegrationsUnifiedcommunicationThirdpartypresences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ucIntegrationId** | **string**| UC Integration ID |  |
| **body** | [**List<UCThirdPartyPresence>**](UCThirdPartyPresence)| List of User presences |  |

### Return type

**string**


_PureCloudPlatform.Client.V2 254.0.0_
