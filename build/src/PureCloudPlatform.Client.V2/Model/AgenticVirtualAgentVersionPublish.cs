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
    /// AgenticVirtualAgentVersionPublish
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentVersionPublish :  IEquatable<AgenticVirtualAgentVersionPublish>
    {
        /// <summary>
        /// The status of the virtual agent version to update as part of this publish job.
        /// </summary>
        /// <value>The status of the virtual agent version to update as part of this publish job.</value>
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
            /// Enum Testready for "TestReady"
            /// </summary>
            [EnumMember(Value = "TestReady")]
            Testready,
            
            /// <summary>
            /// Enum Productionready for "ProductionReady"
            /// </summary>
            [EnumMember(Value = "ProductionReady")]
            Productionready
        }
        /// <summary>
        /// The status of the virtual agent version to update as part of this publish job.
        /// </summary>
        /// <value>The status of the virtual agent version to update as part of this publish job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentVersionPublish" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentVersionPublish() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentVersionPublish" /> class.
        /// </summary>
        /// <param name="Status">The status of the virtual agent version to update as part of this publish job. (required).</param>
        public AgenticVirtualAgentVersionPublish(StatusEnum? Status = null)
        {
            this.Status = Status;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentVersionPublish {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentVersionPublish);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentVersionPublish instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentVersionPublish to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentVersionPublish other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
