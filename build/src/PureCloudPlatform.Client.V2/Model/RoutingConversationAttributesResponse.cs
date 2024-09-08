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
    /// RoutingConversationAttributesResponse
    /// </summary>
    [DataContract]
    public partial class RoutingConversationAttributesResponse :  IEquatable<RoutingConversationAttributesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingConversationAttributesResponse" /> class.
        /// </summary>
        /// <param name="Priority">Current priority value on in-queue conversation. Range:[-25000000, 25000000].</param>
        /// <param name="Skills">Current routing skills on in-queue conversation.</param>
        /// <param name="Language">Current language on in-queue conversation.</param>
        /// <param name="Label">Current label on in-queue conversation.</param>
        /// <param name="ScoredAgents">Current scored agents on in-queue conversation.</param>
        public RoutingConversationAttributesResponse(int? Priority = null, List<RoutingSkill> Skills = null, Language Language = null, UtilizationLabel Label = null, List<ScoredAgent> ScoredAgents = null)
        {
            this.Priority = Priority;
            this.Skills = Skills;
            this.Language = Language;
            this.Label = Label;
            this.ScoredAgents = ScoredAgents;
            
        }
        


        /// <summary>
        /// Current priority value on in-queue conversation. Range:[-25000000, 25000000]
        /// </summary>
        /// <value>Current priority value on in-queue conversation. Range:[-25000000, 25000000]</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// Current routing skills on in-queue conversation
        /// </summary>
        /// <value>Current routing skills on in-queue conversation</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<RoutingSkill> Skills { get; set; }



        /// <summary>
        /// Current language on in-queue conversation
        /// </summary>
        /// <value>Current language on in-queue conversation</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public Language Language { get; set; }



        /// <summary>
        /// Current label on in-queue conversation
        /// </summary>
        /// <value>Current label on in-queue conversation</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public UtilizationLabel Label { get; set; }



        /// <summary>
        /// Current scored agents on in-queue conversation
        /// </summary>
        /// <value>Current scored agents on in-queue conversation</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<ScoredAgent> ScoredAgents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingConversationAttributesResponse {\n");

            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
            return this.Equals(obj as RoutingConversationAttributesResponse);
        }

        /// <summary>
        /// Returns true if RoutingConversationAttributesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingConversationAttributesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingConversationAttributesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
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
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                return hash;
            }
        }
    }

}
