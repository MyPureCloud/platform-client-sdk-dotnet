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
    /// Station
    /// </summary>
    [DataContract]
    public partial class Station :  IEquatable<Station>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Available for "AVAILABLE"
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            Available,
            
            /// <summary>
            /// Enum Associated for "ASSOCIATED"
            /// </summary>
            [EnumMember(Value = "ASSOCIATED")]
            Associated
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Station" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Status">Status.</param>
        /// <param name="UserId">The Id of the user currently logged in and associated with the station..</param>
        /// <param name="WebRtcUserId">The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone..</param>
        /// <param name="PrimaryEdge">PrimaryEdge.</param>
        /// <param name="SecondaryEdge">SecondaryEdge.</param>
        /// <param name="Type">Type.</param>
        /// <param name="LineAppearanceId">LineAppearanceId.</param>
        public Station(string Name = null, string Description = null, StatusEnum? Status = null, string UserId = null, string WebRtcUserId = null, DomainEntityRef PrimaryEdge = null, DomainEntityRef SecondaryEdge = null, string Type = null, string LineAppearanceId = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Status = Status;
            this.UserId = UserId;
            this.WebRtcUserId = WebRtcUserId;
            this.PrimaryEdge = PrimaryEdge;
            this.SecondaryEdge = SecondaryEdge;
            this.Type = Type;
            this.LineAppearanceId = LineAppearanceId;
            
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// The Id of the user currently logged in and associated with the station.
        /// </summary>
        /// <value>The Id of the user currently logged in and associated with the station.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone.
        /// </summary>
        /// <value>The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone.</value>
        [DataMember(Name="webRtcUserId", EmitDefaultValue=false)]
        public string WebRtcUserId { get; set; }



        /// <summary>
        /// Gets or Sets PrimaryEdge
        /// </summary>
        [DataMember(Name="primaryEdge", EmitDefaultValue=false)]
        public DomainEntityRef PrimaryEdge { get; set; }



        /// <summary>
        /// Gets or Sets SecondaryEdge
        /// </summary>
        [DataMember(Name="secondaryEdge", EmitDefaultValue=false)]
        public DomainEntityRef SecondaryEdge { get; set; }



        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// Gets or Sets LineAppearanceId
        /// </summary>
        [DataMember(Name="lineAppearanceId", EmitDefaultValue=false)]
        public string LineAppearanceId { get; set; }



        /// <summary>
        /// The default or configured value of media dscp for the station. Empty if station type is not inin_webrtc_softphone.
        /// </summary>
        /// <value>The default or configured value of media dscp for the station. Empty if station type is not inin_webrtc_softphone.</value>
        [DataMember(Name="webRtcMediaDscp", EmitDefaultValue=false)]
        public int? WebRtcMediaDscp { get; private set; }



        /// <summary>
        /// The default or configured value of persistent connection setting for the station. Empty if station type is not inin_webrtc_softphone.
        /// </summary>
        /// <value>The default or configured value of persistent connection setting for the station. Empty if station type is not inin_webrtc_softphone.</value>
        [DataMember(Name="webRtcPersistentEnabled", EmitDefaultValue=false)]
        public bool? WebRtcPersistentEnabled { get; private set; }



        /// <summary>
        /// Whether the station is configured to require TURN for routing WebRTC calls. Empty if station type is not inin_webrtc_softphone.
        /// </summary>
        /// <value>Whether the station is configured to require TURN for routing WebRTC calls. Empty if station type is not inin_webrtc_softphone.</value>
        [DataMember(Name="webRtcForceTurn", EmitDefaultValue=false)]
        public bool? WebRtcForceTurn { get; private set; }



        /// <summary>
        /// The number of call appearances on the station.
        /// </summary>
        /// <value>The number of call appearances on the station.</value>
        [DataMember(Name="webRtcCallAppearances", EmitDefaultValue=false)]
        public int? WebRtcCallAppearances { get; private set; }



        /// <summary>
        /// True when the media helper required.
        /// </summary>
        /// <value>True when the media helper required.</value>
        [DataMember(Name="webRtcRequireMediaHelper", EmitDefaultValue=false)]
        public bool? WebRtcRequireMediaHelper { get; private set; }



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
            sb.Append("class Station {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WebRtcUserId: ").Append(WebRtcUserId).Append("\n");
            sb.Append("  PrimaryEdge: ").Append(PrimaryEdge).Append("\n");
            sb.Append("  SecondaryEdge: ").Append(SecondaryEdge).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LineAppearanceId: ").Append(LineAppearanceId).Append("\n");
            sb.Append("  WebRtcMediaDscp: ").Append(WebRtcMediaDscp).Append("\n");
            sb.Append("  WebRtcPersistentEnabled: ").Append(WebRtcPersistentEnabled).Append("\n");
            sb.Append("  WebRtcForceTurn: ").Append(WebRtcForceTurn).Append("\n");
            sb.Append("  WebRtcCallAppearances: ").Append(WebRtcCallAppearances).Append("\n");
            sb.Append("  WebRtcRequireMediaHelper: ").Append(WebRtcRequireMediaHelper).Append("\n");
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
            return this.Equals(obj as Station);
        }

        /// <summary>
        /// Returns true if Station instances are equal
        /// </summary>
        /// <param name="other">Instance of Station to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Station other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.WebRtcUserId == other.WebRtcUserId ||
                    this.WebRtcUserId != null &&
                    this.WebRtcUserId.Equals(other.WebRtcUserId)
                ) &&
                (
                    this.PrimaryEdge == other.PrimaryEdge ||
                    this.PrimaryEdge != null &&
                    this.PrimaryEdge.Equals(other.PrimaryEdge)
                ) &&
                (
                    this.SecondaryEdge == other.SecondaryEdge ||
                    this.SecondaryEdge != null &&
                    this.SecondaryEdge.Equals(other.SecondaryEdge)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.LineAppearanceId == other.LineAppearanceId ||
                    this.LineAppearanceId != null &&
                    this.LineAppearanceId.Equals(other.LineAppearanceId)
                ) &&
                (
                    this.WebRtcMediaDscp == other.WebRtcMediaDscp ||
                    this.WebRtcMediaDscp != null &&
                    this.WebRtcMediaDscp.Equals(other.WebRtcMediaDscp)
                ) &&
                (
                    this.WebRtcPersistentEnabled == other.WebRtcPersistentEnabled ||
                    this.WebRtcPersistentEnabled != null &&
                    this.WebRtcPersistentEnabled.Equals(other.WebRtcPersistentEnabled)
                ) &&
                (
                    this.WebRtcForceTurn == other.WebRtcForceTurn ||
                    this.WebRtcForceTurn != null &&
                    this.WebRtcForceTurn.Equals(other.WebRtcForceTurn)
                ) &&
                (
                    this.WebRtcCallAppearances == other.WebRtcCallAppearances ||
                    this.WebRtcCallAppearances != null &&
                    this.WebRtcCallAppearances.Equals(other.WebRtcCallAppearances)
                ) &&
                (
                    this.WebRtcRequireMediaHelper == other.WebRtcRequireMediaHelper ||
                    this.WebRtcRequireMediaHelper != null &&
                    this.WebRtcRequireMediaHelper.Equals(other.WebRtcRequireMediaHelper)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.WebRtcUserId != null)
                    hash = hash * 59 + this.WebRtcUserId.GetHashCode();

                if (this.PrimaryEdge != null)
                    hash = hash * 59 + this.PrimaryEdge.GetHashCode();

                if (this.SecondaryEdge != null)
                    hash = hash * 59 + this.SecondaryEdge.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.LineAppearanceId != null)
                    hash = hash * 59 + this.LineAppearanceId.GetHashCode();

                if (this.WebRtcMediaDscp != null)
                    hash = hash * 59 + this.WebRtcMediaDscp.GetHashCode();

                if (this.WebRtcPersistentEnabled != null)
                    hash = hash * 59 + this.WebRtcPersistentEnabled.GetHashCode();

                if (this.WebRtcForceTurn != null)
                    hash = hash * 59 + this.WebRtcForceTurn.GetHashCode();

                if (this.WebRtcCallAppearances != null)
                    hash = hash * 59 + this.WebRtcCallAppearances.GetHashCode();

                if (this.WebRtcRequireMediaHelper != null)
                    hash = hash * 59 + this.WebRtcRequireMediaHelper.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
