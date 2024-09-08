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
    /// KnowledgeSuggestionConfig
    /// </summary>
    [DataContract]
    public partial class KnowledgeSuggestionConfig :  IEquatable<KnowledgeSuggestionConfig>
    {
        /// <summary>
        /// The name of vendor used for knowledge suggestions.
        /// </summary>
        /// <value>The name of vendor used for knowledge suggestions.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VendorNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Googledialogflow for "GoogleDialogflow"
            /// </summary>
            [EnumMember(Value = "GoogleDialogflow")]
            Googledialogflow,
            
            /// <summary>
            /// Enum Genesysknowledge for "GenesysKnowledge"
            /// </summary>
            [EnumMember(Value = "GenesysKnowledge")]
            Genesysknowledge,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The name of vendor used for knowledge suggestions.
        /// </summary>
        /// <value>The name of vendor used for knowledge suggestions.</value>
        [DataMember(Name="vendorName", EmitDefaultValue=false)]
        public VendorNameEnum? VendorName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSuggestionConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeSuggestionConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSuggestionConfig" /> class.
        /// </summary>
        /// <param name="VendorName">The name of vendor used for knowledge suggestions. (required).</param>
        /// <param name="KnowledgeBase">The ID of knowledge base to query when Genesys is the knowledge suggestions provider..</param>
        /// <param name="KnowledgeBases">The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider..</param>
        public KnowledgeSuggestionConfig(VendorNameEnum? VendorName = null, KnowledgeBaseReference KnowledgeBase = null, List<KnowledgeBaseWithDialectReference> KnowledgeBases = null)
        {
            this.VendorName = VendorName;
            this.KnowledgeBase = KnowledgeBase;
            this.KnowledgeBases = KnowledgeBases;
            
        }
        




        /// <summary>
        /// The ID of knowledge base to query when Genesys is the knowledge suggestions provider.
        /// </summary>
        /// <value>The ID of knowledge base to query when Genesys is the knowledge suggestions provider.</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBaseReference KnowledgeBase { get; set; }



        /// <summary>
        /// The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider.
        /// </summary>
        /// <value>The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider.</value>
        [DataMember(Name="knowledgeBases", EmitDefaultValue=false)]
        public List<KnowledgeBaseWithDialectReference> KnowledgeBases { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSuggestionConfig {\n");

            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  KnowledgeBases: ").Append(KnowledgeBases).Append("\n");
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
            return this.Equals(obj as KnowledgeSuggestionConfig);
        }

        /// <summary>
        /// Returns true if KnowledgeSuggestionConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSuggestionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSuggestionConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.VendorName == other.VendorName ||
                    this.VendorName != null &&
                    this.VendorName.Equals(other.VendorName)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
                ) &&
                (
                    this.KnowledgeBases == other.KnowledgeBases ||
                    this.KnowledgeBases != null &&
                    this.KnowledgeBases.SequenceEqual(other.KnowledgeBases)
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
                if (this.VendorName != null)
                    hash = hash * 59 + this.VendorName.GetHashCode();

                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();

                if (this.KnowledgeBases != null)
                    hash = hash * 59 + this.KnowledgeBases.GetHashCode();

                return hash;
            }
        }
    }

}
