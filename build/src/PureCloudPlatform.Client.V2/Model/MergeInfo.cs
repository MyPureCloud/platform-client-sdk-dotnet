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
    /// MergeInfo
    /// </summary>
    [DataContract]
    public partial class MergeInfo :  IEquatable<MergeInfo>
    {
        /// <summary>
        /// The status of a merge operation being taken against a cluster
        /// </summary>
        /// <value>The status of a merge operation being taken against a cluster</value>
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
            /// Enum Autoqueued for "AutoQueued"
            /// </summary>
            [EnumMember(Value = "AutoQueued")]
            Autoqueued,
            
            /// <summary>
            /// Enum Autosucceeded for "AutoSucceeded"
            /// </summary>
            [EnumMember(Value = "AutoSucceeded")]
            Autosucceeded,
            
            /// <summary>
            /// Enum Autofailed for "AutoFailed"
            /// </summary>
            [EnumMember(Value = "AutoFailed")]
            Autofailed,
            
            /// <summary>
            /// Enum Manualqueued for "ManualQueued"
            /// </summary>
            [EnumMember(Value = "ManualQueued")]
            Manualqueued,
            
            /// <summary>
            /// Enum Manualsucceeded for "ManualSucceeded"
            /// </summary>
            [EnumMember(Value = "ManualSucceeded")]
            Manualsucceeded,
            
            /// <summary>
            /// Enum Manualfailed for "ManualFailed"
            /// </summary>
            [EnumMember(Value = "ManualFailed")]
            Manualfailed,
            
            /// <summary>
            /// Enum Notmerged for "NotMerged"
            /// </summary>
            [EnumMember(Value = "NotMerged")]
            Notmerged
        }
        /// <summary>
        /// The status of a merge operation being taken against a cluster
        /// </summary>
        /// <value>The status of a merge operation being taken against a cluster</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeInfo" /> class.
        /// </summary>
        public MergeInfo()
        {
            
        }
        




        /// <summary>
        /// Error details about a failed merge. Only present if the status of the merge is ManualFailed or AutoFailed
        /// </summary>
        /// <value>Error details about a failed merge. Only present if the status of the merge is ManualFailed or AutoFailed</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public MergeError Error { get; private set; }



        /// <summary>
        /// The date the merge was attempted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the merge was attempted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateMerged", EmitDefaultValue=false)]
        public DateTime? DateMerged { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeInfo {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  DateMerged: ").Append(DateMerged).Append("\n");
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
            return this.Equals(obj as MergeInfo);
        }

        /// <summary>
        /// Returns true if MergeInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MergeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.DateMerged == other.DateMerged ||
                    this.DateMerged != null &&
                    this.DateMerged.Equals(other.DateMerged)
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

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.DateMerged != null)
                    hash = hash * 59 + this.DateMerged.GetHashCode();

                return hash;
            }
        }
    }

}
