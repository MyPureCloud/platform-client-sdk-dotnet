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
    /// IdleTokenTimeout
    /// </summary>
    [DataContract]
    public partial class IdleTokenTimeout :  IEquatable<IdleTokenTimeout>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdleTokenTimeout" /> class.
        /// </summary>
        /// <param name="IdleTokenTimeoutSeconds">Token timeout length in seconds. Must be at least 5 minutes and 8 hours or less (if HIPAA is disabled) or 15 minutes or less (if HIPAA is enabled)..</param>
        /// <param name="EnableIdleTokenTimeout">Indicates whether the Token Timeout should be enabled or disabled..</param>
        public IdleTokenTimeout(int? IdleTokenTimeoutSeconds = null, bool? EnableIdleTokenTimeout = null)
        {
            this.IdleTokenTimeoutSeconds = IdleTokenTimeoutSeconds;
            this.EnableIdleTokenTimeout = EnableIdleTokenTimeout;
            
        }
        


        /// <summary>
        /// Token timeout length in seconds. Must be at least 5 minutes and 8 hours or less (if HIPAA is disabled) or 15 minutes or less (if HIPAA is enabled).
        /// </summary>
        /// <value>Token timeout length in seconds. Must be at least 5 minutes and 8 hours or less (if HIPAA is disabled) or 15 minutes or less (if HIPAA is enabled).</value>
        [DataMember(Name="idleTokenTimeoutSeconds", EmitDefaultValue=false)]
        public int? IdleTokenTimeoutSeconds { get; set; }



        /// <summary>
        /// Indicates whether the Token Timeout should be enabled or disabled.
        /// </summary>
        /// <value>Indicates whether the Token Timeout should be enabled or disabled.</value>
        [DataMember(Name="enableIdleTokenTimeout", EmitDefaultValue=false)]
        public bool? EnableIdleTokenTimeout { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdleTokenTimeout {\n");

            sb.Append("  IdleTokenTimeoutSeconds: ").Append(IdleTokenTimeoutSeconds).Append("\n");
            sb.Append("  EnableIdleTokenTimeout: ").Append(EnableIdleTokenTimeout).Append("\n");
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
            return this.Equals(obj as IdleTokenTimeout);
        }

        /// <summary>
        /// Returns true if IdleTokenTimeout instances are equal
        /// </summary>
        /// <param name="other">Instance of IdleTokenTimeout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdleTokenTimeout other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IdleTokenTimeoutSeconds == other.IdleTokenTimeoutSeconds ||
                    this.IdleTokenTimeoutSeconds != null &&
                    this.IdleTokenTimeoutSeconds.Equals(other.IdleTokenTimeoutSeconds)
                ) &&
                (
                    this.EnableIdleTokenTimeout == other.EnableIdleTokenTimeout ||
                    this.EnableIdleTokenTimeout != null &&
                    this.EnableIdleTokenTimeout.Equals(other.EnableIdleTokenTimeout)
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
                if (this.IdleTokenTimeoutSeconds != null)
                    hash = hash * 59 + this.IdleTokenTimeoutSeconds.GetHashCode();

                if (this.EnableIdleTokenTimeout != null)
                    hash = hash * 59 + this.EnableIdleTokenTimeout.GetHashCode();

                return hash;
            }
        }
    }

}
