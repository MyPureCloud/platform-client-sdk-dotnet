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
    /// ArchitectFlowFields
    /// </summary>
    [DataContract]
    public partial class ArchitectFlowFields :  IEquatable<ArchitectFlowFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectFlowFields" /> class.
        /// </summary>
        /// <param name="ArchitectFlow">The architect flow..</param>
        /// <param name="FlowRequestMappings">Collection of Architect Flow Request Mappings to use..</param>
        public ArchitectFlowFields(AddressableEntityRef ArchitectFlow = null, List<RequestMapping> FlowRequestMappings = null)
        {
            this.ArchitectFlow = ArchitectFlow;
            this.FlowRequestMappings = FlowRequestMappings;
            
        }
        


        /// <summary>
        /// The architect flow.
        /// </summary>
        /// <value>The architect flow.</value>
        [DataMember(Name="architectFlow", EmitDefaultValue=false)]
        public AddressableEntityRef ArchitectFlow { get; set; }



        /// <summary>
        /// Collection of Architect Flow Request Mappings to use.
        /// </summary>
        /// <value>Collection of Architect Flow Request Mappings to use.</value>
        [DataMember(Name="flowRequestMappings", EmitDefaultValue=false)]
        public List<RequestMapping> FlowRequestMappings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectFlowFields {\n");

            sb.Append("  ArchitectFlow: ").Append(ArchitectFlow).Append("\n");
            sb.Append("  FlowRequestMappings: ").Append(FlowRequestMappings).Append("\n");
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
            return this.Equals(obj as ArchitectFlowFields);
        }

        /// <summary>
        /// Returns true if ArchitectFlowFields instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectFlowFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectFlowFields other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ArchitectFlow == other.ArchitectFlow ||
                    this.ArchitectFlow != null &&
                    this.ArchitectFlow.Equals(other.ArchitectFlow)
                ) &&
                (
                    this.FlowRequestMappings == other.FlowRequestMappings ||
                    this.FlowRequestMappings != null &&
                    this.FlowRequestMappings.SequenceEqual(other.FlowRequestMappings)
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
                if (this.ArchitectFlow != null)
                    hash = hash * 59 + this.ArchitectFlow.GetHashCode();

                if (this.FlowRequestMappings != null)
                    hash = hash * 59 + this.FlowRequestMappings.GetHashCode();

                return hash;
            }
        }
    }

}
