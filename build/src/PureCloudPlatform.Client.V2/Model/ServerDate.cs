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
    /// ServerDate
    /// </summary>
    [DataContract]
    public partial class ServerDate :  IEquatable<ServerDate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerDate" /> class.
        /// </summary>
        /// <param name="CurrentDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ServerDate(DateTime? CurrentDate = null)
        {
            this.CurrentDate = CurrentDate;
            
        }
        


        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="currentDate", EmitDefaultValue=false)]
        public DateTime? CurrentDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerDate {\n");

            sb.Append("  CurrentDate: ").Append(CurrentDate).Append("\n");
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
            return this.Equals(obj as ServerDate);
        }

        /// <summary>
        /// Returns true if ServerDate instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerDate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CurrentDate == other.CurrentDate ||
                    this.CurrentDate != null &&
                    this.CurrentDate.Equals(other.CurrentDate)
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
                if (this.CurrentDate != null)
                    hash = hash * 59 + this.CurrentDate.GetHashCode();

                return hash;
            }
        }
    }

}
