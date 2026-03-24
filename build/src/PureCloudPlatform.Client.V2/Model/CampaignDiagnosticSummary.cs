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
    /// CampaignDiagnosticSummary
    /// </summary>
    [DataContract]
    public partial class CampaignDiagnosticSummary :  IEquatable<CampaignDiagnosticSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDiagnosticSummary" /> class.
        /// </summary>
        /// <param name="CampaignId">Campaign ID.</param>
        /// <param name="DateStart">Start of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateEnd">End of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CampaignStates">Array of campaign states.</param>
        /// <param name="CampaignInfo">Array of diagnostic windows.</param>
        /// <param name="CampaignHealthStates">Array of campaign health states.</param>
        /// <param name="ConfigChanges">Configuration changes occurring within the time window.</param>
        public CampaignDiagnosticSummary(string CampaignId = null, DateTime? DateStart = null, DateTime? DateEnd = null, List<CampaignDiagnosticCampaignState> CampaignStates = null, List<CampaignDiagnosticWindow> CampaignInfo = null, List<CampaignDiagnosticCampaignHealthState> CampaignHealthStates = null, List<CampaignDiagnosticConfigChange> ConfigChanges = null)
        {
            this.CampaignId = CampaignId;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.CampaignStates = CampaignStates;
            this.CampaignInfo = CampaignInfo;
            this.CampaignHealthStates = CampaignHealthStates;
            this.ConfigChanges = ConfigChanges;
            
        }
        


        /// <summary>
        /// Campaign ID
        /// </summary>
        /// <value>Campaign ID</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }



        /// <summary>
        /// Start of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// End of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>End of the interval. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }



        /// <summary>
        /// Array of campaign states
        /// </summary>
        /// <value>Array of campaign states</value>
        [DataMember(Name="campaignStates", EmitDefaultValue=false)]
        public List<CampaignDiagnosticCampaignState> CampaignStates { get; set; }



        /// <summary>
        /// Array of diagnostic windows
        /// </summary>
        /// <value>Array of diagnostic windows</value>
        [DataMember(Name="campaignInfo", EmitDefaultValue=false)]
        public List<CampaignDiagnosticWindow> CampaignInfo { get; set; }



        /// <summary>
        /// Array of campaign health states
        /// </summary>
        /// <value>Array of campaign health states</value>
        [DataMember(Name="campaignHealthStates", EmitDefaultValue=false)]
        public List<CampaignDiagnosticCampaignHealthState> CampaignHealthStates { get; set; }



        /// <summary>
        /// Configuration changes occurring within the time window
        /// </summary>
        /// <value>Configuration changes occurring within the time window</value>
        [DataMember(Name="configChanges", EmitDefaultValue=false)]
        public List<CampaignDiagnosticConfigChange> ConfigChanges { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignDiagnosticSummary {\n");

            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  CampaignStates: ").Append(CampaignStates).Append("\n");
            sb.Append("  CampaignInfo: ").Append(CampaignInfo).Append("\n");
            sb.Append("  CampaignHealthStates: ").Append(CampaignHealthStates).Append("\n");
            sb.Append("  ConfigChanges: ").Append(ConfigChanges).Append("\n");
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
            return this.Equals(obj as CampaignDiagnosticSummary);
        }

        /// <summary>
        /// Returns true if CampaignDiagnosticSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignDiagnosticSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignDiagnosticSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CampaignId == other.CampaignId ||
                    this.CampaignId != null &&
                    this.CampaignId.Equals(other.CampaignId)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.CampaignStates == other.CampaignStates ||
                    this.CampaignStates != null &&
                    this.CampaignStates.SequenceEqual(other.CampaignStates)
                ) &&
                (
                    this.CampaignInfo == other.CampaignInfo ||
                    this.CampaignInfo != null &&
                    this.CampaignInfo.SequenceEqual(other.CampaignInfo)
                ) &&
                (
                    this.CampaignHealthStates == other.CampaignHealthStates ||
                    this.CampaignHealthStates != null &&
                    this.CampaignHealthStates.SequenceEqual(other.CampaignHealthStates)
                ) &&
                (
                    this.ConfigChanges == other.ConfigChanges ||
                    this.ConfigChanges != null &&
                    this.ConfigChanges.SequenceEqual(other.ConfigChanges)
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
                if (this.CampaignId != null)
                    hash = hash * 59 + this.CampaignId.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.CampaignStates != null)
                    hash = hash * 59 + this.CampaignStates.GetHashCode();

                if (this.CampaignInfo != null)
                    hash = hash * 59 + this.CampaignInfo.GetHashCode();

                if (this.CampaignHealthStates != null)
                    hash = hash * 59 + this.CampaignHealthStates.GetHashCode();

                if (this.ConfigChanges != null)
                    hash = hash * 59 + this.ConfigChanges.GetHashCode();

                return hash;
            }
        }
    }

}
