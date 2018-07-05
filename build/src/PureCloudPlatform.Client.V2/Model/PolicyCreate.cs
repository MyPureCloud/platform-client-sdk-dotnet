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
    /// PolicyCreate
    /// </summary>
    [DataContract]
    public partial class PolicyCreate :  IEquatable<PolicyCreate>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyCreate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCreate" /> class.
        /// </summary>
        /// <param name="Name">The policy name. (required).</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="MediaPolicies">Conditions and actions per media type.</param>
        /// <param name="Conditions">Conditions.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="PolicyErrors">PolicyErrors.</param>
        public PolicyCreate(string Name = null, DateTime? ModifiedDate = null, DateTime? CreatedDate = null, int? Order = null, string Description = null, bool? Enabled = null, MediaPolicies MediaPolicies = null, PolicyConditions Conditions = null, PolicyActions Actions = null, PolicyErrors PolicyErrors = null)
        {
            this.ModifiedDate = ModifiedDate;
            this.CreatedDate = CreatedDate;
            this.Order = Order;
            this.Description = Description;
            this.Enabled = Enabled;
            this.MediaPolicies = MediaPolicies;
            this.Conditions = Conditions;
            this.Actions = Actions;
            this.PolicyErrors = PolicyErrors;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The policy name.
        /// </summary>
        /// <value>The policy name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// Conditions and actions per media type
        /// </summary>
        /// <value>Conditions and actions per media type</value>
        [DataMember(Name="mediaPolicies", EmitDefaultValue=false)]
        public MediaPolicies MediaPolicies { get; set; }
        
        
        
        /// <summary>
        /// Conditions
        /// </summary>
        /// <value>Conditions</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public PolicyConditions Conditions { get; set; }
        
        
        
        /// <summary>
        /// Actions
        /// </summary>
        /// <value>Actions</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public PolicyActions Actions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PolicyErrors
        /// </summary>
        [DataMember(Name="policyErrors", EmitDefaultValue=false)]
        public PolicyErrors PolicyErrors { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyCreate {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MediaPolicies: ").Append(MediaPolicies).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  PolicyErrors: ").Append(PolicyErrors).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as PolicyCreate);
        }

        /// <summary>
        /// Returns true if PolicyCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyCreate other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.MediaPolicies == other.MediaPolicies ||
                    this.MediaPolicies != null &&
                    this.MediaPolicies.Equals(other.MediaPolicies)
                ) &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.Equals(other.Conditions)
                ) &&
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
                ) &&
                (
                    this.PolicyErrors == other.PolicyErrors ||
                    this.PolicyErrors != null &&
                    this.PolicyErrors.Equals(other.PolicyErrors)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.MediaPolicies != null)
                    hash = hash * 59 + this.MediaPolicies.GetHashCode();
                
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                if (this.PolicyErrors != null)
                    hash = hash * 59 + this.PolicyErrors.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
