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
    /// ConnectionCreateRequest
    /// </summary>
    [DataContract]
    public partial class ConnectionCreateRequest :  IEquatable<ConnectionCreateRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionCreateRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Connection.</param>
        /// <param name="IntegrationId">Integration ID of the Connection (required).</param>
        /// <param name="RedirectUrl">Redirect Url for the Oauth flow (required).</param>
        public ConnectionCreateRequest(string Name = null, string IntegrationId = null, string RedirectUrl = null)
        {
            this.Name = Name;
            this.IntegrationId = IntegrationId;
            this.RedirectUrl = RedirectUrl;
            
        }
        


        /// <summary>
        /// The name of the Connection
        /// </summary>
        /// <value>The name of the Connection</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Integration ID of the Connection
        /// </summary>
        /// <value>Integration ID of the Connection</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }



        /// <summary>
        /// Redirect Url for the Oauth flow
        /// </summary>
        /// <value>Redirect Url for the Oauth flow</value>
        [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionCreateRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
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
            return this.Equals(obj as ConnectionCreateRequest);
        }

        /// <summary>
        /// Returns true if ConnectionCreateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectionCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionCreateRequest other)
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
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.RedirectUrl == other.RedirectUrl ||
                    this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(other.RedirectUrl)
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

                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                if (this.RedirectUrl != null)
                    hash = hash * 59 + this.RedirectUrl.GetHashCode();

                return hash;
            }
        }
    }

}
