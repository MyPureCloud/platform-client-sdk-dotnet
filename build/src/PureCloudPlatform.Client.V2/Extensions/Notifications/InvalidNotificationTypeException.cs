using System;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    ///<Summary>
    /// InvalidNotificationTypeException Exception
    ///</Summary>
    public class InvalidNotificationTypeException : Exception
    {
        ///<Summary>
        /// Message
        ///</Summary>
        public override string Message { get; }

        private InvalidNotificationTypeException()
        {
        }

        ///<Summary>
        /// InvalidNotificationTypeException constructor (from Type)
        ///</Summary>
        public InvalidNotificationTypeException(Type type)
        {
            Message = $"Invalid notification type: {type}. Notification type must implement INotificationData";
        }
    }
}