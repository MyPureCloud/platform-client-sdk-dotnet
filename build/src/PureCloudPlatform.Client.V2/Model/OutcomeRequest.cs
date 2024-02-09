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
    /// OutcomeRequest
    /// </summary>
    [DataContract]
    public partial class OutcomeRequest :  IEquatable<OutcomeRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutcomeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeRequest" /> class.
        /// </summary>
        /// <param name="IsActive">Whether or not the outcome is active..</param>
        /// <param name="DisplayName">The display name of the outcome. (required).</param>
        /// <param name="Version">The version of the outcome..</param>
        /// <param name="Description">A description of the outcome..</param>
        /// <param name="IsPositive">Whether or not the outcome is positive..</param>
        /// <param name="Context">The context of the outcome..</param>
        /// <param name="Journey">The pattern of rules defining the filter of the outcome..</param>
        /// <param name="AssociatedValueField">The field from the event indicating the associated value..</param>
        public OutcomeRequest(bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, bool? IsPositive = null, RequestContext Context = null, RequestJourney Journey = null, AssociatedValueField AssociatedValueField = null)
        {
            this.IsActive = IsActive;
            this.DisplayName = DisplayName;
            this.Version = Version;
            this.Description = Description;
            this.IsPositive = IsPositive;
            this.Context = Context;
            this.Journey = Journey;
            this.AssociatedValueField = AssociatedValueField;
            
        }
        


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
        public RequestContext Context { get; set; }



        /// <summary>
        /// The pattern of rules defining the filter of the outcome.
        /// </summary>
        /// <value>The pattern of rules defining the filter of the outcome.</value>
        [DataMember(Name="journey", EmitDefaultValue=false)]
        public RequestJourney Journey { get; set; }



        /// <summary>
        /// The field from the event indicating the associated value.
        /// </summary>
        /// <value>The field from the event indicating the associated value.</value>
        [DataMember(Name="associatedValueField", EmitDefaultValue=false)]
        public AssociatedValueField AssociatedValueField { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutcomeRequest {\n");

            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Journey: ").Append(Journey).Append("\n");
            sb.Append("  AssociatedValueField: ").Append(AssociatedValueField).Append("\n");
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
            return this.Equals(obj as OutcomeRequest);
        }

        /// <summary>
        /// Returns true if OutcomeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OutcomeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.AssociatedValueField == other.AssociatedValueField ||
                    this.AssociatedValueField != null &&
                    this.AssociatedValueField.Equals(other.AssociatedValueField)
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

                if (this.AssociatedValueField != null)
                    hash = hash * 59 + this.AssociatedValueField.GetHashCode();

                return hash;
            }
        }
    }

}
