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
    /// GenericActionEvent
    /// </summary>
    [DataContract]
    public partial class GenericActionEvent :  IEquatable<GenericActionEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericActionEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenericActionEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericActionEvent" /> class.
        /// </summary>
        /// <param name="Action">The action that triggered the event. (required).</param>
        /// <param name="ActionMap">The action map that triggered the action..</param>
        /// <param name="ErrorCode">Code of the error returned when the action fails..</param>
        /// <param name="ErrorMessage">Message of the error returned when the action fails..</param>
        public GenericActionEvent(GenericEventAction Action = null, ActionEventActionMap ActionMap = null, string ErrorCode = null, string ErrorMessage = null)
        {
            this.Action = Action;
            this.ActionMap = ActionMap;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            
        }
        


        /// <summary>
        /// The action that triggered the event.
        /// </summary>
        /// <value>The action that triggered the event.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public GenericEventAction Action { get; set; }



        /// <summary>
        /// The action map that triggered the action.
        /// </summary>
        /// <value>The action map that triggered the action.</value>
        [DataMember(Name="actionMap", EmitDefaultValue=false)]
        public ActionEventActionMap ActionMap { get; set; }



        /// <summary>
        /// Code of the error returned when the action fails.
        /// </summary>
        /// <value>Code of the error returned when the action fails.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Message of the error returned when the action fails.
        /// </summary>
        /// <value>Message of the error returned when the action fails.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericActionEvent {\n");

            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(obj as GenericActionEvent);
        }

        /// <summary>
        /// Returns true if GenericActionEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of GenericActionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericActionEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.ActionMap == other.ActionMap ||
                    this.ActionMap != null &&
                    this.ActionMap.Equals(other.ActionMap)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.ActionMap != null)
                    hash = hash * 59 + this.ActionMap.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                return hash;
            }
        }
    }

}
