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
    /// CannedResponseLibraries
    /// </summary>
    [DataContract]
    public partial class CannedResponseLibraries :  IEquatable<CannedResponseLibraries>
    {
        /// <summary>
        /// The association mode of canned response libraries to queue
        /// </summary>
        /// <value>The association mode of canned response libraries to queue</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Selectedonly for "SelectedOnly"
            /// </summary>
            [EnumMember(Value = "SelectedOnly")]
            Selectedonly,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        /// <summary>
        /// The association mode of canned response libraries to queue
        /// </summary>
        /// <value>The association mode of canned response libraries to queue</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CannedResponseLibraries" /> class.
        /// </summary>
        /// <param name="LibraryIds">Set of canned response library IDs associated with the queue only when mode is SelectedOnly..</param>
        /// <param name="Mode">The association mode of canned response libraries to queue.</param>
        public CannedResponseLibraries(List<string> LibraryIds = null, ModeEnum? Mode = null)
        {
            this.LibraryIds = LibraryIds;
            this.Mode = Mode;
            
        }
        


        /// <summary>
        /// Set of canned response library IDs associated with the queue only when mode is SelectedOnly.
        /// </summary>
        /// <value>Set of canned response library IDs associated with the queue only when mode is SelectedOnly.</value>
        [DataMember(Name="libraryIds", EmitDefaultValue=false)]
        public List<string> LibraryIds { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CannedResponseLibraries {\n");

            sb.Append("  LibraryIds: ").Append(LibraryIds).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
            return this.Equals(obj as CannedResponseLibraries);
        }

        /// <summary>
        /// Returns true if CannedResponseLibraries instances are equal
        /// </summary>
        /// <param name="other">Instance of CannedResponseLibraries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CannedResponseLibraries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LibraryIds == other.LibraryIds ||
                    this.LibraryIds != null &&
                    this.LibraryIds.SequenceEqual(other.LibraryIds)
                ) &&
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
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
                if (this.LibraryIds != null)
                    hash = hash * 59 + this.LibraryIds.GetHashCode();

                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();

                return hash;
            }
        }
    }

}
