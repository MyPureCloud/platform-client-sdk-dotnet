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
    /// Represents the marketing information that may be associated with a listing
    /// </summary>
    [DataContract]
    public partial class MarketingInfo :  IEquatable<MarketingInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingInfo" /> class.
        /// </summary>
        
        
        /// <param name="CampaignId">The marketing campaign ID.</param>
        
        
        
        /// <param name="FormId">The ID of an associated marketing form.</param>
        
        
        public MarketingInfo(string CampaignId = null, string FormId = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.CampaignId = CampaignId;
            
            
            
            
            
            
            
            
this.FormId = FormId;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The marketing campaign ID
        /// </summary>
        /// <value>The marketing campaign ID</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }
        
        
        
        /// <summary>
        /// The ID of an associated marketing form
        /// </summary>
        /// <value>The ID of an associated marketing form</value>
        [DataMember(Name="formId", EmitDefaultValue=false)]
        public string FormId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketingInfo {\n");
            
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            
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
            return this.Equals(obj as MarketingInfo);
        }

        /// <summary>
        /// Returns true if MarketingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CampaignId == other.CampaignId ||
                    this.CampaignId != null &&
                    this.CampaignId.Equals(other.CampaignId)
                ) &&
                (
                    this.FormId == other.FormId ||
                    this.FormId != null &&
                    this.FormId.Equals(other.FormId)
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
                
                if (this.CampaignId != null)
                    hash = hash * 59 + this.CampaignId.GetHashCode();
                
                if (this.FormId != null)
                    hash = hash * 59 + this.FormId.GetHashCode();
                
                return hash;
            }
        }
    }

}
