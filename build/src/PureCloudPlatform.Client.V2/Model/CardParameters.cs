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
    /// Template parameters for a single carousel card
    /// </summary>
    [DataContract]
    public partial class CardParameters :  IEquatable<CardParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardParameters" /> class.
        /// </summary>
        /// <param name="BodyParameters">A list of Response Management carousel card body parameter substitutions for the response&#39;s messaging template.</param>
        /// <param name="ButtonUrlParameters">A list of Response Management carousel card button URL parameter substitutions for the response&#39;s messaging template.</param>
        public CardParameters(List<TemplateParameter> BodyParameters = null, List<TemplateParameter> ButtonUrlParameters = null)
        {
            this.BodyParameters = BodyParameters;
            this.ButtonUrlParameters = ButtonUrlParameters;
            
        }
        


        /// <summary>
        /// A list of Response Management carousel card body parameter substitutions for the response&#39;s messaging template
        /// </summary>
        /// <value>A list of Response Management carousel card body parameter substitutions for the response&#39;s messaging template</value>
        [DataMember(Name="bodyParameters", EmitDefaultValue=false)]
        public List<TemplateParameter> BodyParameters { get; set; }



        /// <summary>
        /// A list of Response Management carousel card button URL parameter substitutions for the response&#39;s messaging template
        /// </summary>
        /// <value>A list of Response Management carousel card button URL parameter substitutions for the response&#39;s messaging template</value>
        [DataMember(Name="buttonUrlParameters", EmitDefaultValue=false)]
        public List<TemplateParameter> ButtonUrlParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardParameters {\n");

            sb.Append("  BodyParameters: ").Append(BodyParameters).Append("\n");
            sb.Append("  ButtonUrlParameters: ").Append(ButtonUrlParameters).Append("\n");
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
            return this.Equals(obj as CardParameters);
        }

        /// <summary>
        /// Returns true if CardParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CardParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BodyParameters == other.BodyParameters ||
                    this.BodyParameters != null &&
                    this.BodyParameters.SequenceEqual(other.BodyParameters)
                ) &&
                (
                    this.ButtonUrlParameters == other.ButtonUrlParameters ||
                    this.ButtonUrlParameters != null &&
                    this.ButtonUrlParameters.SequenceEqual(other.ButtonUrlParameters)
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
                if (this.BodyParameters != null)
                    hash = hash * 59 + this.BodyParameters.GetHashCode();

                if (this.ButtonUrlParameters != null)
                    hash = hash * 59 + this.ButtonUrlParameters.GetHashCode();

                return hash;
            }
        }
    }

}
