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
    /// SegmentAssignedEventSegment
    /// </summary>
    [DataContract]
    public partial class SegmentAssignedEventSegment :  IEquatable<SegmentAssignedEventSegment>
    {
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Session for "Session"
            /// </summary>
            [EnumMember(Value = "Session")]
            Session,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer
        }
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentAssignedEventSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SegmentAssignedEventSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentAssignedEventSegment" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="DisplayName">The display name of the segment. (required).</param>
        /// <param name="Version">The version of the segment..</param>
        /// <param name="Scope">The target entity that a segment applies to..</param>
        public SegmentAssignedEventSegment(string Id = null, string SelfUri = null, string DisplayName = null, int? Version = null, ScopeEnum? Scope = null)
        {
            this.Id = Id;
            this.SelfUri = SelfUri;
            this.DisplayName = DisplayName;
            this.Version = Version;
            this.Scope = Scope;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// The display name of the segment.
        /// </summary>
        /// <value>The display name of the segment.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }



        /// <summary>
        /// The version of the segment.
        /// </summary>
        /// <value>The version of the segment.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentAssignedEventSegment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(obj as SegmentAssignedEventSegment);
        }

        /// <summary>
        /// Returns true if SegmentAssignedEventSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of SegmentAssignedEventSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentAssignedEventSegment other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();

                return hash;
            }
        }
    }

}
