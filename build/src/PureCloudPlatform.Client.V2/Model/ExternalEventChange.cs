using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// A change in an external event definition
    /// </summary>
    [DataContract]
    public partial class ExternalEventChange :  IEquatable<ExternalEventChange>
    {
        /// <summary>
        /// The category of the change
        /// </summary>
        /// <value>The category of the change</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ChangeCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Updated for "Updated"
            /// </summary>
            [EnumMember(Value = "Updated")]
            Updated,
            
            /// <summary>
            /// Enum New for "New"
            /// </summary>
            [EnumMember(Value = "New")]
            New
        }
        /// <summary>
        /// The status of the change
        /// </summary>
        /// <value>The status of the change</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum New for "New"
            /// </summary>
            [EnumMember(Value = "New")]
            New,
            
            /// <summary>
            /// Enum Updated for "Updated"
            /// </summary>
            [EnumMember(Value = "Updated")]
            Updated,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// The category of the change
        /// </summary>
        /// <value>The category of the change</value>
        [DataMember(Name="changeCategory", EmitDefaultValue=false)]
        public ChangeCategoryEnum? ChangeCategory { get; private set; }
        /// <summary>
        /// The status of the change
        /// </summary>
        /// <value>The status of the change</value>
        [DataMember(Name="systemStatus", EmitDefaultValue=false)]
        public SystemStatusEnum? SystemStatus { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventChange" /> class.
        /// </summary>
        public ExternalEventChange()
        {
            
        }
        




        /// <summary>
        /// The unique identifier for the schema
        /// </summary>
        /// <value>The unique identifier for the schema</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public string SchemaId { get; private set; }



        /// <summary>
        /// The name of the event
        /// </summary>
        /// <value>The name of the event</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; private set; }



        /// <summary>
        /// The timestamp when the change was detected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when the change was detected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDetected", EmitDefaultValue=false)]
        public DateTime? DateDetected { get; private set; }





        /// <summary>
        /// A code representing the error, only present for ERROR category changes
        /// </summary>
        /// <value>A code representing the error, only present for ERROR category changes</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; private set; }



        /// <summary>
        /// A description of the error, only present for ERROR category changes
        /// </summary>
        /// <value>A description of the error, only present for ERROR category changes</value>
        [DataMember(Name="errorDescription", EmitDefaultValue=false)]
        public string ErrorDescription { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalEventChange {\n");

            sb.Append("  ChangeCategory: ").Append(ChangeCategory).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  DateDetected: ").Append(DateDetected).Append("\n");
            sb.Append("  SystemStatus: ").Append(SystemStatus).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ExternalEventChange);
        }

        /// <summary>
        /// Returns true if ExternalEventChange instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalEventChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalEventChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChangeCategory == other.ChangeCategory ||
                    this.ChangeCategory != null &&
                    this.ChangeCategory.Equals(other.ChangeCategory)
                ) &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) &&
                (
                    this.DateDetected == other.DateDetected ||
                    this.DateDetected != null &&
                    this.DateDetected.Equals(other.DateDetected)
                ) &&
                (
                    this.SystemStatus == other.SystemStatus ||
                    this.SystemStatus != null &&
                    this.SystemStatus.Equals(other.SystemStatus)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorDescription == other.ErrorDescription ||
                    this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(other.ErrorDescription)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ChangeCategory != null)
                    hash = hash * 59 + this.ChangeCategory.GetHashCode();

                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();

                if (this.DateDetected != null)
                    hash = hash * 59 + this.DateDetected.GetHashCode();

                if (this.SystemStatus != null)
                    hash = hash * 59 + this.SystemStatus.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.ErrorDescription != null)
                    hash = hash * 59 + this.ErrorDescription.GetHashCode();

                return hash;
            }
        }
    }

}
