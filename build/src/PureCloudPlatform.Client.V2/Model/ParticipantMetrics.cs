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
    /// ParticipantMetrics
    /// </summary>
    [DataContract]
    public partial class ParticipantMetrics :  IEquatable<ParticipantMetrics>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantMetrics" /> class.
        /// </summary>
        /// <param name="AgentDurationPercentage">Percentage of Agent duration in the conversation.</param>
        /// <param name="CustomerDurationPercentage">Percentage of Customer duration in the conversation.</param>
        /// <param name="SilenceDurationPercentage">Percentage of Silence duration in the conversation.</param>
        /// <param name="IvrDurationPercentage">Percentage of IVR duration in the conversation.</param>
        /// <param name="AcdDurationPercentage">Percentage of ACD duration in the conversation.</param>
        /// <param name="OvertalkDurationPercentage">Percentage of Overtalk duration in the conversation.</param>
        /// <param name="OtherDurationPercentage">Percentage of Other events duration in the conversation.</param>
        /// <param name="OvertalkCount">Number of Overtalks in the conversation.</param>
        public ParticipantMetrics(double? AgentDurationPercentage = null, double? CustomerDurationPercentage = null, double? SilenceDurationPercentage = null, double? IvrDurationPercentage = null, double? AcdDurationPercentage = null, double? OvertalkDurationPercentage = null, double? OtherDurationPercentage = null, int? OvertalkCount = null)
        {
            this.AgentDurationPercentage = AgentDurationPercentage;
            this.CustomerDurationPercentage = CustomerDurationPercentage;
            this.SilenceDurationPercentage = SilenceDurationPercentage;
            this.IvrDurationPercentage = IvrDurationPercentage;
            this.AcdDurationPercentage = AcdDurationPercentage;
            this.OvertalkDurationPercentage = OvertalkDurationPercentage;
            this.OtherDurationPercentage = OtherDurationPercentage;
            this.OvertalkCount = OvertalkCount;
            
        }
        
        
        
        /// <summary>
        /// Percentage of Agent duration in the conversation
        /// </summary>
        /// <value>Percentage of Agent duration in the conversation</value>
        [DataMember(Name="agentDurationPercentage", EmitDefaultValue=false)]
        public double? AgentDurationPercentage { get; set; }
        
        
        
        /// <summary>
        /// Percentage of Customer duration in the conversation
        /// </summary>
        /// <value>Percentage of Customer duration in the conversation</value>
        [DataMember(Name="customerDurationPercentage", EmitDefaultValue=false)]
        public double? CustomerDurationPercentage { get; set; }
        
        
        
        /// <summary>
        /// Percentage of Silence duration in the conversation
        /// </summary>
        /// <value>Percentage of Silence duration in the conversation</value>
        [DataMember(Name="silenceDurationPercentage", EmitDefaultValue=false)]
        public double? SilenceDurationPercentage { get; set; }
        
        
        
        /// <summary>
        /// Percentage of IVR duration in the conversation
        /// </summary>
        /// <value>Percentage of IVR duration in the conversation</value>
        [DataMember(Name="ivrDurationPercentage", EmitDefaultValue=false)]
        public double? IvrDurationPercentage { get; set; }
        
        
        
        /// <summary>
        /// Percentage of ACD duration in the conversation
        /// </summary>
        /// <value>Percentage of ACD duration in the conversation</value>
        [DataMember(Name="acdDurationPercentage", EmitDefaultValue=false)]
        public double? AcdDurationPercentage { get; set; }
        
        
        
        /// <summary>
        /// Percentage of Overtalk duration in the conversation
        /// </summary>
        /// <value>Percentage of Overtalk duration in the conversation</value>
        [DataMember(Name="overtalkDurationPercentage", EmitDefaultValue=false)]
        public double? OvertalkDurationPercentage { get; set; }
        
        
        
        /// <summary>
        /// Percentage of Other events duration in the conversation
        /// </summary>
        /// <value>Percentage of Other events duration in the conversation</value>
        [DataMember(Name="otherDurationPercentage", EmitDefaultValue=false)]
        public double? OtherDurationPercentage { get; set; }
        
        
        
        /// <summary>
        /// Number of Overtalks in the conversation
        /// </summary>
        /// <value>Number of Overtalks in the conversation</value>
        [DataMember(Name="overtalkCount", EmitDefaultValue=false)]
        public int? OvertalkCount { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticipantMetrics {\n");
            
            sb.Append("  AgentDurationPercentage: ").Append(AgentDurationPercentage).Append("\n");
            sb.Append("  CustomerDurationPercentage: ").Append(CustomerDurationPercentage).Append("\n");
            sb.Append("  SilenceDurationPercentage: ").Append(SilenceDurationPercentage).Append("\n");
            sb.Append("  IvrDurationPercentage: ").Append(IvrDurationPercentage).Append("\n");
            sb.Append("  AcdDurationPercentage: ").Append(AcdDurationPercentage).Append("\n");
            sb.Append("  OvertalkDurationPercentage: ").Append(OvertalkDurationPercentage).Append("\n");
            sb.Append("  OtherDurationPercentage: ").Append(OtherDurationPercentage).Append("\n");
            sb.Append("  OvertalkCount: ").Append(OvertalkCount).Append("\n");
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
            return this.Equals(obj as ParticipantMetrics);
        }

        /// <summary>
        /// Returns true if ParticipantMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of ParticipantMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentDurationPercentage == other.AgentDurationPercentage ||
                    this.AgentDurationPercentage != null &&
                    this.AgentDurationPercentage.Equals(other.AgentDurationPercentage)
                ) &&
                (
                    this.CustomerDurationPercentage == other.CustomerDurationPercentage ||
                    this.CustomerDurationPercentage != null &&
                    this.CustomerDurationPercentage.Equals(other.CustomerDurationPercentage)
                ) &&
                (
                    this.SilenceDurationPercentage == other.SilenceDurationPercentage ||
                    this.SilenceDurationPercentage != null &&
                    this.SilenceDurationPercentage.Equals(other.SilenceDurationPercentage)
                ) &&
                (
                    this.IvrDurationPercentage == other.IvrDurationPercentage ||
                    this.IvrDurationPercentage != null &&
                    this.IvrDurationPercentage.Equals(other.IvrDurationPercentage)
                ) &&
                (
                    this.AcdDurationPercentage == other.AcdDurationPercentage ||
                    this.AcdDurationPercentage != null &&
                    this.AcdDurationPercentage.Equals(other.AcdDurationPercentage)
                ) &&
                (
                    this.OvertalkDurationPercentage == other.OvertalkDurationPercentage ||
                    this.OvertalkDurationPercentage != null &&
                    this.OvertalkDurationPercentage.Equals(other.OvertalkDurationPercentage)
                ) &&
                (
                    this.OtherDurationPercentage == other.OtherDurationPercentage ||
                    this.OtherDurationPercentage != null &&
                    this.OtherDurationPercentage.Equals(other.OtherDurationPercentage)
                ) &&
                (
                    this.OvertalkCount == other.OvertalkCount ||
                    this.OvertalkCount != null &&
                    this.OvertalkCount.Equals(other.OvertalkCount)
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
                
                if (this.AgentDurationPercentage != null)
                    hash = hash * 59 + this.AgentDurationPercentage.GetHashCode();
                
                if (this.CustomerDurationPercentage != null)
                    hash = hash * 59 + this.CustomerDurationPercentage.GetHashCode();
                
                if (this.SilenceDurationPercentage != null)
                    hash = hash * 59 + this.SilenceDurationPercentage.GetHashCode();
                
                if (this.IvrDurationPercentage != null)
                    hash = hash * 59 + this.IvrDurationPercentage.GetHashCode();
                
                if (this.AcdDurationPercentage != null)
                    hash = hash * 59 + this.AcdDurationPercentage.GetHashCode();
                
                if (this.OvertalkDurationPercentage != null)
                    hash = hash * 59 + this.OvertalkDurationPercentage.GetHashCode();
                
                if (this.OtherDurationPercentage != null)
                    hash = hash * 59 + this.OtherDurationPercentage.GetHashCode();
                
                if (this.OvertalkCount != null)
                    hash = hash * 59 + this.OvertalkCount.GetHashCode();
                
                return hash;
            }
        }
    }

}
