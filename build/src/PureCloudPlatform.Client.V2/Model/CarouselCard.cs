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
    /// CarouselCard
    /// </summary>
    [DataContract]
    public partial class CarouselCard :  IEquatable<CarouselCard>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CarouselCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CarouselCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarouselCard" /> class.
        /// </summary>
        /// <param name="Header">Header for whatsApp carousel card (required).</param>
        /// <param name="Buttons">List of buttons to be included in the whatsApp carousel messages template (required).</param>
        /// <param name="CardBodyText">Optional card body text to be included in the whatsApp carousel messages template.</param>
        public CarouselCard(MessageHeader Header = null, List<Button> Buttons = null, CardBodyText CardBodyText = null)
        {
            this.Header = Header;
            this.Buttons = Buttons;
            this.CardBodyText = CardBodyText;
            
        }
        


        /// <summary>
        /// Header for whatsApp carousel card
        /// </summary>
        /// <value>Header for whatsApp carousel card</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public MessageHeader Header { get; set; }



        /// <summary>
        /// List of buttons to be included in the whatsApp carousel messages template
        /// </summary>
        /// <value>List of buttons to be included in the whatsApp carousel messages template</value>
        [DataMember(Name="buttons", EmitDefaultValue=false)]
        public List<Button> Buttons { get; set; }



        /// <summary>
        /// Optional card body text to be included in the whatsApp carousel messages template
        /// </summary>
        /// <value>Optional card body text to be included in the whatsApp carousel messages template</value>
        [DataMember(Name="cardBodyText", EmitDefaultValue=false)]
        public CardBodyText CardBodyText { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarouselCard {\n");

            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Buttons: ").Append(Buttons).Append("\n");
            sb.Append("  CardBodyText: ").Append(CardBodyText).Append("\n");
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
            return this.Equals(obj as CarouselCard);
        }

        /// <summary>
        /// Returns true if CarouselCard instances are equal
        /// </summary>
        /// <param name="other">Instance of CarouselCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarouselCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.Equals(other.Header)
                ) &&
                (
                    this.Buttons == other.Buttons ||
                    this.Buttons != null &&
                    this.Buttons.SequenceEqual(other.Buttons)
                ) &&
                (
                    this.CardBodyText == other.CardBodyText ||
                    this.CardBodyText != null &&
                    this.CardBodyText.Equals(other.CardBodyText)
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
                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.Buttons != null)
                    hash = hash * 59 + this.Buttons.GetHashCode();

                if (this.CardBodyText != null)
                    hash = hash * 59 + this.CardBodyText.GetHashCode();

                return hash;
            }
        }
    }

}
