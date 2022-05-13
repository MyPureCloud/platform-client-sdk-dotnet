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
    /// User actions available on the content. All actions are optional and all actions are executed simultaneously.
    /// </summary>
    [DataContract]
    public partial class ConversationContentActions :  IEquatable<ConversationContentActions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentActions" /> class.
        /// </summary>
        /// <param name="Url">A URL of a web page to direct the user to..</param>
        /// <param name="UrlTarget">The target window in which to open the URL. If empty will open a blank page or tab..</param>
        /// <param name="Textback">Text to be sent back in reply when the item is selected..</param>
        public ConversationContentActions(string Url = null, string UrlTarget = null, string Textback = null)
        {
            this.Url = Url;
            this.UrlTarget = UrlTarget;
            this.Textback = Textback;
            
        }
        


        /// <summary>
        /// A URL of a web page to direct the user to.
        /// </summary>
        /// <value>A URL of a web page to direct the user to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// The target window in which to open the URL. If empty will open a blank page or tab.
        /// </summary>
        /// <value>The target window in which to open the URL. If empty will open a blank page or tab.</value>
        [DataMember(Name="urlTarget", EmitDefaultValue=false)]
        public string UrlTarget { get; set; }



        /// <summary>
        /// Text to be sent back in reply when the item is selected.
        /// </summary>
        /// <value>Text to be sent back in reply when the item is selected.</value>
        [DataMember(Name="textback", EmitDefaultValue=false)]
        public string Textback { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentActions {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UrlTarget: ").Append(UrlTarget).Append("\n");
            sb.Append("  Textback: ").Append(Textback).Append("\n");
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
            return this.Equals(obj as ConversationContentActions);
        }

        /// <summary>
        /// Returns true if ConversationContentActions instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentActions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.UrlTarget == other.UrlTarget ||
                    this.UrlTarget != null &&
                    this.UrlTarget.Equals(other.UrlTarget)
                ) &&
                (
                    this.Textback == other.Textback ||
                    this.Textback != null &&
                    this.Textback.Equals(other.Textback)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.UrlTarget != null)
                    hash = hash * 59 + this.UrlTarget.GetHashCode();

                if (this.Textback != null)
                    hash = hash * 59 + this.Textback.GetHashCode();

                return hash;
            }
        }
    }

}
