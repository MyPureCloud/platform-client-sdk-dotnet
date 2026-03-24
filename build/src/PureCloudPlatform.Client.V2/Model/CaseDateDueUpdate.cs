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
    /// CaseDateDueUpdate
    /// </summary>
    [DataContract]
    public partial class CaseDateDueUpdate :  IEquatable<CaseDateDueUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseDateDueUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseDateDueUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseDateDueUpdate" /> class.
        /// </summary>
        /// <param name="DateDue">The due date of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public CaseDateDueUpdate(DateTime? DateDue = null)
        {
            this.DateDue = DateDue;
            
        }
        


        /// <summary>
        /// The due date of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The due date of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDue", EmitDefaultValue=false)]
        public DateTime? DateDue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseDateDueUpdate {\n");

            sb.Append("  DateDue: ").Append(DateDue).Append("\n");
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
            return this.Equals(obj as CaseDateDueUpdate);
        }

        /// <summary>
        /// Returns true if CaseDateDueUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseDateDueUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseDateDueUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateDue == other.DateDue ||
                    this.DateDue != null &&
                    this.DateDue.Equals(other.DateDue)
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
                if (this.DateDue != null)
                    hash = hash * 59 + this.DateDue.GetHashCode();

                return hash;
            }
        }
    }

}
