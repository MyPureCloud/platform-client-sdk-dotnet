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
    /// DeleteRetention
    /// </summary>
    [DataContract]
    public partial class DeleteRetention :  IEquatable<DeleteRetention>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRetention" /> class.
        /// </summary>
        /// <param name="Days">Days.</param>
        public DeleteRetention(int? Days = null)
        {
            this.Days = Days;
            
        }
        


        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public int? Days { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRetention {\n");

            sb.Append("  Days: ").Append(Days).Append("\n");
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
            return this.Equals(obj as DeleteRetention);
        }

        /// <summary>
        /// Returns true if DeleteRetention instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteRetention to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRetention other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Days == other.Days ||
                    this.Days != null &&
                    this.Days.Equals(other.Days)
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
                if (this.Days != null)
                    hash = hash * 59 + this.Days.GetHashCode();

                return hash;
            }
        }
    }

}
