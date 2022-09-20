---
title: IntegrationsApi
---
## PureCloudPlatform.Client.V2.Api.IntegrationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIntegration**](IntegrationsApi.html#deleteintegration) | **DELETE** /api/v2/integrations/{integrationId} | Delete integration. |
| [**DeleteIntegrationsAction**](IntegrationsApi.html#deleteintegrationsaction) | **DELETE** /api/v2/integrations/actions/{actionId} | Delete an Action |
| [**DeleteIntegrationsActionDraft**](IntegrationsApi.html#deleteintegrationsactiondraft) | **DELETE** /api/v2/integrations/actions/{actionId}/draft | Delete a Draft |
| [**DeleteIntegrationsCredential**](IntegrationsApi.html#deleteintegrationscredential) | **DELETE** /api/v2/integrations/credentials/{credentialId} | Delete a set of credentials |
| [**GetIntegration**](IntegrationsApi.html#getintegration) | **GET** /api/v2/integrations/{integrationId} | Get integration. |
| [**GetIntegrationConfigCurrent**](IntegrationsApi.html#getintegrationconfigcurrent) | **GET** /api/v2/integrations/{integrationId}/config/current | Get integration configuration. |
| [**GetIntegrations**](IntegrationsApi.html#getintegrations) | **GET** /api/v2/integrations | List integrations |
| [**GetIntegrationsAction**](IntegrationsApi.html#getintegrationsaction) | **GET** /api/v2/integrations/actions/{actionId} | Retrieves a single Action matching id. |
| [**GetIntegrationsActionDraft**](IntegrationsApi.html#getintegrationsactiondraft) | **GET** /api/v2/integrations/actions/{actionId}/draft | Retrieve a Draft |
| [**GetIntegrationsActionDraftSchema**](IntegrationsApi.html#getintegrationsactiondraftschema) | **GET** /api/v2/integrations/actions/{actionId}/draft/schemas/{fileName} | Retrieve schema for a Draft based on filename. |
| [**GetIntegrationsActionDraftTemplate**](IntegrationsApi.html#getintegrationsactiondrafttemplate) | **GET** /api/v2/integrations/actions/{actionId}/draft/templates/{fileName} | Retrieve templates for a Draft based on filename. |
| [**GetIntegrationsActionDraftValidation**](IntegrationsApi.html#getintegrationsactiondraftvalidation) | **GET** /api/v2/integrations/actions/{actionId}/draft/validation | Validate current Draft configuration. |
| [**GetIntegrationsActionSchema**](IntegrationsApi.html#getintegrationsactionschema) | **GET** /api/v2/integrations/actions/{actionId}/schemas/{fileName} | Retrieve schema for an action based on filename. |
| [**GetIntegrationsActionTemplate**](IntegrationsApi.html#getintegrationsactiontemplate) | **GET** /api/v2/integrations/actions/{actionId}/templates/{fileName} | Retrieve text of templates for an action based on filename. |
| [**GetIntegrationsActions**](IntegrationsApi.html#getintegrationsactions) | **GET** /api/v2/integrations/actions | Retrieves all actions associated with filters passed in via query param. |
| [**GetIntegrationsActionsCategories**](IntegrationsApi.html#getintegrationsactionscategories) | **GET** /api/v2/integrations/actions/categories | Retrieves all categories of available Actions |
| [**GetIntegrationsActionsDrafts**](IntegrationsApi.html#getintegrationsactionsdrafts) | **GET** /api/v2/integrations/actions/drafts | Retrieves all action drafts associated with the filters passed in via query param. |
| [**GetIntegrationsBotconnectorIntegrationIdBot**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbot) | **GET** /api/v2/integrations/botconnector/{integrationId}/bots/{botId} | Get a specific botConnector bot, plus versions, for this integration |
| [**GetIntegrationsBotconnectorIntegrationIdBotVersions**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbotversions) | **GET** /api/v2/integrations/botconnector/{integrationId}/bots/{botId}/versions | Get a list of bot versions for a bot |
| [**GetIntegrationsBotconnectorIntegrationIdBots**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbots) | **GET** /api/v2/integrations/botconnector/{integrationId}/bots | Get a list of botConnector bots for this integration |
| [**GetIntegrationsBotconnectorIntegrationIdBotsSummaries**](IntegrationsApi.html#getintegrationsbotconnectorintegrationidbotssummaries) | **GET** /api/v2/integrations/botconnector/{integrationId}/bots/summaries | Get a summary list of botConnector bots for this integration |
| [**GetIntegrationsClientapps**](IntegrationsApi.html#getintegrationsclientapps) | **GET** /api/v2/integrations/clientapps | List permitted client app integrations for the logged in user |
| [**GetIntegrationsClientappsUnifiedcommunications**](IntegrationsApi.html#getintegrationsclientappsunifiedcommunications) | **GET** /api/v2/integrations/clientapps/unifiedcommunications | UC integration client application configuration. |
| [**GetIntegrationsCredential**](IntegrationsApi.html#getintegrationscredential) | **GET** /api/v2/integrations/credentials/{credentialId} | Get a single credential with sensitive fields redacted |
| [**GetIntegrationsCredentials**](IntegrationsApi.html#getintegrationscredentials) | **GET** /api/v2/integrations/credentials | List multiple sets of credentials |
| [**GetIntegrationsCredentialsTypes**](IntegrationsApi.html#getintegrationscredentialstypes) | **GET** /api/v2/integrations/credentials/types | List all credential types |
| [**GetIntegrationsSpeechDialogflowAgent**](IntegrationsApi.html#getintegrationsspeechdialogflowagent) | **GET** /api/v2/integrations/speech/dialogflow/agents/{agentId} | Get details about a Dialogflow agent |
| [**GetIntegrationsSpeechDialogflowAgents**](IntegrationsApi.html#getintegrationsspeechdialogflowagents) | **GET** /api/v2/integrations/speech/dialogflow/agents | Get a list of Dialogflow agents in the customers&#39; Google accounts |
| [**GetIntegrationsSpeechLexBotAlias**](IntegrationsApi.html#getintegrationsspeechlexbotalias) | **GET** /api/v2/integrations/speech/lex/bot/alias/{aliasId} | Get details about a Lex bot alias |
| [**GetIntegrationsSpeechLexBotBotIdAliases**](IntegrationsApi.html#getintegrationsspeechlexbotbotidaliases) | **GET** /api/v2/integrations/speech/lex/bot/{botId}/aliases | Get a list of aliases for a bot in the customer&#39;s AWS accounts |
| [**GetIntegrationsSpeechLexBots**](IntegrationsApi.html#getintegrationsspeechlexbots) | **GET** /api/v2/integrations/speech/lex/bots | Get a list of Lex bots in the customers&#39; AWS accounts |
| [**GetIntegrationsSpeechTtsEngine**](IntegrationsApi.html#getintegrationsspeechttsengine) | **GET** /api/v2/integrations/speech/tts/engines/{engineId} | Get details about a TTS engine |
| [**GetIntegrationsSpeechTtsEngineVoice**](IntegrationsApi.html#getintegrationsspeechttsenginevoice) | **GET** /api/v2/integrations/speech/tts/engines/{engineId}/voices/{voiceId} | Get details about a specific voice for a TTS engine |
| [**GetIntegrationsSpeechTtsEngineVoices**](IntegrationsApi.html#getintegrationsspeechttsenginevoices) | **GET** /api/v2/integrations/speech/tts/engines/{engineId}/voices | Get a list of voices for a TTS engine |
| [**GetIntegrationsSpeechTtsEngines**](IntegrationsApi.html#getintegrationsspeechttsengines) | **GET** /api/v2/integrations/speech/tts/engines | Get a list of TTS engines enabled for org |
| [**GetIntegrationsSpeechTtsSettings**](IntegrationsApi.html#getintegrationsspeechttssettings) | **GET** /api/v2/integrations/speech/tts/settings | Get TTS settings for an org |
| [**GetIntegrationsType**](IntegrationsApi.html#getintegrationstype) | **GET** /api/v2/integrations/types/{typeId} | Get integration type. |
| [**GetIntegrationsTypeConfigschema**](IntegrationsApi.html#getintegrationstypeconfigschema) | **GET** /api/v2/integrations/types/{typeId}/configschemas/{configType} | Get properties config schema for an integration type. |
| [**GetIntegrationsTypes**](IntegrationsApi.html#getintegrationstypes) | **GET** /api/v2/integrations/types | List integration types |
| [**GetIntegrationsUserapps**](IntegrationsApi.html#getintegrationsuserapps) | **GET** /api/v2/integrations/userapps | List permitted user app integrations for the logged in user |
| [**PatchIntegration**](IntegrationsApi.html#patchintegration) | **PATCH** /api/v2/integrations/{integrationId} | Update an integration. |
| [**PatchIntegrationsAction**](IntegrationsApi.html#patchintegrationsaction) | **PATCH** /api/v2/integrations/actions/{actionId} | Patch an Action |
| [**PatchIntegrationsActionDraft**](IntegrationsApi.html#patchintegrationsactiondraft) | **PATCH** /api/v2/integrations/actions/{actionId}/draft | Update an existing Draft |
| [**PostIntegrations**](IntegrationsApi.html#postintegrations) | **POST** /api/v2/integrations | Create an integration. |
| [**PostIntegrationsActionDraft**](IntegrationsApi.html#postintegrationsactiondraft) | **POST** /api/v2/integrations/actions/{actionId}/draft | Create a new Draft from existing Action |
| [**PostIntegrationsActionDraftPublish**](IntegrationsApi.html#postintegrationsactiondraftpublish) | **POST** /api/v2/integrations/actions/{actionId}/draft/publish | Publish a Draft and make it the active Action configuration |
| [**PostIntegrationsActionDraftTest**](IntegrationsApi.html#postintegrationsactiondrafttest) | **POST** /api/v2/integrations/actions/{actionId}/draft/test | Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActionExecute**](IntegrationsApi.html#postintegrationsactionexecute) | **POST** /api/v2/integrations/actions/{actionId}/execute | Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. |
| [**PostIntegrationsActionTest**](IntegrationsApi.html#postintegrationsactiontest) | **POST** /api/v2/integrations/actions/{actionId}/test | Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActions**](IntegrationsApi.html#postintegrationsactions) | **POST** /api/v2/integrations/actions | Create a new Action |
| [**PostIntegrationsActionsDrafts**](IntegrationsApi.html#postintegrationsactionsdrafts) | **POST** /api/v2/integrations/actions/drafts | Create a new Draft |
| [**PostIntegrationsCredentials**](IntegrationsApi.html#postintegrationscredentials) | **POST** /api/v2/integrations/credentials | Create a set of credentials |
| [**PutIntegrationConfigCurrent**](IntegrationsApi.html#putintegrationconfigcurrent) | **PUT** /api/v2/integrations/{integrationId}/config/current | Update integration configuration. |
| [**PutIntegrationsBotconnectorIntegrationIdBots**](IntegrationsApi.html#putintegrationsbotconnectorintegrationidbots) | **PUT** /api/v2/integrations/botconnector/{integrationId}/bots | Set a list of botConnector bots plus versions for this integration |
| [**PutIntegrationsCredential**](IntegrationsApi.html#putintegrationscredential) | **PUT** /api/v2/integrations/credentials/{credentialId} | Update a set of credentials |
| [**PutIntegrationsSpeechTtsSettings**](IntegrationsApi.html#putintegrationsspeechttssettings) | **PUT** /api/v2/integrations/speech/tts/settings | Update TTS settings for an org |
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



UC integration client application configuration.

This endpoint returns basic UI configuration data for all Unified Communications integrations client applications enabled for the current organization.



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



Create a new Action



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
                // Create a new Action
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

