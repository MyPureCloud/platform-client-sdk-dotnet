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
    /// ShiftTradeMatchReviewResponse
    /// </summary>
    [DataContract]
    public partial class ShiftTradeMatchReviewResponse :  IEquatable<ShiftTradeMatchReviewResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeMatchReviewResponse" /> class.
        /// </summary>
        /// <param name="InitiatingUser">Details for the initiatingUser side of the shift trade.</param>
        /// <param name="ReceivingUser">Details for the receivingUser side of the shift trade.</param>
        /// <param name="Violations">Constraint violations introduced after being matched that would normally disallow a trade, but which can still be overridden by the shift trade administrator.</param>
        /// <param name="AdminReviewViolations">Constraint violations associated with this shift trade which require shift trade administrator review.</param>
        public ShiftTradeMatchReviewResponse(ShiftTradeMatchReviewUserResponse InitiatingUser = null, ShiftTradeMatchReviewUserResponse ReceivingUser = null, List<ShiftTradeMatchViolation> Violations = null, List<ShiftTradeMatchViolation> AdminReviewViolations = null)
        {
            this.InitiatingUser = InitiatingUser;
            this.ReceivingUser = ReceivingUser;
            this.Violations = Violations;
            this.AdminReviewViolations = AdminReviewViolations;
            
        }
        
        
        
        /// <summary>
        /// Details for the initiatingUser side of the shift trade
        /// </summary>
        /// <value>Details for the initiatingUser side of the shift trade</value>
        [DataMember(Name="initiatingUser", EmitDefaultValue=false)]
        public ShiftTradeMatchReviewUserResponse InitiatingUser { get; set; }
        
        
        
        /// <summary>
        /// Details for the receivingUser side of the shift trade
        /// </summary>
        /// <value>Details for the receivingUser side of the shift trade</value>
        [DataMember(Name="receivingUser", EmitDefaultValue=false)]
        public ShiftTradeMatchReviewUserResponse ReceivingUser { get; set; }
        
        
        
        /// <summary>
        /// Constraint violations introduced after being matched that would normally disallow a trade, but which can still be overridden by the shift trade administrator
        /// </summary>
        /// <value>Constraint violations introduced after being matched that would normally disallow a trade, but which can still be overridden by the shift trade administrator</value>
        [DataMember(Name="violations", EmitDefaultValue=false)]
        public List<ShiftTradeMatchViolation> Violations { get; set; }
        
        
        
        /// <summary>
        /// Constraint violations associated with this shift trade which require shift trade administrator review
        /// </summary>
        /// <value>Constraint violations associated with this shift trade which require shift trade administrator review</value>
        [DataMember(Name="adminReviewViolations", EmitDefaultValue=false)]
        public List<ShiftTradeMatchViolation> AdminReviewViolations { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeMatchReviewResponse {\n");
            
            sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
            sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
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
            return this.Equals(obj as ShiftTradeMatchReviewResponse);
        }

        /// <summary>
        /// Returns true if ShiftTradeMatchReviewResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeMatchReviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeMatchReviewResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.InitiatingUser == other.InitiatingUser ||
                    this.InitiatingUser != null &&
                    this.InitiatingUser.Equals(other.InitiatingUser)
                ) &&
                (
                    this.ReceivingUser == other.ReceivingUser ||
                    this.ReceivingUser != null &&
                    this.ReceivingUser.Equals(other.ReceivingUser)
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
                
                if (this.InitiatingUser != null)
                    hash = hash * 59 + this.InitiatingUser.GetHashCode();
                
                if (this.ReceivingUser != null)
                    hash = hash * 59 + this.ReceivingUser.GetHashCode();
                
                if (this.Violations != null)
                    hash = hash * 59 + this.Violations.GetHashCode();
                
                if (this.AdminReviewViolations != null)
                    hash = hash * 59 + this.AdminReviewViolations.GetHashCode();
                
                return hash;
            }
        }
    }

}
