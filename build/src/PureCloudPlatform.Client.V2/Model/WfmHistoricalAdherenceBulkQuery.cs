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
    /// WfmHistoricalAdherenceBulkQuery
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceBulkQuery :  IEquatable<WfmHistoricalAdherenceBulkQuery>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmHistoricalAdherenceBulkQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkQuery" /> class.
        /// </summary>
        /// <param name="Items">The historical adherence items to query (required).</param>
        /// <param name="TimeZone">The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input. (required).</param>
        public WfmHistoricalAdherenceBulkQuery(List<WfmHistoricalAdherenceBulkItem> Items = null, string TimeZone = null)
        {
            this.Items = Items;
            this.TimeZone = TimeZone;
            
        }
        


        /// <summary>
        /// The historical adherence items to query
        /// </summary>
        /// <value>The historical adherence items to query</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<WfmHistoricalAdherenceBulkItem> Items { get; set; }



        /// <summary>
        /// The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.
        /// </summary>
        /// <value>The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceBulkQuery {\n");

            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceBulkQuery);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceBulkQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceBulkQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceBulkQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
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
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                return hash;
            }
        }
    }

}
