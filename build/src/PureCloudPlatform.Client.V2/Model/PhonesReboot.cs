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
    /// PhonesReboot
    /// </summary>
    [DataContract]
    public partial class PhonesReboot :  IEquatable<PhonesReboot>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhonesReboot" /> class.
        /// </summary>
        
        
        /// <param name="PhoneIds">The list of phone Ids to reboot..</param>
        
        
        
        /// <param name="SiteId">ID of the site for which to reboot all phones at that site. no.active.edge and phone.cannot.resolve errors are ignored..</param>
        
        
        public PhonesReboot(List<string> PhoneIds = null, string SiteId = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.PhoneIds = PhoneIds;
            
            
            
            
            
            
            
            
this.SiteId = SiteId;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The list of phone Ids to reboot.
        /// </summary>
        /// <value>The list of phone Ids to reboot.</value>
        [DataMember(Name="phoneIds", EmitDefaultValue=false)]
        public List<string> PhoneIds { get; set; }
        
        
        
        /// <summary>
        /// ID of the site for which to reboot all phones at that site. no.active.edge and phone.cannot.resolve errors are ignored.
        /// </summary>
        /// <value>ID of the site for which to reboot all phones at that site. no.active.edge and phone.cannot.resolve errors are ignored.</value>
        [DataMember(Name="siteId", EmitDefaultValue=false)]
        public string SiteId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhonesReboot {\n");
            
            sb.Append("  PhoneIds: ").Append(PhoneIds).Append("\n");
            
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            
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
            return this.Equals(obj as PhonesReboot);
        }

        /// <summary>
        /// Returns true if PhonesReboot instances are equal
        /// </summary>
        /// <param name="other">Instance of PhonesReboot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhonesReboot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PhoneIds == other.PhoneIds ||
                    this.PhoneIds != null &&
                    this.PhoneIds.SequenceEqual(other.PhoneIds)
                ) &&
                (
                    this.SiteId == other.SiteId ||
                    this.SiteId != null &&
                    this.SiteId.Equals(other.SiteId)
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
                
                if (this.PhoneIds != null)
                    hash = hash * 59 + this.PhoneIds.GetHashCode();
                
                if (this.SiteId != null)
                    hash = hash * 59 + this.SiteId.GetHashCode();
                
                return hash;
            }
        }
    }

}
