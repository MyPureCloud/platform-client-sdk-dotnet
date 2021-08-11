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
    /// Details about a forms tracking event trigger
    /// </summary>
    [DataContract]
    public partial class FormsTrackTrigger :  IEquatable<FormsTrackTrigger>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormsTrackTrigger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormsTrackTrigger() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormsTrackTrigger" /> class.
        /// </summary>
        /// <param name="Selector">Form element that triggers the form submitted or abandoned event. (required).</param>
        /// <param name="FormName">Prefix for the form submitted or abandoned event name. (required).</param>
        /// <param name="CaptureDataOnFormAbandon">Whether to capture the form data in the form abandoned event. (required).</param>
        /// <param name="CaptureDataOnFormSubmit">Whether to capture the form data in the form submitted event. (required).</param>
        public FormsTrackTrigger(string Selector = null, string FormName = null, bool? CaptureDataOnFormAbandon = null, bool? CaptureDataOnFormSubmit = null)
        {
            this.Selector = Selector;
            this.FormName = FormName;
            this.CaptureDataOnFormAbandon = CaptureDataOnFormAbandon;
            this.CaptureDataOnFormSubmit = CaptureDataOnFormSubmit;
            
        }
        
        
        
        /// <summary>
        /// Form element that triggers the form submitted or abandoned event.
        /// </summary>
        /// <value>Form element that triggers the form submitted or abandoned event.</value>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public string Selector { get; set; }
        
        
        
        /// <summary>
        /// Prefix for the form submitted or abandoned event name.
        /// </summary>
        /// <value>Prefix for the form submitted or abandoned event name.</value>
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; set; }
        
        
        
        /// <summary>
        /// Whether to capture the form data in the form abandoned event.
        /// </summary>
        /// <value>Whether to capture the form data in the form abandoned event.</value>
        [DataMember(Name="captureDataOnFormAbandon", EmitDefaultValue=false)]
        public bool? CaptureDataOnFormAbandon { get; set; }
        
        
        
        /// <summary>
        /// Whether to capture the form data in the form submitted event.
        /// </summary>
        /// <value>Whether to capture the form data in the form submitted event.</value>
        [DataMember(Name="captureDataOnFormSubmit", EmitDefaultValue=false)]
        public bool? CaptureDataOnFormSubmit { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormsTrackTrigger {\n");
            
            sb.Append("  Selector: ").Append(Selector).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
            sb.Append("  CaptureDataOnFormAbandon: ").Append(CaptureDataOnFormAbandon).Append("\n");
            sb.Append("  CaptureDataOnFormSubmit: ").Append(CaptureDataOnFormSubmit).Append("\n");
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
            return this.Equals(obj as FormsTrackTrigger);
        }

        /// <summary>
        /// Returns true if FormsTrackTrigger instances are equal
        /// </summary>
        /// <param name="other">Instance of FormsTrackTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormsTrackTrigger other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Selector == other.Selector ||
                    this.Selector != null &&
                    this.Selector.Equals(other.Selector)
                ) &&
                (
                    this.FormName == other.FormName ||
                    this.FormName != null &&
                    this.FormName.Equals(other.FormName)
                ) &&
                (
                    this.CaptureDataOnFormAbandon == other.CaptureDataOnFormAbandon ||
                    this.CaptureDataOnFormAbandon != null &&
                    this.CaptureDataOnFormAbandon.Equals(other.CaptureDataOnFormAbandon)
                ) &&
                (
                    this.CaptureDataOnFormSubmit == other.CaptureDataOnFormSubmit ||
                    this.CaptureDataOnFormSubmit != null &&
                    this.CaptureDataOnFormSubmit.Equals(other.CaptureDataOnFormSubmit)
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
                
                if (this.Selector != null)
                    hash = hash * 59 + this.Selector.GetHashCode();
                
                if (this.FormName != null)
                    hash = hash * 59 + this.FormName.GetHashCode();
                
                if (this.CaptureDataOnFormAbandon != null)
                    hash = hash * 59 + this.CaptureDataOnFormAbandon.GetHashCode();
                
                if (this.CaptureDataOnFormSubmit != null)
                    hash = hash * 59 + this.CaptureDataOnFormSubmit.GetHashCode();
                
                return hash;
            }
        }
    }

}
