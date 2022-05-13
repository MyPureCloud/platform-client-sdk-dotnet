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
    /// ProgramMappingsRequest
    /// </summary>
    [DataContract]
    public partial class ProgramMappingsRequest :  IEquatable<ProgramMappingsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramMappingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgramMappingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramMappingsRequest" /> class.
        /// </summary>
        /// <param name="QueueIds">The program queues (required).</param>
        /// <param name="FlowIds">The program flows (required).</param>
        public ProgramMappingsRequest(List<string> QueueIds = null, List<string> FlowIds = null)
        {
            this.QueueIds = QueueIds;
            this.FlowIds = FlowIds;
            
        }
        


        /// <summary>
        /// The program queues
        /// </summary>
        /// <value>The program queues</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }



        /// <summary>
        /// The program flows
        /// </summary>
        /// <value>The program flows</value>
        [DataMember(Name="flowIds", EmitDefaultValue=false)]
        public List<string> FlowIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramMappingsRequest {\n");

            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            sb.Append("  FlowIds: ").Append(FlowIds).Append("\n");
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
            return this.Equals(obj as ProgramMappingsRequest);
        }

        /// <summary>
        /// Returns true if ProgramMappingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramMappingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramMappingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
                ) &&
                (
                    this.FlowIds == other.FlowIds ||
                    this.FlowIds != null &&
                    this.FlowIds.SequenceEqual(other.FlowIds)
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
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();

                if (this.FlowIds != null)
                    hash = hash * 59 + this.FlowIds.GetHashCode();

                return hash;
            }
        }
    }

}
