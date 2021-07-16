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
    /// MatchShiftTradeResponse
    /// </summary>
    [DataContract]
    public partial class MatchShiftTradeResponse :  IEquatable<MatchShiftTradeResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchShiftTradeResponse" /> class.
        /// </summary>
        /// <param name="Trade">The associated shift trade.</param>
        /// <param name="Violations">Constraint violations which disallow this shift trade.</param>
        /// <param name="AdminReviewViolations">Constraint violations for this shift trade which require shift trade administrator review.</param>
        public MatchShiftTradeResponse(ShiftTradeResponse Trade = null, List<ShiftTradeMatchViolation> Violations = null, List<ShiftTradeMatchViolation> AdminReviewViolations = null)
        {
            this.Trade = Trade;
            this.Violations = Violations;
            this.AdminReviewViolations = AdminReviewViolations;
            
        }
        
        
        
        /// <summary>
        /// The associated shift trade
        /// </summary>
        /// <value>The associated shift trade</value>
        [DataMember(Name="trade", EmitDefaultValue=false)]
        public ShiftTradeResponse Trade { get; set; }
        
        
        
        /// <summary>
        /// Constraint violations which disallow this shift trade
        /// </summary>
        /// <value>Constraint violations which disallow this shift trade</value>
        [DataMember(Name="violations", EmitDefaultValue=false)]
        public List<ShiftTradeMatchViolation> Violations { get; set; }
        
        
        
        /// <summary>
        /// Constraint violations for this shift trade which require shift trade administrator review
        /// </summary>
        /// <value>Constraint violations for this shift trade which require shift trade administrator review</value>
        [DataMember(Name="adminReviewViolations", EmitDefaultValue=false)]
        public List<ShiftTradeMatchViolation> AdminReviewViolations { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchShiftTradeResponse {\n");
            
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  Violations: ").Append(Violations).Append("\n");
            sb.Append("  AdminReviewViolations: ").Append(AdminReviewViolations).Append("\n");
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
            return this.Equals(obj as MatchShiftTradeResponse);
        }

        /// <summary>
        /// Returns true if MatchShiftTradeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchShiftTradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchShiftTradeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Trade == other.Trade ||
                    this.Trade != null &&
                    this.Trade.Equals(other.Trade)
                ) &&
                (
                    this.Violations == other.Violations ||
                    this.Violations != null &&
                    this.Violations.SequenceEqual(other.Violations)
                ) &&
                (
                    this.AdminReviewViolations == other.AdminReviewViolations ||
                    this.AdminReviewViolations != null &&
                    this.AdminReviewViolations.SequenceEqual(other.AdminReviewViolations)
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
                
                if (this.Trade != null)
                    hash = hash * 59 + this.Trade.GetHashCode();
                
                if (this.Violations != null)
                    hash = hash * 59 + this.Violations.GetHashCode();
                
                if (this.AdminReviewViolations != null)
                    hash = hash * 59 + this.AdminReviewViolations.GetHashCode();
                
                return hash;
            }
        }
    }

}
