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
        /// <param name="Index">Index of the card in the carousel template.</param>
        /// <param name="BodyParameters">A list of Response Management carousel card body parameter substitutions for the response&#39;s messaging template.</param>
        /// <param name="ButtonUrlParameters">A list of Response Management carousel card button URL parameter substitutions for the response&#39;s messaging template.</param>
        /// <param name="ButtonQuickReplyPayloads">A list of quick reply button payloads for the carousel card.</param>
        public CardParameters(int? Index = null, List<TemplateParameter> BodyParameters = null, List<TemplateParameter> ButtonUrlParameters = null, List<ButtonQuickReplyPayload> ButtonQuickReplyPayloads = null)
        {
            this.Index = Index;
            this.BodyParameters = BodyParameters;
            this.ButtonUrlParameters = ButtonUrlParameters;
            this.ButtonQuickReplyPayloads = ButtonQuickReplyPayloads;
            
        }
        


        /// <summary>
        /// Index of the card in the carousel template
        /// </summary>
        /// <value>Index of the card in the carousel template</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }



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
        /// A list of quick reply button payloads for the carousel card
        /// </summary>
        /// <value>A list of quick reply button payloads for the carousel card</value>
        [DataMember(Name="buttonQuickReplyPayloads", EmitDefaultValue=false)]
        public List<ButtonQuickReplyPayload> ButtonQuickReplyPayloads { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardParameters {\n");

            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  BodyParameters: ").Append(BodyParameters).Append("\n");
            sb.Append("  ButtonUrlParameters: ").Append(ButtonUrlParameters).Append("\n");
            sb.Append("  ButtonQuickReplyPayloads: ").Append(ButtonQuickReplyPayloads).Append("\n");
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
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) &&
                (
                    this.BodyParameters == other.BodyParameters ||
                    this.BodyParameters != null &&
                    this.BodyParameters.SequenceEqual(other.BodyParameters)
                ) &&
                (
                    this.ButtonUrlParameters == other.ButtonUrlParameters ||
                    this.ButtonUrlParameters != null &&
                    this.ButtonUrlParameters.SequenceEqual(other.ButtonUrlParameters)
                ) &&
                (
                    this.ButtonQuickReplyPayloads == other.ButtonQuickReplyPayloads ||
                    this.ButtonQuickReplyPayloads != null &&
                    this.ButtonQuickReplyPayloads.SequenceEqual(other.ButtonQuickReplyPayloads)
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
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();

                if (this.BodyParameters != null)
                    hash = hash * 59 + this.BodyParameters.GetHashCode();

                if (this.ButtonUrlParameters != null)
                    hash = hash * 59 + this.ButtonUrlParameters.GetHashCode();

                if (this.ButtonQuickReplyPayloads != null)
                    hash = hash * 59 + this.ButtonQuickReplyPayloads.GetHashCode();

                return hash;
            }
        }
    }

}
