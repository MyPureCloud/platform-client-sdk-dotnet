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
    /// Settings for a next-action of waiting for additional user input and sending the data as an input action to the bot flow.
    /// </summary>
    [DataContract]
    public partial class TextBotWaitForInputAction :  IEquatable<TextBotWaitForInputAction>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotWaitForInputAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotWaitForInputAction() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotWaitForInputAction" /> class.
        /// </summary>
        /// <param name="ModeConstraints">The mode constraints for the user input. (required).</param>
        public TextBotWaitForInputAction(TextBotModeConstraints ModeConstraints = null)
        {
            this.ModeConstraints = ModeConstraints;
            
        }
        
        
        
        /// <summary>
        /// The mode constraints for the user input.
        /// </summary>
        /// <value>The mode constraints for the user input.</value>
        [DataMember(Name="modeConstraints", EmitDefaultValue=false)]
        public TextBotModeConstraints ModeConstraints { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotWaitForInputAction {\n");
            
            sb.Append("  ModeConstraints: ").Append(ModeConstraints).Append("\n");
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
            return this.Equals(obj as TextBotWaitForInputAction);
        }

        /// <summary>
        /// Returns true if TextBotWaitForInputAction instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotWaitForInputAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotWaitForInputAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ModeConstraints == other.ModeConstraints ||
                    this.ModeConstraints != null &&
                    this.ModeConstraints.Equals(other.ModeConstraints)
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
                
                if (this.ModeConstraints != null)
                    hash = hash * 59 + this.ModeConstraints.GetHashCode();
                
                return hash;
            }
        }
    }

}
