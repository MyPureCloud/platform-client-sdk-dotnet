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
    /// ContentOfferStylingConfiguration
    /// </summary>
    [DataContract]
    public partial class ContentOfferStylingConfiguration :  IEquatable<ContentOfferStylingConfiguration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentOfferStylingConfiguration" /> class.
        /// </summary>
        /// <param name="Position">Properties for customizing the positioning of the content offer..</param>
        /// <param name="Offer">Properties for customizing the appearance of the content offer..</param>
        /// <param name="CloseButton">Properties for customizing the appearance of the close button..</param>
        /// <param name="CtaButton">Properties for customizing the appearance of the CTA button..</param>
        /// <param name="Title">Properties for customizing the appearance of the title text..</param>
        /// <param name="Headline">Properties for customizing the appearance of the headline text..</param>
        /// <param name="Body">Properties for customizing the appearance of the body text..</param>
        public ContentOfferStylingConfiguration(ContentPositionProperties Position = null, ContentOfferStyleProperties Offer = null, CloseButtonStyleProperties CloseButton = null, CtaButtonStyleProperties CtaButton = null, TextStyleProperties Title = null, TextStyleProperties Headline = null, TextStyleProperties Body = null)
        {
            this.Position = Position;
            this.Offer = Offer;
            this.CloseButton = CloseButton;
            this.CtaButton = CtaButton;
            this.Title = Title;
            this.Headline = Headline;
            this.Body = Body;
            
        }
        
        
        
        /// <summary>
        /// Properties for customizing the positioning of the content offer.
        /// </summary>
        /// <value>Properties for customizing the positioning of the content offer.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public ContentPositionProperties Position { get; set; }
        
        
        
        /// <summary>
        /// Properties for customizing the appearance of the content offer.
        /// </summary>
        /// <value>Properties for customizing the appearance of the content offer.</value>
        [DataMember(Name="offer", EmitDefaultValue=false)]
        public ContentOfferStyleProperties Offer { get; set; }
        
        
        
        /// <summary>
        /// Properties for customizing the appearance of the close button.
        /// </summary>
        /// <value>Properties for customizing the appearance of the close button.</value>
        [DataMember(Name="closeButton", EmitDefaultValue=false)]
        public CloseButtonStyleProperties CloseButton { get; set; }
        
        
        
        /// <summary>
        /// Properties for customizing the appearance of the CTA button.
        /// </summary>
        /// <value>Properties for customizing the appearance of the CTA button.</value>
        [DataMember(Name="ctaButton", EmitDefaultValue=false)]
        public CtaButtonStyleProperties CtaButton { get; set; }
        
        
        
        /// <summary>
        /// Properties for customizing the appearance of the title text.
        /// </summary>
        /// <value>Properties for customizing the appearance of the title text.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public TextStyleProperties Title { get; set; }
        
        
        
        /// <summary>
        /// Properties for customizing the appearance of the headline text.
        /// </summary>
        /// <value>Properties for customizing the appearance of the headline text.</value>
        [DataMember(Name="headline", EmitDefaultValue=false)]
        public TextStyleProperties Headline { get; set; }
        
        
        
        /// <summary>
        /// Properties for customizing the appearance of the body text.
        /// </summary>
        /// <value>Properties for customizing the appearance of the body text.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public TextStyleProperties Body { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentOfferStylingConfiguration {\n");
            
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  CloseButton: ").Append(CloseButton).Append("\n");
            sb.Append("  CtaButton: ").Append(CtaButton).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(obj as ContentOfferStylingConfiguration);
        }

        /// <summary>
        /// Returns true if ContentOfferStylingConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentOfferStylingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentOfferStylingConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) &&
                (
                    this.Offer == other.Offer ||
                    this.Offer != null &&
                    this.Offer.Equals(other.Offer)
                ) &&
                (
                    this.CloseButton == other.CloseButton ||
                    this.CloseButton != null &&
                    this.CloseButton.Equals(other.CloseButton)
                ) &&
                (
                    this.CtaButton == other.CtaButton ||
                    this.CtaButton != null &&
                    this.CtaButton.Equals(other.CtaButton)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Headline == other.Headline ||
                    this.Headline != null &&
                    this.Headline.Equals(other.Headline)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
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
                
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                
                if (this.Offer != null)
                    hash = hash * 59 + this.Offer.GetHashCode();
                
                if (this.CloseButton != null)
                    hash = hash * 59 + this.CloseButton.GetHashCode();
                
                if (this.CtaButton != null)
                    hash = hash * 59 + this.CtaButton.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Headline != null)
                    hash = hash * 59 + this.Headline.GetHashCode();
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                return hash;
            }
        }
    }

}
