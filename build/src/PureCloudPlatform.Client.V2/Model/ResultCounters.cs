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
    /// ResultCounters
    /// </summary>
    [DataContract]
    public partial class ResultCounters :  IEquatable<ResultCounters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultCounters" /> class.
        /// </summary>
        /// <param name="Success">Success.</param>
        /// <param name="Failure">Failure.</param>
        public ResultCounters(int? Success = null, int? Failure = null)
        {
            this.Success = Success;
            this.Failure = Failure;
            
        }
        


        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public int? Success { get; set; }



        /// <summary>
        /// Gets or Sets Failure
        /// </summary>
        [DataMember(Name="failure", EmitDefaultValue=false)]
        public int? Failure { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultCounters {\n");

            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
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
            return this.Equals(obj as ResultCounters);
        }

        /// <summary>
        /// Returns true if ResultCounters instances are equal
        /// </summary>
        /// <param name="other">Instance of ResultCounters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultCounters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) &&
                (
                    this.Failure == other.Failure ||
                    this.Failure != null &&
                    this.Failure.Equals(other.Failure)
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
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();

                if (this.Failure != null)
                    hash = hash * 59 + this.Failure.GetHashCode();

                return hash;
            }
        }
    }

}
