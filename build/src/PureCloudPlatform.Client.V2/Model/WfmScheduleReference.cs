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
    /// WfmScheduleReference
    /// </summary>
    [DataContract]
    public partial class WfmScheduleReference :  IEquatable<WfmScheduleReference>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmScheduleReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmScheduleReference() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmScheduleReference" /> class.
        /// </summary>
        /// <param name="Id">The ID of the WFM schedule (required).</param>
        /// <param name="BusinessUnit">A reference to a Workforce Management Business Unit (required).</param>
        /// <param name="WeekDate">The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        public WfmScheduleReference(string Id = null, WfmBusinessUnitReference BusinessUnit = null, DateTime? WeekDate = null)
        {
            this.Id = Id;
            this.BusinessUnit = BusinessUnit;
            this.WeekDate = WeekDate;
            
        }
        
        
        
        /// <summary>
        /// The ID of the WFM schedule
        /// </summary>
        /// <value>The ID of the WFM schedule</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// A reference to a Workforce Management Business Unit
        /// </summary>
        /// <value>A reference to a Workforce Management Business Unit</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public WfmBusinessUnitReference BusinessUnit { get; set; }
        
        
        
        /// <summary>
        /// The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public DateTime? WeekDate { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmScheduleReference {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as WfmScheduleReference);
        }

        /// <summary>
        /// Returns true if WfmScheduleReference instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmScheduleReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmScheduleReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
                ) &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();
                
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
