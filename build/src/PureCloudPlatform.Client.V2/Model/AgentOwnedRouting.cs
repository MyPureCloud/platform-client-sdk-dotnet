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
    /// AgentOwnedRouting
    /// </summary>
    [DataContract]
    public partial class AgentOwnedRouting :  IEquatable<AgentOwnedRouting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOwnedRouting" /> class.
        /// </summary>
        /// <param name="EnableAgentOwnedCallbacks">Indicates if Agent Owned Callbacks are enabled for the queue.</param>
        /// <param name="MaxOwnedCallbackHours">The max amount of time a callback can be owned (in hours); Allowable range 1 - 168 hour(s) (inclusive).</param>
        /// <param name="MaxOwnedCallbackDelayHours">The max amount of time a callback can be scheduled out into the future (in hours); Allowable range 1 - 720 hour(s) (inclusive).</param>
        public AgentOwnedRouting(bool? EnableAgentOwnedCallbacks = null, int? MaxOwnedCallbackHours = null, int? MaxOwnedCallbackDelayHours = null)
        {
            this.EnableAgentOwnedCallbacks = EnableAgentOwnedCallbacks;
            this.MaxOwnedCallbackHours = MaxOwnedCallbackHours;
            this.MaxOwnedCallbackDelayHours = MaxOwnedCallbackDelayHours;
            
        }
        


        /// <summary>
        /// Indicates if Agent Owned Callbacks are enabled for the queue
        /// </summary>
        /// <value>Indicates if Agent Owned Callbacks are enabled for the queue</value>
        [DataMember(Name="enableAgentOwnedCallbacks", EmitDefaultValue=false)]
        public bool? EnableAgentOwnedCallbacks { get; set; }



        /// <summary>
        /// The max amount of time a callback can be owned (in hours); Allowable range 1 - 168 hour(s) (inclusive)
        /// </summary>
        /// <value>The max amount of time a callback can be owned (in hours); Allowable range 1 - 168 hour(s) (inclusive)</value>
        [DataMember(Name="maxOwnedCallbackHours", EmitDefaultValue=false)]
        public int? MaxOwnedCallbackHours { get; set; }



        /// <summary>
        /// The max amount of time a callback can be scheduled out into the future (in hours); Allowable range 1 - 720 hour(s) (inclusive)
        /// </summary>
        /// <value>The max amount of time a callback can be scheduled out into the future (in hours); Allowable range 1 - 720 hour(s) (inclusive)</value>
        [DataMember(Name="maxOwnedCallbackDelayHours", EmitDefaultValue=false)]
        public int? MaxOwnedCallbackDelayHours { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentOwnedRouting {\n");

            sb.Append("  EnableAgentOwnedCallbacks: ").Append(EnableAgentOwnedCallbacks).Append("\n");
            sb.Append("  MaxOwnedCallbackHours: ").Append(MaxOwnedCallbackHours).Append("\n");
            sb.Append("  MaxOwnedCallbackDelayHours: ").Append(MaxOwnedCallbackDelayHours).Append("\n");
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
            return this.Equals(obj as AgentOwnedRouting);
        }

        /// <summary>
        /// Returns true if AgentOwnedRouting instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentOwnedRouting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentOwnedRouting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnableAgentOwnedCallbacks == other.EnableAgentOwnedCallbacks ||
                    this.EnableAgentOwnedCallbacks != null &&
                    this.EnableAgentOwnedCallbacks.Equals(other.EnableAgentOwnedCallbacks)
                ) &&
                (
                    this.MaxOwnedCallbackHours == other.MaxOwnedCallbackHours ||
                    this.MaxOwnedCallbackHours != null &&
                    this.MaxOwnedCallbackHours.Equals(other.MaxOwnedCallbackHours)
                ) &&
                (
                    this.MaxOwnedCallbackDelayHours == other.MaxOwnedCallbackDelayHours ||
                    this.MaxOwnedCallbackDelayHours != null &&
                    this.MaxOwnedCallbackDelayHours.Equals(other.MaxOwnedCallbackDelayHours)
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
                if (this.EnableAgentOwnedCallbacks != null)
                    hash = hash * 59 + this.EnableAgentOwnedCallbacks.GetHashCode();

                if (this.MaxOwnedCallbackHours != null)
                    hash = hash * 59 + this.MaxOwnedCallbackHours.GetHashCode();

                if (this.MaxOwnedCallbackDelayHours != null)
                    hash = hash * 59 + this.MaxOwnedCallbackDelayHours.GetHashCode();

                return hash;
            }
        }
    }

}
