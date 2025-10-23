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
    /// The settings for Agent Video
    /// </summary>
    [DataContract]
    public partial class AgentVideoSettings :  IEquatable<AgentVideoSettings>
    {
        /// <summary>
        /// background for agent
        /// </summary>
        /// <value>background for agent</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BackgroundEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Blur for "BLUR"
            /// </summary>
            [EnumMember(Value = "BLUR")]
            Blur,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None,
            
            /// <summary>
            /// Enum Image for "IMAGE"
            /// </summary>
            [EnumMember(Value = "IMAGE")]
            Image
        }
        /// <summary>
        /// background for agent
        /// </summary>
        /// <value>background for agent</value>
        [DataMember(Name="background", EmitDefaultValue=false)]
        public BackgroundEnum? Background { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVideoSettings" /> class.
        /// </summary>
        /// <param name="AllowCamera">whether or not agent camera is allowed.</param>
        /// <param name="AllowScreenShare">whether or not agent screen share is allowed.</param>
        /// <param name="AllowMicrophone">whether or not agent microphone is allowed.</param>
        /// <param name="Background">background for agent.</param>
        /// <param name="BackgroundImage">background image settings for agent.</param>
        public AgentVideoSettings(bool? AllowCamera = null, bool? AllowScreenShare = null, bool? AllowMicrophone = null, BackgroundEnum? Background = null, BackgroundImageSettings BackgroundImage = null)
        {
            this.AllowCamera = AllowCamera;
            this.AllowScreenShare = AllowScreenShare;
            this.AllowMicrophone = AllowMicrophone;
            this.Background = Background;
            this.BackgroundImage = BackgroundImage;
            
        }
        


        /// <summary>
        /// whether or not agent camera is allowed
        /// </summary>
        /// <value>whether or not agent camera is allowed</value>
        [DataMember(Name="allowCamera", EmitDefaultValue=false)]
        public bool? AllowCamera { get; set; }



        /// <summary>
        /// whether or not agent screen share is allowed
        /// </summary>
        /// <value>whether or not agent screen share is allowed</value>
        [DataMember(Name="allowScreenShare", EmitDefaultValue=false)]
        public bool? AllowScreenShare { get; set; }



        /// <summary>
        /// whether or not agent microphone is allowed
        /// </summary>
        /// <value>whether or not agent microphone is allowed</value>
        [DataMember(Name="allowMicrophone", EmitDefaultValue=false)]
        public bool? AllowMicrophone { get; set; }





        /// <summary>
        /// background image settings for agent
        /// </summary>
        /// <value>background image settings for agent</value>
        [DataMember(Name="backgroundImage", EmitDefaultValue=false)]
        public BackgroundImageSettings BackgroundImage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentVideoSettings {\n");

            sb.Append("  AllowCamera: ").Append(AllowCamera).Append("\n");
            sb.Append("  AllowScreenShare: ").Append(AllowScreenShare).Append("\n");
            sb.Append("  AllowMicrophone: ").Append(AllowMicrophone).Append("\n");
            sb.Append("  Background: ").Append(Background).Append("\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
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
            return this.Equals(obj as AgentVideoSettings);
        }

        /// <summary>
        /// Returns true if AgentVideoSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentVideoSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentVideoSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AllowCamera == other.AllowCamera ||
                    this.AllowCamera != null &&
                    this.AllowCamera.Equals(other.AllowCamera)
                ) &&
                (
                    this.AllowScreenShare == other.AllowScreenShare ||
                    this.AllowScreenShare != null &&
                    this.AllowScreenShare.Equals(other.AllowScreenShare)
                ) &&
                (
                    this.AllowMicrophone == other.AllowMicrophone ||
                    this.AllowMicrophone != null &&
                    this.AllowMicrophone.Equals(other.AllowMicrophone)
                ) &&
                (
                    this.Background == other.Background ||
                    this.Background != null &&
                    this.Background.Equals(other.Background)
                ) &&
                (
                    this.BackgroundImage == other.BackgroundImage ||
                    this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(other.BackgroundImage)
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
                if (this.AllowCamera != null)
                    hash = hash * 59 + this.AllowCamera.GetHashCode();

                if (this.AllowScreenShare != null)
                    hash = hash * 59 + this.AllowScreenShare.GetHashCode();

                if (this.AllowMicrophone != null)
                    hash = hash * 59 + this.AllowMicrophone.GetHashCode();

                if (this.Background != null)
                    hash = hash * 59 + this.Background.GetHashCode();

                if (this.BackgroundImage != null)
                    hash = hash * 59 + this.BackgroundImage.GetHashCode();

                return hash;
            }
        }
    }

}
