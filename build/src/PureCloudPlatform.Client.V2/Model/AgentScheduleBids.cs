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
    /// AgentScheduleBids
    /// </summary>
    [DataContract]
    public partial class AgentScheduleBids :  IEquatable<AgentScheduleBids>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBids" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentScheduleBids() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBids" /> class.
        /// </summary>
        /// <param name="BusinessUnit">The business unit to which the bids belong (required).</param>
        /// <param name="_AgentScheduleBids">Schedule bid summaries associated with this agent (required).</param>
        public AgentScheduleBids(BusinessUnitReference BusinessUnit = null, List<AgentScheduleBid> _AgentScheduleBids = null)
        {
            this.BusinessUnit = BusinessUnit;
            this._AgentScheduleBids = _AgentScheduleBids;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The business unit to which the bids belong
        /// </summary>
        /// <value>The business unit to which the bids belong</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public BusinessUnitReference BusinessUnit { get; set; }



        /// <summary>
        /// Schedule bid summaries associated with this agent
        /// </summary>
        /// <value>Schedule bid summaries associated with this agent</value>
        [DataMember(Name="agentScheduleBids", EmitDefaultValue=false)]
        public List<AgentScheduleBid> _AgentScheduleBids { get; set; }



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
            sb.Append("class AgentScheduleBids {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  _AgentScheduleBids: ").Append(_AgentScheduleBids).Append("\n");
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
            return this.Equals(obj as AgentScheduleBids);
        }

        /// <summary>
        /// Returns true if AgentScheduleBids instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentScheduleBids to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentScheduleBids other)
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
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
                ) &&
                (
                    this._AgentScheduleBids == other._AgentScheduleBids ||
                    this._AgentScheduleBids != null &&
                    this._AgentScheduleBids.SequenceEqual(other._AgentScheduleBids)
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

                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();

                if (this._AgentScheduleBids != null)
                    hash = hash * 59 + this._AgentScheduleBids.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
