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
    /// PatchActionTarget
    /// </summary>
    [DataContract]
    public partial class PatchActionTarget :  IEquatable<PatchActionTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchActionTarget" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ServiceLevel">Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level..</param>
        /// <param name="ShortAbandonThreshold">Indicates the non-default short abandon threshold.</param>
        public PatchActionTarget(string Name = null, ServiceLevel ServiceLevel = null, int? ShortAbandonThreshold = null)
        {
            this.Name = Name;
            this.ServiceLevel = ServiceLevel;
            this.ShortAbandonThreshold = ShortAbandonThreshold;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.
        /// </summary>
        /// <value>Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.</value>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public ServiceLevel ServiceLevel { get; set; }



        /// <summary>
        /// Indicates the non-default short abandon threshold
        /// </summary>
        /// <value>Indicates the non-default short abandon threshold</value>
        [DataMember(Name="shortAbandonThreshold", EmitDefaultValue=false)]
        public int? ShortAbandonThreshold { get; set; }



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
            sb.Append("class PatchActionTarget {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  ShortAbandonThreshold: ").Append(ShortAbandonThreshold).Append("\n");
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
            return this.Equals(obj as PatchActionTarget);
        }

        /// <summary>
        /// Returns true if PatchActionTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchActionTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchActionTarget other)
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
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
                ) &&
                (
                    this.ShortAbandonThreshold == other.ShortAbandonThreshold ||
                    this.ShortAbandonThreshold != null &&
                    this.ShortAbandonThreshold.Equals(other.ShortAbandonThreshold)
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

                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();

                if (this.ShortAbandonThreshold != null)
                    hash = hash * 59 + this.ShortAbandonThreshold.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
