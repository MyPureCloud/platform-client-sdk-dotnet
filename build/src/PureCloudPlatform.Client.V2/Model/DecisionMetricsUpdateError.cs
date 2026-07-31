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
    /// DecisionMetricsUpdateError
    /// </summary>
    [DataContract]
    public partial class DecisionMetricsUpdateError :  IEquatable<DecisionMetricsUpdateError>
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
        /// Initializes a new instance of the <see cref="DecisionMetricsUpdateError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionMetricsUpdateError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsUpdateError" /> class.
        /// </summary>
        /// <param name="User">The user for the decision metrics row where errors were found (required).</param>
        /// <param name="Errors">Errors found during the update process (required).</param>
        public DecisionMetricsUpdateError(UserReference User = null, List<ErrorsEnum> Errors = null)
        {
            this.User = User;
            this.Errors = Errors;
            
        }
        


        /// <summary>
        /// The user for the decision metrics row where errors were found
        /// </summary>
        /// <value>The user for the decision metrics row where errors were found</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// Errors found during the update process
        /// </summary>
        /// <value>Errors found during the update process</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ErrorsEnum> Errors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionMetricsUpdateError {\n");

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
            return this.Equals(obj as DecisionMetricsUpdateError);
        }

        /// <summary>
        /// Returns true if DecisionMetricsUpdateError instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionMetricsUpdateError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionMetricsUpdateError other)
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
