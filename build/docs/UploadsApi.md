---
title: UploadsApi
---
## PureCloudPlatform.Client.V2.Api.UploadsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostUploadsPublicassetsImages**](UploadsApi.html#postuploadspublicassetsimages) | **POST** /api/v2/uploads/publicassets/images | Creates presigned url for uploading a public asset image |
{: class="table table-striped"}

<a name="postuploadspublicassetsimages"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsPublicassetsImages (UploadUrlRequest body)



Creates presigned url for uploading a public asset image



Requires ALL permissions: 

* uploads:publicasset:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsPublicassetsImagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading a public asset image
                UploadUrlResponse result = apiInstance.PostUploadsPublicassetsImages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsPublicassetsImages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

