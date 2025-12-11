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
    /// GuideSessionTurnInvocationParameters
    /// </summary>
    [DataContract]
    public partial class GuideSessionTurnInvocationParameters :  IEquatable<GuideSessionTurnInvocationParameters>
    {
        /// <summary>
        /// The type of the parameter.
        /// </summary>
        /// <value>The type of the parameter.</value>
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
            /// Enum String for "String"
            /// </summary>
            [EnumMember(Value = "String")]
            String,
            
            /// <summary>
            /// Enum Integer for "Integer"
            /// </summary>
            [EnumMember(Value = "Integer")]
            Integer,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,
            
            /// <summary>
            /// Enum Boolean for "Boolean"
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean
        }
        /// <summary>
        /// The type of the parameter.
        /// </summary>
        /// <value>The type of the parameter.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnInvocationParameters" /> class.
        /// </summary>
        /// <param name="Name">The name of the parameter..</param>
        /// <param name="Type">The type of the parameter..</param>
        /// <param name="Value">The value of the parameter..</param>
        public GuideSessionTurnInvocationParameters(string Name = null, TypeEnum? Type = null, string Value = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The name of the parameter.
        /// </summary>
        /// <value>The name of the parameter.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// The value of the parameter.
        /// </summary>
        /// <value>The value of the parameter.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionTurnInvocationParameters {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as GuideSessionTurnInvocationParameters);
        }

        /// <summary>
        /// Returns true if GuideSessionTurnInvocationParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionTurnInvocationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionTurnInvocationParameters other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
