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
    /// WebDeploymentsJourneyContext
    /// </summary>
    [DataContract]
    public partial class WebDeploymentsJourneyContext :  IEquatable<WebDeploymentsJourneyContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsJourneyContext" /> class.
        /// </summary>
        /// <param name="JourneyAction">A subset of the Journey System's action data relevant to a part of a conversation (for external linkage and internal usage/context).</param>
        /// <param name="Customer">Journey customer information. Used for linking the authenticated customer with the journey. .</param>
        /// <param name="CustomerSession">Contains the Journey System's customer session details..</param>
        public WebDeploymentsJourneyContext(JourneyAction JourneyAction = null, JourneyCustomer Customer = null, JourneyCustomerSession CustomerSession = null)
        {
            this.JourneyAction = JourneyAction;
            this.Customer = Customer;
            this.CustomerSession = CustomerSession;
            
        }
        


        /// <summary>
        /// A subset of the Journey System's action data relevant to a part of a conversation (for external linkage and internal usage/context)
        /// </summary>
        /// <value>A subset of the Journey System's action data relevant to a part of a conversation (for external linkage and internal usage/context)</value>
        [DataMember(Name="journeyAction", EmitDefaultValue=false)]
        public JourneyAction JourneyAction { get; set; }



        /// <summary>
        /// Journey customer information. Used for linking the authenticated customer with the journey. 
        /// </summary>
        /// <value>Journey customer information. Used for linking the authenticated customer with the journey. </value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public JourneyCustomer Customer { get; set; }



        /// <summary>
        /// Contains the Journey System's customer session details.
        /// </summary>
        /// <value>Contains the Journey System's customer session details.</value>
        [DataMember(Name="customerSession", EmitDefaultValue=false)]
        public JourneyCustomerSession CustomerSession { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentsJourneyContext {\n");

            sb.Append("  JourneyAction: ").Append(JourneyAction).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  CustomerSession: ").Append(CustomerSession).Append("\n");
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
            return this.Equals(obj as WebDeploymentsJourneyContext);
        }

        /// <summary>
        /// Returns true if WebDeploymentsJourneyContext instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentsJourneyContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentsJourneyContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.JourneyAction == other.JourneyAction ||
                    this.JourneyAction != null &&
                    this.JourneyAction.Equals(other.JourneyAction)
                ) &&
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) &&
                (
                    this.CustomerSession == other.CustomerSession ||
                    this.CustomerSession != null &&
                    this.CustomerSession.Equals(other.CustomerSession)
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
                if (this.JourneyAction != null)
                    hash = hash * 59 + this.JourneyAction.GetHashCode();

                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();

                if (this.CustomerSession != null)
                    hash = hash * 59 + this.CustomerSession.GetHashCode();

                return hash;
            }
        }
    }

}
