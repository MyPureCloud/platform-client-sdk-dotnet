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
    /// MaskingRule
    /// </summary>
    [DataContract]
    public partial class MaskingRule :  IEquatable<MaskingRule>
    {
        /// <summary>
        /// Masking rule type
        /// </summary>
        /// <value>Masking rule type</value>
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
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,
            
            /// <summary>
            /// Enum Predefined for "Predefined"
            /// </summary>
            [EnumMember(Value = "Predefined")]
            Predefined,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default
        }
        /// <summary>
        /// inbound/outbound
        /// </summary>
        /// <value>inbound/outbound</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        /// <summary>
        /// Masking rule type
        /// </summary>
        /// <value>Masking rule type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// inbound/outbound
        /// </summary>
        /// <value>inbound/outbound</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MaskingRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRule" /> class.
        /// </summary>
        /// <param name="Name">Masking rule name. (required).</param>
        /// <param name="Description">Description about masking rule..</param>
        /// <param name="SubstituteCharacter">Replacement character for masked text character. (required).</param>
        /// <param name="Definition">Definition of masking rule (a valid regex or builtin AI based mask name). (required).</param>
        /// <param name="Enabled">True/False (required).</param>
        /// <param name="Type">Masking rule type (required).</param>
        /// <param name="Direction">inbound/outbound.</param>
        /// <param name="Integrations">Associated integration channels.</param>
        public MaskingRule(string Name = null, string Description = null, string SubstituteCharacter = null, string Definition = null, bool? Enabled = null, TypeEnum? Type = null, DirectionEnum? Direction = null, List<string> Integrations = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.SubstituteCharacter = SubstituteCharacter;
            this.Definition = Definition;
            this.Enabled = Enabled;
            this.Type = Type;
            this.Direction = Direction;
            this.Integrations = Integrations;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Masking rule name.
        /// </summary>
        /// <value>Masking rule name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Description about masking rule.
        /// </summary>
        /// <value>Description about masking rule.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Replacement character for masked text character.
        /// </summary>
        /// <value>Replacement character for masked text character.</value>
        [DataMember(Name="substituteCharacter", EmitDefaultValue=false)]
        public string SubstituteCharacter { get; set; }



        /// <summary>
        /// Definition of masking rule (a valid regex or builtin AI based mask name).
        /// </summary>
        /// <value>Definition of masking rule (a valid regex or builtin AI based mask name).</value>
        [DataMember(Name="definition", EmitDefaultValue=false)]
        public string Definition { get; set; }



        /// <summary>
        /// True/False
        /// </summary>
        /// <value>True/False</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }







        /// <summary>
        /// Associated integration channels
        /// </summary>
        /// <value>Associated integration channels</value>
        [DataMember(Name="integrations", EmitDefaultValue=false)]
        public List<string> Integrations { get; set; }



        /// <summary>
        /// Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Date when the rule was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the rule was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaskingRule {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubstituteCharacter: ").Append(SubstituteCharacter).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Integrations: ").Append(Integrations).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as MaskingRule);
        }

        /// <summary>
        /// Returns true if MaskingRule instances are equal
        /// </summary>
        /// <param name="other">Instance of MaskingRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaskingRule other)
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
                    this.SubstituteCharacter == other.SubstituteCharacter ||
                    this.SubstituteCharacter != null &&
                    this.SubstituteCharacter.Equals(other.SubstituteCharacter)
                ) &&
                (
                    this.Definition == other.Definition ||
                    this.Definition != null &&
                    this.Definition.Equals(other.Definition)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.Integrations == other.Integrations ||
                    this.Integrations != null &&
                    this.Integrations.SequenceEqual(other.Integrations)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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

                if (this.SubstituteCharacter != null)
                    hash = hash * 59 + this.SubstituteCharacter.GetHashCode();

                if (this.Definition != null)
                    hash = hash * 59 + this.Definition.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.Integrations != null)
                    hash = hash * 59 + this.Integrations.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                return hash;
            }
        }
    }

}
