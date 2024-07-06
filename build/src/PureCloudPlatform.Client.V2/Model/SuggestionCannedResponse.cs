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
    /// SuggestionCannedResponse
    /// </summary>
    [DataContract]
    public partial class SuggestionCannedResponse :  IEquatable<SuggestionCannedResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionCannedResponse" /> class.
        /// </summary>
        public SuggestionCannedResponse()
        {
            
        }
        


        /// <summary>
        /// The suggested response.
        /// </summary>
        /// <value>The suggested response.</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public AddressableEntityRef Response { get; private set; }



        /// <summary>
        /// The library from which the canned response is suggested
        /// </summary>
        /// <value>The library from which the canned response is suggested</value>
        [DataMember(Name="library", EmitDefaultValue=false)]
        public AddressableEntityRef Library { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestionCannedResponse {\n");

            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Library: ").Append(Library).Append("\n");
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
            return this.Equals(obj as SuggestionCannedResponse);
        }

        /// <summary>
        /// Returns true if SuggestionCannedResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestionCannedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestionCannedResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) &&
                (
                    this.Library == other.Library ||
                    this.Library != null &&
                    this.Library.Equals(other.Library)
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
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();

                if (this.Library != null)
                    hash = hash * 59 + this.Library.GetHashCode();

                return hash;
            }
        }
    }

}
