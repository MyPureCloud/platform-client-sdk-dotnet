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
    /// NluConfusionMatrixRow
    /// </summary>
    [DataContract]
    public partial class NluConfusionMatrixRow :  IEquatable<NluConfusionMatrixRow>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NluConfusionMatrixRow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NluConfusionMatrixRow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NluConfusionMatrixRow" /> class.
        /// </summary>
        /// <param name="Name">The name of the intent for the row. (required).</param>
        /// <param name="Columns">The columns of confusion matrix for the intent (required).</param>
        public NluConfusionMatrixRow(string Name = null, List<NluConfusionMatrixColumn> Columns = null)
        {
            this.Name = Name;
            this.Columns = Columns;
            
        }
        


        /// <summary>
        /// The name of the intent for the row.
        /// </summary>
        /// <value>The name of the intent for the row.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The columns of confusion matrix for the intent
        /// </summary>
        /// <value>The columns of confusion matrix for the intent</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<NluConfusionMatrixColumn> Columns { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluConfusionMatrixRow {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
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
            return this.Equals(obj as NluConfusionMatrixRow);
        }

        /// <summary>
        /// Returns true if NluConfusionMatrixRow instances are equal
        /// </summary>
        /// <param name="other">Instance of NluConfusionMatrixRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluConfusionMatrixRow other)
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
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(other.Columns)
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

                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();

                return hash;
            }
        }
    }

}
