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
    /// ShiftTradePreviewResponse
    /// </summary>
    [DataContract]
    public partial class ShiftTradePreviewResponse :  IEquatable<ShiftTradePreviewResponse>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradePreviewResponse" /> class.
        /// </summary>
        /// <param name="Activities">List of activities that will make up the new shift if this shift trade is approved.</param>
        public ShiftTradePreviewResponse(List<ShiftTradeActivityPreviewResponse> Activities = null)
        {
            this.Activities = Activities;
            
        }
        
        
        
        /// <summary>
        /// List of activities that will make up the new shift if this shift trade is approved
        /// </summary>
        /// <value>List of activities that will make up the new shift if this shift trade is approved</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<ShiftTradeActivityPreviewResponse> Activities { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradePreviewResponse {\n");
            
            sb.Append("  Activities: ").Append(Activities).Append("\n");
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
            return this.Equals(obj as ShiftTradePreviewResponse);
        }

        /// <summary>
        /// Returns true if ShiftTradePreviewResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradePreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradePreviewResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
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
                
                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();
                
                return hash;
            }
        }
    }

}
