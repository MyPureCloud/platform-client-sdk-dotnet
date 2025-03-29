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
    /// ConversationInsight
    /// </summary>
    [DataContract]
    public partial class ConversationInsight :  IEquatable<ConversationInsight>
    {
        /// <summary>
        /// The type of insight
        /// </summary>
        /// <value>The type of insight</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Reason for "Reason"
            /// </summary>
            [EnumMember(Value = "Reason")]
            Reason,
            
            /// <summary>
            /// Enum Resolution for "Resolution"
            /// </summary>
            [EnumMember(Value = "Resolution")]
            Resolution,
            
            /// <summary>
            /// Enum Actionitem for "ActionItem"
            /// </summary>
            [EnumMember(Value = "ActionItem")]
            Actionitem
        }
        /// <summary>
        /// The type of insight
        /// </summary>
        /// <value>The type of insight</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInsight" /> class.
        /// </summary>
        /// <param name="Type">The type of insight.</param>
        /// <param name="Title">The reason for contact, resolution for the interaction, or follow-up action item.</param>
        /// <param name="Description">Reasoning for the given insight.</param>
        /// <param name="Outcome">The outcome of a given resolution insight.</param>
        public ConversationInsight(TypeEnum? Type = null, string Title = null, string Description = null, string Outcome = null)
        {
            this.Type = Type;
            this.Title = Title;
            this.Description = Description;
            this.Outcome = Outcome;
            
        }
        




        /// <summary>
        /// The reason for contact, resolution for the interaction, or follow-up action item
        /// </summary>
        /// <value>The reason for contact, resolution for the interaction, or follow-up action item</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Reasoning for the given insight
        /// </summary>
        /// <value>Reasoning for the given insight</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The outcome of a given resolution insight
        /// </summary>
        /// <value>The outcome of a given resolution insight</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public string Outcome { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationInsight {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
            return this.Equals(obj as ConversationInsight);
        }

        /// <summary>
        /// Returns true if ConversationInsight instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationInsight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationInsight other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();

                return hash;
            }
        }
    }

}
