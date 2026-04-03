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
    /// ModelConfig
    /// </summary>
    [DataContract]
    public partial class ModelConfig :  IEquatable<ModelConfig>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfig" /> class.
        /// </summary>
        /// <param name="UseLatestModel">Use the latest model for summarization. (required).</param>
        public ModelConfig(bool? UseLatestModel = null)
        {
            this.UseLatestModel = UseLatestModel;
            
        }
        


        /// <summary>
        /// Use the latest model for summarization.
        /// </summary>
        /// <value>Use the latest model for summarization.</value>
        [DataMember(Name="useLatestModel", EmitDefaultValue=false)]
        public bool? UseLatestModel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelConfig {\n");

            sb.Append("  UseLatestModel: ").Append(UseLatestModel).Append("\n");
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
            return this.Equals(obj as ModelConfig);
        }

        /// <summary>
        /// Returns true if ModelConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UseLatestModel == other.UseLatestModel ||
                    this.UseLatestModel != null &&
                    this.UseLatestModel.Equals(other.UseLatestModel)
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
                if (this.UseLatestModel != null)
                    hash = hash * 59 + this.UseLatestModel.GetHashCode();

                return hash;
            }
        }
    }

}
