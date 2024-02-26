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
    /// CobrowseWebMessagingSession
    /// </summary>
    [DataContract]
    public partial class CobrowseWebMessagingSession :  IEquatable<CobrowseWebMessagingSession>
    {
        /// <summary>
        /// CommunicationType for Cobrowse Session
        /// </summary>
        /// <value>CommunicationType for Cobrowse Session</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CommunicationTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// CommunicationType for Cobrowse Session
        /// </summary>
        /// <value>CommunicationType for Cobrowse Session</value>
        [DataMember(Name="communicationType", EmitDefaultValue=false)]
        public CommunicationTypeEnum? CommunicationType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CobrowseWebMessagingSession" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        public CobrowseWebMessagingSession(string Name = null)
        {
            this.Name = Name;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Cobrowse session join code
        /// </summary>
        /// <value>Cobrowse session join code</value>
        [DataMember(Name="joinCode", EmitDefaultValue=false)]
        public string JoinCode { get; private set; }



        /// <summary>
        /// WebSocket URL for the JS client
        /// </summary>
        /// <value>WebSocket URL for the JS client</value>
        [DataMember(Name="websocketUrl", EmitDefaultValue=false)]
        public string WebsocketUrl { get; private set; }



        /// <summary>
        /// Date when Cobrowse Offer Expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when Cobrowse Offer Expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateOfferEnds", EmitDefaultValue=false)]
        public DateTime? DateOfferEnds { get; private set; }





        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CobrowseWebMessagingSession {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  JoinCode: ").Append(JoinCode).Append("\n");
            sb.Append("  WebsocketUrl: ").Append(WebsocketUrl).Append("\n");
            sb.Append("  DateOfferEnds: ").Append(DateOfferEnds).Append("\n");
            sb.Append("  CommunicationType: ").Append(CommunicationType).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as CobrowseWebMessagingSession);
        }

        /// <summary>
        /// Returns true if CobrowseWebMessagingSession instances are equal
        /// </summary>
        /// <param name="other">Instance of CobrowseWebMessagingSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CobrowseWebMessagingSession other)
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
                    this.JoinCode == other.JoinCode ||
                    this.JoinCode != null &&
                    this.JoinCode.Equals(other.JoinCode)
                ) &&
                (
                    this.WebsocketUrl == other.WebsocketUrl ||
                    this.WebsocketUrl != null &&
                    this.WebsocketUrl.Equals(other.WebsocketUrl)
                ) &&
                (
                    this.DateOfferEnds == other.DateOfferEnds ||
                    this.DateOfferEnds != null &&
                    this.DateOfferEnds.Equals(other.DateOfferEnds)
                ) &&
                (
                    this.CommunicationType == other.CommunicationType ||
                    this.CommunicationType != null &&
                    this.CommunicationType.Equals(other.CommunicationType)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.JoinCode != null)
                    hash = hash * 59 + this.JoinCode.GetHashCode();

                if (this.WebsocketUrl != null)
                    hash = hash * 59 + this.WebsocketUrl.GetHashCode();

                if (this.DateOfferEnds != null)
                    hash = hash * 59 + this.DateOfferEnds.GetHashCode();

                if (this.CommunicationType != null)
                    hash = hash * 59 + this.CommunicationType.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
