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
    /// TaskManagementObservationPredicate
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationPredicate :  IEquatable<TaskManagementObservationPredicate>
    {
        /// <summary>
        /// The dimension to filter on
        /// </summary>
        /// <value>The dimension to filter on</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Typeid for "typeId"
            /// </summary>
            [EnumMember(Value = "typeId")]
            Typeid
        }
        /// <summary>
        /// The dimension to filter on
        /// </summary>
        /// <value>The dimension to filter on</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum? Dimension { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationPredicate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskManagementObservationPredicate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationPredicate" /> class.
        /// </summary>
        /// <param name="Dimension">The dimension to filter on (required).</param>
        /// <param name="Value">The value to filter by for the specified dimension (required).</param>
        public TaskManagementObservationPredicate(DimensionEnum? Dimension = null, string Value = null)
        {
            this.Dimension = Dimension;
            this.Value = Value;
            
        }
        




        /// <summary>
        /// The value to filter by for the specified dimension
        /// </summary>
        /// <value>The value to filter by for the specified dimension</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationPredicate {\n");

            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationPredicate);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
