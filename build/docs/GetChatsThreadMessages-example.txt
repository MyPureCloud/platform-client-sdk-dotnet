using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;
using PureCloudPlatform.Client.V2.Extensions;

namespace Example
{
    public class GetChatsThreadMessagesExample
    {
        static void Main(string[] args)
        {   
            PureCloudRegionHosts region = PureCloudRegionHosts.us_east_1; // Genesys Cloud region
            Configuration.Default.ApiClient.setBasePath(region);
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Client Credentials Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("your_client_credential_grant_id", "your_client_credential_grant_secret");

            var apiInstance = new ChatApi();
            var threadId = "threadId_example";  // string | threadId
            var limit = "limit_example";  // string | The maximum number of messages to retrieve (optional) 
            var before = "before_example";  // string | The cutoff date for messages to retrieve (optional) 
            var after = "after_example";  // string | The beginning date for messages to retrieve (optional) 
            var excludeMetadata = true;  // bool? | Whether to exclude metadata for messages (optional) 

            try
            { 
                // Get history by thread
                ChatMessageEntityListing result = apiInstance.GetChatsThreadMessages(threadId, limit, before, after, excludeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Chat.GetChatsThreadMessages: " + e.Message );
            }
        }
    }
}