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
    /// The settings for User Video
    /// </summary>
    [DataContract]
    public partial class UserVideoSettings :  IEquatable<UserVideoSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVideoSettings" /> class.
        /// </summary>
        /// <param name="AllowCamera">whether or not user camera is allowed.</param>
        /// <param name="AllowScreenShare">whether or not user screen share is allowed.</param>
        public UserVideoSettings(bool? AllowCamera = null, bool? AllowScreenShare = null)
        {
            this.AllowCamera = AllowCamera;
            this.AllowScreenShare = AllowScreenShare;
            
        }
        


        /// <summary>
        /// whether or not user camera is allowed
        /// </summary>
        /// <value>whether or not user camera is allowed</value>
        [DataMember(Name="allowCamera", EmitDefaultValue=false)]
        public bool? AllowCamera { get; set; }



        /// <summary>
        /// whether or not user screen share is allowed
        /// </summary>
        /// <value>whether or not user screen share is allowed</value>
        [DataMember(Name="allowScreenShare", EmitDefaultValue=false)]
        public bool? AllowScreenShare { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserVideoSettings {\n");

            sb.Append("  AllowCamera: ").Append(AllowCamera).Append("\n");
            sb.Append("  AllowScreenShare: ").Append(AllowScreenShare).Append("\n");
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
            return this.Equals(obj as UserVideoSettings);
        }

        /// <summary>
        /// Returns true if UserVideoSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UserVideoSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserVideoSettings other)
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

                return hash;
            }
        }
    }

}
