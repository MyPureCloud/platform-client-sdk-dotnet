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
    /// UnifiedGeneralTopic
    /// </summary>
    [DataContract]
    public partial class UnifiedGeneralTopic :  IEquatable<UnifiedGeneralTopic>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
            /// Enum Deprecated for "Deprecated"
            /// </summary>
            [EnumMember(Value = "Deprecated")]
            Deprecated,
            
            /// <summary>
            /// Enum Outdated for "Outdated"
            /// </summary>
            [EnumMember(Value = "Outdated")]
            Outdated,
            
            /// <summary>
            /// Enum Modified for "Modified"
            /// </summary>
            [EnumMember(Value = "Modified")]
            Modified,
            
            /// <summary>
            /// Enum Uptodate for "UpToDate"
            /// </summary>
            [EnumMember(Value = "UpToDate")]
            Uptodate,
            
            /// <summary>
            /// Enum Tobecreated for "ToBeCreated"
            /// </summary>
            [EnumMember(Value = "ToBeCreated")]
            Tobecreated,
            
            /// <summary>
            /// Enum Createdbyuser for "CreatedByUser"
            /// </summary>
            [EnumMember(Value = "CreatedByUser")]
            Createdbyuser
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedGeneralTopic" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Status">Status.</param>
        public UnifiedGeneralTopic(string Name = null, StatusEnum? Status = null)
        {
            this.Name = Name;
            this.Status = Status;
            
        }
        


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedGeneralTopic {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as UnifiedGeneralTopic);
        }

        /// <summary>
        /// Returns true if UnifiedGeneralTopic instances are equal
        /// </summary>
        /// <param name="other">Instance of UnifiedGeneralTopic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedGeneralTopic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
