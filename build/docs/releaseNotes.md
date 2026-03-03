Platform API version: 10094


## Release Notes

The Default Http Client (based on RestSharp) is now preventing automatic processing of HTTP Redirect. It will not automatically issue a consecutive GET request to the url provided as Response Location Header.
This is meant to prevent deserialization errors, when the redirect url provides access to a content which is different from the Platform API operation swagger definition.

On 3xx, the SDK will raise an `ApiException.RedirectException` (NEW) to let the developer catch this response and access the url provided in the `Location` HTTP Response Header. The `ApiException.RedirectException` inherits from `ApiException` and can therefore be also managed with an `ApiException`.


# Major Changes (0 changes)


# Minor Changes (0 changes)


# Point Changes (0 changes)
