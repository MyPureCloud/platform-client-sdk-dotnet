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
    /// Settings
    /// </summary>
    [DataContract]
    public partial class Settings :  IEquatable<Settings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="CommunicationBasedACW">Communication Based ACW.</param>
        /// <param name="IncludeNonAgentConversationSummary">Display communication summary.</param>
        public Settings(bool? CommunicationBasedACW = null, bool? IncludeNonAgentConversationSummary = null)
        {
            this.CommunicationBasedACW = CommunicationBasedACW;
            this.IncludeNonAgentConversationSummary = IncludeNonAgentConversationSummary;
            
        }
        


        /// <summary>
        /// Communication Based ACW
        /// </summary>
        /// <value>Communication Based ACW</value>
        [DataMember(Name="communicationBasedACW", EmitDefaultValue=false)]
        public bool? CommunicationBasedACW { get; set; }



        /// <summary>
        /// Display communication summary
        /// </summary>
        /// <value>Display communication summary</value>
        [DataMember(Name="includeNonAgentConversationSummary", EmitDefaultValue=false)]
        public bool? IncludeNonAgentConversationSummary { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Settings {\n");

            sb.Append("  CommunicationBasedACW: ").Append(CommunicationBasedACW).Append("\n");
            sb.Append("  IncludeNonAgentConversationSummary: ").Append(IncludeNonAgentConversationSummary).Append("\n");
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
            return this.Equals(obj as Settings);
        }

        /// <summary>
        /// Returns true if Settings instances are equal
        /// </summary>
        /// <param name="other">Instance of Settings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Settings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CommunicationBasedACW == other.CommunicationBasedACW ||
                    this.CommunicationBasedACW != null &&
                    this.CommunicationBasedACW.Equals(other.CommunicationBasedACW)
                ) &&
                (
                    this.IncludeNonAgentConversationSummary == other.IncludeNonAgentConversationSummary ||
                    this.IncludeNonAgentConversationSummary != null &&
                    this.IncludeNonAgentConversationSummary.Equals(other.IncludeNonAgentConversationSummary)
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
                if (this.CommunicationBasedACW != null)
                    hash = hash * 59 + this.CommunicationBasedACW.GetHashCode();

                if (this.IncludeNonAgentConversationSummary != null)
                    hash = hash * 59 + this.IncludeNonAgentConversationSummary.GetHashCode();

                return hash;
            }
        }
    }

}
