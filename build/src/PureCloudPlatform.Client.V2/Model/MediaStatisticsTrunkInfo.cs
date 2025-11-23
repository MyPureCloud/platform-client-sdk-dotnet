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
    /// MediaStatisticsTrunkInfo
    /// </summary>
    [DataContract]
    public partial class MediaStatisticsTrunkInfo :  IEquatable<MediaStatisticsTrunkInfo>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External,
            
            /// <summary>
            /// Enum Externalpcv for "external.pcv"
            /// </summary>
            [EnumMember(Value = "external.pcv")]
            Externalpcv,
            
            /// <summary>
            /// Enum Externalpcvaws for "external.pcv.aws"
            /// </summary>
            [EnumMember(Value = "external.pcv.aws")]
            Externalpcvaws,
            
            /// <summary>
            /// Enum Externalpcvbyoccarrier for "external.pcv.byoc.carrier"
            /// </summary>
            [EnumMember(Value = "external.pcv.byoc.carrier")]
            Externalpcvbyoccarrier,
            
            /// <summary>
            /// Enum Externalpcvbyocpbx for "external.pcv.byoc.pbx"
            /// </summary>
            [EnumMember(Value = "external.pcv.byoc.pbx")]
            Externalpcvbyocpbx,
            
            /// <summary>
            /// Enum Tie for "tie"
            /// </summary>
            [EnumMember(Value = "tie")]
            Tie,
            
            /// <summary>
            /// Enum Tiedirect for "tie.direct"
            /// </summary>
            [EnumMember(Value = "tie.direct")]
            Tiedirect,
            
            /// <summary>
            /// Enum Tieindirect for "tie.indirect"
            /// </summary>
            [EnumMember(Value = "tie.indirect")]
            Tieindirect,
            
            /// <summary>
            /// Enum Tiecloudproxy for "tie.cloud.proxy"
            /// </summary>
            [EnumMember(Value = "tie.cloud.proxy")]
            Tiecloudproxy,
            
            /// <summary>
            /// Enum Tiecloudproxycallsession for "tie.cloud.proxy.callsession"
            /// </summary>
            [EnumMember(Value = "tie.cloud.proxy.callsession")]
            Tiecloudproxycallsession,
            
            /// <summary>
            /// Enum Station for "station"
            /// </summary>
            [EnumMember(Value = "station")]
            Station,
            
            /// <summary>
            /// Enum Stationcdm for "station.cdm"
            /// </summary>
            [EnumMember(Value = "station.cdm")]
            Stationcdm,
            
            /// <summary>
            /// Enum Stationcdmwebrtc for "station.cdm.webrtc"
            /// </summary>
            [EnumMember(Value = "station.cdm.webrtc")]
            Stationcdmwebrtc
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaStatisticsTrunkInfo" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        public MediaStatisticsTrunkInfo(string Id = null, string Name = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaStatisticsTrunkInfo {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as MediaStatisticsTrunkInfo);
        }

        /// <summary>
        /// Returns true if MediaStatisticsTrunkInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaStatisticsTrunkInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaStatisticsTrunkInfo other)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
