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
    /// Social Message event element.
    /// </summary>
    [DataContract]
    public partial class OpenSocialMediaReactionsEvent :  IEquatable<OpenSocialMediaReactionsEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSocialMediaReactionsEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenSocialMediaReactionsEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSocialMediaReactionsEvent" /> class.
        /// </summary>
        /// <param name="Reactions">List of reactions for this event. (required).</param>
        public OpenSocialMediaReactionsEvent(List<ContentReaction> Reactions = null)
        {
            this.Reactions = Reactions;
            
        }
        


        /// <summary>
        /// List of reactions for this event.
        /// </summary>
        /// <value>List of reactions for this event.</value>
        [DataMember(Name="reactions", EmitDefaultValue=false)]
        public List<ContentReaction> Reactions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenSocialMediaReactionsEvent {\n");

            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
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
            return this.Equals(obj as OpenSocialMediaReactionsEvent);
        }

        /// <summary>
        /// Returns true if OpenSocialMediaReactionsEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenSocialMediaReactionsEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenSocialMediaReactionsEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Reactions == other.Reactions ||
                    this.Reactions != null &&
                    this.Reactions.SequenceEqual(other.Reactions)
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
                if (this.Reactions != null)
                    hash = hash * 59 + this.Reactions.GetHashCode();

                return hash;
            }
        }
    }

}
