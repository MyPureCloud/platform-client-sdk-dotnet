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
    /// DocumentBodyListBlock
    /// </summary>
    [DataContract]
    public partial class DocumentBodyListBlock :  IEquatable<DocumentBodyListBlock>
    {
        /// <summary>
        /// The type of the list block.
        /// </summary>
        /// <value>The type of the list block.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Listitem for "ListItem"
            /// </summary>
            [EnumMember(Value = "ListItem")]
            Listitem
        }
        /// <summary>
        /// The type of the list block.
        /// </summary>
        /// <value>The type of the list block.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyListBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBodyListBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyListBlock" /> class.
        /// </summary>
        /// <param name="Type">The type of the list block. (required).</param>
        /// <param name="Properties">The properties for the list block..</param>
        /// <param name="Blocks">The list of items for an OrderedList or an UnorderedList. (required).</param>
        public DocumentBodyListBlock(TypeEnum? Type = null, DocumentBodyListItemProperties Properties = null, List<DocumentListContentBlock> Blocks = null)
        {
            this.Type = Type;
            this.Properties = Properties;
            this.Blocks = Blocks;
            
        }
        




        /// <summary>
        /// The properties for the list block.
        /// </summary>
        /// <value>The properties for the list block.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public DocumentBodyListItemProperties Properties { get; set; }



        /// <summary>
        /// The list of items for an OrderedList or an UnorderedList.
        /// </summary>
        /// <value>The list of items for an OrderedList or an UnorderedList.</value>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public List<DocumentListContentBlock> Blocks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyListBlock {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
            return this.Equals(obj as DocumentBodyListBlock);
        }

        /// <summary>
        /// Returns true if DocumentBodyListBlock instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyListBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyListBlock other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) &&
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.SequenceEqual(other.Blocks)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();

                return hash;
            }
        }
    }

}
