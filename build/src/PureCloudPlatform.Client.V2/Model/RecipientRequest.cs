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
    /// RecipientRequest
    /// </summary>
    [DataContract]
    public partial class RecipientRequest :  IEquatable<RecipientRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientRequest" /> class.
        /// </summary>
        /// <param name="Flow">An automate flow object which defines the set of actions to be taken, when a message is received by this recipient..</param>
        public RecipientRequest(RecipientFlow Flow = null)
        {
            this.Flow = Flow;
            
        }
        


        /// <summary>
        /// An automate flow object which defines the set of actions to be taken, when a message is received by this recipient.
        /// </summary>
        /// <value>An automate flow object which defines the set of actions to be taken, when a message is received by this recipient.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public RecipientFlow Flow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientRequest {\n");

            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
            return this.Equals(obj as RecipientRequest);
        }

        /// <summary>
        /// Returns true if RecipientRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
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
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                return hash;
            }
        }
    }

}
