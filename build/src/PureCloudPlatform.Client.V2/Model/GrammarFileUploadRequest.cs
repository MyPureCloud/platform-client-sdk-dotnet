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
    /// GrammarFileUploadRequest
    /// </summary>
    [DataContract]
    public partial class GrammarFileUploadRequest :  IEquatable<GrammarFileUploadRequest>
    {
        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FileTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Gram for "gram"
            /// </summary>
            [EnumMember(Value = "gram")]
            Gram,
            
            /// <summary>
            /// Enum Grxml for "grxml"
            /// </summary>
            [EnumMember(Value = "grxml")]
            Grxml
        }
        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [DataMember(Name="fileType", EmitDefaultValue=false)]
        public FileTypeEnum? FileType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrammarFileUploadRequest" /> class.
        /// </summary>
        /// <param name="FileType">FileType.</param>
        public GrammarFileUploadRequest(FileTypeEnum? FileType = null)
        {
            this.FileType = FileType;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrammarFileUploadRequest {\n");

            sb.Append("  FileType: ").Append(FileType).Append("\n");
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
            return this.Equals(obj as GrammarFileUploadRequest);
        }

        /// <summary>
        /// Returns true if GrammarFileUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GrammarFileUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrammarFileUploadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileType == other.FileType ||
                    this.FileType != null &&
                    this.FileType.Equals(other.FileType)
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
                if (this.FileType != null)
                    hash = hash * 59 + this.FileType.GetHashCode();

                return hash;
            }
        }
    }

}
