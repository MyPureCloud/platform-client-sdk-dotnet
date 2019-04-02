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
    /// ActionProperties
    /// </summary>
    [DataContract]
    public partial class ActionProperties :  IEquatable<ActionProperties>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionProperties" /> class.
        /// </summary>
        /// <param name="WebchatPrompt">Prompt message shown to user, used for webchat type action..</param>
        /// <param name="WebchatSurvey">Survey provided to the user, used for webchat type action..</param>
        public ActionProperties(string WebchatPrompt = null, ActionSurvey WebchatSurvey = null)
        {
            this.WebchatPrompt = WebchatPrompt;
            this.WebchatSurvey = WebchatSurvey;
            
        }
        
        
        
        /// <summary>
        /// Prompt message shown to user, used for webchat type action.
        /// </summary>
        /// <value>Prompt message shown to user, used for webchat type action.</value>
        [DataMember(Name="webchatPrompt", EmitDefaultValue=false)]
        public string WebchatPrompt { get; set; }
        
        
        
        /// <summary>
        /// Survey provided to the user, used for webchat type action.
        /// </summary>
        /// <value>Survey provided to the user, used for webchat type action.</value>
        [DataMember(Name="webchatSurvey", EmitDefaultValue=false)]
        public ActionSurvey WebchatSurvey { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionProperties {\n");
            
            sb.Append("  WebchatPrompt: ").Append(WebchatPrompt).Append("\n");
            sb.Append("  WebchatSurvey: ").Append(WebchatSurvey).Append("\n");
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
            return this.Equals(obj as ActionProperties);
        }

        /// <summary>
        /// Returns true if ActionProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WebchatPrompt == other.WebchatPrompt ||
                    this.WebchatPrompt != null &&
                    this.WebchatPrompt.Equals(other.WebchatPrompt)
                ) &&
                (
                    this.WebchatSurvey == other.WebchatSurvey ||
                    this.WebchatSurvey != null &&
                    this.WebchatSurvey.Equals(other.WebchatSurvey)
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
                
                if (this.WebchatPrompt != null)
                    hash = hash * 59 + this.WebchatPrompt.GetHashCode();
                
                if (this.WebchatSurvey != null)
                    hash = hash * 59 + this.WebchatSurvey.GetHashCode();
                
                return hash;
            }
        }
    }

}
