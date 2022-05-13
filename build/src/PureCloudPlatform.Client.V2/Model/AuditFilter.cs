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
    /// AuditFilter
    /// </summary>
    [DataContract]
    public partial class AuditFilter :  IEquatable<AuditFilter>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditFilter" /> class.
        /// </summary>
        /// <param name="Name">The name of the field by which to filter. (required).</param>
        /// <param name="Type">The type of the filter, DATE or STRING. (required).</param>
        /// <param name="Operator">The operation that the filter performs. (required).</param>
        /// <param name="Values">The values to make the filter comparison against. (required).</param>
        public AuditFilter(string Name = null, string Type = null, string Operator = null, List<string> Values = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.Operator = Operator;
            this.Values = Values;
            
        }
        


        /// <summary>
        /// The name of the field by which to filter.
        /// </summary>
        /// <value>The name of the field by which to filter.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The type of the filter, DATE or STRING.
        /// </summary>
        /// <value>The type of the filter, DATE or STRING.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// The operation that the filter performs.
        /// </summary>
        /// <value>The operation that the filter performs.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string Operator { get; set; }



        /// <summary>
        /// The values to make the filter comparison against.
        /// </summary>
        /// <value>The values to make the filter comparison against.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditFilter {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as AuditFilter);
        }

        /// <summary>
        /// Returns true if AuditFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditFilter other)
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
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
