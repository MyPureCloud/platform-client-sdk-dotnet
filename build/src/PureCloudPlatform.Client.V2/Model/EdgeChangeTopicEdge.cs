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
    /// EdgeChangeTopicEdge
    /// </summary>
    [DataContract]
    public partial class EdgeChangeTopicEdge :  IEquatable<EdgeChangeTopicEdge>
    {
        /// <summary>
        /// Gets or Sets OnlineStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OnlineStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Online for "ONLINE"
            /// </summary>
            [EnumMember(Value = "ONLINE")]
            Online,
            
            /// <summary>
            /// Enum Offline for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            Offline
        }
        /// <summary>
        /// Gets or Sets OnlineStatus
        /// </summary>
        [DataMember(Name="onlineStatus", EmitDefaultValue=false)]
        public OnlineStatusEnum? OnlineStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeChangeTopicEdge" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="OnlineStatus">OnlineStatus.</param>
        public EdgeChangeTopicEdge(string Id = null, OnlineStatusEnum? OnlineStatus = null)
        {
            this.Id = Id;
            this.OnlineStatus = OnlineStatus;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeChangeTopicEdge {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OnlineStatus: ").Append(OnlineStatus).Append("\n");
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
            return this.Equals(obj as EdgeChangeTopicEdge);
        }

        /// <summary>
        /// Returns true if EdgeChangeTopicEdge instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeChangeTopicEdge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeChangeTopicEdge other)
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
                    this.OnlineStatus == other.OnlineStatus ||
                    this.OnlineStatus != null &&
                    this.OnlineStatus.Equals(other.OnlineStatus)
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

                if (this.OnlineStatus != null)
                    hash = hash * 59 + this.OnlineStatus.GetHashCode();

                return hash;
            }
        }
    }

}
