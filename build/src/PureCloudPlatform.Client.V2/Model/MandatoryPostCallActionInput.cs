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
    /// MandatoryPostCallActionInput
    /// </summary>
    [DataContract]
    public partial class MandatoryPostCallActionInput :  IEquatable<MandatoryPostCallActionInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatoryPostCallActionInput" /> class.
        /// </summary>
        /// <param name="Destination">The destination phone number or phone id to send the flow to after completion.  If null or blank will not update..</param>
        /// <param name="InvocationData">The invocation data to send the destination after completion.  If null or blank will not update.  Invocation data is only supported when the destination is an Inbound Call flow or Voice Survey flow..</param>
        public MandatoryPostCallActionInput(string Destination = null, string InvocationData = null)
        {
            this.Destination = Destination;
            this.InvocationData = InvocationData;
            
        }
        


        /// <summary>
        /// The destination phone number or phone id to send the flow to after completion.  If null or blank will not update.
        /// </summary>
        /// <value>The destination phone number or phone id to send the flow to after completion.  If null or blank will not update.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }



        /// <summary>
        /// The invocation data to send the destination after completion.  If null or blank will not update.  Invocation data is only supported when the destination is an Inbound Call flow or Voice Survey flow.
        /// </summary>
        /// <value>The invocation data to send the destination after completion.  If null or blank will not update.  Invocation data is only supported when the destination is an Inbound Call flow or Voice Survey flow.</value>
        [DataMember(Name="invocationData", EmitDefaultValue=false)]
        public string InvocationData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MandatoryPostCallActionInput {\n");

            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  InvocationData: ").Append(InvocationData).Append("\n");
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
            return this.Equals(obj as MandatoryPostCallActionInput);
        }

        /// <summary>
        /// Returns true if MandatoryPostCallActionInput instances are equal
        /// </summary>
        /// <param name="other">Instance of MandatoryPostCallActionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MandatoryPostCallActionInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) &&
                (
                    this.InvocationData == other.InvocationData ||
                    this.InvocationData != null &&
                    this.InvocationData.Equals(other.InvocationData)
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
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();

                if (this.InvocationData != null)
                    hash = hash * 59 + this.InvocationData.GetHashCode();

                return hash;
            }
        }
    }

}
