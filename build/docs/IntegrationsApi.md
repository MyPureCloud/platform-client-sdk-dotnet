---
title: IntegrationsApi
---
## PureCloudPlatform.Client.V2.Api.IntegrationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIntegration**](IntegrationsApi.html#deleteintegration) | **Delete** /api/v2/integrations/{integrationId} | Delete integration. |
| [**DeleteIntegrationsAction**](IntegrationsApi.html#deleteintegrationsaction) | **Delete** /api/v2/integrations/actions/{actionId} | Delete an Action |
| [**DeleteIntegrationsActionDraft**](IntegrationsApi.html#deleteintegrationsactiondraft) | **Delete** /api/v2/integrations/actions/{actionId}/draft | Delete a Draft |
| [**DeleteIntegrationsCredential**](IntegrationsApi.html#deleteintegrationscredential) | **Delete** /api/v2/integrations/credentials/{credentialId} | Delete a set of credentials |
| [**GetIntegration**](IntegrationsApi.html#getintegration) | **Get** /api/v2/integrations/{integrationId} | Get integration. |
| [**GetIntegrationConfigCurrent**](IntegrationsApi.html#getintegrationconfigcurrent) | **Get** /api/v2/integrations/{integrationId}/config/current | Get integration configuration. |
| [**GetIntegrations**](IntegrationsApi.html#getintegrations) | **Get** /api/v2/integrations | List integrations |
| [**GetIntegrationsAction**](IntegrationsApi.html#getintegrationsaction) | **Get** /api/v2/integrations/actions/{actionId} | Retrieves a single Action matching id. |
| [**GetIntegrationsActionDraft**](IntegrationsApi.html#getintegrationsactiondraft) | **Get** /api/v2/integrations/actions/{actionId}/draft | Retrieve a Draft |
| [**GetIntegrationsActionDraftFunction**](IntegrationsApi.html#getintegrationsactiondraftfunction) | **Get** /api/v2/integrations/actions/{actionId}/draft/function | Get draft function settings for Action |
| [**GetIntegrationsActionDraftSchema**](IntegrationsApi.html#getintegrationsactiondraftschema) | **Get** /api/v2/integrations/actions/{actionId}/draft/schemas/{fileName} | Retrieve schema for a Draft based on filename. |
| [**GetIntegrationsActionDraftTemplate**](IntegrationsApi.html#getintegrationsactiondrafttemplate) | **Get** /api/v2/integrations/actions/{actionId}/draft/templates/{fileName} | Retrieve templates for a Draft based on filename. |
| [**GetIntegrationsActionDraftValidation**](IntegrationsApi.html#getintegrationsactiondraftvalidation) | **Get** /api/v2/integrations/actions/{actionId}/draft/validation | Validate current Draft configuration. |
| [**GetIntegrationsActionFunction**](IntegrationsApi.html#getintegrationsactionfunction) | **Get** /api/v2/integrations/actions/{actionId}/function | Get published function settings for Action |
| [**GetIntegrationsActionSchema**](IntegrationsApi.html#getintegrationsactionschema) | **Get** /api/v2/integrations/actions/{actionId}/schemas/{fileName} | Retrieve schema for an action based on filename. |
| [**GetIntegrationsActionTemplate**](IntegrationsApi.html#getintegrationsactiontemplate) | **Get** /api/v2/integrations/actions/{actionId}/templates/{fileName} | Retrieve text of templates for an action based on filename. |
| [**GetIntegrationsActions**](IntegrationsApi.html#getintegrationsactions) | **Get** /api/v2/integrations/actions | Retrieves all actions associated with filters passed in via query param. |
| [**GetIntegrationsActionsCategories**](IntegrationsApi.html#getintegrationsactionscategories) | **Get** /api/v2/integrations/actions/categories | Retrieves all categories of available Actions |
| [**GetIntegrationsActionsCertificates**](IntegrationsApi.html#getintegrationsactionscertificates) | **Get** /api/v2/integrations/actions/certificates | Retrieves the available mTLS client certificates in use. This endpoint will return inconsistent results while a certificate rotation is in progress. |
| [**GetIntegrationsActionsCertificatesTruststore**](IntegrationsApi.html#getintegrationsactionscertificatestruststore) | **Get** /api/v2/integrations/actions/certificates/truststore | Retrieves basic info about trusted root CA certificates |
| [**GetIntegrationsActionsDrafts**](IntegrationsApi.html#getintegrationsactionsdrafts) | **Get** /api/v2/integrations/actions/drafts | Retrieves all action drafts associated with the filters passed in via query param. |
| [**GetIntegrationsActionsFunctionsRuntimes**](IntegrationsApi.html#getintegrationsactionsfunctionsruntimes) | **Get** /api/v2/integrations/actions/functions/runtimes | Get action function settings for Action |
| [**GetIntegrationsBotconnectorIntegrationIdBot**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbot) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots/{botId} | Get a specific botConnector bot, plus versions, for this integration |
| [**GetIntegrationsBotconnectorIntegrationIdBotVersions**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbotversions) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots/{botId}/versions | Get a list of bot versions for a bot |
| [**GetIntegrationsBotconnectorIntegrationIdBots**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbots) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots | Get a list of botConnector bots for this integration |
| [**GetIntegrationsBotconnectorIntegrationIdBotsSummaries**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbotssummaries) | **Get** /api/v2/integrations/botconnector/{integrationId}/bots/summaries | Get a summary list of botConnector bots for this integration |
| [**GetIntegrationsClientapps**](IntegrationsApi.html#getintegrationsclientapps) | **Get** /api/v2/integrations/clientapps | List permitted client app integrations for the logged in user |
| [**GetIntegrationsClientappsUnifiedcommunications**](IntegrationsApi.html#getintegrationsclientappsunifiedcommunications) | **Get** /api/v2/integrations/clientapps/unifiedcommunications | UC integration client application configuration. |
| [**GetIntegrationsCredential**](IntegrationsApi.html#getintegrationscredential) | **Get** /api/v2/integrations/credentials/{credentialId} | Get a single credential with sensitive fields redacted |
| [**GetIntegrationsCredentials**](IntegrationsApi.html#getintegrationscredentials) | **Get** /api/v2/integrations/credentials | List multiple sets of credentials |
| [**GetIntegrationsCredentialsTypes**](IntegrationsApi.html#getintegrationscredentialstypes) | **Get** /api/v2/integrations/credentials/types | List all credential types |
| [**GetIntegrationsSpeechDialogflowAgent**](IntegrationsApi.html#getintegrationsspeechdialogflowagent) | **Get** /api/v2/integrations/speech/dialogflow/agents/{agentId} | Get details about a Dialogflow agent |
| [**GetIntegrationsSpeechDialogflowAgents**](IntegrationsApi.html#getintegrationsspeechdialogflowagents) | **Get** /api/v2/integrations/speech/dialogflow/agents | Get a list of Dialogflow agents in the customers&#39; Google accounts |
| [**GetIntegrationsSpeechDialogflowcxAgent**](IntegrationsApi.html#getintegrationsspeechdialogflowcxagent) | **Get** /api/v2/integrations/speech/dialogflowcx/agents/{agentId} | Get details about a Dialogflow CX agent |
| [**GetIntegrationsSpeechDialogflowcxAgents**](IntegrationsApi.html#getintegrationsspeechdialogflowcxagents) | **Get** /api/v2/integrations/speech/dialogflowcx/agents | Get a list of Dialogflow CX agents in the customers&#39; Google accounts |
| [**GetIntegrationsSpeechLexBotAlias**](IntegrationsApi.html#getintegrationsspeechlexbotalias) | **Get** /api/v2/integrations/speech/lex/bot/alias/{aliasId} | Get details about a Lex bot alias |
| [**GetIntegrationsSpeechLexBotBotIdAliases**](IntegrationsApi.html#getintegrationsspeechlexbotbotidaliases) | **Get** /api/v2/integrations/speech/lex/bot/{botId}/aliases | Get a list of aliases for a bot in the customer&#39;s AWS accounts |
| [**GetIntegrationsSpeechLexBots**](IntegrationsApi.html#getintegrationsspeechlexbots) | **Get** /api/v2/integrations/speech/lex/bots | Get a list of Lex bots in the customers&#39; AWS accounts |
| [**GetIntegrationsSpeechLexv2BotAlias**](IntegrationsApi.html#getintegrationsspeechlexv2botalias) | **Get** /api/v2/integrations/speech/lexv2/bot/alias/{aliasId} | Get details about a Lex V2 bot alias |
| [**GetIntegrationsSpeechLexv2BotBotIdAliases**](IntegrationsApi.html#getintegrationsspeechlexv2botbotidaliases) | **Get** /api/v2/integrations/speech/lexv2/bot/{botId}/aliases | Get a list of aliases for a Lex V2 bot |
| [**GetIntegrationsSpeechLexv2Bots**](IntegrationsApi.html#getintegrationsspeechlexv2bots) | **Get** /api/v2/integrations/speech/lexv2/bots | Get a list of Lex V2 bots |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBot**](IntegrationsApi.html#getintegrationsspeechnuancenuanceintegrationidbot) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId} | Get a Nuance bot in the specified Integration |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob**](IntegrationsApi.html#getintegrationsspeechnuancenuanceintegrationidbotjob) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId} | Get the status of an asynchronous Nuance bot GET job |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults**](IntegrationsApi.html#getintegrationsspeechnuancenuanceintegrationidbotjobresults) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs/{jobId}/results | Get the result of an asynchronous Nuance bot GET job |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBots**](IntegrationsApi.html#getintegrationsspeechnuancenuanceintegrationidbots) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots | Get a list of Nuance bots available in the specified Integration |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob**](IntegrationsApi.html#getintegrationsspeechnuancenuanceintegrationidbotsjob) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId} | Get the status of an asynchronous Nuance bots GET job |
| [**GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults**](IntegrationsApi.html#getintegrationsspeechnuancenuanceintegrationidbotsjobresults) | **Get** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs/{jobId}/results | Get the result of an asynchronous Nuance bots GET job |
| [**GetIntegrationsSpeechSttEngine**](IntegrationsApi.html#getintegrationsspeechsttengine) | **Get** /api/v2/integrations/speech/stt/engines/{engineId} | Get details about a STT engine |
| [**GetIntegrationsSpeechSttEngines**](IntegrationsApi.html#getintegrationsspeechsttengines) | **Get** /api/v2/integrations/speech/stt/engines | Get a list of STT engines enabled for org |
| [**GetIntegrationsSpeechTtsEngine**](IntegrationsApi.html#getintegrationsspeechttsengine) | **Get** /api/v2/integrations/speech/tts/engines/{engineId} | Get details about a TTS engine |
| [**GetIntegrationsSpeechTtsEngineVoice**](IntegrationsApi.html#getintegrationsspeechttsenginevoice) | **Get** /api/v2/integrations/speech/tts/engines/{engineId}/voices/{voiceId} | Get details about a specific voice for a TTS engine |
| [**GetIntegrationsSpeechTtsEngineVoices**](IntegrationsApi.html#getintegrationsspeechttsenginevoices) | **Get** /api/v2/integrations/speech/tts/engines/{engineId}/voices | Get a list of voices for a TTS engine |
| [**GetIntegrationsSpeechTtsEngines**](IntegrationsApi.html#getintegrationsspeechttsengines) | **Get** /api/v2/integrations/speech/tts/engines | Get a list of TTS engines enabled for org |
| [**GetIntegrationsSpeechTtsSettings**](IntegrationsApi.html#getintegrationsspeechttssettings) | **Get** /api/v2/integrations/speech/tts/settings | Get TTS settings for an org |
| [**GetIntegrationsType**](IntegrationsApi.html#getintegrationstype) | **Get** /api/v2/integrations/types/{typeId} | Get integration type. |
| [**GetIntegrationsTypeConfigschema**](IntegrationsApi.html#getintegrationstypeconfigschema) | **Get** /api/v2/integrations/types/{typeId}/configschemas/{configType} | Get properties config schema for an integration type. |
| [**GetIntegrationsTypes**](IntegrationsApi.html#getintegrationstypes) | **Get** /api/v2/integrations/types | List integration types |
| [**GetIntegrationsUnifiedcommunicationsClientapp**](IntegrationsApi.html#getintegrationsunifiedcommunicationsclientapp) | **Get** /api/v2/integrations/unifiedcommunications/clientapps/{ucIntegrationId} | UC integration client application configuration. |
| [**GetIntegrationsUnifiedcommunicationsClientapps**](IntegrationsApi.html#getintegrationsunifiedcommunicationsclientapps) | **Get** /api/v2/integrations/unifiedcommunications/clientapps | List UC integration client application configurations. |
| [**GetIntegrationsUserapps**](IntegrationsApi.html#getintegrationsuserapps) | **Get** /api/v2/integrations/userapps | List permitted user app integrations for the logged in user |
| [**PatchIntegration**](IntegrationsApi.html#patchintegration) | **Patch** /api/v2/integrations/{integrationId} | Update an integration. |
| [**PatchIntegrationsAction**](IntegrationsApi.html#patchintegrationsaction) | **Patch** /api/v2/integrations/actions/{actionId} | Patch an Action |
| [**PatchIntegrationsActionDraft**](IntegrationsApi.html#patchintegrationsactiondraft) | **Patch** /api/v2/integrations/actions/{actionId}/draft | Update an existing Draft |
| [**PostIntegrations**](IntegrationsApi.html#postintegrations) | **Post** /api/v2/integrations | Create an integration. |
| [**PostIntegrationsActionDraft**](IntegrationsApi.html#postintegrationsactiondraft) | **Post** /api/v2/integrations/actions/{actionId}/draft | Create a new Draft from existing Action |
| [**PostIntegrationsActionDraftFunctionUpload**](IntegrationsApi.html#postintegrationsactiondraftfunctionupload) | **Post** /api/v2/integrations/actions/{actionId}/draft/function/upload | Create upload presigned URL for draft function package file. |
| [**PostIntegrationsActionDraftPublish**](IntegrationsApi.html#postintegrationsactiondraftpublish) | **Post** /api/v2/integrations/actions/{actionId}/draft/publish | Publish a Draft and make it the active Action configuration |
| [**PostIntegrationsActionDraftTest**](IntegrationsApi.html#postintegrationsactiondrafttest) | **Post** /api/v2/integrations/actions/{actionId}/draft/test | Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActionExecute**](IntegrationsApi.html#postintegrationsactionexecute) | **Post** /api/v2/integrations/actions/{actionId}/execute | Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. |
| [**PostIntegrationsActionTest**](IntegrationsApi.html#postintegrationsactiontest) | **Post** /api/v2/integrations/actions/{actionId}/test | Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActions**](IntegrationsApi.html#postintegrationsactions) | **Post** /api/v2/integrations/actions | Create a new Action. Not supported for &#39;Function Integration&#39; actions. Function integrations must be created as drafts to allow managing of uploading required ZIP function package before they may be used as a published action. |
| [**PostIntegrationsActionsDrafts**](IntegrationsApi.html#postintegrationsactionsdrafts) | **Post** /api/v2/integrations/actions/drafts | Create a new Draft |
| [**PostIntegrationsCredentials**](IntegrationsApi.html#postintegrationscredentials) | **Post** /api/v2/integrations/credentials | Create a set of credentials |
| [**PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs**](IntegrationsApi.html#postintegrationsspeechnuancenuanceintegrationidbotjobs) | **Post** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/{botId}/jobs | Get a Nuance bot in the specified Integration asynchronously |
| [**PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs**](IntegrationsApi.html#postintegrationsspeechnuancenuanceintegrationidbotsjobs) | **Post** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/jobs | Get a list of Nuance bots in the specified Integration asynchronously |
| [**PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate**](IntegrationsApi.html#postintegrationsspeechnuancenuanceintegrationidbotslaunchvalidate) | **Post** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/validate | Try out a single credential for a Nuance bot to know if the secret is correct |
| [**PutIntegrationConfigCurrent**](IntegrationsApi.html#putintegrationconfigcurrent) | **Put** /api/v2/integrations/{integrationId}/config/current | Update integration configuration. |
| [**PutIntegrationsActionDraftFunction**](IntegrationsApi.html#putintegrationsactiondraftfunction) | **Put** /api/v2/integrations/actions/{actionId}/draft/function | Update draft function settings. |
| [**PutIntegrationsBotconnectorIntegrationIdBots**](IntegrationsApi.html#putintegrationsbotconnectorintegrationidbots) | **Put** /api/v2/integrations/botconnector/{integrationId}/bots | Set a list of botConnector bots plus versions for this integration |
| [**PutIntegrationsCredential**](IntegrationsApi.html#putintegrationscredential) | **Put** /api/v2/integrations/credentials/{credentialId} | Update a set of credentials |
| [**PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings**](IntegrationsApi.html#putintegrationsspeechnuancenuanceintegrationidbotslaunchsettings) | **Put** /api/v2/integrations/speech/nuance/{nuanceIntegrationId}/bots/launch/settings | Update the Nuance bot list for the specific bots made available to Genesys Cloud in the specified Integration |
| [**PutIntegrationsSpeechTtsSettings**](IntegrationsApi.html#putintegrationsspeechttssettings) | **Put** /api/v2/integrations/speech/tts/settings | Update TTS settings for an org |
| [**PutIntegrationsUnifiedcommunicationThirdpartypresences**](IntegrationsApi.html#putintegrationsunifiedcommunicationthirdpartypresences) | **Put** /api/v2/integrations/unifiedcommunications/{ucIntegrationId}/thirdpartypresences | Bulk integration presence ingestion |
{: class="table table-striped"}

<a name="deleteintegration"></a>

## [**Integration**](Integration.html) DeleteIntegration (string integrationId)



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
{: class="table table-striped"}

### Return type

[**Integration**](Integration.html)

<a name="deleteintegrationsaction"></a>

## void DeleteIntegrationsAction (string actionId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteintegrationsactiondraft"></a>

## void DeleteIntegrationsActionDraft (string actionId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteintegrationscredential"></a>

## void DeleteIntegrationsCredential (string credentialId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getintegration"></a>

## [**Integration**](Integration.html) GetIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**Integration**](Integration.html)

<a name="getintegrationconfigcurrent"></a>

## [**IntegrationConfiguration**](IntegrationConfiguration.html) GetIntegrationConfigCurrent (string integrationId)



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
{: class="table table-striped"}

### Return type

[**IntegrationConfiguration**](IntegrationConfiguration.html)

<a name="getintegrations"></a>

## [**IntegrationEntityListing**](IntegrationEntityListing.html) GetIntegrations (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)



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

            try
            { 
                // List integrations
                IntegrationEntityListing result = apiInstance.GetIntegrations(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**IntegrationEntityListing**](IntegrationEntityListing.html)

<a name="getintegrationsaction"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) GetIntegrationsAction (string actionId, string expand = null, bool? includeConfig = null)



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
            var includeConfig = includeConfig_example;  // bool? | Return config in response. (optional)  (default to false)

            try
            { 
                // Retrieves a single Action matching id.
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.GetIntegrationsAction(actionId, expand, includeConfig);
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
| **includeConfig** | **bool?**| Return config in response. | [optional] [default to false]<br />**Values**: true, false |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="getintegrationsactiondraft"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) GetIntegrationsActionDraft (string actionId, string expand = null, bool? includeConfig = null)



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
            var includeConfig = includeConfig_example;  // bool? | Return config in response. (optional)  (default to false)

            try
            { 
                // Retrieve a Draft
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.GetIntegrationsActionDraft(actionId, expand, includeConfig);
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
| **includeConfig** | **bool?**| Return config in response. | [optional] [default to false]<br />**Values**: true, false |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="getintegrationsactiondraftfunction"></a>

## [**FunctionConfig**](FunctionConfig.html) GetIntegrationsActionDraftFunction (string actionId)



Get draft function settings for Action

GetIntegrationsActionDraftFunction is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
{: class="table table-striped"}

### Return type

[**FunctionConfig**](FunctionConfig.html)

<a name="getintegrationsactiondraftschema"></a>

## [**JsonSchemaDocument**](JsonSchemaDocument.html) GetIntegrationsActionDraftSchema (string actionId, string fileName)



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

            try
            { 
                // Retrieve schema for a Draft based on filename.
                JsonSchemaDocument result = apiInstance.GetIntegrationsActionDraftSchema(actionId, fileName);
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
{: class="table table-striped"}

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument.html)

<a name="getintegrationsactiondrafttemplate"></a>

## **string** GetIntegrationsActionDraftTemplate (string actionId, string fileName)



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
{: class="table table-striped"}

### Return type

**string**

<a name="getintegrationsactiondraftvalidation"></a>

## [**DraftValidationResult**](DraftValidationResult.html) GetIntegrationsActionDraftValidation (string actionId)



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
{: class="table table-striped"}

### Return type

[**DraftValidationResult**](DraftValidationResult.html)

<a name="getintegrationsactionfunction"></a>

## [**FunctionConfig**](FunctionConfig.html) GetIntegrationsActionFunction (string actionId)



Get published function settings for Action

GetIntegrationsActionFunction is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
{: class="table table-striped"}

### Return type

[**FunctionConfig**](FunctionConfig.html)

<a name="getintegrationsactionschema"></a>

## [**JsonSchemaDocument**](JsonSchemaDocument.html) GetIntegrationsActionSchema (string actionId, string fileName)



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

            try
            { 
                // Retrieve schema for an action based on filename.
                JsonSchemaDocument result = apiInstance.GetIntegrationsActionSchema(actionId, fileName);
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
{: class="table table-striped"}

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument.html)

<a name="getintegrationsactiontemplate"></a>

## **string** GetIntegrationsActionTemplate (string actionId, string fileName)



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
{: class="table table-striped"}

### Return type

**string**

<a name="getintegrationsactions"></a>

## [**ActionEntityListing**](ActionEntityListing.html) GetIntegrationsActions (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)



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
{: class="table table-striped"}

### Return type

[**ActionEntityListing**](ActionEntityListing.html)

<a name="getintegrationsactionscategories"></a>

## [**CategoryEntityListing**](CategoryEntityListing.html) GetIntegrationsActionsCategories (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string secure = null)



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
{: class="table table-striped"}

### Return type

[**CategoryEntityListing**](CategoryEntityListing.html)

<a name="getintegrationsactionscertificates"></a>

## [**ActionCertificateListing**](ActionCertificateListing.html) GetIntegrationsActionsCertificates (string status = null, string type = null)



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
{: class="table table-striped"}

### Return type

[**ActionCertificateListing**](ActionCertificateListing.html)

<a name="getintegrationsactionscertificatestruststore"></a>

## [**TrustedCertificates**](TrustedCertificates.html) GetIntegrationsActionsCertificatesTruststore ()



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

[**TrustedCertificates**](TrustedCertificates.html)

<a name="getintegrationsactionsdrafts"></a>

## [**ActionEntityListing**](ActionEntityListing.html) GetIntegrationsActionsDrafts (int? pageSize = null, int? pageNumber = null, string nextPage = null, string previousPage = null, string sortBy = null, string sortOrder = null, string category = null, string name = null, string ids = null, string secure = null, string includeAuthActions = null)



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
{: class="table table-striped"}

### Return type

[**ActionEntityListing**](ActionEntityListing.html)

<a name="getintegrationsactionsfunctionsruntimes"></a>

## [**List&lt;FunctionRuntime&gt;**](FunctionRuntime.html) GetIntegrationsActionsFunctionsRuntimes ()



Get action function settings for Action

GetIntegrationsActionsFunctionsRuntimes is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

[**List<FunctionRuntime>**](FunctionRuntime.html)

<a name="getintegrationsbotconnectorintegrationidbot"></a>

## [**BotConnectorBot**](BotConnectorBot.html) GetIntegrationsBotconnectorIntegrationIdBot (string integrationId, string botId, string version = null)



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
{: class="table table-striped"}

### Return type

[**BotConnectorBot**](BotConnectorBot.html)

<a name="getintegrationsbotconnectorintegrationidbotversions"></a>

## [**BotConnectorBotVersionSummaryEntityListing**](BotConnectorBotVersionSummaryEntityListing.html) GetIntegrationsBotconnectorIntegrationIdBotVersions (string integrationId, string botId, int? pageNumber = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**BotConnectorBotVersionSummaryEntityListing**](BotConnectorBotVersionSummaryEntityListing.html)

<a name="getintegrationsbotconnectorintegrationidbots"></a>

## [**BotList**](BotList.html) GetIntegrationsBotconnectorIntegrationIdBots (string integrationId)



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
{: class="table table-striped"}

### Return type

[**BotList**](BotList.html)

<a name="getintegrationsbotconnectorintegrationidbotssummaries"></a>

## [**BotConnectorBotSummaryEntityListing**](BotConnectorBotSummaryEntityListing.html) GetIntegrationsBotconnectorIntegrationIdBotsSummaries (string integrationId, int? pageNumber = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**BotConnectorBotSummaryEntityListing**](BotConnectorBotSummaryEntityListing.html)

<a name="getintegrationsclientapps"></a>

## [**ClientAppEntityListing**](ClientAppEntityListing.html) GetIntegrationsClientapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**ClientAppEntityListing**](ClientAppEntityListing.html)

<a name="getintegrationsclientappsunifiedcommunications"></a>

## [**UCIntegrationListing**](UCIntegrationListing.html) GetIntegrationsClientappsUnifiedcommunications (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**UCIntegrationListing**](UCIntegrationListing.html)

<a name="getintegrationscredential"></a>

## [**Credential**](Credential.html) GetIntegrationsCredential (string credentialId)



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
{: class="table table-striped"}

### Return type

[**Credential**](Credential.html)

<a name="getintegrationscredentials"></a>

## [**CredentialInfoListing**](CredentialInfoListing.html) GetIntegrationsCredentials (int? pageNumber = null, int? pageSize = null)



List multiple sets of credentials

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
{: class="table table-striped"}

### Return type

[**CredentialInfoListing**](CredentialInfoListing.html)

<a name="getintegrationscredentialstypes"></a>

## [**CredentialTypeListing**](CredentialTypeListing.html) GetIntegrationsCredentialsTypes ()



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

[**CredentialTypeListing**](CredentialTypeListing.html)

<a name="getintegrationsspeechdialogflowagent"></a>

## [**DialogflowAgent**](DialogflowAgent.html) GetIntegrationsSpeechDialogflowAgent (string agentId)



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
{: class="table table-striped"}

### Return type

[**DialogflowAgent**](DialogflowAgent.html)

<a name="getintegrationsspeechdialogflowagents"></a>

## [**DialogflowAgentSummaryEntityListing**](DialogflowAgentSummaryEntityListing.html) GetIntegrationsSpeechDialogflowAgents (int? pageNumber = null, int? pageSize = null, string name = null)



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
{: class="table table-striped"}

### Return type

[**DialogflowAgentSummaryEntityListing**](DialogflowAgentSummaryEntityListing.html)

<a name="getintegrationsspeechdialogflowcxagent"></a>

## [**DialogflowCXAgent**](DialogflowCXAgent.html) GetIntegrationsSpeechDialogflowcxAgent (string agentId)



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
{: class="table table-striped"}

### Return type

[**DialogflowCXAgent**](DialogflowCXAgent.html)

<a name="getintegrationsspeechdialogflowcxagents"></a>

## [**DialogflowCXAgentSummaryEntityListing**](DialogflowCXAgentSummaryEntityListing.html) GetIntegrationsSpeechDialogflowcxAgents (int? pageNumber = null, int? pageSize = null, string name = null)



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
{: class="table table-striped"}

### Return type

[**DialogflowCXAgentSummaryEntityListing**](DialogflowCXAgentSummaryEntityListing.html)

<a name="getintegrationsspeechlexbotalias"></a>

## [**LexBotAlias**](LexBotAlias.html) GetIntegrationsSpeechLexBotAlias (string aliasId)



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
{: class="table table-striped"}

### Return type

[**LexBotAlias**](LexBotAlias.html)

<a name="getintegrationsspeechlexbotbotidaliases"></a>

## [**LexBotAliasEntityListing**](LexBotAliasEntityListing.html) GetIntegrationsSpeechLexBotBotIdAliases (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)



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
{: class="table table-striped"}

### Return type

[**LexBotAliasEntityListing**](LexBotAliasEntityListing.html)

<a name="getintegrationsspeechlexbots"></a>

## [**LexBotEntityListing**](LexBotEntityListing.html) GetIntegrationsSpeechLexBots (int? pageNumber = null, int? pageSize = null, string name = null)



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
{: class="table table-striped"}

### Return type

[**LexBotEntityListing**](LexBotEntityListing.html)

<a name="getintegrationsspeechlexv2botalias"></a>

## [**LexV2BotAlias**](LexV2BotAlias.html) GetIntegrationsSpeechLexv2BotAlias (string aliasId)



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
{: class="table table-striped"}

### Return type

[**LexV2BotAlias**](LexV2BotAlias.html)

<a name="getintegrationsspeechlexv2botbotidaliases"></a>

## [**LexV2BotAliasEntityListing**](LexV2BotAliasEntityListing.html) GetIntegrationsSpeechLexv2BotBotIdAliases (string botId, int? pageNumber = null, int? pageSize = null, string status = null, string name = null)



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
{: class="table table-striped"}

### Return type

[**LexV2BotAliasEntityListing**](LexV2BotAliasEntityListing.html)

<a name="getintegrationsspeechlexv2bots"></a>

## [**LexV2BotEntityListing**](LexV2BotEntityListing.html) GetIntegrationsSpeechLexv2Bots (int? pageNumber = null, int? pageSize = null, string name = null)



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
{: class="table table-striped"}

### Return type

[**LexV2BotEntityListing**](LexV2BotEntityListing.html)

<a name="getintegrationsspeechnuancenuanceintegrationidbot"></a>

## [**NuanceBot**](NuanceBot.html) GetIntegrationsSpeechNuanceNuanceIntegrationIdBot (string nuanceIntegrationId, string botId, List<string> expand = null, string targetChannel = null)



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
| **expand** | [**List<string>**](string.html)| expand | [optional] <br />**Values**: variables, transferNodes, channels, locales |
| **targetChannel** | **string**| targetChannel | [optional] <br />**Values**: digital, voice |
{: class="table table-striped"}

### Return type

[**NuanceBot**](NuanceBot.html)

<a name="getintegrationsspeechnuancenuanceintegrationidbotjob"></a>

## [**AsyncJob**](AsyncJob.html) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJob (string nuanceIntegrationId, string botId, string jobId)



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
{: class="table table-striped"}

### Return type

[**AsyncJob**](AsyncJob.html)

<a name="getintegrationsspeechnuancenuanceintegrationidbotjobresults"></a>

## [**NuanceBot**](NuanceBot.html) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotJobResults (string nuanceIntegrationId, string botId, string jobId)



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
{: class="table table-striped"}

### Return type

[**NuanceBot**](NuanceBot.html)

<a name="getintegrationsspeechnuancenuanceintegrationidbots"></a>

## [**NuanceBotEntityListing**](NuanceBotEntityListing.html) GetIntegrationsSpeechNuanceNuanceIntegrationIdBots (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)



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
{: class="table table-striped"}

### Return type

[**NuanceBotEntityListing**](NuanceBotEntityListing.html)

<a name="getintegrationsspeechnuancenuanceintegrationidbotsjob"></a>

## [**AsyncJob**](AsyncJob.html) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJob (string nuanceIntegrationId, string jobId)



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
{: class="table table-striped"}

### Return type

[**AsyncJob**](AsyncJob.html)

<a name="getintegrationsspeechnuancenuanceintegrationidbotsjobresults"></a>

## [**NuanceBotEntityListing**](NuanceBotEntityListing.html) GetIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobResults (string nuanceIntegrationId, string jobId)



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
{: class="table table-striped"}

### Return type

[**NuanceBotEntityListing**](NuanceBotEntityListing.html)

<a name="getintegrationsspeechsttengine"></a>

## [**SttEngineEntity**](SttEngineEntity.html) GetIntegrationsSpeechSttEngine (string engineId)



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
{: class="table table-striped"}

### Return type

[**SttEngineEntity**](SttEngineEntity.html)

<a name="getintegrationsspeechsttengines"></a>

## [**SttEngineEntityListing**](SttEngineEntityListing.html) GetIntegrationsSpeechSttEngines (int? pageNumber = null, int? pageSize = null, string name = null)



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
{: class="table table-striped"}

### Return type

[**SttEngineEntityListing**](SttEngineEntityListing.html)

<a name="getintegrationsspeechttsengine"></a>

## [**TtsEngineEntity**](TtsEngineEntity.html) GetIntegrationsSpeechTtsEngine (string engineId, bool? includeVoices = null)



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
{: class="table table-striped"}

### Return type

[**TtsEngineEntity**](TtsEngineEntity.html)

<a name="getintegrationsspeechttsenginevoice"></a>

## [**TtsVoiceEntity**](TtsVoiceEntity.html) GetIntegrationsSpeechTtsEngineVoice (string engineId, string voiceId)



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
{: class="table table-striped"}

### Return type

[**TtsVoiceEntity**](TtsVoiceEntity.html)

<a name="getintegrationsspeechttsenginevoices"></a>

## [**TtsVoiceEntityListing**](TtsVoiceEntityListing.html) GetIntegrationsSpeechTtsEngineVoices (string engineId, int? pageNumber = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**TtsVoiceEntityListing**](TtsVoiceEntityListing.html)

<a name="getintegrationsspeechttsengines"></a>

## [**TtsEngineEntityListing**](TtsEngineEntityListing.html) GetIntegrationsSpeechTtsEngines (int? pageNumber = null, int? pageSize = null, bool? includeVoices = null, string name = null, string language = null)



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
{: class="table table-striped"}

### Return type

[**TtsEngineEntityListing**](TtsEngineEntityListing.html)

<a name="getintegrationsspeechttssettings"></a>

## [**TtsSettings**](TtsSettings.html) GetIntegrationsSpeechTtsSettings ()



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

[**TtsSettings**](TtsSettings.html)

<a name="getintegrationstype"></a>

## [**IntegrationType**](IntegrationType.html) GetIntegrationsType (string typeId)



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
{: class="table table-striped"}

### Return type

[**IntegrationType**](IntegrationType.html)

<a name="getintegrationstypeconfigschema"></a>

## [**JsonSchemaDocument**](JsonSchemaDocument.html) GetIntegrationsTypeConfigschema (string typeId, string configType)



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
{: class="table table-striped"}

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument.html)

<a name="getintegrationstypes"></a>

## [**IntegrationTypeEntityListing**](IntegrationTypeEntityListing.html) GetIntegrationsTypes (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**IntegrationTypeEntityListing**](IntegrationTypeEntityListing.html)

<a name="getintegrationsunifiedcommunicationsclientapp"></a>

## [**UnifiedCommunicationsIntegration**](UnifiedCommunicationsIntegration.html) GetIntegrationsUnifiedcommunicationsClientapp (string ucIntegrationId)



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
{: class="table table-striped"}

### Return type

[**UnifiedCommunicationsIntegration**](UnifiedCommunicationsIntegration.html)

<a name="getintegrationsunifiedcommunicationsclientapps"></a>

## [**UnifiedCommunicationsIntegrationListing**](UnifiedCommunicationsIntegrationListing.html) GetIntegrationsUnifiedcommunicationsClientapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**UnifiedCommunicationsIntegrationListing**](UnifiedCommunicationsIntegrationListing.html)

<a name="getintegrationsuserapps"></a>

## [**UserAppEntityListing**](UserAppEntityListing.html) GetIntegrationsUserapps (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string appHost = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **appHost** | **string**| The type of UserApp to filter by | [optional]  |
{: class="table table-striped"}

### Return type

[**UserAppEntityListing**](UserAppEntityListing.html)

<a name="patchintegration"></a>

## [**Integration**](Integration.html) PatchIntegration (string integrationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, Integration body = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **body** | [**Integration**](Integration.html)| Integration Update | [optional]  |
{: class="table table-striped"}

### Return type

[**Integration**](Integration.html)

<a name="patchintegrationsaction"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) PatchIntegrationsAction (string actionId, UpdateActionInput body)



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
| **body** | [**UpdateActionInput**](UpdateActionInput.html)| Input used to patch the Action. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="patchintegrationsactiondraft"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) PatchIntegrationsActionDraft (string actionId, UpdateDraftInput body)



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
| **body** | [**UpdateDraftInput**](UpdateDraftInput.html)| Input used to patch the Action Draft. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="postintegrations"></a>

## [**Integration**](Integration.html) PostIntegrations (CreateIntegrationRequest body = null)



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
| **body** | [**CreateIntegrationRequest**](CreateIntegrationRequest.html)| Integration | [optional]  |
{: class="table table-striped"}

### Return type

[**Integration**](Integration.html)

<a name="postintegrationsactiondraft"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) PostIntegrationsActionDraft (string actionId)



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
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="postintegrationsactiondraftfunctionupload"></a>

## [**FunctionUploadResponse**](FunctionUploadResponse.html) PostIntegrationsActionDraftFunctionUpload (string actionId, FunctionUploadRequest body)



Create upload presigned URL for draft function package file.

PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**FunctionUploadRequest**](FunctionUploadRequest.html)| Input used to request URL upload. |  |
{: class="table table-striped"}

### Return type

[**FunctionUploadResponse**](FunctionUploadResponse.html)

<a name="postintegrationsactiondraftpublish"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) PostIntegrationsActionDraftPublish (string actionId, PublishDraftInput body)



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
| **body** | [**PublishDraftInput**](PublishDraftInput.html)| Input used to patch the Action. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="postintegrationsactiondrafttest"></a>

## [**TestExecutionResult**](TestExecutionResult.html) PostIntegrationsActionDraftTest (string actionId, Object body)



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

            try
            { 
                // Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.
                TestExecutionResult result = apiInstance.PostIntegrationsActionDraftTest(actionId, body);
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
| **body** | [**Object**](Object.html)| Map of parameters used for variable substitution. |  |
{: class="table table-striped"}

### Return type

[**TestExecutionResult**](TestExecutionResult.html)

<a name="postintegrationsactionexecute"></a>

## **Object** PostIntegrationsActionExecute (string actionId, Object body)



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

            try
            { 
                // Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.
                Object result = apiInstance.PostIntegrationsActionExecute(actionId, body);
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
| **body** | [**Object**](Object.html)| Map of parameters used for variable substitution. |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="postintegrationsactiontest"></a>

## [**TestExecutionResult**](TestExecutionResult.html) PostIntegrationsActionTest (string actionId, Object body)



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

            try
            { 
                // Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.
                TestExecutionResult result = apiInstance.PostIntegrationsActionTest(actionId, body);
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
| **body** | [**Object**](Object.html)| Map of parameters used for variable substitution. |  |
{: class="table table-striped"}

### Return type

[**TestExecutionResult**](TestExecutionResult.html)

<a name="postintegrationsactions"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) PostIntegrationsActions (PostActionInput body)



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
| **body** | [**PostActionInput**](PostActionInput.html)| Input used to create Action. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="postintegrationsactionsdrafts"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html) PostIntegrationsActionsDrafts (PostActionInput body)



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
| **body** | [**PostActionInput**](PostActionInput.html)| Input used to create Action Draft. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](PureCloudPlatform.Client.V2.Model.Action.html)

<a name="postintegrationscredentials"></a>

## [**CredentialInfo**](CredentialInfo.html) PostIntegrationsCredentials (Credential body = null)



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
| **body** | [**Credential**](Credential.html)| Credential | [optional]  |
{: class="table table-striped"}

### Return type

[**CredentialInfo**](CredentialInfo.html)

<a name="postintegrationsspeechnuancenuanceintegrationidbotjobs"></a>

## [**AsyncJob**](AsyncJob.html) PostIntegrationsSpeechNuanceNuanceIntegrationIdBotJobs (string nuanceIntegrationId, string botId, List<string> expand = null, string body = null)



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
| **expand** | [**List<string>**](string.html)| expand | [optional] <br />**Values**: variables, transferNodes, channels, locales |
| **body** | **string**| targetChannel | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncJob**](AsyncJob.html)

<a name="postintegrationsspeechnuancenuanceintegrationidbotsjobs"></a>

## [**AsyncJob**](AsyncJob.html) PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsJobs (string nuanceIntegrationId, int? pageNumber = null, int? pageSize = null, bool? onlyRegisteredBots = null)



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
{: class="table table-striped"}

### Return type

[**AsyncJob**](AsyncJob.html)

<a name="postintegrationsspeechnuancenuanceintegrationidbotslaunchvalidate"></a>

## void PostIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchValidate (string nuanceIntegrationId, BotExecutionConfiguration settings)



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
| **settings** | [**BotExecutionConfiguration**](BotExecutionConfiguration.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putintegrationconfigcurrent"></a>

## [**IntegrationConfiguration**](IntegrationConfiguration.html) PutIntegrationConfigCurrent (string integrationId, IntegrationConfiguration body = null)



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
| **body** | [**IntegrationConfiguration**](IntegrationConfiguration.html)| Integration Configuration | [optional]  |
{: class="table table-striped"}

### Return type

[**IntegrationConfiguration**](IntegrationConfiguration.html)

<a name="putintegrationsactiondraftfunction"></a>

## [**FunctionConfig**](FunctionConfig.html) PutIntegrationsActionDraftFunction (string actionId, Function body)



Update draft function settings.

PutIntegrationsActionDraftFunction is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**Function**](Function.html)| Input used to update function settings. |  |
{: class="table table-striped"}

### Return type

[**FunctionConfig**](FunctionConfig.html)

<a name="putintegrationsbotconnectorintegrationidbots"></a>

## void PutIntegrationsBotconnectorIntegrationIdBots (string integrationId, BotList botList)



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
| **botList** | [**BotList**](BotList.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putintegrationscredential"></a>

## [**CredentialInfo**](CredentialInfo.html) PutIntegrationsCredential (string credentialId, Credential body = null)



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
| **body** | [**Credential**](Credential.html)| Credential | [optional]  |
{: class="table table-striped"}

### Return type

[**CredentialInfo**](CredentialInfo.html)

<a name="putintegrationsspeechnuancenuanceintegrationidbotslaunchsettings"></a>

## void PutIntegrationsSpeechNuanceNuanceIntegrationIdBotsLaunchSettings (string nuanceIntegrationId, NuanceBotLaunchSettings settings)



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
| **settings** | [**NuanceBotLaunchSettings**](NuanceBotLaunchSettings.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putintegrationsspeechttssettings"></a>

## [**TtsSettings**](TtsSettings.html) PutIntegrationsSpeechTtsSettings (TtsSettings body)



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
| **body** | [**TtsSettings**](TtsSettings.html)| Updated TtsSettings |  |
{: class="table table-striped"}

### Return type

[**TtsSettings**](TtsSettings.html)

<a name="putintegrationsunifiedcommunicationthirdpartypresences"></a>

## **string** PutIntegrationsUnifiedcommunicationThirdpartypresences (string ucIntegrationId, List<UCThirdPartyPresence> body)



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
| **body** | [**List<UCThirdPartyPresence>**](UCThirdPartyPresence.html)| List of User presences |  |
{: class="table table-striped"}

### Return type

**string**

