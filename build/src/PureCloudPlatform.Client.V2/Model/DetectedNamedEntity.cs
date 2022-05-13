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
    /// DetectedNamedEntity
    /// </summary>
    [DataContract]
    public partial class DetectedNamedEntity :  IEquatable<DetectedNamedEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedNamedEntity" /> class.
        /// </summary>
        public DetectedNamedEntity()
        {
            
        }
        


        /// <summary>
        /// The name of the detected named entity.
        /// </summary>
        /// <value>The name of the detected named entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }



        /// <summary>
        /// The type of the detected named entity.
        /// </summary>
        /// <value>The type of the detected named entity.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; private set; }



        /// <summary>
        /// The probability of the detected named entity.
        /// </summary>
        /// <value>The probability of the detected named entity.</value>
        [DataMember(Name="probability", EmitDefaultValue=false)]
        public double? Probability { get; private set; }



        /// <summary>
        /// The value of the detected named entity.
        /// </summary>
        /// <value>The value of the detected named entity.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public DetectedNamedEntityValue Value { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectedNamedEntity {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
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
            return this.Equals(obj as DetectedNamedEntity);
        }

        /// <summary>
        /// Returns true if DetectedNamedEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of DetectedNamedEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectedNamedEntity other)
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
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.Probability == other.Probability ||
                    this.Probability != null &&
                    this.Probability.Equals(other.Probability)
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

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.Probability != null)
                    hash = hash * 59 + this.Probability.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
