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
    /// Service goal abandon rate configuration
    /// </summary>
    [DataContract]
    public partial class BuAbandonRate :  IEquatable<BuAbandonRate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuAbandonRate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuAbandonRate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAbandonRate" /> class.
        /// </summary>
        /// <param name="Include">Whether to include abandon rate in the associated configuration (required).</param>
        /// <param name="Percent">Abandon rate percent goal. Required if include == true.</param>
        public BuAbandonRate(bool? Include = null, int? Percent = null)
        {
            this.Include = Include;
            this.Percent = Percent;
            
        }
        


        /// <summary>
        /// Whether to include abandon rate in the associated configuration
        /// </summary>
        /// <value>Whether to include abandon rate in the associated configuration</value>
        [DataMember(Name="include", EmitDefaultValue=false)]
        public bool? Include { get; set; }



        /// <summary>
        /// Abandon rate percent goal. Required if include == true
        /// </summary>
        /// <value>Abandon rate percent goal. Required if include == true</value>
        [DataMember(Name="percent", EmitDefaultValue=false)]
        public int? Percent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAbandonRate {\n");

            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
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
            return this.Equals(obj as BuAbandonRate);
        }

        /// <summary>
        /// Returns true if BuAbandonRate instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAbandonRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAbandonRate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Include == other.Include ||
                    this.Include != null &&
                    this.Include.Equals(other.Include)
                ) &&
                (
                    this.Percent == other.Percent ||
                    this.Percent != null &&
                    this.Percent.Equals(other.Percent)
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
                if (this.Include != null)
                    hash = hash * 59 + this.Include.GetHashCode();

                if (this.Percent != null)
                    hash = hash * 59 + this.Percent.GetHashCode();

                return hash;
            }
        }
    }

}
