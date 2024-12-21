# CoachingApi

## PureCloudPlatform.Client.V2.Api.CoachingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCoachingAppointment**](#DeleteCoachingAppointment) | **Delete** /api/v2/coaching/appointments/{appointmentId} | Delete an existing appointment |
| [**DeleteCoachingAppointmentAnnotation**](#DeleteCoachingAppointmentAnnotation) | **Delete** /api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId} | Delete an existing annotation |
| [**GetCoachingAppointment**](#GetCoachingAppointment) | **Get** /api/v2/coaching/appointments/{appointmentId} | Retrieve an appointment |
| [**GetCoachingAppointmentAnnotation**](#GetCoachingAppointmentAnnotation) | **Get** /api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId} | Retrieve an annotation. |
| [**GetCoachingAppointmentAnnotations**](#GetCoachingAppointmentAnnotations) | **Get** /api/v2/coaching/appointments/{appointmentId}/annotations | Get a list of annotations. |
| [**GetCoachingAppointmentStatuses**](#GetCoachingAppointmentStatuses) | **Get** /api/v2/coaching/appointments/{appointmentId}/statuses | Get the list of status changes for a coaching appointment. |
| [**GetCoachingAppointments**](#GetCoachingAppointments) | **Get** /api/v2/coaching/appointments | Get appointments for users and optional date range |
| [**GetCoachingAppointmentsMe**](#GetCoachingAppointmentsMe) | **Get** /api/v2/coaching/appointments/me | Get my appointments for a given date range |
| [**GetCoachingNotification**](#GetCoachingNotification) | **Get** /api/v2/coaching/notifications/{notificationId} | Get an existing notification |
| [**GetCoachingNotifications**](#GetCoachingNotifications) | **Get** /api/v2/coaching/notifications | Retrieve the list of your notifications. |
| [**PatchCoachingAppointment**](#PatchCoachingAppointment) | **Patch** /api/v2/coaching/appointments/{appointmentId} | Update an existing appointment |
| [**PatchCoachingAppointmentAnnotation**](#PatchCoachingAppointmentAnnotation) | **Patch** /api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId} | Update an existing annotation. |
| [**PatchCoachingAppointmentStatus**](#PatchCoachingAppointmentStatus) | **Patch** /api/v2/coaching/appointments/{appointmentId}/status | Update the status of a coaching appointment |
| [**PatchCoachingNotification**](#PatchCoachingNotification) | **Patch** /api/v2/coaching/notifications/{notificationId} | Update an existing notification. |
| [**PostCoachingAppointmentAnnotations**](#PostCoachingAppointmentAnnotations) | **Post** /api/v2/coaching/appointments/{appointmentId}/annotations | Create a new annotation. |
| [**PostCoachingAppointmentConversations**](#PostCoachingAppointmentConversations) | **Post** /api/v2/coaching/appointments/{appointmentId}/conversations | Add a conversation to an appointment |
| [**PostCoachingAppointments**](#PostCoachingAppointments) | **Post** /api/v2/coaching/appointments | Create a new appointment |
| [**PostCoachingAppointmentsAggregatesQuery**](#PostCoachingAppointmentsAggregatesQuery) | **Post** /api/v2/coaching/appointments/aggregates/query | Retrieve aggregated appointment data |
| [**PostCoachingScheduleslotsQuery**](#PostCoachingScheduleslotsQuery) | **Post** /api/v2/coaching/scheduleslots/query | Get list of possible slots where a coaching appointment can be scheduled. |



## DeleteCoachingAppointment

> [**CoachingAppointmentReference**](CoachingAppointmentReference) DeleteCoachingAppointment (string appointmentId)


Delete an existing appointment

Permission not required if you are the creator of the appointment

Requires ANY permissions: 

* coaching:appointment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteCoachingAppointmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.

            try
            { 
                // Delete an existing appointment
                CoachingAppointmentReference result = apiInstance.DeleteCoachingAppointment(appointmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.DeleteCoachingAppointment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |

### Return type

[**CoachingAppointmentReference**](CoachingAppointmentReference)


## DeleteCoachingAppointmentAnnotation

> void DeleteCoachingAppointmentAnnotation (string appointmentId, string annotationId)


Delete an existing annotation

You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment

Requires ANY permissions: 

* coaching:annotation:delete
* coaching:privateAnnotation:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteCoachingAppointmentAnnotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var annotationId = annotationId_example;  // string | The ID of the annotation.

            try
            { 
                // Delete an existing annotation
                apiInstance.DeleteCoachingAppointmentAnnotation(appointmentId, annotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.DeleteCoachingAppointmentAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **annotationId** | **string**| The ID of the annotation. |  |

### Return type

void (empty response body)


## GetCoachingAppointment

> [**CoachingAppointmentResponse**](CoachingAppointmentResponse) GetCoachingAppointment (string appointmentId)


Retrieve an appointment

Permission not required if you are the attendee, creator or facilitator of the appointment

Requires ANY permissions: 

* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCoachingAppointmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.

            try
            { 
                // Retrieve an appointment
                CoachingAppointmentResponse result = apiInstance.GetCoachingAppointment(appointmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingAppointment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |

### Return type

[**CoachingAppointmentResponse**](CoachingAppointmentResponse)


## GetCoachingAppointmentAnnotation

> [**CoachingAnnotation**](CoachingAnnotation) GetCoachingAppointmentAnnotation (string appointmentId, string annotationId)


Retrieve an annotation.

You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).

Requires ANY permissions: 

* coaching:annotation:view
* coaching:privateAnnotation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCoachingAppointmentAnnotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var annotationId = annotationId_example;  // string | The ID of the annotation.

            try
            { 
                // Retrieve an annotation.
                CoachingAnnotation result = apiInstance.GetCoachingAppointmentAnnotation(appointmentId, annotationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingAppointmentAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **annotationId** | **string**| The ID of the annotation. |  |

### Return type

[**CoachingAnnotation**](CoachingAnnotation)


## GetCoachingAppointmentAnnotations

> [**CoachingAnnotationList**](CoachingAnnotationList) GetCoachingAppointmentAnnotations (string appointmentId, int? pageNumber = null, int? pageSize = null)


Get a list of annotations.

You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).

Requires ANY permissions: 

* coaching:annotation:view
* coaching:privateAnnotation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCoachingAppointmentAnnotationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get a list of annotations.
                CoachingAnnotationList result = apiInstance.GetCoachingAppointmentAnnotations(appointmentId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingAppointmentAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**CoachingAnnotationList**](CoachingAnnotationList)


## GetCoachingAppointmentStatuses

> [**CoachingAppointmentStatusResponseList**](CoachingAppointmentStatusResponseList) GetCoachingAppointmentStatuses (string appointmentId, int? pageNumber = null, int? pageSize = null)


Get the list of status changes for a coaching appointment.

Permission not required if you are an attendee, creator or facilitator of the appointment

Requires ANY permissions: 

* coaching:appointmentStatus:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCoachingAppointmentStatusesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get the list of status changes for a coaching appointment.
                CoachingAppointmentStatusResponseList result = apiInstance.GetCoachingAppointmentStatuses(appointmentId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingAppointmentStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**CoachingAppointmentStatusResponseList**](CoachingAppointmentStatusResponseList)


## GetCoachingAppointments

> [**CoachingAppointmentResponseList**](CoachingAppointmentResponseList) GetCoachingAppointments (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null)


Get appointments for users and optional date range

Requires ANY permissions: 

* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCoachingAppointmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var userIds = new List<string>(); // List<string> | The user IDs for which to retrieve appointments
            var interval = interval_example;  // string | Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var statuses = new List<string>(); // List<string> | Appointment Statuses to filter by (optional) 
            var facilitatorIds = new List<string>(); // List<string> | The facilitator IDs for which to retrieve appointments (optional) 
            var sortOrder = sortOrder_example;  // string | Sort (by due date) either Asc or Desc (optional) 
            var relationships = new List<string>(); // List<string> | Relationships to filter by (optional) 
            var completionInterval = completionInterval_example;  // string | Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Overdue status to filter by (optional) 
            var intervalCondition = intervalCondition_example;  // string | Filter condition for interval (optional) 

            try
            { 
                // Get appointments for users and optional date range
                CoachingAppointmentResponseList result = apiInstance.GetCoachingAppointments(userIds, interval, pageNumber, pageSize, statuses, facilitatorIds, sortOrder, relationships, completionInterval, overdue, intervalCondition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingAppointments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userIds** | [**List<string>**](string)| The user IDs for which to retrieve appointments |  |
| **interval** | **string**| Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **statuses** | [**List<string>**](string)| Appointment Statuses to filter by | [optional] <br />**Values**: Scheduled, InProgress, Completed, InvalidSchedule |
| **facilitatorIds** | [**List<string>**](string)| The facilitator IDs for which to retrieve appointments | [optional]  |
| **sortOrder** | **string**| Sort (by due date) either Asc or Desc | [optional] <br />**Values**: Desc, Asc |
| **relationships** | [**List<string>**](string)| Relationships to filter by | [optional] <br />**Values**: Creator, Facilitator, Attendee |
| **completionInterval** | **string**| Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Overdue status to filter by | [optional] <br />**Values**: True, False, Any |
| **intervalCondition** | **string**| Filter condition for interval | [optional] <br />**Values**: StartsIn, Overlaps |

### Return type

[**CoachingAppointmentResponseList**](CoachingAppointmentResponseList)


## GetCoachingAppointmentsMe

> [**CoachingAppointmentResponseList**](CoachingAppointmentResponseList) GetCoachingAppointmentsMe (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null)


Get my appointments for a given date range

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
    public class GetCoachingAppointmentsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var interval = interval_example;  // string | Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var statuses = new List<string>(); // List<string> | Appointment Statuses to filter by (optional) 
            var facilitatorIds = new List<string>(); // List<string> | The facilitator IDs for which to retrieve appointments (optional) 
            var sortOrder = sortOrder_example;  // string | Sort (by due date) either Asc or Desc (optional) 
            var relationships = new List<string>(); // List<string> | Relationships to filter by (optional) 
            var completionInterval = completionInterval_example;  // string | Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Overdue status to filter by (optional) 
            var intervalCondition = intervalCondition_example;  // string | Filter condition for interval (optional) 

            try
            { 
                // Get my appointments for a given date range
                CoachingAppointmentResponseList result = apiInstance.GetCoachingAppointmentsMe(interval, pageNumber, pageSize, statuses, facilitatorIds, sortOrder, relationships, completionInterval, overdue, intervalCondition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingAppointmentsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **interval** | **string**| Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **statuses** | [**List<string>**](string)| Appointment Statuses to filter by | [optional] <br />**Values**: Scheduled, InProgress, Completed, InvalidSchedule |
| **facilitatorIds** | [**List<string>**](string)| The facilitator IDs for which to retrieve appointments | [optional]  |
| **sortOrder** | **string**| Sort (by due date) either Asc or Desc | [optional] <br />**Values**: Desc, Asc |
| **relationships** | [**List<string>**](string)| Relationships to filter by | [optional] <br />**Values**: Creator, Facilitator, Attendee |
| **completionInterval** | **string**| Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Overdue status to filter by | [optional] <br />**Values**: True, False, Any |
| **intervalCondition** | **string**| Filter condition for interval | [optional] <br />**Values**: StartsIn, Overlaps |

### Return type

[**CoachingAppointmentResponseList**](CoachingAppointmentResponseList)


## GetCoachingNotification

> [**CoachingNotification**](CoachingNotification) GetCoachingNotification (string notificationId, List<string> expand = null)


Get an existing notification

Permission not required if you are the owner of the notification.

Requires ANY permissions: 

* coaching:notification:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCoachingNotificationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var notificationId = notificationId_example;  // string | The ID of the notification.
            var expand = new List<string>(); // List<string> | Indicates a field in the response which should be expanded. (optional) 

            try
            { 
                // Get an existing notification
                CoachingNotification result = apiInstance.GetCoachingNotification(notificationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **notificationId** | **string**| The ID of the notification. |  |
| **expand** | [**List<string>**](string)| Indicates a field in the response which should be expanded. | [optional] <br />**Values**: appointment |

### Return type

[**CoachingNotification**](CoachingNotification)


## GetCoachingNotifications

> [**CoachingNotificationList**](CoachingNotificationList) GetCoachingNotifications (int? pageNumber = null, int? pageSize = null, List<string> expand = null)


Retrieve the list of your notifications.

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
    public class GetCoachingNotificationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var expand = new List<string>(); // List<string> | Indicates a field in the response which should be expanded. (optional) 

            try
            { 
                // Retrieve the list of your notifications.
                CoachingNotificationList result = apiInstance.GetCoachingNotifications(pageNumber, pageSize, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.GetCoachingNotifications: " + e.Message );
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
| **expand** | [**List<string>**](string)| Indicates a field in the response which should be expanded. | [optional] <br />**Values**: appointment |

### Return type

[**CoachingNotificationList**](CoachingNotificationList)


## PatchCoachingAppointment

> [**CoachingAppointmentResponse**](CoachingAppointmentResponse) PatchCoachingAppointment (string appointmentId, UpdateCoachingAppointmentRequest body)


Update an existing appointment

Permission not required if you are the creator or facilitator of the appointment

Requires ANY permissions: 

* coaching:appointment:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCoachingAppointmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var body = new UpdateCoachingAppointmentRequest(); // UpdateCoachingAppointmentRequest | The new version of the appointment

            try
            { 
                // Update an existing appointment
                CoachingAppointmentResponse result = apiInstance.PatchCoachingAppointment(appointmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PatchCoachingAppointment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **body** | [**UpdateCoachingAppointmentRequest**](UpdateCoachingAppointmentRequest)| The new version of the appointment |  |

### Return type

[**CoachingAppointmentResponse**](CoachingAppointmentResponse)


## PatchCoachingAppointmentAnnotation

> [**CoachingAnnotation**](CoachingAnnotation) PatchCoachingAppointmentAnnotation (string appointmentId, string annotationId, CoachingAnnotation body)


Update an existing annotation.

You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment

Requires ANY permissions: 

* coaching:annotation:edit
* coaching:privateAnnotation:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCoachingAppointmentAnnotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var annotationId = annotationId_example;  // string | The ID of the annotation.
            var body = new CoachingAnnotation(); // CoachingAnnotation | The new version of the annotation

            try
            { 
                // Update an existing annotation.
                CoachingAnnotation result = apiInstance.PatchCoachingAppointmentAnnotation(appointmentId, annotationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PatchCoachingAppointmentAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **annotationId** | **string**| The ID of the annotation. |  |
| **body** | [**CoachingAnnotation**](CoachingAnnotation)| The new version of the annotation |  |

### Return type

[**CoachingAnnotation**](CoachingAnnotation)


## PatchCoachingAppointmentStatus

> [**CoachingAppointmentStatusResponse**](CoachingAppointmentStatusResponse) PatchCoachingAppointmentStatus (string appointmentId, CoachingAppointmentStatusRequest body)


Update the status of a coaching appointment

Permission not required if you are an attendee, creator or facilitator of the appointment

Requires ANY permissions: 

* coaching:appointmentStatus:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCoachingAppointmentStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var body = new CoachingAppointmentStatusRequest(); // CoachingAppointmentStatusRequest | Updated status of the coaching appointment

            try
            { 
                // Update the status of a coaching appointment
                CoachingAppointmentStatusResponse result = apiInstance.PatchCoachingAppointmentStatus(appointmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PatchCoachingAppointmentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **body** | [**CoachingAppointmentStatusRequest**](CoachingAppointmentStatusRequest)| Updated status of the coaching appointment |  |

### Return type

[**CoachingAppointmentStatusResponse**](CoachingAppointmentStatusResponse)


## PatchCoachingNotification

> [**CoachingNotification**](CoachingNotification) PatchCoachingNotification (string notificationId, CoachingNotification body)


Update an existing notification.

Can only update your own notifications.

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
    public class PatchCoachingNotificationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var notificationId = notificationId_example;  // string | The ID of the notification.
            var body = new CoachingNotification(); // CoachingNotification | Change the read state of a notification

            try
            { 
                // Update an existing notification.
                CoachingNotification result = apiInstance.PatchCoachingNotification(notificationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PatchCoachingNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **notificationId** | **string**| The ID of the notification. |  |
| **body** | [**CoachingNotification**](CoachingNotification)| Change the read state of a notification |  |

### Return type

[**CoachingNotification**](CoachingNotification)


## PostCoachingAppointmentAnnotations

> [**CoachingAnnotation**](CoachingAnnotation) PostCoachingAppointmentAnnotations (string appointmentId, CoachingAnnotationCreateRequest body)


Create a new annotation.

You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).

Requires ANY permissions: 

* coaching:annotation:add
* coaching:privateAnnotation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCoachingAppointmentAnnotationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var body = new CoachingAnnotationCreateRequest(); // CoachingAnnotationCreateRequest | The annotation to add

            try
            { 
                // Create a new annotation.
                CoachingAnnotation result = apiInstance.PostCoachingAppointmentAnnotations(appointmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PostCoachingAppointmentAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **body** | [**CoachingAnnotationCreateRequest**](CoachingAnnotationCreateRequest)| The annotation to add |  |

### Return type

[**CoachingAnnotation**](CoachingAnnotation)


## PostCoachingAppointmentConversations

> [**AddConversationResponse**](AddConversationResponse) PostCoachingAppointmentConversations (string appointmentId, AddConversationRequest body)


Add a conversation to an appointment

Permission not required if you are the creator or facilitator of the appointment

Requires ANY permissions: 

* coaching:appointment:edit
* coaching:appointmentConversation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCoachingAppointmentConversationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var appointmentId = appointmentId_example;  // string | The ID of the coaching appointment.
            var body = new AddConversationRequest(); // AddConversationRequest | body

            try
            { 
                // Add a conversation to an appointment
                AddConversationResponse result = apiInstance.PostCoachingAppointmentConversations(appointmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PostCoachingAppointmentConversations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **appointmentId** | **string**| The ID of the coaching appointment. |  |
| **body** | [**AddConversationRequest**](AddConversationRequest)| body |  |

### Return type

[**AddConversationResponse**](AddConversationResponse)


## PostCoachingAppointments

> [**CoachingAppointmentResponse**](CoachingAppointmentResponse) PostCoachingAppointments (CreateCoachingAppointmentRequest body)


Create a new appointment

Requires ANY permissions: 

* coaching:appointment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCoachingAppointmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var body = new CreateCoachingAppointmentRequest(); // CreateCoachingAppointmentRequest | The appointment to add

            try
            { 
                // Create a new appointment
                CoachingAppointmentResponse result = apiInstance.PostCoachingAppointments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PostCoachingAppointments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCoachingAppointmentRequest**](CreateCoachingAppointmentRequest)| The appointment to add |  |

### Return type

[**CoachingAppointmentResponse**](CoachingAppointmentResponse)


## PostCoachingAppointmentsAggregatesQuery

> [**CoachingAppointmentAggregateResponse**](CoachingAppointmentAggregateResponse) PostCoachingAppointmentsAggregatesQuery (CoachingAppointmentAggregateRequest body)


Retrieve aggregated appointment data

Requires ANY permissions: 

* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCoachingAppointmentsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var body = new CoachingAppointmentAggregateRequest(); // CoachingAppointmentAggregateRequest | Aggregate Request

            try
            { 
                // Retrieve aggregated appointment data
                CoachingAppointmentAggregateResponse result = apiInstance.PostCoachingAppointmentsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PostCoachingAppointmentsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CoachingAppointmentAggregateRequest**](CoachingAppointmentAggregateRequest)| Aggregate Request |  |

### Return type

[**CoachingAppointmentAggregateResponse**](CoachingAppointmentAggregateResponse)


## PostCoachingScheduleslotsQuery

> [**CoachingSlotsResponse**](CoachingSlotsResponse) PostCoachingScheduleslotsQuery (CoachingSlotsRequest body)


Get list of possible slots where a coaching appointment can be scheduled.

Requires ANY permissions: 

* coaching:scheduleSlot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCoachingScheduleslotsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CoachingApi();
            var body = new CoachingSlotsRequest(); // CoachingSlotsRequest | The slot search request

            try
            { 
                // Get list of possible slots where a coaching appointment can be scheduled.
                CoachingSlotsResponse result = apiInstance.PostCoachingScheduleslotsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoachingApi.PostCoachingScheduleslotsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CoachingSlotsRequest**](CoachingSlotsRequest)| The slot search request |  |

### Return type

[**CoachingSlotsResponse**](CoachingSlotsResponse)


_PureCloudPlatform.Client.V2 224.0.0_
