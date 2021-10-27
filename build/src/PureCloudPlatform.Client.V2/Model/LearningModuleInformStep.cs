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
    /// LearningModuleInformStep
    /// </summary>
    [DataContract]
    public partial class LearningModuleInformStep :  IEquatable<LearningModuleInformStep>
    {
        
        
        /// <summary>
        /// The learning module inform step type
        /// </summary>
        /// <value>The learning module inform step type</value>
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
            /// Enum Url for "Url"
            /// </summary>
            [EnumMember(Value = "Url")]
            Url,
            
            /// <summary>
            /// Enum Content for "Content"
            /// </summary>
            [EnumMember(Value = "Content")]
            Content,
            
            /// <summary>
            /// Enum Genesysbuiltincourse for "GenesysBuiltInCourse"
            /// </summary>
            [EnumMember(Value = "GenesysBuiltInCourse")]
            Genesysbuiltincourse,
            
            /// <summary>
            /// Enum Richtext for "RichText"
            /// </summary>
            [EnumMember(Value = "RichText")]
            Richtext
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The learning module inform step type
        /// </summary>
        /// <value>The learning module inform step type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleInformStep" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningModuleInformStep() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleInformStep" /> class.
        /// </summary>
        /// <param name="Type">The learning module inform step type (required).</param>
        /// <param name="Name">The name of the inform step or content.</param>
        /// <param name="Value">The value for inform step (required).</param>
        /// <param name="SharingUri">The sharing uri for Content type inform step.</param>
        /// <param name="ContentType">The document type for Content type Inform step.</param>
        /// <param name="Order">The order of inform step in a learning module (required).</param>
        public LearningModuleInformStep(TypeEnum? Type = null, string Name = null, string Value = null, string SharingUri = null, string ContentType = null, int? Order = null)
        {
            this.Type = Type;
            this.Name = Name;
            this.Value = Value;
            this.SharingUri = SharingUri;
            this.ContentType = ContentType;
            this.Order = Order;
            
        }
        
        
        
        
        
        /// <summary>
        /// The name of the inform step or content
        /// </summary>
        /// <value>The name of the inform step or content</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The value for inform step
        /// </summary>
        /// <value>The value for inform step</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// The sharing uri for Content type inform step
        /// </summary>
        /// <value>The sharing uri for Content type inform step</value>
        [DataMember(Name="sharingUri", EmitDefaultValue=false)]
        public string SharingUri { get; set; }
        
        
        
        /// <summary>
        /// The document type for Content type Inform step
        /// </summary>
        /// <value>The document type for Content type Inform step</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
        
        
        
        /// <summary>
        /// The order of inform step in a learning module
        /// </summary>
        /// <value>The order of inform step in a learning module</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModuleInformStep {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  SharingUri: ").Append(SharingUri).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as LearningModuleInformStep);
        }

        /// <summary>
        /// Returns true if LearningModuleInformStep instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModuleInformStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModuleInformStep other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.SharingUri == other.SharingUri ||
                    this.SharingUri != null &&
                    this.SharingUri.Equals(other.SharingUri)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.SharingUri != null)
                    hash = hash * 59 + this.SharingUri.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                
                return hash;
            }
        }
    }

}
