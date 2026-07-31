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
    /// DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError
    /// </summary>
    [DataContract]
    public partial class DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError :  IEquatable<DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError>
    {
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ErrorsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Invaliduser for "InvalidUser"
            /// </summary>
            [EnumMember(Value = "InvalidUser")]
            Invaliduser,
            
            /// <summary>
            /// Enum Invalidperformancerank for "InvalidPerformanceRank"
            /// </summary>
            [EnumMember(Value = "InvalidPerformanceRank")]
            Invalidperformancerank,
            
            /// <summary>
            /// Enum Invalidtiebreaker for "InvalidTieBreaker"
            /// </summary>
            [EnumMember(Value = "InvalidTieBreaker")]
            Invalidtiebreaker
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Errors">Errors.</param>
        public DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError(DecisionMetricsAdminNotificationTopicAddressableEntityRef User = null, List<ErrorsEnum> Errors = null)
        {
            this.User = User;
            this.Errors = Errors;
            
        }
        


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DecisionMetricsAdminNotificationTopicAddressableEntityRef User { get; set; }



        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ErrorsEnum> Errors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError);
        }

        /// <summary>
        /// Returns true if DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                return hash;
            }
        }
    }

}
