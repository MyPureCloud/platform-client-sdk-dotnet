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
    /// CampaignOutboundLinesReservation
    /// </summary>
    [DataContract]
    public partial class CampaignOutboundLinesReservation :  IEquatable<CampaignOutboundLinesReservation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignOutboundLinesReservation" /> class.
        /// </summary>
        /// <param name="Campaign">The Campaign.</param>
        /// <param name="LinesReserved">The number of lines reserved for the campaign.</param>
        public CampaignOutboundLinesReservation(DomainEntityRef Campaign = null, int? LinesReserved = null)
        {
            this.Campaign = Campaign;
            this.LinesReserved = LinesReserved;
            
        }
        


        /// <summary>
        /// The Campaign
        /// </summary>
        /// <value>The Campaign</value>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public DomainEntityRef Campaign { get; set; }



        /// <summary>
        /// The number of lines reserved for the campaign
        /// </summary>
        /// <value>The number of lines reserved for the campaign</value>
        [DataMember(Name="linesReserved", EmitDefaultValue=false)]
        public int? LinesReserved { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignOutboundLinesReservation {\n");

            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  LinesReserved: ").Append(LinesReserved).Append("\n");
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
            return this.Equals(obj as CampaignOutboundLinesReservation);
        }

        /// <summary>
        /// Returns true if CampaignOutboundLinesReservation instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignOutboundLinesReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignOutboundLinesReservation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
                ) &&
                (
                    this.LinesReserved == other.LinesReserved ||
                    this.LinesReserved != null &&
                    this.LinesReserved.Equals(other.LinesReserved)
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
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();

                if (this.LinesReserved != null)
                    hash = hash * 59 + this.LinesReserved.GetHashCode();

                return hash;
            }
        }
    }

}
