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
    /// DialerRulesetConfigChangeAction
    /// </summary>
    [DataContract]
    public partial class DialerRulesetConfigChangeAction :  IEquatable<DialerRulesetConfigChangeAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeAction" /> class.
        /// </summary>
        /// <param name="Type">Type of the action.</param>
        /// <param name="ActionTypeName">Identifier of the action.</param>
        /// <param name="UpdateOption">Indicator of the type of update action (applicable only to certain types of actions).</param>
        /// <param name="Properties">Map of key-value pairs pertinent to the action (different actions require different properties).</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerRulesetConfigChangeAction(string Type = null, string ActionTypeName = null, string UpdateOption = null, Dictionary<string, string> Properties = null, Dictionary<string, Object> AdditionalProperties = null)
        {
            this.Type = Type;
            this.ActionTypeName = ActionTypeName;
            this.UpdateOption = UpdateOption;
            this.Properties = Properties;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        


        /// <summary>
        /// Type of the action
        /// </summary>
        /// <value>Type of the action</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// Identifier of the action
        /// </summary>
        /// <value>Identifier of the action</value>
        [DataMember(Name="actionTypeName", EmitDefaultValue=false)]
        public string ActionTypeName { get; set; }



        /// <summary>
        /// Indicator of the type of update action (applicable only to certain types of actions)
        /// </summary>
        /// <value>Indicator of the type of update action (applicable only to certain types of actions)</value>
        [DataMember(Name="updateOption", EmitDefaultValue=false)]
        public string UpdateOption { get; set; }



        /// <summary>
        /// Map of key-value pairs pertinent to the action (different actions require different properties)
        /// </summary>
        /// <value>Map of key-value pairs pertinent to the action (different actions require different properties)</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerRulesetConfigChangeAction {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ActionTypeName: ").Append(ActionTypeName).Append("\n");
            sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerRulesetConfigChangeAction);
        }

        /// <summary>
        /// Returns true if DialerRulesetConfigChangeAction instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerRulesetConfigChangeAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerRulesetConfigChangeAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ActionTypeName == other.ActionTypeName ||
                    this.ActionTypeName != null &&
                    this.ActionTypeName.Equals(other.ActionTypeName)
                ) &&
                (
                    this.UpdateOption == other.UpdateOption ||
                    this.UpdateOption != null &&
                    this.UpdateOption.Equals(other.UpdateOption)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ActionTypeName != null)
                    hash = hash * 59 + this.ActionTypeName.GetHashCode();

                if (this.UpdateOption != null)
                    hash = hash * 59 + this.UpdateOption.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
