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
    /// ArchiveRetention
    /// </summary>
    [DataContract]
    public partial class ArchiveRetention :  IEquatable<ArchiveRetention>
    {
        /// <summary>
        /// Gets or Sets StorageMedium
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StorageMediumEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Cloudarchive for "CLOUDARCHIVE"
            /// </summary>
            [EnumMember(Value = "CLOUDARCHIVE")]
            Cloudarchive
        }
        /// <summary>
        /// Gets or Sets StorageMedium
        /// </summary>
        [DataMember(Name="storageMedium", EmitDefaultValue=false)]
        public StorageMediumEnum? StorageMedium { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveRetention" /> class.
        /// </summary>
        /// <param name="Days">Days.</param>
        /// <param name="StorageMedium">StorageMedium.</param>
        public ArchiveRetention(int? Days = null, StorageMediumEnum? StorageMedium = null)
        {
            this.Days = Days;
            this.StorageMedium = StorageMedium;
        }
        
        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public int? Days { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveRetention {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  StorageMedium: ").Append(StorageMedium).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ArchiveRetention);
        }

        /// <summary>
        /// Returns true if ArchiveRetention instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchiveRetention to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveRetention other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Days == other.Days ||
                    this.Days != null &&
                    this.Days.Equals(other.Days)
                ) &&
                (
                    this.StorageMedium == other.StorageMedium ||
                    this.StorageMedium != null &&
                    this.StorageMedium.Equals(other.StorageMedium)
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
                if (this.Days != null)
                    hash = hash * 59 + this.Days.GetHashCode();
                if (this.StorageMedium != null)
                    hash = hash * 59 + this.StorageMedium.GetHashCode();
                return hash;
            }
        }
    }

}
