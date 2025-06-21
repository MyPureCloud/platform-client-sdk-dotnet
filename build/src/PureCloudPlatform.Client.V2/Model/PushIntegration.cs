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
    /// PushIntegration
    /// </summary>
    [DataContract]
    public partial class PushIntegration :  IEquatable<PushIntegration>
    {
        /// <summary>
        /// The integration provider associated with the deployment
        /// </summary>
        /// <value>The integration provider associated with the deployment</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ProviderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Apns for "APNS"
            /// </summary>
            [EnumMember(Value = "APNS")]
            Apns,
            
            /// <summary>
            /// Enum Fcm for "FCM"
            /// </summary>
            [EnumMember(Value = "FCM")]
            Fcm
        }
        /// <summary>
        /// The integration provider associated with the deployment
        /// </summary>
        /// <value>The integration provider associated with the deployment</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public ProviderEnum? Provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushIntegration" /> class.
        /// </summary>
        /// <param name="Id">The mobile push integration id associated with the deployment.</param>
        /// <param name="Provider">The integration provider associated with the deployment.</param>
        public PushIntegration(string Id = null, ProviderEnum? Provider = null)
        {
            this.Id = Id;
            this.Provider = Provider;
            
        }
        


        /// <summary>
        /// The mobile push integration id associated with the deployment
        /// </summary>
        /// <value>The mobile push integration id associated with the deployment</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushIntegration {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
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
            return this.Equals(obj as PushIntegration);
        }

        /// <summary>
        /// Returns true if PushIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of PushIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushIntegration other)
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
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
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

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                return hash;
            }
        }
    }

}
