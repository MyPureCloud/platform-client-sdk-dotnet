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
    /// FieldMapping
    /// </summary>
    [DataContract]
    public partial class FieldMapping :  IEquatable<FieldMapping>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldMapping" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldMapping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldMapping" /> class.
        /// </summary>
        /// <param name="DataActionValueName">The data action output field name that maps to the list item values. (required).</param>
        /// <param name="DataActionSynonymName">The data action output field name that maps to the list item synonyms. Optional if synonyms are not provided by the data action..</param>
        public FieldMapping(string DataActionValueName = null, string DataActionSynonymName = null)
        {
            this.DataActionValueName = DataActionValueName;
            this.DataActionSynonymName = DataActionSynonymName;
            
        }
        


        /// <summary>
        /// The data action output field name that maps to the list item values.
        /// </summary>
        /// <value>The data action output field name that maps to the list item values.</value>
        [DataMember(Name="dataActionValueName", EmitDefaultValue=false)]
        public string DataActionValueName { get; set; }



        /// <summary>
        /// The data action output field name that maps to the list item synonyms. Optional if synonyms are not provided by the data action.
        /// </summary>
        /// <value>The data action output field name that maps to the list item synonyms. Optional if synonyms are not provided by the data action.</value>
        [DataMember(Name="dataActionSynonymName", EmitDefaultValue=false)]
        public string DataActionSynonymName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldMapping {\n");

            sb.Append("  DataActionValueName: ").Append(DataActionValueName).Append("\n");
            sb.Append("  DataActionSynonymName: ").Append(DataActionSynonymName).Append("\n");
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
            return this.Equals(obj as FieldMapping);
        }

        /// <summary>
        /// Returns true if FieldMapping instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldMapping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DataActionValueName == other.DataActionValueName ||
                    this.DataActionValueName != null &&
                    this.DataActionValueName.Equals(other.DataActionValueName)
                ) &&
                (
                    this.DataActionSynonymName == other.DataActionSynonymName ||
                    this.DataActionSynonymName != null &&
                    this.DataActionSynonymName.Equals(other.DataActionSynonymName)
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
                if (this.DataActionValueName != null)
                    hash = hash * 59 + this.DataActionValueName.GetHashCode();

                if (this.DataActionSynonymName != null)
                    hash = hash * 59 + this.DataActionSynonymName.GetHashCode();

                return hash;
            }
        }
    }

}
