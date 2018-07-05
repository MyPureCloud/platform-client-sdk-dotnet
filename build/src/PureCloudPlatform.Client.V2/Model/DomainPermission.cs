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
    /// DomainPermission
    /// </summary>
    [DataContract]
    public partial class DomainPermission :  IEquatable<DomainPermission>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPermission" /> class.
        /// </summary>
        /// <param name="Domain">Domain.</param>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="Action">Action.</param>
        /// <param name="Label">Label.</param>
        /// <param name="AllowsConditions">AllowsConditions.</param>
        /// <param name="DivisionAware">DivisionAware.</param>
        public DomainPermission(string Domain = null, string EntityType = null, string Action = null, string Label = null, bool? AllowsConditions = null, bool? DivisionAware = null)
        {
            this.Domain = Domain;
            this.EntityType = EntityType;
            this.Action = Action;
            this.Label = Label;
            this.AllowsConditions = AllowsConditions;
            this.DivisionAware = DivisionAware;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AllowsConditions
        /// </summary>
        [DataMember(Name="allowsConditions", EmitDefaultValue=false)]
        public bool? AllowsConditions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DivisionAware
        /// </summary>
        [DataMember(Name="divisionAware", EmitDefaultValue=false)]
        public bool? DivisionAware { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPermission {\n");
            
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  AllowsConditions: ").Append(AllowsConditions).Append("\n");
            sb.Append("  DivisionAware: ").Append(DivisionAware).Append("\n");
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
            return this.Equals(obj as DomainPermission);
        }

        /// <summary>
        /// Returns true if DomainPermission instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPermission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) &&
                (
                    this.AllowsConditions == other.AllowsConditions ||
                    this.AllowsConditions != null &&
                    this.AllowsConditions.Equals(other.AllowsConditions)
                ) &&
                (
                    this.DivisionAware == other.DivisionAware ||
                    this.DivisionAware != null &&
                    this.DivisionAware.Equals(other.DivisionAware)
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
                
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                
                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                if (this.AllowsConditions != null)
                    hash = hash * 59 + this.AllowsConditions.GetHashCode();
                
                if (this.DivisionAware != null)
                    hash = hash * 59 + this.DivisionAware.GetHashCode();
                
                return hash;
            }
        }
    }

}
