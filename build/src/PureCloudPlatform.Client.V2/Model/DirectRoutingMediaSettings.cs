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
    /// DirectRoutingMediaSettings
    /// </summary>
    [DataContract]
    public partial class DirectRoutingMediaSettings :  IEquatable<DirectRoutingMediaSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectRoutingMediaSettings" /> class.
        /// </summary>
        /// <param name="Enabled">Toggle that enables Direct Routing for this media type..</param>
        /// <param name="InboundFlow">The Direct Routing inbound flow id for this media type..</param>
        public DirectRoutingMediaSettings(bool? Enabled = null, AddressableEntityRef InboundFlow = null)
        {
            this.Enabled = Enabled;
            this.InboundFlow = InboundFlow;
            
        }
        


        /// <summary>
        /// Toggle that enables Direct Routing for this media type.
        /// </summary>
        /// <value>Toggle that enables Direct Routing for this media type.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The Direct Routing inbound flow id for this media type.
        /// </summary>
        /// <value>The Direct Routing inbound flow id for this media type.</value>
        [DataMember(Name="inboundFlow", EmitDefaultValue=false)]
        public AddressableEntityRef InboundFlow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectRoutingMediaSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  InboundFlow: ").Append(InboundFlow).Append("\n");
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
            return this.Equals(obj as DirectRoutingMediaSettings);
        }

        /// <summary>
        /// Returns true if DirectRoutingMediaSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of DirectRoutingMediaSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectRoutingMediaSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.InboundFlow == other.InboundFlow ||
                    this.InboundFlow != null &&
                    this.InboundFlow.Equals(other.InboundFlow)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.InboundFlow != null)
                    hash = hash * 59 + this.InboundFlow.GetHashCode();

                return hash;
            }
        }
    }

}
