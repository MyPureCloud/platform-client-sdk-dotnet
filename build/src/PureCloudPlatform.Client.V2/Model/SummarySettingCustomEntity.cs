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
    /// SummarySettingCustomEntity
    /// </summary>
    [DataContract]
    public partial class SummarySettingCustomEntity :  IEquatable<SummarySettingCustomEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySettingCustomEntity" /> class.
        /// </summary>
        /// <param name="Label">Label how the entity should be called..</param>
        /// <param name="Description">Describe the information the entity captures..</param>
        public SummarySettingCustomEntity(string Label = null, string Description = null)
        {
            this.Label = Label;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// Label how the entity should be called.
        /// </summary>
        /// <value>Label how the entity should be called.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }



        /// <summary>
        /// Describe the information the entity captures.
        /// </summary>
        /// <value>Describe the information the entity captures.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummarySettingCustomEntity {\n");

            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as SummarySettingCustomEntity);
        }

        /// <summary>
        /// Returns true if SummarySettingCustomEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of SummarySettingCustomEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummarySettingCustomEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}
