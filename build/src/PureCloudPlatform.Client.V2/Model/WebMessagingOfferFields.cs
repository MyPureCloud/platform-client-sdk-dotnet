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
    /// WebMessagingOfferFields
    /// </summary>
    [DataContract]
    public partial class WebMessagingOfferFields :  IEquatable<WebMessagingOfferFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebMessagingOfferFields" /> class.
        /// </summary>
        /// <param name="OfferText">Text value to be used when inviting a visitor to engage with a web messaging offer..</param>
        /// <param name="ArchitectFlow">Flow to be invoked, overrides default flow when specified..</param>
        public WebMessagingOfferFields(string OfferText = null, AddressableEntityRef ArchitectFlow = null)
        {
            this.OfferText = OfferText;
            this.ArchitectFlow = ArchitectFlow;
            
        }
        


        /// <summary>
        /// Text value to be used when inviting a visitor to engage with a web messaging offer.
        /// </summary>
        /// <value>Text value to be used when inviting a visitor to engage with a web messaging offer.</value>
        [DataMember(Name="offerText", EmitDefaultValue=false)]
        public string OfferText { get; set; }



        /// <summary>
        /// Flow to be invoked, overrides default flow when specified.
        /// </summary>
        /// <value>Flow to be invoked, overrides default flow when specified.</value>
        [DataMember(Name="architectFlow", EmitDefaultValue=false)]
        public AddressableEntityRef ArchitectFlow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebMessagingOfferFields {\n");

            sb.Append("  OfferText: ").Append(OfferText).Append("\n");
            sb.Append("  ArchitectFlow: ").Append(ArchitectFlow).Append("\n");
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
            return this.Equals(obj as WebMessagingOfferFields);
        }

        /// <summary>
        /// Returns true if WebMessagingOfferFields instances are equal
        /// </summary>
        /// <param name="other">Instance of WebMessagingOfferFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebMessagingOfferFields other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OfferText == other.OfferText ||
                    this.OfferText != null &&
                    this.OfferText.Equals(other.OfferText)
                ) &&
                (
                    this.ArchitectFlow == other.ArchitectFlow ||
                    this.ArchitectFlow != null &&
                    this.ArchitectFlow.Equals(other.ArchitectFlow)
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
                if (this.OfferText != null)
                    hash = hash * 59 + this.OfferText.GetHashCode();

                if (this.ArchitectFlow != null)
                    hash = hash * 59 + this.ArchitectFlow.GetHashCode();

                return hash;
            }
        }
    }

}
