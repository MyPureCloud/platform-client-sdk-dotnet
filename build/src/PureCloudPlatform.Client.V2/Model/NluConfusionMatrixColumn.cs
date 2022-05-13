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
    /// NluConfusionMatrixColumn
    /// </summary>
    [DataContract]
    public partial class NluConfusionMatrixColumn :  IEquatable<NluConfusionMatrixColumn>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NluConfusionMatrixColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NluConfusionMatrixColumn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NluConfusionMatrixColumn" /> class.
        /// </summary>
        /// <param name="Name">The name of the intent for the column. (required).</param>
        /// <param name="Value">The confusion value between the intents (required).</param>
        public NluConfusionMatrixColumn(string Name = null, float? Value = null)
        {
            this.Name = Name;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The name of the intent for the column.
        /// </summary>
        /// <value>The name of the intent for the column.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The confusion value between the intents
        /// </summary>
        /// <value>The confusion value between the intents</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public float? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluConfusionMatrixColumn {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as NluConfusionMatrixColumn);
        }

        /// <summary>
        /// Returns true if NluConfusionMatrixColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of NluConfusionMatrixColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluConfusionMatrixColumn other)
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

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
