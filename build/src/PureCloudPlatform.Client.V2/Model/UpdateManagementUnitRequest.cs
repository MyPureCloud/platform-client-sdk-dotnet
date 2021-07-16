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
    /// UpdateManagementUnitRequest
    /// </summary>
    [DataContract]
    public partial class UpdateManagementUnitRequest :  IEquatable<UpdateManagementUnitRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagementUnitRequest" /> class.
        /// </summary>
        /// <param name="Name">The new name of the management unit.</param>
        /// <param name="DivisionId">The new division id for the management unit.</param>
        /// <param name="Settings">Updated settings for the management unit.</param>
        public UpdateManagementUnitRequest(string Name = null, string DivisionId = null, ManagementUnitSettingsRequest Settings = null)
        {
            this.Name = Name;
            this.DivisionId = DivisionId;
            this.Settings = Settings;
            
        }
        
        
        
        /// <summary>
        /// The new name of the management unit
        /// </summary>
        /// <value>The new name of the management unit</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The new division id for the management unit
        /// </summary>
        /// <value>The new division id for the management unit</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }
        
        
        
        /// <summary>
        /// Updated settings for the management unit
        /// </summary>
        /// <value>Updated settings for the management unit</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public ManagementUnitSettingsRequest Settings { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateManagementUnitRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(obj as UpdateManagementUnitRequest);
        }

        /// <summary>
        /// Returns true if UpdateManagementUnitRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateManagementUnitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateManagementUnitRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();
                
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                
                return hash;
            }
        }
    }

}
