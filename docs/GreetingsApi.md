# GreetingsApi

## PureCloudPlatform.Client.V2.Api.GreetingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGreeting**](#DeleteGreeting) | **Delete** /api/v2/greetings/{greetingId} | Deletes a Greeting with the given GreetingId |
| [**GetGreeting**](#GetGreeting) | **Get** /api/v2/greetings/{greetingId} | Get a Greeting with the given GreetingId |
| [**GetGreetingMedia**](#GetGreetingMedia) | **Get** /api/v2/greetings/{greetingId}/media | Get media playback URI for this greeting |
| [**GetGreetings**](#GetGreetings) | **Get** /api/v2/greetings | Gets an Organization&#39;s Greetings |
| [**GetGreetingsDefaults**](#GetGreetingsDefaults) | **Get** /api/v2/greetings/defaults | Get an Organization&#39;s DefaultGreetingList |
| [**GetGroupGreetings**](#GetGroupGreetings) | **Get** /api/v2/groups/{groupId}/greetings | Get a list of the Group&#39;s Greetings |
| [**GetGroupGreetingsDefaults**](#GetGroupGreetingsDefaults) | **Get** /api/v2/groups/{groupId}/greetings/defaults | Grabs the list of Default Greetings given a Group&#39;s ID |
| [**GetUserGreetings**](#GetUserGreetings) | **Get** /api/v2/users/{userId}/greetings | Get a list of the User&#39;s Greetings |
| [**GetUserGreetingsDefaults**](#GetUserGreetingsDefaults) | **Get** /api/v2/users/{userId}/greetings/defaults | Grabs the list of Default Greetings given a User&#39;s ID |
| [**PostGreetings**](#PostGreetings) | **Post** /api/v2/greetings | Create a Greeting for an Organization |
| [**PostGroupGreetings**](#PostGroupGreetings) | **Post** /api/v2/groups/{groupId}/greetings | Creates a Greeting for a Group |
| [**PostUserGreetings**](#PostUserGreetings) | **Post** /api/v2/users/{userId}/greetings | Creates a Greeting for a User |
| [**PutGreeting**](#PutGreeting) | **Put** /api/v2/greetings/{greetingId} | Updates the Greeting with the given GreetingId |
| [**PutGreetingsDefaults**](#PutGreetingsDefaults) | **Put** /api/v2/greetings/defaults | Update an Organization&#39;s DefaultGreetingList |
| [**PutGroupGreetingsDefaults**](#PutGroupGreetingsDefaults) | **Put** /api/v2/groups/{groupId}/greetings/defaults | Updates the DefaultGreetingList of the specified Group |
| [**PutUserGreetingsDefaults**](#PutUserGreetingsDefaults) | **Put** /api/v2/users/{userId}/greetings/defaults | Updates the DefaultGreetingList of the specified User |



## DeleteGreeting

> void DeleteGreeting (string greetingId)


Deletes a Greeting with the given GreetingId

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
    public class DeleteGreetingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID

            try
            { 
                // Deletes a Greeting with the given GreetingId
                apiInstance.DeleteGreeting(greetingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.DeleteGreeting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |

### Return type

void (empty response body)


## GetGreeting

> [**Greeting**](Greeting) GetGreeting (string greetingId)


Get a Greeting with the given GreetingId

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
    public class GetGreetingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID

            try
            { 
                // Get a Greeting with the given GreetingId
                Greeting result = apiInstance.GetGreeting(greetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreeting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |

### Return type

[**Greeting**](Greeting)


## GetGreetingMedia

> [**GreetingMediaInfo**](GreetingMediaInfo) GetGreetingMedia (string greetingId, string formatId = null)


Get media playback URI for this greeting

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
    public class GetGreetingMediaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WAV)

            try
            { 
                // Get media playback URI for this greeting
                GreetingMediaInfo result = apiInstance.GetGreetingMedia(greetingId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreetingMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WAV]<br />**Values**: WAV, WEBM, WAV_ULAW, OGG_VORBIS, OGG_OPUS, MP3, NONE |

### Return type

[**GreetingMediaInfo**](GreetingMediaInfo)


## GetGreetings

> [**DomainEntityListing**](DomainEntityListing) GetGreetings (int? pageSize = null, int? pageNumber = null)


Gets an Organization's Greetings

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
    public class GetGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Gets an Organization's Greetings
                DomainEntityListing result = apiInstance.GetGreetings(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**DomainEntityListing**](DomainEntityListing)


## GetGreetingsDefaults

> [**DefaultGreetingList**](DefaultGreetingList) GetGreetingsDefaults ()


Get an Organization's DefaultGreetingList

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
    public class GetGreetingsDefaultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();

            try
            { 
                // Get an Organization's DefaultGreetingList
                DefaultGreetingList result = apiInstance.GetGreetingsDefaults();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreetingsDefaults: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**DefaultGreetingList**](DefaultGreetingList)


## GetGroupGreetings

> [**GreetingListing**](GreetingListing) GetGroupGreetings (string groupId, int? pageSize = null, int? pageNumber = null)


Get a list of the Group's Greetings

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
    public class GetGroupGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of the Group's Greetings
                GreetingListing result = apiInstance.GetGroupGreetings(groupId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGroupGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**GreetingListing**](GreetingListing)


## GetGroupGreetingsDefaults

> [**DefaultGreetingList**](DefaultGreetingList) GetGroupGreetingsDefaults (string groupId)


Grabs the list of Default Greetings given a Group's ID

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
    public class GetGroupGreetingsDefaultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Grabs the list of Default Greetings given a Group's ID
                DefaultGreetingList result = apiInstance.GetGroupGreetingsDefaults(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGroupGreetingsDefaults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |

### Return type

[**DefaultGreetingList**](DefaultGreetingList)


## GetUserGreetings

> [**DomainEntityListing**](DomainEntityListing) GetUserGreetings (string userId, int? pageSize = null, int? pageNumber = null)


Get a list of the User's Greetings

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
    public class GetUserGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of the User's Greetings
                DomainEntityListing result = apiInstance.GetUserGreetings(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetUserGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**DomainEntityListing**](DomainEntityListing)


## GetUserGreetingsDefaults

> [**DefaultGreetingList**](DefaultGreetingList) GetUserGreetingsDefaults (string userId)


Grabs the list of Default Greetings given a User's ID

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
    public class GetUserGreetingsDefaultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Grabs the list of Default Greetings given a User's ID
                DefaultGreetingList result = apiInstance.GetUserGreetingsDefaults(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetUserGreetingsDefaults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |

### Return type

[**DefaultGreetingList**](DefaultGreetingList)


## PostGreetings

> [**Greeting**](Greeting) PostGreetings (Greeting body)


Create a Greeting for an Organization

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
    public class PostGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var body = new Greeting(); // Greeting | The Greeting to create

            try
            { 
                // Create a Greeting for an Organization
                Greeting result = apiInstance.PostGreetings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PostGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Greeting**](Greeting)| The Greeting to create |  |

### Return type

[**Greeting**](Greeting)


## PostGroupGreetings

> [**Greeting**](Greeting) PostGroupGreetings (string groupId, Greeting body)


Creates a Greeting for a Group

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
    public class PostGroupGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new Greeting(); // Greeting | The Greeting to create

            try
            { 
                // Creates a Greeting for a Group
                Greeting result = apiInstance.PostGroupGreetings(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PostGroupGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**Greeting**](Greeting)| The Greeting to create |  |

### Return type

[**Greeting**](Greeting)


## PostUserGreetings

> [**Greeting**](Greeting) PostUserGreetings (string userId, Greeting body)


Creates a Greeting for a User

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
    public class PostUserGreetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID
            var body = new Greeting(); // Greeting | The Greeting to create

            try
            { 
                // Creates a Greeting for a User
                Greeting result = apiInstance.PostUserGreetings(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PostUserGreetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**Greeting**](Greeting)| The Greeting to create |  |

### Return type

[**Greeting**](Greeting)


## PutGreeting

> [**Greeting**](Greeting) PutGreeting (string greetingId, Greeting body)


Updates the Greeting with the given GreetingId

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
    public class PutGreetingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID
            var body = new Greeting(); // Greeting | The updated Greeting

            try
            { 
                // Updates the Greeting with the given GreetingId
                Greeting result = apiInstance.PutGreeting(greetingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutGreeting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
| **body** | [**Greeting**](Greeting)| The updated Greeting |  |

### Return type

[**Greeting**](Greeting)


## PutGreetingsDefaults

> [**DefaultGreetingList**](DefaultGreetingList) PutGreetingsDefaults (DefaultGreetingList body)


Update an Organization's DefaultGreetingList

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
    public class PutGreetingsDefaultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var body = new DefaultGreetingList(); // DefaultGreetingList | The updated defaultGreetingList

            try
            { 
                // Update an Organization's DefaultGreetingList
                DefaultGreetingList result = apiInstance.PutGreetingsDefaults(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutGreetingsDefaults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DefaultGreetingList**](DefaultGreetingList)| The updated defaultGreetingList |  |

### Return type

[**DefaultGreetingList**](DefaultGreetingList)


## PutGroupGreetingsDefaults

> [**DefaultGreetingList**](DefaultGreetingList) PutGroupGreetingsDefaults (string groupId, DefaultGreetingList body)


Updates the DefaultGreetingList of the specified Group

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
    public class PutGroupGreetingsDefaultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new DefaultGreetingList(); // DefaultGreetingList | The updated defaultGreetingList

            try
            { 
                // Updates the DefaultGreetingList of the specified Group
                DefaultGreetingList result = apiInstance.PutGroupGreetingsDefaults(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutGroupGreetingsDefaults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**DefaultGreetingList**](DefaultGreetingList)| The updated defaultGreetingList |  |

### Return type

[**DefaultGreetingList**](DefaultGreetingList)


## PutUserGreetingsDefaults

> [**DefaultGreetingList**](DefaultGreetingList) PutUserGreetingsDefaults (string userId, DefaultGreetingList body)


Updates the DefaultGreetingList of the specified User

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
    public class PutUserGreetingsDefaultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID
            var body = new DefaultGreetingList(); // DefaultGreetingList | The updated defaultGreetingList

            try
            { 
                // Updates the DefaultGreetingList of the specified User
                DefaultGreetingList result = apiInstance.PutUserGreetingsDefaults(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutUserGreetingsDefaults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**DefaultGreetingList**](DefaultGreetingList)| The updated defaultGreetingList |  |

### Return type

[**DefaultGreetingList**](DefaultGreetingList)


_PureCloudPlatform.Client.V2 217.0.0_
