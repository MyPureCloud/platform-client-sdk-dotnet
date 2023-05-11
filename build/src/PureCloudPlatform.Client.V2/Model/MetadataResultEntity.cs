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
    /// A Genesys Cloud resource created or modified as a result of running an accelerator
    /// </summary>
    [DataContract]
    public partial class MetadataResultEntity :  IEquatable<MetadataResultEntity>
    {
        /// <summary>
        /// whether the modified resource is visible or hidden
        /// </summary>
        /// <value>whether the modified resource is visible or hidden</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Visible for "Visible"
            /// </summary>
            [EnumMember(Value = "Visible")]
            Visible,
            
            /// <summary>
            /// Enum Hidden for "Hidden"
            /// </summary>
            [EnumMember(Value = "Hidden")]
            Hidden
        }
        /// <summary>
        /// whether the modified resource is visible or hidden
        /// </summary>
        /// <value>whether the modified resource is visible or hidden</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityEnum? Visibility { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResultEntity" /> class.
        /// </summary>
        public MetadataResultEntity()
        {
            
        }
        


        /// <summary>
        /// object type of the modified resource
        /// </summary>
        /// <value>object type of the modified resource</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }



        /// <summary>
        /// description of the modified resource
        /// </summary>
        /// <value>description of the modified resource</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataResultEntity {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(obj as MetadataResultEntity);
        }

        /// <summary>
        /// Returns true if MetadataResultEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of MetadataResultEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataResultEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Visibility == other.Visibility ||
                    this.Visibility != null &&
                    this.Visibility.Equals(other.Visibility)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Visibility != null)
                    hash = hash * 59 + this.Visibility.GetHashCode();

                return hash;
            }
        }
    }

}
