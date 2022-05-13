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
    /// User information for a twitter account
    /// </summary>
    [DataContract]
    public partial class TwitterId :  IEquatable<TwitterId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterId" /> class.
        /// </summary>
        /// <param name="Id">twitter user.id_str.</param>
        /// <param name="Name">twitter user.name.</param>
        /// <param name="ScreenName">twitter user.screen_name.</param>
        public TwitterId(string Id = null, string Name = null, string ScreenName = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.ScreenName = ScreenName;
            
        }
        


        /// <summary>
        /// twitter user.id_str
        /// </summary>
        /// <value>twitter user.id_str</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// twitter user.name
        /// </summary>
        /// <value>twitter user.name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// twitter user.screen_name
        /// </summary>
        /// <value>twitter user.screen_name</value>
        [DataMember(Name="screenName", EmitDefaultValue=false)]
        public string ScreenName { get; set; }



        /// <summary>
        /// whether this data has been verified using the twitter API
        /// </summary>
        /// <value>whether this data has been verified using the twitter API</value>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; private set; }



        /// <summary>
        /// url of user's twitter profile
        /// </summary>
        /// <value>url of user's twitter profile</value>
        [DataMember(Name="profileUrl", EmitDefaultValue=false)]
        public string ProfileUrl { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwitterId {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
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
            return this.Equals(obj as TwitterId);
        }

        /// <summary>
        /// Returns true if TwitterId instances are equal
        /// </summary>
        /// <param name="other">Instance of TwitterId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ScreenName == other.ScreenName ||
                    this.ScreenName != null &&
                    this.ScreenName.Equals(other.ScreenName)
                ) &&
                (
                    this.Verified == other.Verified ||
                    this.Verified != null &&
                    this.Verified.Equals(other.Verified)
                ) &&
                (
                    this.ProfileUrl == other.ProfileUrl ||
                    this.ProfileUrl != null &&
                    this.ProfileUrl.Equals(other.ProfileUrl)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ScreenName != null)
                    hash = hash * 59 + this.ScreenName.GetHashCode();

                if (this.Verified != null)
                    hash = hash * 59 + this.Verified.GetHashCode();

                if (this.ProfileUrl != null)
                    hash = hash * 59 + this.ProfileUrl.GetHashCode();

                return hash;
            }
        }
    }

}
