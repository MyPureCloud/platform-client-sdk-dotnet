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
    /// DataActionInput
    /// </summary>
    [DataContract]
    public partial class DataActionInput :  IEquatable<DataActionInput>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DataActionInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataActionInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataActionInput" /> class.
        /// </summary>
        /// <param name="ParameterName">The name of the data action input parameter to map a guide variable to. (required).</param>
        /// <param name="VariableName">The guide variable whose value will be passed as the input to the paired data action parameter. (required).</param>
        public DataActionInput(string ParameterName = null, string VariableName = null)
        {
            this.ParameterName = ParameterName;
            this.VariableName = VariableName;
            
        }
        


        /// <summary>
        /// The name of the data action input parameter to map a guide variable to.
        /// </summary>
        /// <value>The name of the data action input parameter to map a guide variable to.</value>
        [DataMember(Name="parameterName", EmitDefaultValue=false)]
        public string ParameterName { get; set; }



        /// <summary>
        /// The guide variable whose value will be passed as the input to the paired data action parameter.
        /// </summary>
        /// <value>The guide variable whose value will be passed as the input to the paired data action parameter.</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataActionInput {\n");

            sb.Append("  ParameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
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
            return this.Equals(obj as DataActionInput);
        }

        /// <summary>
        /// Returns true if DataActionInput instances are equal
        /// </summary>
        /// <param name="other">Instance of DataActionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataActionInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ParameterName == other.ParameterName ||
                    this.ParameterName != null &&
                    this.ParameterName.Equals(other.ParameterName)
                ) &&
                (
                    this.VariableName == other.VariableName ||
                    this.VariableName != null &&
                    this.VariableName.Equals(other.VariableName)
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
                if (this.ParameterName != null)
                    hash = hash * 59 + this.ParameterName.GetHashCode();

                if (this.VariableName != null)
                    hash = hash * 59 + this.VariableName.GetHashCode();

                return hash;
            }
        }
    }

}
