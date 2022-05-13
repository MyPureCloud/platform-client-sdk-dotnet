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
    /// StorySetting
    /// </summary>
    [DataContract]
    public partial class StorySetting :  IEquatable<StorySetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorySetting" /> class.
        /// </summary>
        /// <param name="Mention">Setting relating to Story Mentions.</param>
        /// <param name="Reply">Setting relating to Story Replies.</param>
        public StorySetting(InboundOnlySetting Mention = null, InboundOnlySetting Reply = null)
        {
            this.Mention = Mention;
            this.Reply = Reply;
            
        }
        


        /// <summary>
        /// Setting relating to Story Mentions
        /// </summary>
        /// <value>Setting relating to Story Mentions</value>
        [DataMember(Name="mention", EmitDefaultValue=false)]
        public InboundOnlySetting Mention { get; set; }



        /// <summary>
        /// Setting relating to Story Replies
        /// </summary>
        /// <value>Setting relating to Story Replies</value>
        [DataMember(Name="reply", EmitDefaultValue=false)]
        public InboundOnlySetting Reply { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorySetting {\n");

            sb.Append("  Mention: ").Append(Mention).Append("\n");
            sb.Append("  Reply: ").Append(Reply).Append("\n");
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
            return this.Equals(obj as StorySetting);
        }

        /// <summary>
        /// Returns true if StorySetting instances are equal
        /// </summary>
        /// <param name="other">Instance of StorySetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorySetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Mention == other.Mention ||
                    this.Mention != null &&
                    this.Mention.Equals(other.Mention)
                ) &&
                (
                    this.Reply == other.Reply ||
                    this.Reply != null &&
                    this.Reply.Equals(other.Reply)
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
                if (this.Mention != null)
                    hash = hash * 59 + this.Mention.GetHashCode();

                if (this.Reply != null)
                    hash = hash * 59 + this.Reply.GetHashCode();

                return hash;
            }
        }
    }

}
