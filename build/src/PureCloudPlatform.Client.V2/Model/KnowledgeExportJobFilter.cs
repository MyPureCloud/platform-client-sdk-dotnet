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
    /// KnowledgeExportJobFilter
    /// </summary>
    [DataContract]
    public partial class KnowledgeExportJobFilter :  IEquatable<KnowledgeExportJobFilter>
    {
        /// <summary>
        /// Specifies what version should be exported.
        /// </summary>
        /// <value>Specifies what version should be exported.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VersionFilterEnum
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
            /// Enum Latest for "Latest"
            /// </summary>
            [EnumMember(Value = "Latest")]
            Latest
        }
        /// <summary>
        /// Specifies what version should be exported.
        /// </summary>
        /// <value>Specifies what version should be exported.</value>
        [DataMember(Name="versionFilter", EmitDefaultValue=false)]
        public VersionFilterEnum? VersionFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExportJobFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeExportJobFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExportJobFilter" /> class.
        /// </summary>
        /// <param name="DocumentsFilter">Filters for narrowing down which documents to export..</param>
        /// <param name="VersionFilter">Specifies what version should be exported. (required).</param>
        public KnowledgeExportJobFilter(KnowledgeExportJobDocumentsFilter DocumentsFilter = null, VersionFilterEnum? VersionFilter = null)
        {
            this.DocumentsFilter = DocumentsFilter;
            this.VersionFilter = VersionFilter;
            
        }
        


        /// <summary>
        /// Filters for narrowing down which documents to export.
        /// </summary>
        /// <value>Filters for narrowing down which documents to export.</value>
        [DataMember(Name="documentsFilter", EmitDefaultValue=false)]
        public KnowledgeExportJobDocumentsFilter DocumentsFilter { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeExportJobFilter {\n");

            sb.Append("  DocumentsFilter: ").Append(DocumentsFilter).Append("\n");
            sb.Append("  VersionFilter: ").Append(VersionFilter).Append("\n");
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
            return this.Equals(obj as KnowledgeExportJobFilter);
        }

        /// <summary>
        /// Returns true if KnowledgeExportJobFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeExportJobFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeExportJobFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DocumentsFilter == other.DocumentsFilter ||
                    this.DocumentsFilter != null &&
                    this.DocumentsFilter.Equals(other.DocumentsFilter)
                ) &&
                (
                    this.VersionFilter == other.VersionFilter ||
                    this.VersionFilter != null &&
                    this.VersionFilter.Equals(other.VersionFilter)
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
                if (this.DocumentsFilter != null)
                    hash = hash * 59 + this.DocumentsFilter.GetHashCode();

                if (this.VersionFilter != null)
                    hash = hash * 59 + this.VersionFilter.GetHashCode();

                return hash;
            }
        }
    }

}
