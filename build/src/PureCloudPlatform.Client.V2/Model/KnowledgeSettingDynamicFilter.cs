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
    /// KnowledgeSettingDynamicFilter
    /// </summary>
    [DataContract]
    public partial class KnowledgeSettingDynamicFilter :  IEquatable<KnowledgeSettingDynamicFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSettingDynamicFilter" /> class.
        /// </summary>
        /// <param name="Context">Filter based on copilot context values..</param>
        public KnowledgeSettingDynamicFilter(CopilotContextFilter Context = null)
        {
            this.Context = Context;
            
        }
        


        /// <summary>
        /// Filter based on copilot context values.
        /// </summary>
        /// <value>Filter based on copilot context values.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public CopilotContextFilter Context { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSettingDynamicFilter {\n");

            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as KnowledgeSettingDynamicFilter);
        }

        /// <summary>
        /// Returns true if KnowledgeSettingDynamicFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSettingDynamicFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSettingDynamicFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
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
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                return hash;
            }
        }
    }

}
