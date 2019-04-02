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
    /// WeekShiftTradeResponse
    /// </summary>
    [DataContract]
    public partial class WeekShiftTradeResponse :  IEquatable<WeekShiftTradeResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WeekShiftTradeResponse" /> class.
        /// </summary>
        /// <param name="Trade">The shift trade details.</param>
        /// <param name="MatchReview">A preview of what the schedule would look like if the shift trade is approved plus any violations.</param>
        public WeekShiftTradeResponse(ShiftTradeResponse Trade = null, ShiftTradeMatchReviewResponse MatchReview = null)
        {
            this.Trade = Trade;
            this.MatchReview = MatchReview;
            
        }
        
        
        
        /// <summary>
        /// The shift trade details
        /// </summary>
        /// <value>The shift trade details</value>
        [DataMember(Name="trade", EmitDefaultValue=false)]
        public ShiftTradeResponse Trade { get; set; }
        
        
        
        /// <summary>
        /// A preview of what the schedule would look like if the shift trade is approved plus any violations
        /// </summary>
        /// <value>A preview of what the schedule would look like if the shift trade is approved plus any violations</value>
        [DataMember(Name="matchReview", EmitDefaultValue=false)]
        public ShiftTradeMatchReviewResponse MatchReview { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeekShiftTradeResponse {\n");
            
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  MatchReview: ").Append(MatchReview).Append("\n");
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
            return this.Equals(obj as WeekShiftTradeResponse);
        }

        /// <summary>
        /// Returns true if WeekShiftTradeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WeekShiftTradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeekShiftTradeResponse other)
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
                    this.MatchReview == other.MatchReview ||
                    this.MatchReview != null &&
                    this.MatchReview.Equals(other.MatchReview)
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
                
                if (this.MatchReview != null)
                    hash = hash * 59 + this.MatchReview.GetHashCode();
                
                return hash;
            }
        }
    }

}
