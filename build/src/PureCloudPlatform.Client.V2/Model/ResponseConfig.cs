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
    /// Defines response components of the Action Request.
    /// </summary>
    [DataContract]
    public partial class ResponseConfig :  IEquatable<ResponseConfig>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfig" /> class.
        /// </summary>
        /// <param name="TranslationMap">Map &#39;attribute name&#39; and &#39;JSON path&#39; pairs used to extract data from REST response..</param>
        /// <param name="TranslationMapDefaults">Map &#39;attribute name&#39; and &#39;default value&#39; pairs used as fallback values if JSON path extraction fails for specified key..</param>
        /// <param name="SuccessTemplate">Velocity template to build response to return from Action..</param>
        /// <param name="SuccessTemplateUri">URI to retrieve success template..</param>
        public ResponseConfig(Dictionary<string, string> TranslationMap = null, Dictionary<string, string> TranslationMapDefaults = null, string SuccessTemplate = null, string SuccessTemplateUri = null)
        {
            this.TranslationMap = TranslationMap;
            this.TranslationMapDefaults = TranslationMapDefaults;
            this.SuccessTemplate = SuccessTemplate;
            this.SuccessTemplateUri = SuccessTemplateUri;
            
        }
        
        
        
        /// <summary>
        /// Map &#39;attribute name&#39; and &#39;JSON path&#39; pairs used to extract data from REST response.
        /// </summary>
        /// <value>Map &#39;attribute name&#39; and &#39;JSON path&#39; pairs used to extract data from REST response.</value>
        [DataMember(Name="translationMap", EmitDefaultValue=false)]
        public Dictionary<string, string> TranslationMap { get; set; }
        
        
        
        /// <summary>
        /// Map &#39;attribute name&#39; and &#39;default value&#39; pairs used as fallback values if JSON path extraction fails for specified key.
        /// </summary>
        /// <value>Map &#39;attribute name&#39; and &#39;default value&#39; pairs used as fallback values if JSON path extraction fails for specified key.</value>
        [DataMember(Name="translationMapDefaults", EmitDefaultValue=false)]
        public Dictionary<string, string> TranslationMapDefaults { get; set; }
        
        
        
        /// <summary>
        /// Velocity template to build response to return from Action.
        /// </summary>
        /// <value>Velocity template to build response to return from Action.</value>
        [DataMember(Name="successTemplate", EmitDefaultValue=false)]
        public string SuccessTemplate { get; set; }
        
        
        
        /// <summary>
        /// URI to retrieve success template.
        /// </summary>
        /// <value>URI to retrieve success template.</value>
        [DataMember(Name="successTemplateUri", EmitDefaultValue=false)]
        public string SuccessTemplateUri { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseConfig {\n");
            
            sb.Append("  TranslationMap: ").Append(TranslationMap).Append("\n");
            sb.Append("  TranslationMapDefaults: ").Append(TranslationMapDefaults).Append("\n");
            sb.Append("  SuccessTemplate: ").Append(SuccessTemplate).Append("\n");
            sb.Append("  SuccessTemplateUri: ").Append(SuccessTemplateUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ResponseConfig);
        }

        /// <summary>
        /// Returns true if ResponseConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TranslationMap == other.TranslationMap ||
                    this.TranslationMap != null &&
                    this.TranslationMap.SequenceEqual(other.TranslationMap)
                ) &&
                (
                    this.TranslationMapDefaults == other.TranslationMapDefaults ||
                    this.TranslationMapDefaults != null &&
                    this.TranslationMapDefaults.SequenceEqual(other.TranslationMapDefaults)
                ) &&
                (
                    this.SuccessTemplate == other.SuccessTemplate ||
                    this.SuccessTemplate != null &&
                    this.SuccessTemplate.Equals(other.SuccessTemplate)
                ) &&
                (
                    this.SuccessTemplateUri == other.SuccessTemplateUri ||
                    this.SuccessTemplateUri != null &&
                    this.SuccessTemplateUri.Equals(other.SuccessTemplateUri)
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
                
                if (this.TranslationMap != null)
                    hash = hash * 59 + this.TranslationMap.GetHashCode();
                
                if (this.TranslationMapDefaults != null)
                    hash = hash * 59 + this.TranslationMapDefaults.GetHashCode();
                
                if (this.SuccessTemplate != null)
                    hash = hash * 59 + this.SuccessTemplate.GetHashCode();
                
                if (this.SuccessTemplateUri != null)
                    hash = hash * 59 + this.SuccessTemplateUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
