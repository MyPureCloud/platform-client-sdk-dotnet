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
    /// AuditEntityReference
    /// </summary>
    [DataContract]
    public partial class AuditEntityReference :  IEquatable<AuditEntityReference>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Attribute for "ATTRIBUTE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE")]
            Attribute,
            
            /// <summary>
            /// Enum AttributeGroupInstance for "ATTRIBUTE_GROUP_INSTANCE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE")]
            AttributeGroupInstance,
            
            /// <summary>
            /// Enum Document for "DOCUMENT"
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            Document,
            
            /// <summary>
            /// Enum Download for "DOWNLOAD"
            /// </summary>
            [EnumMember(Value = "DOWNLOAD")]
            Download,
            
            /// <summary>
            /// Enum Fax for "FAX"
            /// </summary>
            [EnumMember(Value = "FAX")]
            Fax,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group,
            
            /// <summary>
            /// Enum Recording for "RECORDING"
            /// </summary>
            [EnumMember(Value = "RECORDING")]
            Recording,
            
            /// <summary>
            /// Enum Tag for "TAG"
            /// </summary>
            [EnumMember(Value = "TAG")]
            Tag,
            
            /// <summary>
            /// Enum Workspace for "WORKSPACE"
            /// </summary>
            [EnumMember(Value = "WORKSPACE")]
            Workspace,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Public for "PUBLIC"
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            Public
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntityReference" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Action">Action.</param>
        public AuditEntityReference(string Id = null, string Name = null, string SelfUri = null, TypeEnum? Type = null, string Action = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SelfUri = SelfUri;
            this.Type = Type;
            this.Action = Action;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }





        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditEntityReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as AuditEntityReference);
        }

        /// <summary>
        /// Returns true if AuditEntityReference instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditEntityReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditEntityReference other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                return hash;
            }
        }
    }

}
