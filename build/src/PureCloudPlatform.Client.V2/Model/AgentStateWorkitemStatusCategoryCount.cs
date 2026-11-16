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
    /// AgentStateWorkitemStatusCategoryCount
    /// </summary>
    [DataContract]
    public partial class AgentStateWorkitemStatusCategoryCount :  IEquatable<AgentStateWorkitemStatusCategoryCount>
    {
        /// <summary>
        /// Workitem status category
        /// </summary>
        /// <value>Workitem status category</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Waiting for "Waiting"
            /// </summary>
            [EnumMember(Value = "Waiting")]
            Waiting,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Workitem status category
        /// </summary>
        /// <value>Workitem status category</value>
        [DataMember(Name="statusCategory", EmitDefaultValue=false)]
        public StatusCategoryEnum? StatusCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStateWorkitemStatusCategoryCount" /> class.
        /// </summary>
        /// <param name="StatusCategory">Workitem status category.</param>
        /// <param name="Count">Count of workitems with this status category.</param>
        public AgentStateWorkitemStatusCategoryCount(StatusCategoryEnum? StatusCategory = null, int? Count = null)
        {
            this.StatusCategory = StatusCategory;
            this.Count = Count;
            
        }
        




        /// <summary>
        /// Count of workitems with this status category
        /// </summary>
        /// <value>Count of workitems with this status category</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStateWorkitemStatusCategoryCount {\n");

            sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as AgentStateWorkitemStatusCategoryCount);
        }

        /// <summary>
        /// Returns true if AgentStateWorkitemStatusCategoryCount instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentStateWorkitemStatusCategoryCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStateWorkitemStatusCategoryCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StatusCategory == other.StatusCategory ||
                    this.StatusCategory != null &&
                    this.StatusCategory.Equals(other.StatusCategory)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.StatusCategory != null)
                    hash = hash * 59 + this.StatusCategory.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
