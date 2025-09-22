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
    /// ContentModeration
    /// </summary>
    [DataContract]
    public partial class ContentModeration :  IEquatable<ContentModeration>
    {
        /// <summary>
        /// The Content Moderation Flag of the message.
        /// </summary>
        /// <value>The Content Moderation Flag of the message.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlagEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Notsafeforwork for "NotSafeForWork"
            /// </summary>
            [EnumMember(Value = "NotSafeForWork")]
            Notsafeforwork,
            
            /// <summary>
            /// Enum Safeforwork for "SafeForWork"
            /// </summary>
            [EnumMember(Value = "SafeForWork")]
            Safeforwork,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The Content Moderation Flag of the message.
        /// </summary>
        /// <value>The Content Moderation Flag of the message.</value>
        [DataMember(Name="flag", EmitDefaultValue=false)]
        public FlagEnum? Flag { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentModeration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentModeration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentModeration" /> class.
        /// </summary>
        /// <param name="Flag">The Content Moderation Flag of the message. (required).</param>
        public ContentModeration(FlagEnum? Flag = null)
        {
            this.Flag = Flag;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentModeration {\n");

            sb.Append("  Flag: ").Append(Flag).Append("\n");
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
            return this.Equals(obj as ContentModeration);
        }

        /// <summary>
        /// Returns true if ContentModeration instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentModeration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentModeration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Flag == other.Flag ||
                    this.Flag != null &&
                    this.Flag.Equals(other.Flag)
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
                if (this.Flag != null)
                    hash = hash * 59 + this.Flag.GetHashCode();

                return hash;
            }
        }
    }

}
