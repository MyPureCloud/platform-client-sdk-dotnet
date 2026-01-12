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
    /// CustomerSourceIntent
    /// </summary>
    [DataContract]
    public partial class CustomerSourceIntent :  IEquatable<CustomerSourceIntent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSourceIntent" /> class.
        /// </summary>
        /// <param name="SourceIntent">Source intent data.</param>
        /// <param name="CustomerIntent">Customer intent source intent is assigned to.</param>
        public CustomerSourceIntent(SourceIntent SourceIntent = null, DomainEntityRef CustomerIntent = null)
        {
            this.SourceIntent = SourceIntent;
            this.CustomerIntent = CustomerIntent;
            
        }
        


        /// <summary>
        /// Source intent data
        /// </summary>
        /// <value>Source intent data</value>
        [DataMember(Name="sourceIntent", EmitDefaultValue=false)]
        public SourceIntent SourceIntent { get; set; }



        /// <summary>
        /// Customer intent source intent is assigned to
        /// </summary>
        /// <value>Customer intent source intent is assigned to</value>
        [DataMember(Name="customerIntent", EmitDefaultValue=false)]
        public DomainEntityRef CustomerIntent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerSourceIntent {\n");

            sb.Append("  SourceIntent: ").Append(SourceIntent).Append("\n");
            sb.Append("  CustomerIntent: ").Append(CustomerIntent).Append("\n");
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
            return this.Equals(obj as CustomerSourceIntent);
        }

        /// <summary>
        /// Returns true if CustomerSourceIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerSourceIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerSourceIntent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceIntent == other.SourceIntent ||
                    this.SourceIntent != null &&
                    this.SourceIntent.Equals(other.SourceIntent)
                ) &&
                (
                    this.CustomerIntent == other.CustomerIntent ||
                    this.CustomerIntent != null &&
                    this.CustomerIntent.Equals(other.CustomerIntent)
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
                if (this.SourceIntent != null)
                    hash = hash * 59 + this.SourceIntent.GetHashCode();

                if (this.CustomerIntent != null)
                    hash = hash * 59 + this.CustomerIntent.GetHashCode();

                return hash;
            }
        }
    }

}
