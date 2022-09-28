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
    /// PredictorModelFeature
    /// </summary>
    [DataContract]
    public partial class PredictorModelFeature :  IEquatable<PredictorModelFeature>
    {
        /// <summary>
        /// The type of feature.
        /// </summary>
        /// <value>The type of feature.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer,
            
            /// <summary>
            /// Enum Other for "Other"
            /// </summary>
            [EnumMember(Value = "Other")]
            Other
        }
        /// <summary>
        /// The type of feature.
        /// </summary>
        /// <value>The type of feature.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictorModelFeature" /> class.
        /// </summary>
        public PredictorModelFeature()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The percentage of how important a feature is in the model.
        /// </summary>
        /// <value>The percentage of how important a feature is in the model.</value>
        [DataMember(Name="percentageImportance", EmitDefaultValue=false)]
        public double? PercentageImportance { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredictorModelFeature {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PercentageImportance: ").Append(PercentageImportance).Append("\n");
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
            return this.Equals(obj as PredictorModelFeature);
        }

        /// <summary>
        /// Returns true if PredictorModelFeature instances are equal
        /// </summary>
        /// <param name="other">Instance of PredictorModelFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictorModelFeature other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.PercentageImportance == other.PercentageImportance ||
                    this.PercentageImportance != null &&
                    this.PercentageImportance.Equals(other.PercentageImportance)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.PercentageImportance != null)
                    hash = hash * 59 + this.PercentageImportance.GetHashCode();

                return hash;
            }
        }
    }

}
