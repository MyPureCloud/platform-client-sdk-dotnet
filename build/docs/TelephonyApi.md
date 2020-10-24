---
title: TelephonyApi
---
## PureCloudPlatform.Client.V2.Api.TelephonyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetTelephonySiptraces**](TelephonyApi.html#gettelephonysiptraces) | **GET** /api/v2/telephony/siptraces | Fetch SIP metadata |
| [**GetTelephonySiptracesDownloadDownloadId**](TelephonyApi.html#gettelephonysiptracesdownloaddownloadid) | **GET** /api/v2/telephony/siptraces/download/{downloadId} | Get signed S3 URL for a pcap download |
| [**PostTelephonySiptracesDownload**](TelephonyApi.html#posttelephonysiptracesdownload) | **POST** /api/v2/telephony/siptraces/download | Request a download of a pcap file to S3 |
{: class="table table-striped"}

<a name="gettelephonysiptraces"></a>

## [**SipSearchResult**](SipSearchResult.html) GetTelephonySiptraces (DateTime? dateStart, DateTime? dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null)



Fetch SIP metadata

Fetch SIP metadata that matches a given parameter. If exactMatch is passed as a parameter only sip records that have exactly that value will be returned. For example, some records contain conversationId but not all relevant records for that call may contain the conversationId so only a partial view of the call will be reflected

Requires ALL permissions: 

* telephony:pcap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonySiptracesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TelephonyApi();
            var dateStart = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
            var dateEnd = 2013-10-20T19:20:30+01:00;  // DateTime? | End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
            var callId = callId_example;  // string | unique identification of the placed call (optional) 
            var toUser = toUser_example;  // string | User to who the call was placed (optional) 
            var fromUser = fromUser_example;  // string | user who placed the call (optional) 
            var conversationId = conversationId_example;  // string | Unique identification of the conversation (optional) 

            try
            { 
                // Fetch SIP metadata
                SipSearchResult result = apiInstance.GetTelephonySiptraces(dateStart, dateEnd, callId, toUser, fromUser, conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonySiptraces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dateStart** | **DateTime?**| Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z |  |
| **dateEnd** | **DateTime?**| End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z |  |
| **callId** | **string**| unique identification of the placed call | [optional]  |
| **toUser** | **string**| User to who the call was placed | [optional]  |
| **fromUser** | **string**| user who placed the call | [optional]  |
| **conversationId** | **string**| Unique identification of the conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**SipSearchResult**](SipSearchResult.html)

<a name="gettelephonysiptracesdownloaddownloadid"></a>

## [**SignedUrlResponse**](SignedUrlResponse.html) GetTelephonySiptracesDownloadDownloadId (string downloadId)



Get signed S3 URL for a pcap download



Requires ALL permissions: 

* telephony:pcap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTelephonySiptracesDownloadDownloadIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TelephonyApi();
            var downloadId = downloadId_example;  // string | unique id for the downloaded file in S3

            try
            { 
                // Get signed S3 URL for a pcap download
                SignedUrlResponse result = apiInstance.GetTelephonySiptracesDownloadDownloadId(downloadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.GetTelephonySiptracesDownloadDownloadId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **downloadId** | **string**| unique id for the downloaded file in S3 |  |
{: class="table table-striped"}

### Return type

[**SignedUrlResponse**](SignedUrlResponse.html)

<a name="posttelephonysiptracesdownload"></a>

## [**SipDownloadResponse**](SipDownloadResponse.html) PostTelephonySiptracesDownload (SIPSearchPublicRequest sIPSearchPublicRequest)



Request a download of a pcap file to S3



Requires ALL permissions: 

* telephony:pcap:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTelephonySiptracesDownloadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TelephonyApi();
            var sIPSearchPublicRequest = new SIPSearchPublicRequest(); // SIPSearchPublicRequest | 

            try
            { 
                // Request a download of a pcap file to S3
                SipDownloadResponse result = apiInstance.PostTelephonySiptracesDownload(sIPSearchPublicRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyApi.PostTelephonySiptracesDownload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sIPSearchPublicRequest** | [**SIPSearchPublicRequest**](SIPSearchPublicRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**SipDownloadResponse**](SipDownloadResponse.html)

