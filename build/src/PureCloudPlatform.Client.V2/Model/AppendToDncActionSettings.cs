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
    /// AppendToDncActionSettings
    /// </summary>
    [DataContract]
    public partial class AppendToDncActionSettings :  IEquatable<AppendToDncActionSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AppendToDncActionSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppendToDncActionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppendToDncActionSettings" /> class.
        /// </summary>
        /// <param name="Expire">Whether to expire the record appended to the DNC list. (required).</param>
        /// <param name="ExpirationDuration">If 'expire' is set to true, how long to keep the record..</param>
        public AppendToDncActionSettings(bool? Expire = null, string ExpirationDuration = null)
        {
            this.Expire = Expire;
            this.ExpirationDuration = ExpirationDuration;
            
        }
        


        /// <summary>
        /// Whether to expire the record appended to the DNC list.
        /// </summary>
        /// <value>Whether to expire the record appended to the DNC list.</value>
        [DataMember(Name="expire", EmitDefaultValue=false)]
        public bool? Expire { get; set; }



        /// <summary>
        /// If 'expire' is set to true, how long to keep the record.
        /// </summary>
        /// <value>If 'expire' is set to true, how long to keep the record.</value>
        [DataMember(Name="expirationDuration", EmitDefaultValue=false)]
        public string ExpirationDuration { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppendToDncActionSettings {\n");

            sb.Append("  Expire: ").Append(Expire).Append("\n");
            sb.Append("  ExpirationDuration: ").Append(ExpirationDuration).Append("\n");
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
            return this.Equals(obj as AppendToDncActionSettings);
        }

        /// <summary>
        /// Returns true if AppendToDncActionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AppendToDncActionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppendToDncActionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Expire == other.Expire ||
                    this.Expire != null &&
                    this.Expire.Equals(other.Expire)
                ) &&
                (
                    this.ExpirationDuration == other.ExpirationDuration ||
                    this.ExpirationDuration != null &&
                    this.ExpirationDuration.Equals(other.ExpirationDuration)
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
                if (this.Expire != null)
                    hash = hash * 59 + this.Expire.GetHashCode();

                if (this.ExpirationDuration != null)
                    hash = hash * 59 + this.ExpirationDuration.GetHashCode();

                return hash;
            }
        }
    }

}
