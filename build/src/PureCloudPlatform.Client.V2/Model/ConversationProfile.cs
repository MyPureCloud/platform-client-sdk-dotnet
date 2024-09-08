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
    /// ConversationProfile
    /// </summary>
    [DataContract]
    public partial class ConversationProfile :  IEquatable<ConversationProfile>
    {
        /// <summary>
        /// The language code supported by the conversation profile belonging to a particular project for Dialogflow.
        /// </summary>
        /// <value>The language code supported by the conversation profile belonging to a particular project for Dialogflow.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LanguageCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum En for "en"
            /// </summary>
            [EnumMember(Value = "en")]
            En,
            
            /// <summary>
            /// Enum Enau for "en-AU"
            /// </summary>
            [EnumMember(Value = "en-AU")]
            Enau,
            
            /// <summary>
            /// Enum Enca for "en-CA"
            /// </summary>
            [EnumMember(Value = "en-CA")]
            Enca,
            
            /// <summary>
            /// Enum Engb for "en-GB"
            /// </summary>
            [EnumMember(Value = "en-GB")]
            Engb,
            
            /// <summary>
            /// Enum Enin for "en-IN"
            /// </summary>
            [EnumMember(Value = "en-IN")]
            Enin,
            
            /// <summary>
            /// Enum Enus for "en-US"
            /// </summary>
            [EnumMember(Value = "en-US")]
            Enus
        }
        /// <summary>
        /// The language code supported by the conversation profile belonging to a particular project for Dialogflow.
        /// </summary>
        /// <value>The language code supported by the conversation profile belonging to a particular project for Dialogflow.</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public LanguageCodeEnum? LanguageCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationProfile" /> class.
        /// </summary>
        /// <param name="LanguageCode">The language code supported by the conversation profile belonging to a particular project for Dialogflow. (required).</param>
        /// <param name="Name">The name of the conversation profile belonging to a particular project for Dialogflow (required).</param>
        public ConversationProfile(LanguageCodeEnum? LanguageCode = null, string Name = null)
        {
            this.LanguageCode = LanguageCode;
            this.Name = Name;
            
        }
        




        /// <summary>
        /// The name of the conversation profile belonging to a particular project for Dialogflow
        /// </summary>
        /// <value>The name of the conversation profile belonging to a particular project for Dialogflow</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationProfile {\n");

            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as ConversationProfile);
        }

        /// <summary>
        /// Returns true if ConversationProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationProfile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                return hash;
            }
        }
    }

}
