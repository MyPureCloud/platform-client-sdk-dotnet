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
    /// MessagingCampaignDiagnostics
    /// </summary>
    [DataContract]
    public partial class MessagingCampaignDiagnostics :  IEquatable<MessagingCampaignDiagnostics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingCampaignDiagnostics" /> class.
        /// </summary>
        public MessagingCampaignDiagnostics()
        {
            
        }
        


        /// <summary>
        /// Current number of time zone rescheduled messages on the campaign
        /// </summary>
        /// <value>Current number of time zone rescheduled messages on the campaign</value>
        [DataMember(Name="timeZoneRescheduledContactsCount", EmitDefaultValue=false)]
        public int? TimeZoneRescheduledContactsCount { get; private set; }



        /// <summary>
        /// Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.
        /// </summary>
        /// <value>Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.</value>
        [DataMember(Name="filteredOutContactsCount", EmitDefaultValue=false)]
        public int? FilteredOutContactsCount { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingCampaignDiagnostics {\n");

            sb.Append("  TimeZoneRescheduledContactsCount: ").Append(TimeZoneRescheduledContactsCount).Append("\n");
            sb.Append("  FilteredOutContactsCount: ").Append(FilteredOutContactsCount).Append("\n");
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
            return this.Equals(obj as MessagingCampaignDiagnostics);
        }

        /// <summary>
        /// Returns true if MessagingCampaignDiagnostics instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingCampaignDiagnostics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingCampaignDiagnostics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeZoneRescheduledContactsCount == other.TimeZoneRescheduledContactsCount ||
                    this.TimeZoneRescheduledContactsCount != null &&
                    this.TimeZoneRescheduledContactsCount.Equals(other.TimeZoneRescheduledContactsCount)
                ) &&
                (
                    this.FilteredOutContactsCount == other.FilteredOutContactsCount ||
                    this.FilteredOutContactsCount != null &&
                    this.FilteredOutContactsCount.Equals(other.FilteredOutContactsCount)
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
                if (this.TimeZoneRescheduledContactsCount != null)
                    hash = hash * 59 + this.TimeZoneRescheduledContactsCount.GetHashCode();

                if (this.FilteredOutContactsCount != null)
                    hash = hash * 59 + this.FilteredOutContactsCount.GetHashCode();

                return hash;
            }
        }
    }

}
