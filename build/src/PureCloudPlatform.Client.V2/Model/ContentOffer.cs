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
    /// ContentOffer
    /// </summary>
    [DataContract]
    public partial class ContentOffer :  IEquatable<ContentOffer>
    {
        
        
        
        
        
        /// <summary>
        /// The display mode of Genesys Widgets when displaying content offer.
        /// </summary>
        /// <value>The display mode of Genesys Widgets when displaying content offer.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DisplayModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Modal for "Modal"
            /// </summary>
            [EnumMember(Value = "Modal")]
            Modal,
            
            /// <summary>
            /// Enum Overlay for "Overlay"
            /// </summary>
            [EnumMember(Value = "Overlay")]
            Overlay,
            
            /// <summary>
            /// Enum Toast for "Toast"
            /// </summary>
            [EnumMember(Value = "Toast")]
            Toast
        }
        
        
        
        
        /// <summary>
        /// The layout mode of the text shown to the user when displaying content offer.
        /// </summary>
        /// <value>The layout mode of the text shown to the user when displaying content offer.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LayoutModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Textonly for "TextOnly"
            /// </summary>
            [EnumMember(Value = "TextOnly")]
            Textonly,
            
            /// <summary>
            /// Enum Imageonly for "ImageOnly"
            /// </summary>
            [EnumMember(Value = "ImageOnly")]
            Imageonly,
            
            /// <summary>
            /// Enum Lefttext for "LeftText"
            /// </summary>
            [EnumMember(Value = "LeftText")]
            Lefttext,
            
            /// <summary>
            /// Enum Righttext for "RightText"
            /// </summary>
            [EnumMember(Value = "RightText")]
            Righttext,
            
            /// <summary>
            /// Enum Toptext for "TopText"
            /// </summary>
            [EnumMember(Value = "TopText")]
            Toptext,
            
            /// <summary>
            /// Enum Bottomtext for "BottomText"
            /// </summary>
            [EnumMember(Value = "BottomText")]
            Bottomtext
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The display mode of Genesys Widgets when displaying content offer.
        /// </summary>
        /// <value>The display mode of Genesys Widgets when displaying content offer.</value>
        [DataMember(Name="displayMode", EmitDefaultValue=false)]
        public DisplayModeEnum? DisplayMode { get; set; }
        
        
        
        /// <summary>
        /// The layout mode of the text shown to the user when displaying content offer.
        /// </summary>
        /// <value>The layout mode of the text shown to the user when displaying content offer.</value>
        [DataMember(Name="layoutMode", EmitDefaultValue=false)]
        public LayoutModeEnum? LayoutMode { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentOffer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentOffer() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentOffer" /> class.
        /// </summary>
        /// <param name="ImageUrl">URL for image displayed to the customer when displaying content offer..</param>
        /// <param name="DisplayMode">The display mode of Genesys Widgets when displaying content offer. (required).</param>
        /// <param name="LayoutMode">The layout mode of the text shown to the user when displaying content offer. (required).</param>
        /// <param name="Title">Title used in the header of the content offer..</param>
        /// <param name="Headline">Headline displayed above the body text of the content offer..</param>
        /// <param name="Body">Body text of the content offer..</param>
        /// <param name="CallToAction">Properties customizing the call to action button on the content offer..</param>
        /// <param name="Style">Properties customizing the styling of the content offer..</param>
        public ContentOffer(string ImageUrl = null, DisplayModeEnum? DisplayMode = null, LayoutModeEnum? LayoutMode = null, string Title = null, string Headline = null, string Body = null, CallToAction CallToAction = null, ContentOfferStylingConfiguration Style = null)
        {
            this.ImageUrl = ImageUrl;
            this.DisplayMode = DisplayMode;
            this.LayoutMode = LayoutMode;
            this.Title = Title;
            this.Headline = Headline;
            this.Body = Body;
            this.CallToAction = CallToAction;
            this.Style = Style;
            
        }
        
        
        
        /// <summary>
        /// URL for image displayed to the customer when displaying content offer.
        /// </summary>
        /// <value>URL for image displayed to the customer when displaying content offer.</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Title used in the header of the content offer.
        /// </summary>
        /// <value>Title used in the header of the content offer.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// Headline displayed above the body text of the content offer.
        /// </summary>
        /// <value>Headline displayed above the body text of the content offer.</value>
        [DataMember(Name="headline", EmitDefaultValue=false)]
        public string Headline { get; set; }
        
        
        
        /// <summary>
        /// Body text of the content offer.
        /// </summary>
        /// <value>Body text of the content offer.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        
        
        
        /// <summary>
        /// Properties customizing the call to action button on the content offer.
        /// </summary>
        /// <value>Properties customizing the call to action button on the content offer.</value>
        [DataMember(Name="callToAction", EmitDefaultValue=false)]
        public CallToAction CallToAction { get; set; }
        
        
        
        /// <summary>
        /// Properties customizing the styling of the content offer.
        /// </summary>
        /// <value>Properties customizing the styling of the content offer.</value>
        [DataMember(Name="style", EmitDefaultValue=false)]
        public ContentOfferStylingConfiguration Style { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentOffer {\n");
            
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  DisplayMode: ").Append(DisplayMode).Append("\n");
            sb.Append("  LayoutMode: ").Append(LayoutMode).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CallToAction: ").Append(CallToAction).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ContentOffer);
        }

        /// <summary>
        /// Returns true if ContentOffer instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentOffer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) &&
                (
                    this.DisplayMode == other.DisplayMode ||
                    this.DisplayMode != null &&
                    this.DisplayMode.Equals(other.DisplayMode)
                ) &&
                (
                    this.LayoutMode == other.LayoutMode ||
                    this.LayoutMode != null &&
                    this.LayoutMode.Equals(other.LayoutMode)
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
                ) &&
                (
                    this.CallToAction == other.CallToAction ||
                    this.CallToAction != null &&
                    this.CallToAction.Equals(other.CallToAction)
                ) &&
                (
                    this.Style == other.Style ||
                    this.Style != null &&
                    this.Style.Equals(other.Style)
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
                
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                
                if (this.DisplayMode != null)
                    hash = hash * 59 + this.DisplayMode.GetHashCode();
                
                if (this.LayoutMode != null)
                    hash = hash * 59 + this.LayoutMode.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Headline != null)
                    hash = hash * 59 + this.Headline.GetHashCode();
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                if (this.CallToAction != null)
                    hash = hash * 59 + this.CallToAction.GetHashCode();
                
                if (this.Style != null)
                    hash = hash * 59 + this.Style.GetHashCode();
                
                return hash;
            }
        }
    }

}
