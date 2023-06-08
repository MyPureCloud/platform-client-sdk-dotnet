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
    /// Model for a Nuance bot variable
    /// </summary>
    [DataContract]
    public partial class NuanceBotVariable :  IEquatable<NuanceBotVariable>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NuanceBotVariable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NuanceBotVariable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NuanceBotVariable" /> class.
        /// </summary>
        /// <param name="Id">The variable ID (required).</param>
        /// <param name="Name">The variable display name (required).</param>
        /// <param name="Description">The variable description.</param>
        /// <param name="Reserved">True if the variable is a reserved variable.</param>
        /// <param name="SimpleVariableInfo">The type information for this variable.</param>
        /// <param name="ComplexGenericVariableInfo">The type information for this variable.</param>
        public NuanceBotVariable(string Id = null, string Name = null, string Description = null, bool? Reserved = null, string SimpleVariableInfo = null, ComplexVariableInfo ComplexGenericVariableInfo = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Reserved = Reserved;
            this.SimpleVariableInfo = SimpleVariableInfo;
            this.ComplexGenericVariableInfo = ComplexGenericVariableInfo;
            
        }
        


        /// <summary>
        /// The variable ID
        /// </summary>
        /// <value>The variable ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The variable display name
        /// </summary>
        /// <value>The variable display name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The variable description
        /// </summary>
        /// <value>The variable description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// True if the variable is a reserved variable
        /// </summary>
        /// <value>True if the variable is a reserved variable</value>
        [DataMember(Name="reserved", EmitDefaultValue=false)]
        public bool? Reserved { get; set; }



        /// <summary>
        /// The type information for this variable
        /// </summary>
        /// <value>The type information for this variable</value>
        [DataMember(Name="simpleVariableInfo", EmitDefaultValue=false)]
        public string SimpleVariableInfo { get; set; }



        /// <summary>
        /// The type information for this variable
        /// </summary>
        /// <value>The type information for this variable</value>
        [DataMember(Name="complexGenericVariableInfo", EmitDefaultValue=false)]
        public ComplexVariableInfo ComplexGenericVariableInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NuanceBotVariable {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Reserved: ").Append(Reserved).Append("\n");
            sb.Append("  SimpleVariableInfo: ").Append(SimpleVariableInfo).Append("\n");
            sb.Append("  ComplexGenericVariableInfo: ").Append(ComplexGenericVariableInfo).Append("\n");
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
            return this.Equals(obj as NuanceBotVariable);
        }

        /// <summary>
        /// Returns true if NuanceBotVariable instances are equal
        /// </summary>
        /// <param name="other">Instance of NuanceBotVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NuanceBotVariable other)
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
                    this.Reserved == other.Reserved ||
                    this.Reserved != null &&
                    this.Reserved.Equals(other.Reserved)
                ) &&
                (
                    this.SimpleVariableInfo == other.SimpleVariableInfo ||
                    this.SimpleVariableInfo != null &&
                    this.SimpleVariableInfo.Equals(other.SimpleVariableInfo)
                ) &&
                (
                    this.ComplexGenericVariableInfo == other.ComplexGenericVariableInfo ||
                    this.ComplexGenericVariableInfo != null &&
                    this.ComplexGenericVariableInfo.Equals(other.ComplexGenericVariableInfo)
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

                if (this.Reserved != null)
                    hash = hash * 59 + this.Reserved.GetHashCode();

                if (this.SimpleVariableInfo != null)
                    hash = hash * 59 + this.SimpleVariableInfo.GetHashCode();

                if (this.ComplexGenericVariableInfo != null)
                    hash = hash * 59 + this.ComplexGenericVariableInfo.GetHashCode();

                return hash;
            }
        }
    }

}
