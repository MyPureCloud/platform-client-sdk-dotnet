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
    /// DecisionTableExportJobRequest
    /// </summary>
    [DataContract]
    public partial class DecisionTableExportJobRequest :  IEquatable<DecisionTableExportJobRequest>
    {
        /// <summary>
        /// The type of export to perform.
        /// </summary>
        /// <value>The type of export to perform.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExportTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Template for "Template"
            /// </summary>
            [EnumMember(Value = "Template")]
            Template,
            
            /// <summary>
            /// Enum Populated for "Populated"
            /// </summary>
            [EnumMember(Value = "Populated")]
            Populated
        }
        /// <summary>
        /// The format of the exported file.
        /// </summary>
        /// <value>The format of the exported file.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Csv for "Csv"
            /// </summary>
            [EnumMember(Value = "Csv")]
            Csv
        }
        /// <summary>
        /// The type of export to perform.
        /// </summary>
        /// <value>The type of export to perform.</value>
        [DataMember(Name="exportType", EmitDefaultValue=false)]
        public ExportTypeEnum? ExportType { get; set; }
        /// <summary>
        /// The format of the exported file.
        /// </summary>
        /// <value>The format of the exported file.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableExportJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionTableExportJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableExportJobRequest" /> class.
        /// </summary>
        /// <param name="TableVersion">TableVersion.</param>
        /// <param name="ExportType">The type of export to perform. (required).</param>
        /// <param name="Format">The format of the exported file. (required).</param>
        public DecisionTableExportJobRequest(int? TableVersion = null, ExportTypeEnum? ExportType = null, FormatEnum? Format = null)
        {
            this.TableVersion = TableVersion;
            this.ExportType = ExportType;
            this.Format = Format;
            
        }
        


        /// <summary>
        /// Gets or Sets TableVersion
        /// </summary>
        [DataMember(Name="tableVersion", EmitDefaultValue=false)]
        public int? TableVersion { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableExportJobRequest {\n");

            sb.Append("  TableVersion: ").Append(TableVersion).Append("\n");
            sb.Append("  ExportType: ").Append(ExportType).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(obj as DecisionTableExportJobRequest);
        }

        /// <summary>
        /// Returns true if DecisionTableExportJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableExportJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableExportJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TableVersion == other.TableVersion ||
                    this.TableVersion != null &&
                    this.TableVersion.Equals(other.TableVersion)
                ) &&
                (
                    this.ExportType == other.ExportType ||
                    this.ExportType != null &&
                    this.ExportType.Equals(other.ExportType)
                ) &&
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
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
                if (this.TableVersion != null)
                    hash = hash * 59 + this.TableVersion.GetHashCode();

                if (this.ExportType != null)
                    hash = hash * 59 + this.ExportType.GetHashCode();

                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();

                return hash;
            }
        }
    }

}
