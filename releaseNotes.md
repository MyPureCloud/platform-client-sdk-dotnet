Platform API version: 3884


# SDK Changes

* API-5244 `NotificationHandler` now listens for the `v2.system.socket_closing` event and will automatically reestablish the socket connection
* API-5244 `NotificationHandler` will now automatically emit events for `v2.system.socket_closing` and `channel.metadata` using the event types of `SystemMessageSystemMessage` and  `ChannelMetadataNotification`, respectively
* API-5244 `AddHandlerNoSubscribe` and `AddHandlersNoSubscribe` methods have been added to `NotificationHandler` to allow topic event handlers to be set without modifying the channel's subscription. This is primarily for use when an existing `Channel` is provided when constructing the `NotificationHandler` instance.
* API-5244 Class `ChannelMetadataNotification` has been moved from the erroneous namespace `Extensions.Notifications` to the proper namespace within the SDK of `PureCloudPlatform.Client.V2.Extensions.Notifications`

# Major Changes (0 changes)


# Minor Changes (0 changes)


# Point Changes (0 changes)
