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
    /// OpenRichMediaSetting
    /// </summary>
    [DataContract]
    public partial class OpenRichMediaSetting :  IEquatable<OpenRichMediaSetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRichMediaSetting" /> class.
        /// </summary>
        /// <param name="QuickReply">Setting relating to quick replies.</param>
        /// <param name="Cards">Setting relating to cards.</param>
        public OpenRichMediaSetting(OutboundOnlySetting QuickReply = null, OutboundOnlySetting Cards = null)
        {
            this.QuickReply = QuickReply;
            this.Cards = Cards;
            
        }
        


        /// <summary>
        /// Setting relating to quick replies
        /// </summary>
        /// <value>Setting relating to quick replies</value>
        [DataMember(Name="quickReply", EmitDefaultValue=false)]
        public OutboundOnlySetting QuickReply { get; set; }



        /// <summary>
        /// Setting relating to cards
        /// </summary>
        /// <value>Setting relating to cards</value>
        [DataMember(Name="cards", EmitDefaultValue=false)]
        public OutboundOnlySetting Cards { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenRichMediaSetting {\n");

            sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
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
            return this.Equals(obj as OpenRichMediaSetting);
        }

        /// <summary>
        /// Returns true if OpenRichMediaSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenRichMediaSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenRichMediaSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QuickReply == other.QuickReply ||
                    this.QuickReply != null &&
                    this.QuickReply.Equals(other.QuickReply)
                ) &&
                (
                    this.Cards == other.Cards ||
                    this.Cards != null &&
                    this.Cards.Equals(other.Cards)
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
                if (this.QuickReply != null)
                    hash = hash * 59 + this.QuickReply.GetHashCode();

                if (this.Cards != null)
                    hash = hash * 59 + this.Cards.GetHashCode();

                return hash;
            }
        }
    }

}
