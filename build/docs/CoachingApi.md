---
title: CoachingApi
---
## PureCloudPlatform.Client.V2.Api.CoachingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCoachingAppointment**](CoachingApi.html#deletecoachingappointment) | **DELETE** /api/v2/coaching/appointments/{appointmentId} | Delete an existing appointment |
| [**DeleteCoachingAppointmentAnnotation**](CoachingApi.html#deletecoachingappointmentannotation) | **DELETE** /api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId} | Delete an existing annotation |
| [**GetCoachingAppointment**](CoachingApi.html#getcoachingappointment) | **GET** /api/v2/coaching/appointments/{appointmentId} | Retrieve an appointment |
| [**GetCoachingAppointmentAnnotation**](CoachingApi.html#getcoachingappointmentannotation) | **GET** /api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId} | Retrieve an annotation. |
| [**GetCoachingAppointmentAnnotations**](CoachingApi.html#getcoachingappointmentannotations) | **GET** /api/v2/coaching/appointments/{appointmentId}/annotations | Get a list of annotations. |
| [**GetCoachingAppointmentStatuses**](CoachingApi.html#getcoachingappointmentstatuses) | **GET** /api/v2/coaching/appointments/{appointmentId}/statuses | Get the list of status changes for a coaching appointment. |
| [**GetCoachingAppointments**](CoachingApi.html#getcoachingappointments) | **GET** /api/v2/coaching/appointments | Get appointments for users and optional date range |
| [**GetCoachingAppointmentsMe**](CoachingApi.html#getcoachingappointmentsme) | **GET** /api/v2/coaching/appointments/me | Get my appointments for a given date range |
| [**GetCoachingNotification**](CoachingApi.html#getcoachingnotification) | **GET** /api/v2/coaching/notifications/{notificationId} | Get an existing notification |
| [**GetCoachingNotifications**](CoachingApi.html#getcoachingnotifications) | **GET** /api/v2/coaching/notifications | Retrieve the list of your notifications. |
| [**PatchCoachingAppointment**](CoachingApi.html#patchcoachingappointment) | **PATCH** /api/v2/coaching/appointments/{appointmentId} | Update an existing appointment |
| [**PatchCoachingAppointmentAnnotation**](CoachingApi.html#patchcoachingappointmentannotation) | **PATCH** /api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId} | Update an existing annotation. |
| [**PatchCoachingAppointmentStatus**](CoachingApi.html#patchcoachingappointmentstatus) | **PATCH** /api/v2/coaching/appointments/{appointmentId}/status | Update the status of a coaching appointment |
| [**PatchCoachingNotification**](CoachingApi.html#patchcoachingnotification) | **PATCH** /api/v2/coaching/notifications/{notificationId} | Update an existing notification. |
| [**PostCoachingAppointmentAnnotations**](CoachingApi.html#postcoachingappointmentannotations) | **POST** /api/v2/coaching/appointments/{appointmentId}/annotations | Create a new annotation. |
| [**PostCoachingAppointmentConversations**](CoachingApi.html#postcoachingappointmentconversations) | **POST** /api/v2/coaching/appointments/{appointmentId}/conversations | Add a conversation to an appointment |
| [**PostCoachingAppointments**](CoachingApi.html#postcoachingappointments) | **POST** /api/v2/coaching/appointments | Create a new appointment |
| [**PostCoachingAppointmentsAggregatesQuery**](CoachingApi.html#postcoachingappointmentsaggregatesquery) | **POST** /api/v2/coaching/appointments/aggregates/query | Retrieve aggregated appointment data |
| [**PostCoachingScheduleslotsQuery**](CoachingApi.html#postcoachingscheduleslotsquery) | **POST** /api/v2/coaching/scheduleslots/query | Get list of possible slots where a coaching appointment can be scheduled. |
{: class="table table-striped"}

<a name="deletecoachingappointment"></a>

## [**CoachingAppointmentReference**](CoachingAppointmentReference.html) DeleteCoachingAppointment (string appointmentId)



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
{: class="table table-striped"}

### Return type

[**CoachingAppointmentReference**](CoachingAppointmentReference.html)

<a name="deletecoachingappointmentannotation"></a>

## void DeleteCoachingAppointmentAnnotation (string appointmentId, string annotationId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getcoachingappointment"></a>

## [**CoachingAppointmentResponse**](CoachingAppointmentResponse.html) GetCoachingAppointment (string appointmentId)



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
{: class="table table-striped"}

### Return type

[**CoachingAppointmentResponse**](CoachingAppointmentResponse.html)

<a name="getcoachingappointmentannotation"></a>

## [**CoachingAnnotation**](CoachingAnnotation.html) GetCoachingAppointmentAnnotation (string appointmentId, string annotationId)



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
{: class="table table-striped"}

### Return type

[**CoachingAnnotation**](CoachingAnnotation.html)

<a name="getcoachingappointmentannotations"></a>

## [**CoachingAnnotationList**](CoachingAnnotationList.html) GetCoachingAppointmentAnnotations (string appointmentId, int? pageNumber = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**CoachingAnnotationList**](CoachingAnnotationList.html)

<a name="getcoachingappointmentstatuses"></a>

## [**CoachingAppointmentStatusResponseList**](CoachingAppointmentStatusResponseList.html) GetCoachingAppointmentStatuses (string appointmentId, int? pageNumber = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**CoachingAppointmentStatusResponseList**](CoachingAppointmentStatusResponseList.html)

<a name="getcoachingappointments"></a>

## [**CoachingAppointmentResponseList**](CoachingAppointmentResponseList.html) GetCoachingAppointments (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null)



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
| **userIds** | [**List<string>**](string.html)| The user IDs for which to retrieve appointments |  |
| **interval** | **string**| Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **statuses** | [**List<string>**](string.html)| Appointment Statuses to filter by | [optional] <br />**Values**: Scheduled, InProgress, Completed, InvalidSchedule |
| **facilitatorIds** | [**List<string>**](string.html)| The facilitator IDs for which to retrieve appointments | [optional]  |
| **sortOrder** | **string**| Sort (by due date) either Asc or Desc | [optional] <br />**Values**: Desc, Asc |
| **relationships** | [**List<string>**](string.html)| Relationships to filter by | [optional] <br />**Values**: Creator, Facilitator, Attendee |
| **completionInterval** | **string**| Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Overdue status to filter by | [optional] <br />**Values**: True, False, Any |
| **intervalCondition** | **string**| Filter condition for interval | [optional] <br />**Values**: StartsIn, Overlaps |
{: class="table table-striped"}

### Return type

[**CoachingAppointmentResponseList**](CoachingAppointmentResponseList.html)

<a name="getcoachingappointmentsme"></a>

## [**CoachingAppointmentResponseList**](CoachingAppointmentResponseList.html) GetCoachingAppointmentsMe (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null, string intervalCondition = null)



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
| **statuses** | [**List<string>**](string.html)| Appointment Statuses to filter by | [optional] <br />**Values**: Scheduled, InProgress, Completed, InvalidSchedule |
| **facilitatorIds** | [**List<string>**](string.html)| The facilitator IDs for which to retrieve appointments | [optional]  |
| **sortOrder** | **string**| Sort (by due date) either Asc or Desc | [optional] <br />**Values**: Desc, Asc |
| **relationships** | [**List<string>**](string.html)| Relationships to filter by | [optional] <br />**Values**: Creator, Facilitator, Attendee |
| **completionInterval** | **string**| Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Overdue status to filter by | [optional] <br />**Values**: True, False, Any |
| **intervalCondition** | **string**| Filter condition for interval | [optional] <br />**Values**: StartsIn, Overlaps |
{: class="table table-striped"}

### Return type

[**CoachingAppointmentResponseList**](CoachingAppointmentResponseList.html)

<a name="getcoachingnotification"></a>

## [**CoachingNotification**](CoachingNotification.html) GetCoachingNotification (string notificationId, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| Indicates a field in the response which should be expanded. | [optional] <br />**Values**: appointment |
{: class="table table-striped"}

### Return type

[**CoachingNotification**](CoachingNotification.html)

<a name="getcoachingnotifications"></a>

## [**CoachingNotificationList**](CoachingNotificationList.html) GetCoachingNotifications (int? pageNumber = null, int? pageSize = null, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| Indicates a field in the response which should be expanded. | [optional] <br />**Values**: appointment |
{: class="table table-striped"}

### Return type

[**CoachingNotificationList**](CoachingNotificationList.html)

<a name="patchcoachingappointment"></a>

## [**CoachingAppointmentResponse**](CoachingAppointmentResponse.html) PatchCoachingAppointment (string appointmentId, UpdateCoachingAppointmentRequest body)



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
| **body** | [**UpdateCoachingAppointmentRequest**](UpdateCoachingAppointmentRequest.html)| The new version of the appointment |  |
{: class="table table-striped"}

### Return type

[**CoachingAppointmentResponse**](CoachingAppointmentResponse.html)

<a name="patchcoachingappointmentannotation"></a>

## [**CoachingAnnotation**](CoachingAnnotation.html) PatchCoachingAppointmentAnnotation (string appointmentId, string annotationId, CoachingAnnotation body)



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
| **body** | [**CoachingAnnotation**](CoachingAnnotation.html)| The new version of the annotation |  |
{: class="table table-striped"}

### Return type

[**CoachingAnnotation**](CoachingAnnotation.html)

<a name="patchcoachingappointmentstatus"></a>

## [**CoachingAppointmentStatusResponse**](CoachingAppointmentStatusResponse.html) PatchCoachingAppointmentStatus (string appointmentId, CoachingAppointmentStatusRequest body)



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
| **body** | [**CoachingAppointmentStatusRequest**](CoachingAppointmentStatusRequest.html)| Updated status of the coaching appointment |  |
{: class="table table-striped"}

### Return type

[**CoachingAppointmentStatusResponse**](CoachingAppointmentStatusResponse.html)

<a name="patchcoachingnotification"></a>

## [**CoachingNotification**](CoachingNotification.html) PatchCoachingNotification (string notificationId, CoachingNotification body)



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
| **body** | [**CoachingNotification**](CoachingNotification.html)| Change the read state of a notification |  |
{: class="table table-striped"}

### Return type

[**CoachingNotification**](CoachingNotification.html)

<a name="postcoachingappointmentannotations"></a>

## [**CoachingAnnotation**](CoachingAnnotation.html) PostCoachingAppointmentAnnotations (string appointmentId, CoachingAnnotationCreateRequest body)



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
| **body** | [**CoachingAnnotationCreateRequest**](CoachingAnnotationCreateRequest.html)| The annotation to add |  |
{: class="table table-striped"}

### Return type

[**CoachingAnnotation**](CoachingAnnotation.html)

<a name="postcoachingappointmentconversations"></a>

## [**AddConversationResponse**](AddConversationResponse.html) PostCoachingAppointmentConversations (string appointmentId, AddConversationRequest body)



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
| **body** | [**AddConversationRequest**](AddConversationRequest.html)| body |  |
{: class="table table-striped"}

### Return type

[**AddConversationResponse**](AddConversationResponse.html)

<a name="postcoachingappointments"></a>

## [**CoachingAppointmentResponse**](CoachingAppointmentResponse.html) PostCoachingAppointments (CreateCoachingAppointmentRequest body)



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
| **body** | [**CreateCoachingAppointmentRequest**](CreateCoachingAppointmentRequest.html)| The appointment to add |  |
{: class="table table-striped"}

### Return type

[**CoachingAppointmentResponse**](CoachingAppointmentResponse.html)

<a name="postcoachingappointmentsaggregatesquery"></a>

## [**CoachingAppointmentAggregateResponse**](CoachingAppointmentAggregateResponse.html) PostCoachingAppointmentsAggregatesQuery (CoachingAppointmentAggregateRequest body)



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
| **body** | [**CoachingAppointmentAggregateRequest**](CoachingAppointmentAggregateRequest.html)| Aggregate Request |  |
{: class="table table-striped"}

### Return type

[**CoachingAppointmentAggregateResponse**](CoachingAppointmentAggregateResponse.html)

<a name="postcoachingscheduleslotsquery"></a>

## [**CoachingSlotsResponse**](CoachingSlotsResponse.html) PostCoachingScheduleslotsQuery (CoachingSlotsRequest body)



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
| **body** | [**CoachingSlotsRequest**](CoachingSlotsRequest.html)| The slot search request |  |
{: class="table table-striped"}

### Return type

[**CoachingSlotsResponse**](CoachingSlotsResponse.html)

