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
    /// Current action function configuration and zip upload configuration.
    /// </summary>
    [DataContract]
    public partial class FunctionConfig :  IEquatable<FunctionConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionConfig" /> class.
        /// </summary>
        public FunctionConfig()
        {
            
        }
        


        /// <summary>
        /// Action identifier.
        /// </summary>
        /// <value>Action identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Function configuration.
        /// </summary>
        /// <value>Function configuration.</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public Function Function { get; private set; }



        /// <summary>
        /// Zip file configuration and state.
        /// </summary>
        /// <value>Zip file configuration and state.</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public FunctionZipConfig Zip { get; private set; }



        /// <summary>
        /// History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures.
        /// </summary>
        /// <value>History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures.</value>
        [DataMember(Name="uploadExceptionHistory", EmitDefaultValue=false)]
        public List<FunctionZipConfig> UploadExceptionHistory { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionConfig {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  UploadExceptionHistory: ").Append(UploadExceptionHistory).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as FunctionConfig);
        }

        /// <summary>
        /// Returns true if FunctionConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of FunctionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Function == other.Function ||
                    this.Function != null &&
                    this.Function.Equals(other.Function)
                ) &&
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) &&
                (
                    this.UploadExceptionHistory == other.UploadExceptionHistory ||
                    this.UploadExceptionHistory != null &&
                    this.UploadExceptionHistory.SequenceEqual(other.UploadExceptionHistory)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Function != null)
                    hash = hash * 59 + this.Function.GetHashCode();

                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();

                if (this.UploadExceptionHistory != null)
                    hash = hash * 59 + this.UploadExceptionHistory.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
