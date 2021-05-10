using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoachingApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>CoachingAppointmentReference</returns>
        CoachingAppointmentReference DeleteCoachingAppointment (string appointmentId);

        /// <summary>
        /// Delete an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>ApiResponse of CoachingAppointmentReference</returns>
        ApiResponse<CoachingAppointmentReference> DeleteCoachingAppointmentWithHttpInfo (string appointmentId);
        
        /// <summary>
        /// Delete an existing annotation
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns></returns>
        void DeleteCoachingAppointmentAnnotation (string appointmentId, string annotationId);

        /// <summary>
        /// Delete an existing annotation
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCoachingAppointmentAnnotationWithHttpInfo (string appointmentId, string annotationId);
        
        /// <summary>
        /// Retrieve an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>CoachingAppointmentResponse</returns>
        CoachingAppointmentResponse GetCoachingAppointment (string appointmentId);

        /// <summary>
        /// Retrieve an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>ApiResponse of CoachingAppointmentResponse</returns>
        ApiResponse<CoachingAppointmentResponse> GetCoachingAppointmentWithHttpInfo (string appointmentId);
        
        /// <summary>
        /// Retrieve an annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>CoachingAnnotation</returns>
        CoachingAnnotation GetCoachingAppointmentAnnotation (string appointmentId, string annotationId);

        /// <summary>
        /// Retrieve an annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>ApiResponse of CoachingAnnotation</returns>
        ApiResponse<CoachingAnnotation> GetCoachingAppointmentAnnotationWithHttpInfo (string appointmentId, string annotationId);
        
        /// <summary>
        /// Get a list of annotations.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>CoachingAnnotationList</returns>
        CoachingAnnotationList GetCoachingAppointmentAnnotations (string appointmentId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of annotations.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of CoachingAnnotationList</returns>
        ApiResponse<CoachingAnnotationList> GetCoachingAppointmentAnnotationsWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get the list of status changes for a coaching appointment.
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>CoachingAppointmentStatusResponseList</returns>
        CoachingAppointmentStatusResponseList GetCoachingAppointmentStatuses (string appointmentId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get the list of status changes for a coaching appointment.
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of CoachingAppointmentStatusResponseList</returns>
        ApiResponse<CoachingAppointmentStatusResponseList> GetCoachingAppointmentStatusesWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get appointments for users and optional date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>CoachingAppointmentResponseList</returns>
        CoachingAppointmentResponseList GetCoachingAppointments (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);

        /// <summary>
        /// Get appointments for users and optional date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>ApiResponse of CoachingAppointmentResponseList</returns>
        ApiResponse<CoachingAppointmentResponseList> GetCoachingAppointmentsWithHttpInfo (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);
        
        /// <summary>
        /// Get my appointments for a given date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>CoachingAppointmentResponseList</returns>
        CoachingAppointmentResponseList GetCoachingAppointmentsMe (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);

        /// <summary>
        /// Get my appointments for a given date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>ApiResponse of CoachingAppointmentResponseList</returns>
        ApiResponse<CoachingAppointmentResponseList> GetCoachingAppointmentsMeWithHttpInfo (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);
        
        /// <summary>
        /// Get an existing notification
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the owner of the notification.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>CoachingNotification</returns>
        CoachingNotification GetCoachingNotification (string notificationId, List<string> expand = null);

        /// <summary>
        /// Get an existing notification
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the owner of the notification.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>ApiResponse of CoachingNotification</returns>
        ApiResponse<CoachingNotification> GetCoachingNotificationWithHttpInfo (string notificationId, List<string> expand = null);
        
        /// <summary>
        /// Retrieve the list of your notifications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>CoachingNotificationList</returns>
        CoachingNotificationList GetCoachingNotifications (int? pageNumber = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Retrieve the list of your notifications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>ApiResponse of CoachingNotificationList</returns>
        ApiResponse<CoachingNotificationList> GetCoachingNotificationsWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> expand = null);
        
        /// <summary>
        /// Update an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>CoachingAppointmentResponse</returns>
        CoachingAppointmentResponse PatchCoachingAppointment (string appointmentId, UpdateCoachingAppointmentRequest body);

        /// <summary>
        /// Update an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>ApiResponse of CoachingAppointmentResponse</returns>
        ApiResponse<CoachingAppointmentResponse> PatchCoachingAppointmentWithHttpInfo (string appointmentId, UpdateCoachingAppointmentRequest body);
        
        /// <summary>
        /// Update an existing annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>CoachingAnnotation</returns>
        CoachingAnnotation PatchCoachingAppointmentAnnotation (string appointmentId, string annotationId, CoachingAnnotation body);

        /// <summary>
        /// Update an existing annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>ApiResponse of CoachingAnnotation</returns>
        ApiResponse<CoachingAnnotation> PatchCoachingAppointmentAnnotationWithHttpInfo (string appointmentId, string annotationId, CoachingAnnotation body);
        
        /// <summary>
        /// Update the status of a coaching appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>CoachingAppointmentStatusResponse</returns>
        CoachingAppointmentStatusResponse PatchCoachingAppointmentStatus (string appointmentId, CoachingAppointmentStatusRequest body);

        /// <summary>
        /// Update the status of a coaching appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>ApiResponse of CoachingAppointmentStatusResponse</returns>
        ApiResponse<CoachingAppointmentStatusResponse> PatchCoachingAppointmentStatusWithHttpInfo (string appointmentId, CoachingAppointmentStatusRequest body);
        
        /// <summary>
        /// Update an existing notification.
        /// </summary>
        /// <remarks>
        /// Can only update your own notifications.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>CoachingNotification</returns>
        CoachingNotification PatchCoachingNotification (string notificationId, CoachingNotification body);

        /// <summary>
        /// Update an existing notification.
        /// </summary>
        /// <remarks>
        /// Can only update your own notifications.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>ApiResponse of CoachingNotification</returns>
        ApiResponse<CoachingNotification> PatchCoachingNotificationWithHttpInfo (string notificationId, CoachingNotification body);
        
        /// <summary>
        /// Create a new annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>CoachingAnnotation</returns>
        CoachingAnnotation PostCoachingAppointmentAnnotations (string appointmentId, CoachingAnnotationCreateRequest body);

        /// <summary>
        /// Create a new annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>ApiResponse of CoachingAnnotation</returns>
        ApiResponse<CoachingAnnotation> PostCoachingAppointmentAnnotationsWithHttpInfo (string appointmentId, CoachingAnnotationCreateRequest body);
        
        /// <summary>
        /// Add a conversation to an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>AddConversationResponse</returns>
        AddConversationResponse PostCoachingAppointmentConversations (string appointmentId, AddConversationRequest body);

        /// <summary>
        /// Add a conversation to an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of AddConversationResponse</returns>
        ApiResponse<AddConversationResponse> PostCoachingAppointmentConversationsWithHttpInfo (string appointmentId, AddConversationRequest body);
        
        /// <summary>
        /// Create a new appointment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>CoachingAppointmentResponse</returns>
        CoachingAppointmentResponse PostCoachingAppointments (CreateCoachingAppointmentRequest body);

        /// <summary>
        /// Create a new appointment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>ApiResponse of CoachingAppointmentResponse</returns>
        ApiResponse<CoachingAppointmentResponse> PostCoachingAppointmentsWithHttpInfo (CreateCoachingAppointmentRequest body);
        
        /// <summary>
        /// Retrieve aggregated appointment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>CoachingAppointmentAggregateResponse</returns>
        CoachingAppointmentAggregateResponse PostCoachingAppointmentsAggregatesQuery (CoachingAppointmentAggregateRequest body);

        /// <summary>
        /// Retrieve aggregated appointment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>ApiResponse of CoachingAppointmentAggregateResponse</returns>
        ApiResponse<CoachingAppointmentAggregateResponse> PostCoachingAppointmentsAggregatesQueryWithHttpInfo (CoachingAppointmentAggregateRequest body);
        
        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>CoachingSlotsResponse</returns>
        CoachingSlotsResponse PostCoachingScheduleslotsQuery (CoachingSlotsRequest body);

        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>ApiResponse of CoachingSlotsResponse</returns>
        ApiResponse<CoachingSlotsResponse> PostCoachingScheduleslotsQueryWithHttpInfo (CoachingSlotsRequest body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of CoachingAppointmentReference</returns>
        System.Threading.Tasks.Task<CoachingAppointmentReference> DeleteCoachingAppointmentAsync (string appointmentId);

        /// <summary>
        /// Delete an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentReference)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentReference>> DeleteCoachingAppointmentAsyncWithHttpInfo (string appointmentId);
        
        /// <summary>
        /// Delete an existing annotation
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCoachingAppointmentAnnotationAsync (string appointmentId, string annotationId);

        /// <summary>
        /// Delete an existing annotation
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCoachingAppointmentAnnotationAsyncWithHttpInfo (string appointmentId, string annotationId);
        
        /// <summary>
        /// Retrieve an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of CoachingAppointmentResponse</returns>
        System.Threading.Tasks.Task<CoachingAppointmentResponse> GetCoachingAppointmentAsync (string appointmentId);

        /// <summary>
        /// Retrieve an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponse>> GetCoachingAppointmentAsyncWithHttpInfo (string appointmentId);
        
        /// <summary>
        /// Retrieve an annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of CoachingAnnotation</returns>
        System.Threading.Tasks.Task<CoachingAnnotation> GetCoachingAppointmentAnnotationAsync (string appointmentId, string annotationId);

        /// <summary>
        /// Retrieve an annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of ApiResponse (CoachingAnnotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAnnotation>> GetCoachingAppointmentAnnotationAsyncWithHttpInfo (string appointmentId, string annotationId);
        
        /// <summary>
        /// Get a list of annotations.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of CoachingAnnotationList</returns>
        System.Threading.Tasks.Task<CoachingAnnotationList> GetCoachingAppointmentAnnotationsAsync (string appointmentId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of annotations.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (CoachingAnnotationList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAnnotationList>> GetCoachingAppointmentAnnotationsAsyncWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get the list of status changes for a coaching appointment.
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of CoachingAppointmentStatusResponseList</returns>
        System.Threading.Tasks.Task<CoachingAppointmentStatusResponseList> GetCoachingAppointmentStatusesAsync (string appointmentId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get the list of status changes for a coaching appointment.
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentStatusResponseList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentStatusResponseList>> GetCoachingAppointmentStatusesAsyncWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get appointments for users and optional date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of CoachingAppointmentResponseList</returns>
        System.Threading.Tasks.Task<CoachingAppointmentResponseList> GetCoachingAppointmentsAsync (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);

        /// <summary>
        /// Get appointments for users and optional date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponseList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponseList>> GetCoachingAppointmentsAsyncWithHttpInfo (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);
        
        /// <summary>
        /// Get my appointments for a given date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of CoachingAppointmentResponseList</returns>
        System.Threading.Tasks.Task<CoachingAppointmentResponseList> GetCoachingAppointmentsMeAsync (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);

        /// <summary>
        /// Get my appointments for a given date range
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponseList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponseList>> GetCoachingAppointmentsMeAsyncWithHttpInfo (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null);
        
        /// <summary>
        /// Get an existing notification
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the owner of the notification.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of CoachingNotification</returns>
        System.Threading.Tasks.Task<CoachingNotification> GetCoachingNotificationAsync (string notificationId, List<string> expand = null);

        /// <summary>
        /// Get an existing notification
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the owner of the notification.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of ApiResponse (CoachingNotification)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingNotification>> GetCoachingNotificationAsyncWithHttpInfo (string notificationId, List<string> expand = null);
        
        /// <summary>
        /// Retrieve the list of your notifications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of CoachingNotificationList</returns>
        System.Threading.Tasks.Task<CoachingNotificationList> GetCoachingNotificationsAsync (int? pageNumber = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Retrieve the list of your notifications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of ApiResponse (CoachingNotificationList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingNotificationList>> GetCoachingNotificationsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> expand = null);
        
        /// <summary>
        /// Update an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>Task of CoachingAppointmentResponse</returns>
        System.Threading.Tasks.Task<CoachingAppointmentResponse> PatchCoachingAppointmentAsync (string appointmentId, UpdateCoachingAppointmentRequest body);

        /// <summary>
        /// Update an existing appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponse>> PatchCoachingAppointmentAsyncWithHttpInfo (string appointmentId, UpdateCoachingAppointmentRequest body);
        
        /// <summary>
        /// Update an existing annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>Task of CoachingAnnotation</returns>
        System.Threading.Tasks.Task<CoachingAnnotation> PatchCoachingAppointmentAnnotationAsync (string appointmentId, string annotationId, CoachingAnnotation body);

        /// <summary>
        /// Update an existing annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>Task of ApiResponse (CoachingAnnotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAnnotation>> PatchCoachingAppointmentAnnotationAsyncWithHttpInfo (string appointmentId, string annotationId, CoachingAnnotation body);
        
        /// <summary>
        /// Update the status of a coaching appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>Task of CoachingAppointmentStatusResponse</returns>
        System.Threading.Tasks.Task<CoachingAppointmentStatusResponse> PatchCoachingAppointmentStatusAsync (string appointmentId, CoachingAppointmentStatusRequest body);

        /// <summary>
        /// Update the status of a coaching appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentStatusResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentStatusResponse>> PatchCoachingAppointmentStatusAsyncWithHttpInfo (string appointmentId, CoachingAppointmentStatusRequest body);
        
        /// <summary>
        /// Update an existing notification.
        /// </summary>
        /// <remarks>
        /// Can only update your own notifications.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>Task of CoachingNotification</returns>
        System.Threading.Tasks.Task<CoachingNotification> PatchCoachingNotificationAsync (string notificationId, CoachingNotification body);

        /// <summary>
        /// Update an existing notification.
        /// </summary>
        /// <remarks>
        /// Can only update your own notifications.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>Task of ApiResponse (CoachingNotification)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingNotification>> PatchCoachingNotificationAsyncWithHttpInfo (string notificationId, CoachingNotification body);
        
        /// <summary>
        /// Create a new annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>Task of CoachingAnnotation</returns>
        System.Threading.Tasks.Task<CoachingAnnotation> PostCoachingAppointmentAnnotationsAsync (string appointmentId, CoachingAnnotationCreateRequest body);

        /// <summary>
        /// Create a new annotation.
        /// </summary>
        /// <remarks>
        /// You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>Task of ApiResponse (CoachingAnnotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAnnotation>> PostCoachingAppointmentAnnotationsAsyncWithHttpInfo (string appointmentId, CoachingAnnotationCreateRequest body);
        
        /// <summary>
        /// Add a conversation to an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>Task of AddConversationResponse</returns>
        System.Threading.Tasks.Task<AddConversationResponse> PostCoachingAppointmentConversationsAsync (string appointmentId, AddConversationRequest body);

        /// <summary>
        /// Add a conversation to an appointment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the creator or facilitator of the appointment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (AddConversationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddConversationResponse>> PostCoachingAppointmentConversationsAsyncWithHttpInfo (string appointmentId, AddConversationRequest body);
        
        /// <summary>
        /// Create a new appointment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>Task of CoachingAppointmentResponse</returns>
        System.Threading.Tasks.Task<CoachingAppointmentResponse> PostCoachingAppointmentsAsync (CreateCoachingAppointmentRequest body);

        /// <summary>
        /// Create a new appointment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponse>> PostCoachingAppointmentsAsyncWithHttpInfo (CreateCoachingAppointmentRequest body);
        
        /// <summary>
        /// Retrieve aggregated appointment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of CoachingAppointmentAggregateResponse</returns>
        System.Threading.Tasks.Task<CoachingAppointmentAggregateResponse> PostCoachingAppointmentsAggregatesQueryAsync (CoachingAppointmentAggregateRequest body);

        /// <summary>
        /// Retrieve aggregated appointment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentAggregateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentAggregateResponse>> PostCoachingAppointmentsAggregatesQueryAsyncWithHttpInfo (CoachingAppointmentAggregateRequest body);
        
        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>Task of CoachingSlotsResponse</returns>
        System.Threading.Tasks.Task<CoachingSlotsResponse> PostCoachingScheduleslotsQueryAsync (CoachingSlotsRequest body);

        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>Task of ApiResponse (CoachingSlotsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoachingSlotsResponse>> PostCoachingScheduleslotsQueryAsyncWithHttpInfo (CoachingSlotsRequest body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CoachingApi : ICoachingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoachingApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CoachingApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PureCloudPlatform.Client.V2.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PureCloudPlatform.Client.V2.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <summary>
        /// Delete an existing appointment Permission not required if you are the creator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>CoachingAppointmentReference</returns>
        public CoachingAppointmentReference DeleteCoachingAppointment (string appointmentId)
        {
             ApiResponse<CoachingAppointmentReference> localVarResponse = DeleteCoachingAppointmentWithHttpInfo(appointmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an existing appointment Permission not required if you are the creator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>ApiResponse of CoachingAppointmentReference</returns>
        public ApiResponse< CoachingAppointmentReference > DeleteCoachingAppointmentWithHttpInfo (string appointmentId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->DeleteCoachingAppointment");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentReference>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentReference) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentReference)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete an existing appointment Permission not required if you are the creator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of CoachingAppointmentReference</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentReference> DeleteCoachingAppointmentAsync (string appointmentId)
        {
             ApiResponse<CoachingAppointmentReference> localVarResponse = await DeleteCoachingAppointmentAsyncWithHttpInfo(appointmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an existing appointment Permission not required if you are the creator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentReference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentReference>> DeleteCoachingAppointmentAsyncWithHttpInfo (string appointmentId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->DeleteCoachingAppointment");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentReference>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentReference) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentReference)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete an existing annotation You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns></returns>
        public void DeleteCoachingAppointmentAnnotation (string appointmentId, string annotationId)
        {
             DeleteCoachingAppointmentAnnotationWithHttpInfo(appointmentId, annotationId);
        }

        /// <summary>
        /// Delete an existing annotation You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCoachingAppointmentAnnotationWithHttpInfo (string appointmentId, string annotationId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->DeleteCoachingAppointmentAnnotation");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling CoachingApi->DeleteCoachingAppointmentAnnotation");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointmentAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointmentAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete an existing annotation You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCoachingAppointmentAnnotationAsync (string appointmentId, string annotationId)
        {
             await DeleteCoachingAppointmentAnnotationAsyncWithHttpInfo(appointmentId, annotationId);

        }

        /// <summary>
        /// Delete an existing annotation You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCoachingAppointmentAnnotationAsyncWithHttpInfo (string appointmentId, string annotationId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->DeleteCoachingAppointmentAnnotation");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling CoachingApi->DeleteCoachingAppointmentAnnotation");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointmentAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCoachingAppointmentAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve an appointment Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>CoachingAppointmentResponse</returns>
        public CoachingAppointmentResponse GetCoachingAppointment (string appointmentId)
        {
             ApiResponse<CoachingAppointmentResponse> localVarResponse = GetCoachingAppointmentWithHttpInfo(appointmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve an appointment Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>ApiResponse of CoachingAppointmentResponse</returns>
        public ApiResponse< CoachingAppointmentResponse > GetCoachingAppointmentWithHttpInfo (string appointmentId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointment");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve an appointment Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of CoachingAppointmentResponse</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentResponse> GetCoachingAppointmentAsync (string appointmentId)
        {
             ApiResponse<CoachingAppointmentResponse> localVarResponse = await GetCoachingAppointmentAsyncWithHttpInfo(appointmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve an appointment Permission not required if you are the attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponse>> GetCoachingAppointmentAsyncWithHttpInfo (string appointmentId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointment");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve an annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>CoachingAnnotation</returns>
        public CoachingAnnotation GetCoachingAppointmentAnnotation (string appointmentId, string annotationId)
        {
             ApiResponse<CoachingAnnotation> localVarResponse = GetCoachingAppointmentAnnotationWithHttpInfo(appointmentId, annotationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve an annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>ApiResponse of CoachingAnnotation</returns>
        public ApiResponse< CoachingAnnotation > GetCoachingAppointmentAnnotationWithHttpInfo (string appointmentId, string annotationId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointmentAnnotation");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling CoachingApi->GetCoachingAppointmentAnnotation");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotation>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve an annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of CoachingAnnotation</returns>
        public async System.Threading.Tasks.Task<CoachingAnnotation> GetCoachingAppointmentAnnotationAsync (string appointmentId, string annotationId)
        {
             ApiResponse<CoachingAnnotation> localVarResponse = await GetCoachingAppointmentAnnotationAsyncWithHttpInfo(appointmentId, annotationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve an annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <returns>Task of ApiResponse (CoachingAnnotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAnnotation>> GetCoachingAppointmentAnnotationAsyncWithHttpInfo (string appointmentId, string annotationId)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointmentAnnotation");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling CoachingApi->GetCoachingAppointmentAnnotation");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotation>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of annotations. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>CoachingAnnotationList</returns>
        public CoachingAnnotationList GetCoachingAppointmentAnnotations (string appointmentId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<CoachingAnnotationList> localVarResponse = GetCoachingAppointmentAnnotationsWithHttpInfo(appointmentId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of annotations. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of CoachingAnnotationList</returns>
        public ApiResponse< CoachingAnnotationList > GetCoachingAppointmentAnnotationsWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointmentAnnotations");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotationList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotationList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of annotations. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of CoachingAnnotationList</returns>
        public async System.Threading.Tasks.Task<CoachingAnnotationList> GetCoachingAppointmentAnnotationsAsync (string appointmentId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<CoachingAnnotationList> localVarResponse = await GetCoachingAppointmentAnnotationsAsyncWithHttpInfo(appointmentId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of annotations. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can view private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (CoachingAnnotationList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAnnotationList>> GetCoachingAppointmentAnnotationsAsyncWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointmentAnnotations");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotationList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotationList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the list of status changes for a coaching appointment. Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>CoachingAppointmentStatusResponseList</returns>
        public CoachingAppointmentStatusResponseList GetCoachingAppointmentStatuses (string appointmentId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<CoachingAppointmentStatusResponseList> localVarResponse = GetCoachingAppointmentStatusesWithHttpInfo(appointmentId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of status changes for a coaching appointment. Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of CoachingAppointmentStatusResponseList</returns>
        public ApiResponse< CoachingAppointmentStatusResponseList > GetCoachingAppointmentStatusesWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointmentStatuses");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/statuses";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentStatuses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentStatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentStatusResponseList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentStatusResponseList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentStatusResponseList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the list of status changes for a coaching appointment. Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of CoachingAppointmentStatusResponseList</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentStatusResponseList> GetCoachingAppointmentStatusesAsync (string appointmentId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<CoachingAppointmentStatusResponseList> localVarResponse = await GetCoachingAppointmentStatusesAsyncWithHttpInfo(appointmentId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of status changes for a coaching appointment. Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentStatusResponseList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentStatusResponseList>> GetCoachingAppointmentStatusesAsyncWithHttpInfo (string appointmentId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->GetCoachingAppointmentStatuses");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/statuses";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentStatuses: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentStatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentStatusResponseList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentStatusResponseList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentStatusResponseList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get appointments for users and optional date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>CoachingAppointmentResponseList</returns>
        public CoachingAppointmentResponseList GetCoachingAppointments (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        {
             ApiResponse<CoachingAppointmentResponseList> localVarResponse = GetCoachingAppointmentsWithHttpInfo(userIds, interval, pageNumber, pageSize, statuses, facilitatorIds, sortOrder, relationships, completionInterval, overdue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get appointments for users and optional date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>ApiResponse of CoachingAppointmentResponseList</returns>
        public ApiResponse< CoachingAppointmentResponseList > GetCoachingAppointmentsWithHttpInfo (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        { 
            // verify the required parameter 'userIds' is set
            if (userIds == null)
                throw new ApiException(400, "Missing required parameter 'userIds' when calling CoachingApi->GetCoachingAppointments");

            var localVarPath = "/api/v2/coaching/appointments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (userIds != null) userIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (facilitatorIds != null) facilitatorIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("facilitatorIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (relationships != null) relationships.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationships", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponseList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponseList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponseList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get appointments for users and optional date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of CoachingAppointmentResponseList</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentResponseList> GetCoachingAppointmentsAsync (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        {
             ApiResponse<CoachingAppointmentResponseList> localVarResponse = await GetCoachingAppointmentsAsyncWithHttpInfo(userIds, interval, pageNumber, pageSize, statuses, facilitatorIds, sortOrder, relationships, completionInterval, overdue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get appointments for users and optional date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIds">The user IDs for which to retrieve appointments</param>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponseList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponseList>> GetCoachingAppointmentsAsyncWithHttpInfo (List<string> userIds, string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        { 
            // verify the required parameter 'userIds' is set
            if (userIds == null)
                throw new ApiException(400, "Missing required parameter 'userIds' when calling CoachingApi->GetCoachingAppointments");
            

            var localVarPath = "/api/v2/coaching/appointments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (userIds != null) userIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (facilitatorIds != null) facilitatorIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("facilitatorIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (relationships != null) relationships.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationships", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponseList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponseList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponseList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get my appointments for a given date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>CoachingAppointmentResponseList</returns>
        public CoachingAppointmentResponseList GetCoachingAppointmentsMe (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        {
             ApiResponse<CoachingAppointmentResponseList> localVarResponse = GetCoachingAppointmentsMeWithHttpInfo(interval, pageNumber, pageSize, statuses, facilitatorIds, sortOrder, relationships, completionInterval, overdue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get my appointments for a given date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>ApiResponse of CoachingAppointmentResponseList</returns>
        public ApiResponse< CoachingAppointmentResponseList > GetCoachingAppointmentsMeWithHttpInfo (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        { 

            var localVarPath = "/api/v2/coaching/appointments/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (facilitatorIds != null) facilitatorIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("facilitatorIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (relationships != null) relationships.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationships", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponseList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponseList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponseList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get my appointments for a given date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of CoachingAppointmentResponseList</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentResponseList> GetCoachingAppointmentsMeAsync (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        {
             ApiResponse<CoachingAppointmentResponseList> localVarResponse = await GetCoachingAppointmentsMeAsyncWithHttpInfo(interval, pageNumber, pageSize, statuses, facilitatorIds, sortOrder, relationships, completionInterval, overdue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get my appointments for a given date range 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interval">Interval to filter data by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="statuses">Appointment Statuses to filter by (optional)</param>
        /// <param name="facilitatorIds">The facilitator IDs for which to retrieve appointments (optional)</param>
        /// <param name="sortOrder">Sort (by due date) either Asc or Desc (optional)</param>
        /// <param name="relationships">Relationships to filter by (optional)</param>
        /// <param name="completionInterval">Appointment completion start and end to filter by. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Overdue status to filter by (optional)</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponseList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponseList>> GetCoachingAppointmentsMeAsyncWithHttpInfo (string interval = null, int? pageNumber = null, int? pageSize = null, List<string> statuses = null, List<string> facilitatorIds = null, string sortOrder = null, List<string> relationships = null, string completionInterval = null, string overdue = null)
        { 

            var localVarPath = "/api/v2/coaching/appointments/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (statuses != null) statuses.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("statuses", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (facilitatorIds != null) facilitatorIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("facilitatorIds", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (relationships != null) relationships.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("relationships", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingAppointmentsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponseList>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponseList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponseList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get an existing notification Permission not required if you are the owner of the notification.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>CoachingNotification</returns>
        public CoachingNotification GetCoachingNotification (string notificationId, List<string> expand = null)
        {
             ApiResponse<CoachingNotification> localVarResponse = GetCoachingNotificationWithHttpInfo(notificationId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an existing notification Permission not required if you are the owner of the notification.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>ApiResponse of CoachingNotification</returns>
        public ApiResponse< CoachingNotification > GetCoachingNotificationWithHttpInfo (string notificationId, List<string> expand = null)
        { 
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling CoachingApi->GetCoachingNotification");

            var localVarPath = "/api/v2/coaching/notifications/{notificationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotification: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotification: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingNotification>(localVarStatusCode,
                localVarHeaders,
                (CoachingNotification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingNotification)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get an existing notification Permission not required if you are the owner of the notification.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of CoachingNotification</returns>
        public async System.Threading.Tasks.Task<CoachingNotification> GetCoachingNotificationAsync (string notificationId, List<string> expand = null)
        {
             ApiResponse<CoachingNotification> localVarResponse = await GetCoachingNotificationAsyncWithHttpInfo(notificationId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an existing notification Permission not required if you are the owner of the notification.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of ApiResponse (CoachingNotification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingNotification>> GetCoachingNotificationAsyncWithHttpInfo (string notificationId, List<string> expand = null)
        { 
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling CoachingApi->GetCoachingNotification");
            

            var localVarPath = "/api/v2/coaching/notifications/{notificationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotification: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotification: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingNotification>(localVarStatusCode,
                localVarHeaders,
                (CoachingNotification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingNotification)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve the list of your notifications. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>CoachingNotificationList</returns>
        public CoachingNotificationList GetCoachingNotifications (int? pageNumber = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<CoachingNotificationList> localVarResponse = GetCoachingNotificationsWithHttpInfo(pageNumber, pageSize, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the list of your notifications. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>ApiResponse of CoachingNotificationList</returns>
        public ApiResponse< CoachingNotificationList > GetCoachingNotificationsWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/coaching/notifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotifications: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingNotificationList>(localVarStatusCode,
                localVarHeaders,
                (CoachingNotificationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingNotificationList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve the list of your notifications. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of CoachingNotificationList</returns>
        public async System.Threading.Tasks.Task<CoachingNotificationList> GetCoachingNotificationsAsync (int? pageNumber = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<CoachingNotificationList> localVarResponse = await GetCoachingNotificationsAsyncWithHttpInfo(pageNumber, pageSize, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the list of your notifications. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Indicates a field in the response which should be expanded. (optional)</param>
        /// <returns>Task of ApiResponse (CoachingNotificationList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingNotificationList>> GetCoachingNotificationsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/coaching/notifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotifications: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCoachingNotifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingNotificationList>(localVarStatusCode,
                localVarHeaders,
                (CoachingNotificationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingNotificationList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update an existing appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>CoachingAppointmentResponse</returns>
        public CoachingAppointmentResponse PatchCoachingAppointment (string appointmentId, UpdateCoachingAppointmentRequest body)
        {
             ApiResponse<CoachingAppointmentResponse> localVarResponse = PatchCoachingAppointmentWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>ApiResponse of CoachingAppointmentResponse</returns>
        public ApiResponse< CoachingAppointmentResponse > PatchCoachingAppointmentWithHttpInfo (string appointmentId, UpdateCoachingAppointmentRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PatchCoachingAppointment");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingAppointment");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update an existing appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>Task of CoachingAppointmentResponse</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentResponse> PatchCoachingAppointmentAsync (string appointmentId, UpdateCoachingAppointmentRequest body)
        {
             ApiResponse<CoachingAppointmentResponse> localVarResponse = await PatchCoachingAppointmentAsyncWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The new version of the appointment</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponse>> PatchCoachingAppointmentAsyncWithHttpInfo (string appointmentId, UpdateCoachingAppointmentRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PatchCoachingAppointment");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingAppointment");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update an existing annotation. You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>CoachingAnnotation</returns>
        public CoachingAnnotation PatchCoachingAppointmentAnnotation (string appointmentId, string annotationId, CoachingAnnotation body)
        {
             ApiResponse<CoachingAnnotation> localVarResponse = PatchCoachingAppointmentAnnotationWithHttpInfo(appointmentId, annotationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing annotation. You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>ApiResponse of CoachingAnnotation</returns>
        public ApiResponse< CoachingAnnotation > PatchCoachingAppointmentAnnotationWithHttpInfo (string appointmentId, string annotationId, CoachingAnnotation body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PatchCoachingAppointmentAnnotation");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling CoachingApi->PatchCoachingAppointmentAnnotation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingAppointmentAnnotation");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotation>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update an existing annotation. You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>Task of CoachingAnnotation</returns>
        public async System.Threading.Tasks.Task<CoachingAnnotation> PatchCoachingAppointmentAnnotationAsync (string appointmentId, string annotationId, CoachingAnnotation body)
        {
             ApiResponse<CoachingAnnotation> localVarResponse = await PatchCoachingAppointmentAnnotationAsyncWithHttpInfo(appointmentId, annotationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing annotation. You must have the appropriate permission for the type of annotation you are updating. Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="annotationId">The ID of the annotation.</param>
        /// <param name="body">The new version of the annotation</param>
        /// <returns>Task of ApiResponse (CoachingAnnotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAnnotation>> PatchCoachingAppointmentAnnotationAsyncWithHttpInfo (string appointmentId, string annotationId, CoachingAnnotation body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PatchCoachingAppointmentAnnotation");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling CoachingApi->PatchCoachingAppointmentAnnotation");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingAppointmentAnnotation");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations/{annotationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));
            if (annotationId != null) localVarPathParams.Add("annotationId", this.Configuration.ApiClient.ParameterToString(annotationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentAnnotation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentAnnotation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotation>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update the status of a coaching appointment Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>CoachingAppointmentStatusResponse</returns>
        public CoachingAppointmentStatusResponse PatchCoachingAppointmentStatus (string appointmentId, CoachingAppointmentStatusRequest body)
        {
             ApiResponse<CoachingAppointmentStatusResponse> localVarResponse = PatchCoachingAppointmentStatusWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the status of a coaching appointment Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>ApiResponse of CoachingAppointmentStatusResponse</returns>
        public ApiResponse< CoachingAppointmentStatusResponse > PatchCoachingAppointmentStatusWithHttpInfo (string appointmentId, CoachingAppointmentStatusRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PatchCoachingAppointmentStatus");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingAppointmentStatus");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update the status of a coaching appointment Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>Task of CoachingAppointmentStatusResponse</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentStatusResponse> PatchCoachingAppointmentStatusAsync (string appointmentId, CoachingAppointmentStatusRequest body)
        {
             ApiResponse<CoachingAppointmentStatusResponse> localVarResponse = await PatchCoachingAppointmentStatusAsyncWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the status of a coaching appointment Permission not required if you are an attendee, creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">Updated status of the coaching appointment</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentStatusResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentStatusResponse>> PatchCoachingAppointmentStatusAsyncWithHttpInfo (string appointmentId, CoachingAppointmentStatusRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PatchCoachingAppointmentStatus");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingAppointmentStatus");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingAppointmentStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update an existing notification. Can only update your own notifications.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>CoachingNotification</returns>
        public CoachingNotification PatchCoachingNotification (string notificationId, CoachingNotification body)
        {
             ApiResponse<CoachingNotification> localVarResponse = PatchCoachingNotificationWithHttpInfo(notificationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing notification. Can only update your own notifications.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>ApiResponse of CoachingNotification</returns>
        public ApiResponse< CoachingNotification > PatchCoachingNotificationWithHttpInfo (string notificationId, CoachingNotification body)
        { 
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling CoachingApi->PatchCoachingNotification");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingNotification");

            var localVarPath = "/api/v2/coaching/notifications/{notificationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingNotification: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingNotification: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingNotification>(localVarStatusCode,
                localVarHeaders,
                (CoachingNotification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingNotification)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update an existing notification. Can only update your own notifications.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>Task of CoachingNotification</returns>
        public async System.Threading.Tasks.Task<CoachingNotification> PatchCoachingNotificationAsync (string notificationId, CoachingNotification body)
        {
             ApiResponse<CoachingNotification> localVarResponse = await PatchCoachingNotificationAsyncWithHttpInfo(notificationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing notification. Can only update your own notifications.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId">The ID of the notification.</param>
        /// <param name="body">Change the read state of a notification</param>
        /// <returns>Task of ApiResponse (CoachingNotification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingNotification>> PatchCoachingNotificationAsyncWithHttpInfo (string notificationId, CoachingNotification body)
        { 
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling CoachingApi->PatchCoachingNotification");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PatchCoachingNotification");
            

            var localVarPath = "/api/v2/coaching/notifications/{notificationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingNotification: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCoachingNotification: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingNotification>(localVarStatusCode,
                localVarHeaders,
                (CoachingNotification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingNotification)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>CoachingAnnotation</returns>
        public CoachingAnnotation PostCoachingAppointmentAnnotations (string appointmentId, CoachingAnnotationCreateRequest body)
        {
             ApiResponse<CoachingAnnotation> localVarResponse = PostCoachingAppointmentAnnotationsWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>ApiResponse of CoachingAnnotation</returns>
        public ApiResponse< CoachingAnnotation > PostCoachingAppointmentAnnotationsWithHttpInfo (string appointmentId, CoachingAnnotationCreateRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PostCoachingAppointmentAnnotations");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointmentAnnotations");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotation>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>Task of CoachingAnnotation</returns>
        public async System.Threading.Tasks.Task<CoachingAnnotation> PostCoachingAppointmentAnnotationsAsync (string appointmentId, CoachingAnnotationCreateRequest body)
        {
             ApiResponse<CoachingAnnotation> localVarResponse = await PostCoachingAppointmentAnnotationsAsyncWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new annotation. You must have the appropriate permission for the type of annotation you are creating. Permission not required if you are related to the appointment (only the creator or facilitator can create private annotations).
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">The annotation to add</param>
        /// <returns>Task of ApiResponse (CoachingAnnotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAnnotation>> PostCoachingAppointmentAnnotationsAsyncWithHttpInfo (string appointmentId, CoachingAnnotationCreateRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PostCoachingAppointmentAnnotations");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointmentAnnotations");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/annotations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentAnnotations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAnnotation>(localVarStatusCode,
                localVarHeaders,
                (CoachingAnnotation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAnnotation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Add a conversation to an appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>AddConversationResponse</returns>
        public AddConversationResponse PostCoachingAppointmentConversations (string appointmentId, AddConversationRequest body)
        {
             ApiResponse<AddConversationResponse> localVarResponse = PostCoachingAppointmentConversationsWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a conversation to an appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of AddConversationResponse</returns>
        public ApiResponse< AddConversationResponse > PostCoachingAppointmentConversationsWithHttpInfo (string appointmentId, AddConversationRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PostCoachingAppointmentConversations");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointmentConversations");

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AddConversationResponse>(localVarStatusCode,
                localVarHeaders,
                (AddConversationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddConversationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Add a conversation to an appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>Task of AddConversationResponse</returns>
        public async System.Threading.Tasks.Task<AddConversationResponse> PostCoachingAppointmentConversationsAsync (string appointmentId, AddConversationRequest body)
        {
             ApiResponse<AddConversationResponse> localVarResponse = await PostCoachingAppointmentConversationsAsyncWithHttpInfo(appointmentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a conversation to an appointment Permission not required if you are the creator or facilitator of the appointment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appointmentId">The ID of the coaching appointment.</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (AddConversationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddConversationResponse>> PostCoachingAppointmentConversationsAsyncWithHttpInfo (string appointmentId, AddConversationRequest body)
        { 
            // verify the required parameter 'appointmentId' is set
            if (appointmentId == null)
                throw new ApiException(400, "Missing required parameter 'appointmentId' when calling CoachingApi->PostCoachingAppointmentConversations");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointmentConversations");
            

            var localVarPath = "/api/v2/coaching/appointments/{appointmentId}/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (appointmentId != null) localVarPathParams.Add("appointmentId", this.Configuration.ApiClient.ParameterToString(appointmentId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AddConversationResponse>(localVarStatusCode,
                localVarHeaders,
                (AddConversationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddConversationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new appointment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>CoachingAppointmentResponse</returns>
        public CoachingAppointmentResponse PostCoachingAppointments (CreateCoachingAppointmentRequest body)
        {
             ApiResponse<CoachingAppointmentResponse> localVarResponse = PostCoachingAppointmentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new appointment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>ApiResponse of CoachingAppointmentResponse</returns>
        public ApiResponse< CoachingAppointmentResponse > PostCoachingAppointmentsWithHttpInfo (CreateCoachingAppointmentRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointments");

            var localVarPath = "/api/v2/coaching/appointments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new appointment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>Task of CoachingAppointmentResponse</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentResponse> PostCoachingAppointmentsAsync (CreateCoachingAppointmentRequest body)
        {
             ApiResponse<CoachingAppointmentResponse> localVarResponse = await PostCoachingAppointmentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new appointment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The appointment to add</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentResponse>> PostCoachingAppointmentsAsyncWithHttpInfo (CreateCoachingAppointmentRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointments");
            

            var localVarPath = "/api/v2/coaching/appointments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve aggregated appointment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>CoachingAppointmentAggregateResponse</returns>
        public CoachingAppointmentAggregateResponse PostCoachingAppointmentsAggregatesQuery (CoachingAppointmentAggregateRequest body)
        {
             ApiResponse<CoachingAppointmentAggregateResponse> localVarResponse = PostCoachingAppointmentsAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve aggregated appointment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>ApiResponse of CoachingAppointmentAggregateResponse</returns>
        public ApiResponse< CoachingAppointmentAggregateResponse > PostCoachingAppointmentsAggregatesQueryWithHttpInfo (CoachingAppointmentAggregateRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointmentsAggregatesQuery");

            var localVarPath = "/api/v2/coaching/appointments/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentAggregateResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentAggregateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentAggregateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve aggregated appointment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of CoachingAppointmentAggregateResponse</returns>
        public async System.Threading.Tasks.Task<CoachingAppointmentAggregateResponse> PostCoachingAppointmentsAggregatesQueryAsync (CoachingAppointmentAggregateRequest body)
        {
             ApiResponse<CoachingAppointmentAggregateResponse> localVarResponse = await PostCoachingAppointmentsAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve aggregated appointment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of ApiResponse (CoachingAppointmentAggregateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingAppointmentAggregateResponse>> PostCoachingAppointmentsAggregatesQueryAsyncWithHttpInfo (CoachingAppointmentAggregateRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingAppointmentsAggregatesQuery");
            

            var localVarPath = "/api/v2/coaching/appointments/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingAppointmentsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingAppointmentAggregateResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingAppointmentAggregateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingAppointmentAggregateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>CoachingSlotsResponse</returns>
        public CoachingSlotsResponse PostCoachingScheduleslotsQuery (CoachingSlotsRequest body)
        {
             ApiResponse<CoachingSlotsResponse> localVarResponse = PostCoachingScheduleslotsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>ApiResponse of CoachingSlotsResponse</returns>
        public ApiResponse< CoachingSlotsResponse > PostCoachingScheduleslotsQueryWithHttpInfo (CoachingSlotsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingScheduleslotsQuery");

            var localVarPath = "/api/v2/coaching/scheduleslots/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingScheduleslotsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingScheduleslotsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingSlotsResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingSlotsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingSlotsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>Task of CoachingSlotsResponse</returns>
        public async System.Threading.Tasks.Task<CoachingSlotsResponse> PostCoachingScheduleslotsQueryAsync (CoachingSlotsRequest body)
        {
             ApiResponse<CoachingSlotsResponse> localVarResponse = await PostCoachingScheduleslotsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of possible slots where a coaching appointment can be scheduled. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The slot search request</param>
        /// <returns>Task of ApiResponse (CoachingSlotsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CoachingSlotsResponse>> PostCoachingScheduleslotsQueryAsyncWithHttpInfo (CoachingSlotsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CoachingApi->PostCoachingScheduleslotsQuery");
            

            var localVarPath = "/api/v2/coaching/scheduleslots/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingScheduleslotsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCoachingScheduleslotsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CoachingSlotsResponse>(localVarStatusCode,
                localVarHeaders,
                (CoachingSlotsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoachingSlotsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
