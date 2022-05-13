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
    /// RequestMapping
    /// </summary>
    [DataContract]
    public partial class RequestMapping :  IEquatable<RequestMapping>
    {
        /// <summary>
        /// Type of the value supplied
        /// </summary>
        /// <value>Type of the value supplied</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AttributeTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum String for "String"
            /// </summary>
            [EnumMember(Value = "String")]
            String,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,
            
            /// <summary>
            /// Enum Integer for "Integer"
            /// </summary>
            [EnumMember(Value = "Integer")]
            Integer,
            
            /// <summary>
            /// Enum Boolean for "Boolean"
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean
        }
        /// <summary>
        /// Method of finding value to use with Attribute
        /// </summary>
        /// <value>Method of finding value to use with Attribute</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MappingTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Lookup for "Lookup"
            /// </summary>
            [EnumMember(Value = "Lookup")]
            Lookup,
            
            /// <summary>
            /// Enum Hardcoded for "HardCoded"
            /// </summary>
            [EnumMember(Value = "HardCoded")]
            Hardcoded
        }
        /// <summary>
        /// Type of the value supplied
        /// </summary>
        /// <value>Type of the value supplied</value>
        [DataMember(Name="attributeType", EmitDefaultValue=false)]
        public AttributeTypeEnum? AttributeType { get; set; }
        /// <summary>
        /// Method of finding value to use with Attribute
        /// </summary>
        /// <value>Method of finding value to use with Attribute</value>
        [DataMember(Name="mappingType", EmitDefaultValue=false)]
        public MappingTypeEnum? MappingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestMapping" /> class.
        /// </summary>
        /// <param name="Name">Name of the Integration Action Attribute to supply the value for.</param>
        /// <param name="AttributeType">Type of the value supplied.</param>
        /// <param name="MappingType">Method of finding value to use with Attribute.</param>
        /// <param name="Value">Value to supply for the specified Attribute.</param>
        public RequestMapping(string Name = null, AttributeTypeEnum? AttributeType = null, MappingTypeEnum? MappingType = null, string Value = null)
        {
            this.Name = Name;
            this.AttributeType = AttributeType;
            this.MappingType = MappingType;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// Name of the Integration Action Attribute to supply the value for
        /// </summary>
        /// <value>Name of the Integration Action Attribute to supply the value for</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }







        /// <summary>
        /// Value to supply for the specified Attribute
        /// </summary>
        /// <value>Value to supply for the specified Attribute</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestMapping {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AttributeType: ").Append(AttributeType).Append("\n");
            sb.Append("  MappingType: ").Append(MappingType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as RequestMapping);
        }

        /// <summary>
        /// Returns true if RequestMapping instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestMapping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.AttributeType == other.AttributeType ||
                    this.AttributeType != null &&
                    this.AttributeType.Equals(other.AttributeType)
                ) &&
                (
                    this.MappingType == other.MappingType ||
                    this.MappingType != null &&
                    this.MappingType.Equals(other.MappingType)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.AttributeType != null)
                    hash = hash * 59 + this.AttributeType.GetHashCode();

                if (this.MappingType != null)
                    hash = hash * 59 + this.MappingType.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
