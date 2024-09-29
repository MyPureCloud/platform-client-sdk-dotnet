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
    /// GraphApiSettings
    /// </summary>
    [DataContract]
    public partial class GraphApiSettings :  IEquatable<GraphApiSettings>
    {
        /// <summary>
        /// Graph API Server Status
        /// </summary>
        /// <value>Graph API Server Status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Integrationdeleted for "IntegrationDeleted"
            /// </summary>
            [EnumMember(Value = "IntegrationDeleted")]
            Integrationdeleted,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Graph API Server Status
        /// </summary>
        /// <value>Graph API Server Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphApiSettings" /> class.
        /// </summary>
        /// <param name="Integration">The Graph API server integration to use for emails..</param>
        public GraphApiSettings(DomainEntityRef Integration = null)
        {
            this.Integration = Integration;
            
        }
        


        /// <summary>
        /// The Graph API server integration to use for emails.
        /// </summary>
        /// <value>The Graph API server integration to use for emails.</value>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public DomainEntityRef Integration { get; set; }





        /// <summary>
        /// Additional Graph API Server error information
        /// </summary>
        /// <value>Additional Graph API Server error information</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public EmailErrorInfo ErrorInfo { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GraphApiSettings {\n");

            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
            return this.Equals(obj as GraphApiSettings);
        }

        /// <summary>
        /// Returns true if GraphApiSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of GraphApiSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GraphApiSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Integration == other.Integration ||
                    this.Integration != null &&
                    this.Integration.Equals(other.Integration)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
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
                if (this.Integration != null)
                    hash = hash * 59 + this.Integration.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                return hash;
            }
        }
    }

}
