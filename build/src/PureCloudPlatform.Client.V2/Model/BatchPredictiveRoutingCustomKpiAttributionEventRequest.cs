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
    /// A maximum of 100 events are allowed per request
    /// </summary>
    [DataContract]
    public partial class BatchPredictiveRoutingCustomKpiAttributionEventRequest :  IEquatable<BatchPredictiveRoutingCustomKpiAttributionEventRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPredictiveRoutingCustomKpiAttributionEventRequest" /> class.
        /// </summary>
        /// <param name="CustomKpiAttributionEvents">PredictiveRoutingCustomKpiAttributionEvent events for this batch.</param>
        public BatchPredictiveRoutingCustomKpiAttributionEventRequest(List<PredictiveRoutingCustomKpiAttributionEvent> CustomKpiAttributionEvents = null)
        {
            this.CustomKpiAttributionEvents = CustomKpiAttributionEvents;
            
        }
        


        /// <summary>
        /// PredictiveRoutingCustomKpiAttributionEvent events for this batch
        /// </summary>
        /// <value>PredictiveRoutingCustomKpiAttributionEvent events for this batch</value>
        [DataMember(Name="customKpiAttributionEvents", EmitDefaultValue=false)]
        public List<PredictiveRoutingCustomKpiAttributionEvent> CustomKpiAttributionEvents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchPredictiveRoutingCustomKpiAttributionEventRequest {\n");

            sb.Append("  CustomKpiAttributionEvents: ").Append(CustomKpiAttributionEvents).Append("\n");
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
            return this.Equals(obj as BatchPredictiveRoutingCustomKpiAttributionEventRequest);
        }

        /// <summary>
        /// Returns true if BatchPredictiveRoutingCustomKpiAttributionEventRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchPredictiveRoutingCustomKpiAttributionEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchPredictiveRoutingCustomKpiAttributionEventRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CustomKpiAttributionEvents == other.CustomKpiAttributionEvents ||
                    this.CustomKpiAttributionEvents != null &&
                    this.CustomKpiAttributionEvents.SequenceEqual(other.CustomKpiAttributionEvents)
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
                if (this.CustomKpiAttributionEvents != null)
                    hash = hash * 59 + this.CustomKpiAttributionEvents.GetHashCode();

                return hash;
            }
        }
    }

}
