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
    /// Information about the results being matched by the expressions
    /// </summary>
    [DataContract]
    public partial class MatchTestResult :  IEquatable<MatchTestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchTestResult" /> class.
        /// </summary>
        /// <param name="Value">The value of the field being matched.</param>
        /// <param name="Path">The json path to the json node being matched on. ex: $[&#39;things&#39;][1].</param>
        public MatchTestResult(Object Value = null, string Path = null)
        {
            this.Value = Value;
            this.Path = Path;
            
        }
        


        /// <summary>
        /// The value of the field being matched
        /// </summary>
        /// <value>The value of the field being matched</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }



        /// <summary>
        /// The json path to the json node being matched on. ex: $[&#39;things&#39;][1]
        /// </summary>
        /// <value>The json path to the json node being matched on. ex: $[&#39;things&#39;][1]</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchTestResult {\n");

            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(obj as MatchTestResult);
        }

        /// <summary>
        /// Returns true if MatchTestResult instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchTestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchTestResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();

                return hash;
            }
        }
    }

}
