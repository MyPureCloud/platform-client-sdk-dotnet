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
    /// The localization settings for homescreen and push notification
    /// </summary>
    [DataContract]
    public partial class CustomI18nLabels :  IEquatable<CustomI18nLabels>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomI18nLabels" /> class.
        /// </summary>
        /// <param name="Language">Language of localized labels in homescreen app (eg. en-us, de-de) and push notification.</param>
        /// <param name="LocalizedLabels">Contains localized labels used in messenger apps and push notification. PushNotificationTitle and PushNotificationBody are required when notifications are enabled..</param>
        public CustomI18nLabels(string Language = null, List<LocalizedLabels> LocalizedLabels = null)
        {
            this.Language = Language;
            this.LocalizedLabels = LocalizedLabels;
            
        }
        


        /// <summary>
        /// Language of localized labels in homescreen app (eg. en-us, de-de) and push notification
        /// </summary>
        /// <value>Language of localized labels in homescreen app (eg. en-us, de-de) and push notification</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Contains localized labels used in messenger apps and push notification. PushNotificationTitle and PushNotificationBody are required when notifications are enabled.
        /// </summary>
        /// <value>Contains localized labels used in messenger apps and push notification. PushNotificationTitle and PushNotificationBody are required when notifications are enabled.</value>
        [DataMember(Name="localizedLabels", EmitDefaultValue=false)]
        public List<LocalizedLabels> LocalizedLabels { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomI18nLabels {\n");

            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LocalizedLabels: ").Append(LocalizedLabels).Append("\n");
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
            return this.Equals(obj as CustomI18nLabels);
        }

        /// <summary>
        /// Returns true if CustomI18nLabels instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomI18nLabels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomI18nLabels other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.LocalizedLabels == other.LocalizedLabels ||
                    this.LocalizedLabels != null &&
                    this.LocalizedLabels.SequenceEqual(other.LocalizedLabels)
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
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.LocalizedLabels != null)
                    hash = hash * 59 + this.LocalizedLabels.GetHashCode();

                return hash;
            }
        }
    }

}
