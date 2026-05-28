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
    /// Request to update an external event
    /// </summary>
    [DataContract]
    public partial class UpdateExternalEventRequest :  IEquatable<UpdateExternalEventRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExternalEventRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateExternalEventRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExternalEventRequest" /> class.
        /// </summary>
        /// <param name="DisplayName">The display name of the external event (required).</param>
        /// <param name="Rank">The rank of the external event (required).</param>
        public UpdateExternalEventRequest(string DisplayName = null, int? Rank = null)
        {
            this.DisplayName = DisplayName;
            this.Rank = Rank;
            
        }
        


        /// <summary>
        /// The display name of the external event
        /// </summary>
        /// <value>The display name of the external event</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }



        /// <summary>
        /// The rank of the external event
        /// </summary>
        /// <value>The rank of the external event</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExternalEventRequest {\n");

            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return this.Equals(obj as UpdateExternalEventRequest);
        }

        /// <summary>
        /// Returns true if UpdateExternalEventRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateExternalEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateExternalEventRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();

                return hash;
            }
        }
    }

}
