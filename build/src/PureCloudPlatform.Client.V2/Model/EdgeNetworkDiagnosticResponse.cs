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
    /// EdgeNetworkDiagnosticResponse
    /// </summary>
    [DataContract]
    public partial class EdgeNetworkDiagnosticResponse :  IEquatable<EdgeNetworkDiagnosticResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeNetworkDiagnosticResponse" /> class.
        /// </summary>
        /// <param name="CommandCorrelationId">UUID of each executed command on edge.</param>
        /// <param name="Diagnostics">Response string of executed command from edge.</param>
        public EdgeNetworkDiagnosticResponse(string CommandCorrelationId = null, string Diagnostics = null)
        {
            this.CommandCorrelationId = CommandCorrelationId;
            this.Diagnostics = Diagnostics;
            
        }
        


        /// <summary>
        /// UUID of each executed command on edge
        /// </summary>
        /// <value>UUID of each executed command on edge</value>
        [DataMember(Name="commandCorrelationId", EmitDefaultValue=false)]
        public string CommandCorrelationId { get; set; }



        /// <summary>
        /// Response string of executed command from edge
        /// </summary>
        /// <value>Response string of executed command from edge</value>
        [DataMember(Name="diagnostics", EmitDefaultValue=false)]
        public string Diagnostics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeNetworkDiagnosticResponse {\n");

            sb.Append("  CommandCorrelationId: ").Append(CommandCorrelationId).Append("\n");
            sb.Append("  Diagnostics: ").Append(Diagnostics).Append("\n");
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
            return this.Equals(obj as EdgeNetworkDiagnosticResponse);
        }

        /// <summary>
        /// Returns true if EdgeNetworkDiagnosticResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeNetworkDiagnosticResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeNetworkDiagnosticResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CommandCorrelationId == other.CommandCorrelationId ||
                    this.CommandCorrelationId != null &&
                    this.CommandCorrelationId.Equals(other.CommandCorrelationId)
                ) &&
                (
                    this.Diagnostics == other.Diagnostics ||
                    this.Diagnostics != null &&
                    this.Diagnostics.Equals(other.Diagnostics)
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
                if (this.CommandCorrelationId != null)
                    hash = hash * 59 + this.CommandCorrelationId.GetHashCode();

                if (this.Diagnostics != null)
                    hash = hash * 59 + this.Diagnostics.GetHashCode();

                return hash;
            }
        }
    }

}
