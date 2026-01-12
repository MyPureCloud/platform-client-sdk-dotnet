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
    /// CustomerIntentAssignmentResponse
    /// </summary>
    [DataContract]
    public partial class CustomerIntentAssignmentResponse :  IEquatable<CustomerIntentAssignmentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerIntentAssignmentResponse" /> class.
        /// </summary>
        public CustomerIntentAssignmentResponse()
        {
            
        }
        


        /// <summary>
        /// Customer intent assigned
        /// </summary>
        /// <value>Customer intent assigned</value>
        [DataMember(Name="customerIntent", EmitDefaultValue=false)]
        public DomainEntityRef CustomerIntent { get; private set; }



        /// <summary>
        /// Category of the customer intent
        /// </summary>
        /// <value>Category of the customer intent</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public AddressableEntityRef Category { get; private set; }



        /// <summary>
        /// Date of the most recent assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date of the most recent assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateMostRecentlyAssigned", EmitDefaultValue=false)]
        public DateTime? DateMostRecentlyAssigned { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerIntentAssignmentResponse {\n");

            sb.Append("  CustomerIntent: ").Append(CustomerIntent).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DateMostRecentlyAssigned: ").Append(DateMostRecentlyAssigned).Append("\n");
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
            return this.Equals(obj as CustomerIntentAssignmentResponse);
        }

        /// <summary>
        /// Returns true if CustomerIntentAssignmentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerIntentAssignmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerIntentAssignmentResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CustomerIntent == other.CustomerIntent ||
                    this.CustomerIntent != null &&
                    this.CustomerIntent.Equals(other.CustomerIntent)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.DateMostRecentlyAssigned == other.DateMostRecentlyAssigned ||
                    this.DateMostRecentlyAssigned != null &&
                    this.DateMostRecentlyAssigned.Equals(other.DateMostRecentlyAssigned)
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
                if (this.CustomerIntent != null)
                    hash = hash * 59 + this.CustomerIntent.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.DateMostRecentlyAssigned != null)
                    hash = hash * 59 + this.DateMostRecentlyAssigned.GetHashCode();

                return hash;
            }
        }
    }

}
