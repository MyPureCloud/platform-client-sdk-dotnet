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
    /// UpdateVerifierRequest
    /// </summary>
    [DataContract]
    public partial class UpdateVerifierRequest :  IEquatable<UpdateVerifierRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVerifierRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the verifier..</param>
        /// <param name="Enabled">Indicates whether this verifier will be enabled..</param>
        /// <param name="Default">Indicates whether this will be the default verifier..</param>
        public UpdateVerifierRequest(string Name = null, bool? Enabled = null, bool? Default = null)
        {
            this.Name = Name;
            this.Enabled = Enabled;
            this.Default = Default;
            
        }
        


        /// <summary>
        /// The name of the verifier.
        /// </summary>
        /// <value>The name of the verifier.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Indicates whether this verifier will be enabled.
        /// </summary>
        /// <value>Indicates whether this verifier will be enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Indicates whether this will be the default verifier.
        /// </summary>
        /// <value>Indicates whether this will be the default verifier.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVerifierRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(obj as UpdateVerifierRequest);
        }

        /// <summary>
        /// Returns true if UpdateVerifierRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateVerifierRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVerifierRequest other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Default == other.Default ||
                    this.Default != null &&
                    this.Default.Equals(other.Default)
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

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Default != null)
                    hash = hash * 59 + this.Default.GetHashCode();

                return hash;
            }
        }
    }

}
