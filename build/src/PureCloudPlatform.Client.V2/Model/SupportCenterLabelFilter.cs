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
    /// SupportCenterLabelFilter
    /// </summary>
    [DataContract]
    public partial class SupportCenterLabelFilter :  IEquatable<SupportCenterLabelFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterLabelFilter" /> class.
        /// </summary>
        /// <param name="Labels">Labels to filter by..</param>
        public SupportCenterLabelFilter(List<AddressableEntityRef> Labels = null)
        {
            this.Labels = Labels;
            
        }
        


        /// <summary>
        /// Labels to filter by.
        /// </summary>
        /// <value>Labels to filter by.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Labels { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterLabelFilter {\n");

            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
            return this.Equals(obj as SupportCenterLabelFilter);
        }

        /// <summary>
        /// Returns true if SupportCenterLabelFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterLabelFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterLabelFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(other.Labels)
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
                if (this.Labels != null)
                    hash = hash * 59 + this.Labels.GetHashCode();

                return hash;
            }
        }
    }

}
