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
    /// UpdateAgentRequest
    /// </summary>
    [DataContract]
    public partial class UpdateAgentRequest :  IEquatable<UpdateAgentRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="AcceptDirectShiftTrades">Whether the agent accepts direct shift trades.</param>
        public UpdateAgentRequest(bool? AcceptDirectShiftTrades = null)
        {
            this.AcceptDirectShiftTrades = AcceptDirectShiftTrades;
            
        }
        
        
        
        /// <summary>
        /// Whether the agent accepts direct shift trades
        /// </summary>
        /// <value>Whether the agent accepts direct shift trades</value>
        [DataMember(Name="acceptDirectShiftTrades", EmitDefaultValue=false)]
        public bool? AcceptDirectShiftTrades { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgentRequest {\n");
            
            sb.Append("  AcceptDirectShiftTrades: ").Append(AcceptDirectShiftTrades).Append("\n");
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
            return this.Equals(obj as UpdateAgentRequest);
        }

        /// <summary>
        /// Returns true if UpdateAgentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAgentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAgentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AcceptDirectShiftTrades == other.AcceptDirectShiftTrades ||
                    this.AcceptDirectShiftTrades != null &&
                    this.AcceptDirectShiftTrades.Equals(other.AcceptDirectShiftTrades)
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
                
                if (this.AcceptDirectShiftTrades != null)
                    hash = hash * 59 + this.AcceptDirectShiftTrades.GetHashCode();
                
                return hash;
            }
        }
    }

}
