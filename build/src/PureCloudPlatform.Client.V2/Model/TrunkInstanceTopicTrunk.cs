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
    /// TrunkInstanceTopicTrunk
    /// </summary>
    [DataContract]
    public partial class TrunkInstanceTopicTrunk :  IEquatable<TrunkInstanceTopicTrunk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunk" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ConnectedStatus">ConnectedStatus.</param>
        /// <param name="OptionsStatus">OptionsStatus.</param>
        /// <param name="RegistersStatus">RegistersStatus.</param>
        /// <param name="IpStatus">IpStatus.</param>
        public TrunkInstanceTopicTrunk(string Id = null, TrunkInstanceTopicTrunkConnectedStatus ConnectedStatus = null, List<TrunkInstanceTopicTrunkMetricsOptions> OptionsStatus = null, List<TrunkInstanceTopicTrunkMetricsRegisters> RegistersStatus = null, TrunkInstanceTopicTrunkMetricsNetworkTypeIp IpStatus = null)
        {
            this.Id = Id;
            this.ConnectedStatus = ConnectedStatus;
            this.OptionsStatus = OptionsStatus;
            this.RegistersStatus = RegistersStatus;
            this.IpStatus = IpStatus;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets ConnectedStatus
        /// </summary>
        [DataMember(Name="connectedStatus", EmitDefaultValue=false)]
        public TrunkInstanceTopicTrunkConnectedStatus ConnectedStatus { get; set; }



        /// <summary>
        /// Gets or Sets OptionsStatus
        /// </summary>
        [DataMember(Name="optionsStatus", EmitDefaultValue=false)]
        public List<TrunkInstanceTopicTrunkMetricsOptions> OptionsStatus { get; set; }



        /// <summary>
        /// Gets or Sets RegistersStatus
        /// </summary>
        [DataMember(Name="registersStatus", EmitDefaultValue=false)]
        public List<TrunkInstanceTopicTrunkMetricsRegisters> RegistersStatus { get; set; }



        /// <summary>
        /// Gets or Sets IpStatus
        /// </summary>
        [DataMember(Name="ipStatus", EmitDefaultValue=false)]
        public TrunkInstanceTopicTrunkMetricsNetworkTypeIp IpStatus { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkInstanceTopicTrunk {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConnectedStatus: ").Append(ConnectedStatus).Append("\n");
            sb.Append("  OptionsStatus: ").Append(OptionsStatus).Append("\n");
            sb.Append("  RegistersStatus: ").Append(RegistersStatus).Append("\n");
            sb.Append("  IpStatus: ").Append(IpStatus).Append("\n");
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
            return this.Equals(obj as TrunkInstanceTopicTrunk);
        }

        /// <summary>
        /// Returns true if TrunkInstanceTopicTrunk instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkInstanceTopicTrunk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkInstanceTopicTrunk other)
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
                    this.ConnectedStatus == other.ConnectedStatus ||
                    this.ConnectedStatus != null &&
                    this.ConnectedStatus.Equals(other.ConnectedStatus)
                ) &&
                (
                    this.OptionsStatus == other.OptionsStatus ||
                    this.OptionsStatus != null &&
                    this.OptionsStatus.SequenceEqual(other.OptionsStatus)
                ) &&
                (
                    this.RegistersStatus == other.RegistersStatus ||
                    this.RegistersStatus != null &&
                    this.RegistersStatus.SequenceEqual(other.RegistersStatus)
                ) &&
                (
                    this.IpStatus == other.IpStatus ||
                    this.IpStatus != null &&
                    this.IpStatus.Equals(other.IpStatus)
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

                if (this.ConnectedStatus != null)
                    hash = hash * 59 + this.ConnectedStatus.GetHashCode();

                if (this.OptionsStatus != null)
                    hash = hash * 59 + this.OptionsStatus.GetHashCode();

                if (this.RegistersStatus != null)
                    hash = hash * 59 + this.RegistersStatus.GetHashCode();

                if (this.IpStatus != null)
                    hash = hash * 59 + this.IpStatus.GetHashCode();

                return hash;
            }
        }
    }

}
