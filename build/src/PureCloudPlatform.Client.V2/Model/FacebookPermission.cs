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
    /// Facebook Permissions Model
    /// </summary>
    [DataContract]
    public partial class FacebookPermission :  IEquatable<FacebookPermission>
    {
        /// <summary>
        /// Facebook permission type
        /// </summary>
        /// <value>Facebook permission type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Facebookprivate for "FacebookPrivate"
            /// </summary>
            [EnumMember(Value = "FacebookPrivate")]
            Facebookprivate,
            
            /// <summary>
            /// Enum Facebookpublic for "FacebookPublic"
            /// </summary>
            [EnumMember(Value = "FacebookPublic")]
            Facebookpublic,
            
            /// <summary>
            /// Enum Instagramprivate for "InstagramPrivate"
            /// </summary>
            [EnumMember(Value = "InstagramPrivate")]
            Instagramprivate,
            
            /// <summary>
            /// Enum Whatsappprivate for "WhatsAppPrivate"
            /// </summary>
            [EnumMember(Value = "WhatsAppPrivate")]
            Whatsappprivate
        }
        /// <summary>
        /// Facebook permission type
        /// </summary>
        /// <value>Facebook permission type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookPermission" /> class.
        /// </summary>
        public FacebookPermission()
        {
            
        }
        


        /// <summary>
        /// Facebook permission name
        /// </summary>
        /// <value>Facebook permission name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacebookPermission {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as FacebookPermission);
        }

        /// <summary>
        /// Returns true if FacebookPermission instances are equal
        /// </summary>
        /// <param name="other">Instance of FacebookPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacebookPermission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
