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
    /// LogCaptureUserConfiguration
    /// </summary>
    [DataContract]
    public partial class LogCaptureUserConfiguration :  IEquatable<LogCaptureUserConfiguration>
    {
        /// <summary>
        /// Indicates the method by which the logs were captured.
        /// </summary>
        /// <value>Indicates the method by which the logs were captured.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CaptureMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ondemand for "OnDemand"
            /// </summary>
            [EnumMember(Value = "OnDemand")]
            Ondemand,
            
            /// <summary>
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled
        }
        /// <summary>
        /// Indicates the method by which the logs were captured.
        /// </summary>
        /// <value>Indicates the method by which the logs were captured.</value>
        [DataMember(Name="captureMethod", EmitDefaultValue=false)]
        public CaptureMethodEnum? CaptureMethod { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogCaptureUserConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogCaptureUserConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogCaptureUserConfiguration" /> class.
        /// </summary>
        /// <param name="DateExpired">Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public LogCaptureUserConfiguration(DateTime? DateExpired = null)
        {
            this.DateExpired = DateExpired;
            
        }
        


        /// <summary>
        /// The ID of the user for which log capture is configured.
        /// </summary>
        /// <value>The ID of the user for which log capture is configured.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStarted", EmitDefaultValue=false)]
        public DateTime? DateStarted { get; private set; }



        /// <summary>
        /// Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpired", EmitDefaultValue=false)]
        public DateTime? DateExpired { get; set; }





        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogCaptureUserConfiguration {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
            sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
            sb.Append("  CaptureMethod: ").Append(CaptureMethod).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as LogCaptureUserConfiguration);
        }

        /// <summary>
        /// Returns true if LogCaptureUserConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of LogCaptureUserConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogCaptureUserConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.DateStarted == other.DateStarted ||
                    this.DateStarted != null &&
                    this.DateStarted.Equals(other.DateStarted)
                ) &&
                (
                    this.DateExpired == other.DateExpired ||
                    this.DateExpired != null &&
                    this.DateExpired.Equals(other.DateExpired)
                ) &&
                (
                    this.CaptureMethod == other.CaptureMethod ||
                    this.CaptureMethod != null &&
                    this.CaptureMethod.Equals(other.CaptureMethod)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.DateStarted != null)
                    hash = hash * 59 + this.DateStarted.GetHashCode();

                if (this.DateExpired != null)
                    hash = hash * 59 + this.DateExpired.GetHashCode();

                if (this.CaptureMethod != null)
                    hash = hash * 59 + this.CaptureMethod.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
