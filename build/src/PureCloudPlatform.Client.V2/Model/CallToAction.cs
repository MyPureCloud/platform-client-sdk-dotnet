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
    /// CallToAction
    /// </summary>
    [DataContract]
    public partial class CallToAction :  IEquatable<CallToAction>
    {
        /// <summary>
        /// Where the URL should be opened when the user clicks on the call to action button.
        /// </summary>
        /// <value>Where the URL should be opened when the user clicks on the call to action button.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TargetEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Blank for "Blank"
            /// </summary>
            [EnumMember(Value = "Blank")]
            Blank,
            
            /// <summary>
            /// Enum Self for "Self"
            /// </summary>
            [EnumMember(Value = "Self")]
            Self
        }
        /// <summary>
        /// Where the URL should be opened when the user clicks on the call to action button.
        /// </summary>
        /// <value>Where the URL should be opened when the user clicks on the call to action button.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TargetEnum? Target { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallToAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallToAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallToAction" /> class.
        /// </summary>
        /// <param name="Text">Text displayed on the call to action button..</param>
        /// <param name="Url">URL to open when user clicks on the call to action button. (required).</param>
        /// <param name="Target">Where the URL should be opened when the user clicks on the call to action button..</param>
        public CallToAction(string Text = null, string Url = null, TargetEnum? Target = null)
        {
            this.Text = Text;
            this.Url = Url;
            this.Target = Target;
            
        }
        


        /// <summary>
        /// Text displayed on the call to action button.
        /// </summary>
        /// <value>Text displayed on the call to action button.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// URL to open when user clicks on the call to action button.
        /// </summary>
        /// <value>URL to open when user clicks on the call to action button.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallToAction {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(obj as CallToAction);
        }

        /// <summary>
        /// Returns true if CallToAction instances are equal
        /// </summary>
        /// <param name="other">Instance of CallToAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallToAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                return hash;
            }
        }
    }

}
