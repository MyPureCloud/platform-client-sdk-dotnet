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
    /// Used to set the log level of a particular flow
    /// </summary>
    [DataContract]
    public partial class FlowLogLevelRequest :  IEquatable<FlowLogLevelRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowLogLevelRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowLogLevelRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowLogLevelRequest" /> class.
        /// </summary>
        /// <param name="LogLevelCharacteristics">The log level characteristics currently set for this flow (required).</param>
        public FlowLogLevelRequest(FlowLogLevel LogLevelCharacteristics = null)
        {
            this.LogLevelCharacteristics = LogLevelCharacteristics;
            
        }
        


        /// <summary>
        /// The log level characteristics currently set for this flow
        /// </summary>
        /// <value>The log level characteristics currently set for this flow</value>
        [DataMember(Name="logLevelCharacteristics", EmitDefaultValue=false)]
        public FlowLogLevel LogLevelCharacteristics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowLogLevelRequest {\n");

            sb.Append("  LogLevelCharacteristics: ").Append(LogLevelCharacteristics).Append("\n");
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
            return this.Equals(obj as FlowLogLevelRequest);
        }

        /// <summary>
        /// Returns true if FlowLogLevelRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowLogLevelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowLogLevelRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LogLevelCharacteristics == other.LogLevelCharacteristics ||
                    this.LogLevelCharacteristics != null &&
                    this.LogLevelCharacteristics.Equals(other.LogLevelCharacteristics)
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
                if (this.LogLevelCharacteristics != null)
                    hash = hash * 59 + this.LogLevelCharacteristics.GetHashCode();

                return hash;
            }
        }
    }

}
