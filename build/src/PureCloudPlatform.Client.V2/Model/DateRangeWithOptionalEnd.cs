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
    /// DateRangeWithOptionalEnd
    /// </summary>
    [DataContract]
    public partial class DateRangeWithOptionalEnd :  IEquatable<DateRangeWithOptionalEnd>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRangeWithOptionalEnd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DateRangeWithOptionalEnd() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRangeWithOptionalEnd" /> class.
        /// </summary>
        /// <param name="StartBusinessUnitDate">The start date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="EndBusinessUnitDate">The end date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Null denotes open ended date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        public DateRangeWithOptionalEnd(DateTime? StartBusinessUnitDate = null, DateTime? EndBusinessUnitDate = null)
        {
            this.StartBusinessUnitDate = StartBusinessUnitDate;
            this.EndBusinessUnitDate = EndBusinessUnitDate;
            
        }
        
        
        
        /// <summary>
        /// The start date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="startBusinessUnitDate", EmitDefaultValue=false)]
        public DateTime? StartBusinessUnitDate { get; set; }
        
        
        
        /// <summary>
        /// The end date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Null denotes open ended date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end date for work plan rotation or an agent, interpreted in the business unit&#39;s time zone. Null denotes open ended date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="endBusinessUnitDate", EmitDefaultValue=false)]
        public DateTime? EndBusinessUnitDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateRangeWithOptionalEnd {\n");
            
            sb.Append("  StartBusinessUnitDate: ").Append(StartBusinessUnitDate).Append("\n");
            sb.Append("  EndBusinessUnitDate: ").Append(EndBusinessUnitDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DateRangeWithOptionalEnd);
        }

        /// <summary>
        /// Returns true if DateRangeWithOptionalEnd instances are equal
        /// </summary>
        /// <param name="other">Instance of DateRangeWithOptionalEnd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateRangeWithOptionalEnd other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartBusinessUnitDate == other.StartBusinessUnitDate ||
                    this.StartBusinessUnitDate != null &&
                    this.StartBusinessUnitDate.Equals(other.StartBusinessUnitDate)
                ) &&
                (
                    this.EndBusinessUnitDate == other.EndBusinessUnitDate ||
                    this.EndBusinessUnitDate != null &&
                    this.EndBusinessUnitDate.Equals(other.EndBusinessUnitDate)
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
                
                if (this.StartBusinessUnitDate != null)
                    hash = hash * 59 + this.StartBusinessUnitDate.GetHashCode();
                
                if (this.EndBusinessUnitDate != null)
                    hash = hash * 59 + this.EndBusinessUnitDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
