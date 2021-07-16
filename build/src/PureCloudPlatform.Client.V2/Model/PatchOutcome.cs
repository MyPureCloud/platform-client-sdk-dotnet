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
    /// PatchOutcome
    /// </summary>
    [DataContract]
    public partial class PatchOutcome :  IEquatable<PatchOutcome>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOutcome" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchOutcome() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOutcome" /> class.
        /// </summary>
        /// <param name="IsActive">Whether or not the outcome is active..</param>
        /// <param name="DisplayName">The display name of the outcome. (required).</param>
        /// <param name="Version">The version of the outcome..</param>
        /// <param name="Description">A description of the outcome..</param>
        /// <param name="IsPositive">Whether or not the outcome is positive..</param>
        /// <param name="Context">The context of the outcome..</param>
        /// <param name="Journey">The pattern of rules defining the filter of the outcome..</param>
        /// <param name="CreatedDate">Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedDate">Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public PatchOutcome(bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, bool? IsPositive = null, Context Context = null, Journey Journey = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null)
        {
            this.IsActive = IsActive;
            this.DisplayName = DisplayName;
            this.Version = Version;
            this.Description = Description;
            this.IsPositive = IsPositive;
            this.Context = Context;
            this.Journey = Journey;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Whether or not the outcome is active.
        /// </summary>
        /// <value>Whether or not the outcome is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
        
        
        
        /// <summary>
        /// The display name of the outcome.
        /// </summary>
        /// <value>The display name of the outcome.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        
        /// <summary>
        /// The version of the outcome.
        /// </summary>
        /// <value>The version of the outcome.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// A description of the outcome.
        /// </summary>
        /// <value>A description of the outcome.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Whether or not the outcome is positive.
        /// </summary>
        /// <value>Whether or not the outcome is positive.</value>
        [DataMember(Name="isPositive", EmitDefaultValue=false)]
        public bool? IsPositive { get; set; }
        
        
        
        /// <summary>
        /// The context of the outcome.
        /// </summary>
        /// <value>The context of the outcome.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public Context Context { get; set; }
        
        
        
        /// <summary>
        /// The pattern of rules defining the filter of the outcome.
        /// </summary>
        /// <value>The pattern of rules defining the filter of the outcome.</value>
        [DataMember(Name="journey", EmitDefaultValue=false)]
        public Journey Journey { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchOutcome {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Journey: ").Append(Journey).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as PatchOutcome);
        }

        /// <summary>
        /// Returns true if PatchOutcome instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchOutcome to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchOutcome other)
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
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.IsPositive == other.IsPositive ||
                    this.IsPositive != null &&
                    this.IsPositive.Equals(other.IsPositive)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) &&
                (
                    this.Journey == other.Journey ||
                    this.Journey != null &&
                    this.Journey.Equals(other.Journey)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.IsPositive != null)
                    hash = hash * 59 + this.IsPositive.GetHashCode();
                
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                
                if (this.Journey != null)
                    hash = hash * 59 + this.Journey.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
