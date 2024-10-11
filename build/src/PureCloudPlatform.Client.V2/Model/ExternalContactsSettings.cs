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
    /// ExternalContactsSettings
    /// </summary>
    [DataContract]
    public partial class ExternalContactsSettings :  IEquatable<ExternalContactsSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsSettings" /> class.
        /// </summary>
        /// <param name="ManuallyAssignDivisionsToInteractions">ManuallyAssignDivisionsToInteractions.</param>
        /// <param name="ManuallyAssignDivisionsToContacts">ManuallyAssignDivisionsToContacts.</param>
        public ExternalContactsSettings(bool? ManuallyAssignDivisionsToInteractions = null, bool? ManuallyAssignDivisionsToContacts = null)
        {
            this.ManuallyAssignDivisionsToInteractions = ManuallyAssignDivisionsToInteractions;
            this.ManuallyAssignDivisionsToContacts = ManuallyAssignDivisionsToContacts;
            
        }
        


        /// <summary>
        /// Gets or Sets ManuallyAssignDivisionsToInteractions
        /// </summary>
        [DataMember(Name="manuallyAssignDivisionsToInteractions", EmitDefaultValue=false)]
        public bool? ManuallyAssignDivisionsToInteractions { get; set; }



        /// <summary>
        /// Gets or Sets ManuallyAssignDivisionsToContacts
        /// </summary>
        [DataMember(Name="manuallyAssignDivisionsToContacts", EmitDefaultValue=false)]
        public bool? ManuallyAssignDivisionsToContacts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsSettings {\n");

            sb.Append("  ManuallyAssignDivisionsToInteractions: ").Append(ManuallyAssignDivisionsToInteractions).Append("\n");
            sb.Append("  ManuallyAssignDivisionsToContacts: ").Append(ManuallyAssignDivisionsToContacts).Append("\n");
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
            return this.Equals(obj as ExternalContactsSettings);
        }

        /// <summary>
        /// Returns true if ExternalContactsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManuallyAssignDivisionsToInteractions == other.ManuallyAssignDivisionsToInteractions ||
                    this.ManuallyAssignDivisionsToInteractions != null &&
                    this.ManuallyAssignDivisionsToInteractions.Equals(other.ManuallyAssignDivisionsToInteractions)
                ) &&
                (
                    this.ManuallyAssignDivisionsToContacts == other.ManuallyAssignDivisionsToContacts ||
                    this.ManuallyAssignDivisionsToContacts != null &&
                    this.ManuallyAssignDivisionsToContacts.Equals(other.ManuallyAssignDivisionsToContacts)
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
                if (this.ManuallyAssignDivisionsToInteractions != null)
                    hash = hash * 59 + this.ManuallyAssignDivisionsToInteractions.GetHashCode();

                if (this.ManuallyAssignDivisionsToContacts != null)
                    hash = hash * 59 + this.ManuallyAssignDivisionsToContacts.GetHashCode();

                return hash;
            }
        }
    }

}
