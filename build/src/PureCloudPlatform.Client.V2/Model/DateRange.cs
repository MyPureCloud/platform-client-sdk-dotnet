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
    /// DateRange
    /// </summary>
    [DataContract]
    public partial class DateRange :  IEquatable<DateRange>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRange" /> class.
        /// </summary>
        /// <param name="StartDate">The inclusive start of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone..</param>
        /// <param name="EndDate">The inclusive end of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone..</param>
        public DateRange(string StartDate = null, string EndDate = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            
        }
        
        
        
        /// <summary>
        /// The inclusive start of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.
        /// </summary>
        /// <value>The inclusive start of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }
        
        
        
        /// <summary>
        /// The inclusive end of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.
        /// </summary>
        /// <value>The inclusive end of a date range in yyyy-MM-dd format. Should be interpreted in the management unit&#39;s configured time zone.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateRange {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as DateRange);
        }

        /// <summary>
        /// Returns true if DateRange instances are equal
        /// </summary>
        /// <param name="other">Instance of DateRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
