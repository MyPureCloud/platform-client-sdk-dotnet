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
    /// IntegrationActionFields
    /// </summary>
    [DataContract]
    public partial class IntegrationActionFields :  IEquatable<IntegrationActionFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationActionFields" /> class.
        /// </summary>
        /// <param name="IntegrationAction">Reference to the Integration Action to be used when integrationAction type is qualified.</param>
        /// <param name="RequestMappings">Collection of Request Mappings to use.</param>
        public IntegrationActionFields(IntegrationAction IntegrationAction = null, List<RequestMapping> RequestMappings = null)
        {
            this.IntegrationAction = IntegrationAction;
            this.RequestMappings = RequestMappings;
            
        }
        


        /// <summary>
        /// Reference to the Integration Action to be used when integrationAction type is qualified
        /// </summary>
        /// <value>Reference to the Integration Action to be used when integrationAction type is qualified</value>
        [DataMember(Name="integrationAction", EmitDefaultValue=false)]
        public IntegrationAction IntegrationAction { get; set; }



        /// <summary>
        /// Collection of Request Mappings to use
        /// </summary>
        /// <value>Collection of Request Mappings to use</value>
        [DataMember(Name="requestMappings", EmitDefaultValue=false)]
        public List<RequestMapping> RequestMappings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationActionFields {\n");

            sb.Append("  IntegrationAction: ").Append(IntegrationAction).Append("\n");
            sb.Append("  RequestMappings: ").Append(RequestMappings).Append("\n");
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
            return this.Equals(obj as IntegrationActionFields);
        }

        /// <summary>
        /// Returns true if IntegrationActionFields instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationActionFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationActionFields other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IntegrationAction == other.IntegrationAction ||
                    this.IntegrationAction != null &&
                    this.IntegrationAction.Equals(other.IntegrationAction)
                ) &&
                (
                    this.RequestMappings == other.RequestMappings ||
                    this.RequestMappings != null &&
                    this.RequestMappings.SequenceEqual(other.RequestMappings)
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
                if (this.IntegrationAction != null)
                    hash = hash * 59 + this.IntegrationAction.GetHashCode();

                if (this.RequestMappings != null)
                    hash = hash * 59 + this.RequestMappings.GetHashCode();

                return hash;
            }
        }
    }

}
