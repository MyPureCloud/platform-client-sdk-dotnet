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
    /// Reaction
    /// </summary>
    [DataContract]
    public partial class Reaction :  IEquatable<Reaction>
    {
        /// <summary>
        /// Gets or Sets ReactionType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReactionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hangup for "HANGUP"
            /// </summary>
            [EnumMember(Value = "HANGUP")]
            Hangup,
            
            /// <summary>
            /// Enum Transfer for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            /// <summary>
            /// Enum TransferFlow for "TRANSFER_FLOW"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FLOW")]
            TransferFlow,
            
            /// <summary>
            /// Enum PlayFile for "PLAY_FILE"
            /// </summary>
            [EnumMember(Value = "PLAY_FILE")]
            PlayFile
        }
        /// <summary>
        /// Gets or Sets ReactionType
        /// </summary>
        [DataMember(Name="reactionType", EmitDefaultValue=false)]
        public ReactionTypeEnum? ReactionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ReactionType">ReactionType.</param>
        public Reaction(string Data = null, string Name = null, ReactionTypeEnum? ReactionType = null)
        {
            this.Data = Data;
            this.Name = Name;
            this.ReactionType = ReactionType;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }
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
            sb.Append("class Reaction {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReactionType: ").Append(ReactionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Reaction);
        }

        /// <summary>
        /// Returns true if Reaction instances are equal
        /// </summary>
        /// <param name="other">Instance of Reaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ReactionType == other.ReactionType ||
                    this.ReactionType != null &&
                    this.ReactionType.Equals(other.ReactionType)
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
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ReactionType != null)
                    hash = hash * 59 + this.ReactionType.GetHashCode();
                return hash;
            }
        }
    }

}
