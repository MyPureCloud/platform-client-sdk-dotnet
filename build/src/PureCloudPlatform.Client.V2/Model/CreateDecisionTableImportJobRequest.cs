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
    /// CreateDecisionTableImportJobRequest
    /// </summary>
    [DataContract]
    public partial class CreateDecisionTableImportJobRequest :  IEquatable<CreateDecisionTableImportJobRequest>
    {
        /// <summary>
        /// How imported rows are merged with existing rows
        /// </summary>
        /// <value>How imported rows are merged with existing rows</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ImportModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Append for "Append"
            /// </summary>
            [EnumMember(Value = "Append")]
            Append,
            
            /// <summary>
            /// Enum Replace for "Replace"
            /// </summary>
            [EnumMember(Value = "Replace")]
            Replace
        }
        /// <summary>
        /// How imported rows are merged with existing rows
        /// </summary>
        /// <value>How imported rows are merged with existing rows</value>
        [DataMember(Name="importMode", EmitDefaultValue=false)]
        public ImportModeEnum? ImportMode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionTableImportJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDecisionTableImportJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionTableImportJobRequest" /> class.
        /// </summary>
        /// <param name="ImportMode">How imported rows are merged with existing rows (required).</param>
        /// <param name="FileName">Name of the file to import. Must include the file extension. (required).</param>
        public CreateDecisionTableImportJobRequest(ImportModeEnum? ImportMode = null, string FileName = null)
        {
            this.ImportMode = ImportMode;
            this.FileName = FileName;
            
        }
        




        /// <summary>
        /// Name of the file to import. Must include the file extension.
        /// </summary>
        /// <value>Name of the file to import. Must include the file extension.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDecisionTableImportJobRequest {\n");

            sb.Append("  ImportMode: ").Append(ImportMode).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return this.Equals(obj as CreateDecisionTableImportJobRequest);
        }

        /// <summary>
        /// Returns true if CreateDecisionTableImportJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateDecisionTableImportJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDecisionTableImportJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ImportMode == other.ImportMode ||
                    this.ImportMode != null &&
                    this.ImportMode.Equals(other.ImportMode)
                ) &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
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
                if (this.ImportMode != null)
                    hash = hash * 59 + this.ImportMode.GetHashCode();

                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                return hash;
            }
        }
    }

}
