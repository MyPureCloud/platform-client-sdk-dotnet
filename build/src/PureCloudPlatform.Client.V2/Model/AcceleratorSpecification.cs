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
    /// Metadata for a CX infrastructure as code accelerator
    /// </summary>
    [DataContract]
    public partial class AcceleratorSpecification :  IEquatable<AcceleratorSpecification>
    {
        /// <summary>
        /// where the accelerator originated
        /// </summary>
        /// <value>where the accelerator originated</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OriginEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Community for "Community"
            /// </summary>
            [EnumMember(Value = "Community")]
            Community,
            
            /// <summary>
            /// Enum Partner for "Partner"
            /// </summary>
            [EnumMember(Value = "Partner")]
            Partner,
            
            /// <summary>
            /// Enum Genesys for "Genesys"
            /// </summary>
            [EnumMember(Value = "Genesys")]
            Genesys
        }
        /// <summary>
        /// type of the artifact
        /// </summary>
        /// <value>type of the artifact</value>
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
            /// Enum Module for "Module"
            /// </summary>
            [EnumMember(Value = "Module")]
            Module,
            
            /// <summary>
            /// Enum Accelerator for "Accelerator"
            /// </summary>
            [EnumMember(Value = "Accelerator")]
            Accelerator,
            
            /// <summary>
            /// Enum Blueprint for "Blueprint"
            /// </summary>
            [EnumMember(Value = "Blueprint")]
            Blueprint
        }
        /// <summary>
        /// where the accelerator originated
        /// </summary>
        /// <value>where the accelerator originated</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; private set; }
        /// <summary>
        /// type of the artifact
        /// </summary>
        /// <value>type of the artifact</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceleratorSpecification" /> class.
        /// </summary>
        public AcceleratorSpecification()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// name of this accelerator
        /// </summary>
        /// <value>name of this accelerator</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }



        /// <summary>
        /// a description of the general purpose of this accelerator
        /// </summary>
        /// <value>a description of the general purpose of this accelerator</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }







        /// <summary>
        /// architectural classification into which the accelerator belongs
        /// </summary>
        /// <value>architectural classification into which the accelerator belongs</value>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public string Classification { get; private set; }



        /// <summary>
        /// tags
        /// </summary>
        /// <value>tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; private set; }



        /// <summary>
        /// Genesys Cloud permissions required to install the accelerator
        /// </summary>
        /// <value>Genesys Cloud permissions required to install the accelerator</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; private set; }



        /// <summary>
        /// Genesys Cloud products required to install the accelerator
        /// </summary>
        /// <value>Genesys Cloud products required to install the accelerator</value>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public List<string> Products { get; private set; }



        /// <summary>
        /// additional documentation about the artifact
        /// </summary>
        /// <value>additional documentation about the artifact</value>
        [DataMember(Name="documentation", EmitDefaultValue=false)]
        public List<MetadataDocumentation> Documentation { get; private set; }



        /// <summary>
        /// presentation of data fields to be gathered for the accelerator
        /// </summary>
        /// <value>presentation of data fields to be gathered for the accelerator</value>
        [DataMember(Name="presentation", EmitDefaultValue=false)]
        public List<MetadataPresentation> Presentation { get; private set; }



        /// <summary>
        /// resources created or modified as a result of running the accelerator
        /// </summary>
        /// <value>resources created or modified as a result of running the accelerator</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public MetadataResults Results { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcceleratorSpecification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Documentation: ").Append(Documentation).Append("\n");
            sb.Append("  Presentation: ").Append(Presentation).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as AcceleratorSpecification);
        }

        /// <summary>
        /// Returns true if AcceleratorSpecification instances are equal
        /// </summary>
        /// <param name="other">Instance of AcceleratorSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcceleratorSpecification other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Classification == other.Classification ||
                    this.Classification != null &&
                    this.Classification.Equals(other.Classification)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) &&
                (
                    this.Products == other.Products ||
                    this.Products != null &&
                    this.Products.SequenceEqual(other.Products)
                ) &&
                (
                    this.Documentation == other.Documentation ||
                    this.Documentation != null &&
                    this.Documentation.SequenceEqual(other.Documentation)
                ) &&
                (
                    this.Presentation == other.Presentation ||
                    this.Presentation != null &&
                    this.Presentation.SequenceEqual(other.Presentation)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.Equals(other.Results)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Classification != null)
                    hash = hash * 59 + this.Classification.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();

                if (this.Products != null)
                    hash = hash * 59 + this.Products.GetHashCode();

                if (this.Documentation != null)
                    hash = hash * 59 + this.Documentation.GetHashCode();

                if (this.Presentation != null)
                    hash = hash * 59 + this.Presentation.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
