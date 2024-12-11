# DataPrivacyApi

## PureCloudPlatform.Client.V2.Api.DataPrivacyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteDataprivacyMaskingrule**](#DeleteDataprivacyMaskingrule) | **Delete** /api/v2/dataprivacy/maskingrules/{ruleId} | Delete a masking rule. |
| [**GetDataprivacyMaskingrule**](#GetDataprivacyMaskingrule) | **Get** /api/v2/dataprivacy/maskingrules/{ruleId} | Fetch details about a masking rule. |
| [**GetDataprivacyMaskingrules**](#GetDataprivacyMaskingrules) | **Get** /api/v2/dataprivacy/maskingrules | Retrieve the list of masking rules. |
| [**PatchDataprivacyMaskingrule**](#PatchDataprivacyMaskingrule) | **Patch** /api/v2/dataprivacy/maskingrules/{ruleId} | Update information about a masking rule. |
| [**PostDataprivacyMaskingrules**](#PostDataprivacyMaskingrules) | **Post** /api/v2/dataprivacy/maskingrules | Create a new masking rule resource. |
| [**PostDataprivacyMaskingrulesValidate**](#PostDataprivacyMaskingrulesValidate) | **Post** /api/v2/dataprivacy/maskingrules/validate | Validate masking before creating. |



## DeleteDataprivacyMaskingrule

> void DeleteDataprivacyMaskingrule (string ruleId)


Delete a masking rule.

Requires ALL permissions: 

* dataprivacy:maskingrule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteDataprivacyMaskingruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataPrivacyApi();
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Delete a masking rule.
                apiInstance.DeleteDataprivacyMaskingrule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPrivacyApi.DeleteDataprivacyMaskingrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| ruleId |  |

### Return type

void (empty response body)


## GetDataprivacyMaskingrule

> [**MaskingRule**](MaskingRule) GetDataprivacyMaskingrule (string ruleId)


Fetch details about a masking rule.

Requires ALL permissions: 

* dataprivacy:maskingrule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDataprivacyMaskingruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataPrivacyApi();
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Fetch details about a masking rule.
                MaskingRule result = apiInstance.GetDataprivacyMaskingrule(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPrivacyApi.GetDataprivacyMaskingrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| ruleId |  |

### Return type

[**MaskingRule**](MaskingRule)


## GetDataprivacyMaskingrules

> [**MaskingRuleListing**](MaskingRuleListing) GetDataprivacyMaskingrules ()


Retrieve the list of masking rules.

Requires ALL permissions: 

* dataprivacy:maskingrule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDataprivacyMaskingrulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataPrivacyApi();

            try
            { 
                // Retrieve the list of masking rules.
                MaskingRuleListing result = apiInstance.GetDataprivacyMaskingrules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPrivacyApi.GetDataprivacyMaskingrules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**MaskingRuleListing**](MaskingRuleListing)


## PatchDataprivacyMaskingrule

> [**MaskingRule**](MaskingRule) PatchDataprivacyMaskingrule (string ruleId, MaskingRule body = null)


Update information about a masking rule.

Requires ALL permissions: 

* dataprivacy:maskingrule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchDataprivacyMaskingruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataPrivacyApi();
            var ruleId = ruleId_example;  // string | ruleId
            var body = new MaskingRule(); // MaskingRule |  (optional) 

            try
            { 
                // Update information about a masking rule.
                MaskingRule result = apiInstance.PatchDataprivacyMaskingrule(ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPrivacyApi.PatchDataprivacyMaskingrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| ruleId |  |
| **body** | [**MaskingRule**](MaskingRule)|  | [optional]  |

### Return type

[**MaskingRule**](MaskingRule)


## PostDataprivacyMaskingrules

> [**MaskingRule**](MaskingRule) PostDataprivacyMaskingrules (MaskingRule body)


Create a new masking rule resource.

Requires ALL permissions: 

* dataprivacy:maskingrule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostDataprivacyMaskingrulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataPrivacyApi();
            var body = new MaskingRule(); // MaskingRule | Details for creating masking rule resource

            try
            { 
                // Create a new masking rule resource.
                MaskingRule result = apiInstance.PostDataprivacyMaskingrules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPrivacyApi.PostDataprivacyMaskingrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MaskingRule**](MaskingRule)| Details for creating masking rule resource |  |

### Return type

[**MaskingRule**](MaskingRule)


## PostDataprivacyMaskingrulesValidate

> [**MaskingRuleValidateResponse**](MaskingRuleValidateResponse) PostDataprivacyMaskingrulesValidate (MaskingRuleValidateRequest body)


Validate masking before creating.

Requires ALL permissions: 

* dataprivacy:maskingrule:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostDataprivacyMaskingrulesValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataPrivacyApi();
            var body = new MaskingRuleValidateRequest(); // MaskingRuleValidateRequest | Text to be masked

            try
            { 
                // Validate masking before creating.
                MaskingRuleValidateResponse result = apiInstance.PostDataprivacyMaskingrulesValidate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPrivacyApi.PostDataprivacyMaskingrulesValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MaskingRuleValidateRequest**](MaskingRuleValidateRequest)| Text to be masked |  |

### Return type

[**MaskingRuleValidateResponse**](MaskingRuleValidateResponse)


_PureCloudPlatform.Client.V2 223.0.0_
