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
    /// ConnectionUpdateRequest
    /// </summary>
    [DataContract]
    public partial class ConnectionUpdateRequest :  IEquatable<ConnectionUpdateRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionUpdateRequest" /> class.
        /// </summary>
        /// <param name="Code">Unique code that allows to be connected (required).</param>
        /// <param name="Error">Name of the received error.</param>
        /// <param name="ErrorDescription">Detailed description of the error.</param>
        public ConnectionUpdateRequest(string Code = null, string Error = null, string ErrorDescription = null)
        {
            this.Code = Code;
            this.Error = Error;
            this.ErrorDescription = ErrorDescription;
            
        }
        


        /// <summary>
        /// Unique code that allows to be connected
        /// </summary>
        /// <value>Unique code that allows to be connected</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Name of the received error
        /// </summary>
        /// <value>Name of the received error</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }



        /// <summary>
        /// Detailed description of the error
        /// </summary>
        /// <value>Detailed description of the error</value>
        [DataMember(Name="errorDescription", EmitDefaultValue=false)]
        public string ErrorDescription { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionUpdateRequest {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
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
            return this.Equals(obj as ConnectionUpdateRequest);
        }

        /// <summary>
        /// Returns true if ConnectionUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectionUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.ErrorDescription == other.ErrorDescription ||
                    this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(other.ErrorDescription)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.ErrorDescription != null)
                    hash = hash * 59 + this.ErrorDescription.GetHashCode();

                return hash;
            }
        }
    }

}
