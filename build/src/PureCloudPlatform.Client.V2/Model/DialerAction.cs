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
    /// DialerAction
    /// </summary>
    [DataContract]
    public partial class DialerAction :  IEquatable<DialerAction>
    {
        
        
        /// <summary>
        /// The type of this DialerAction.
        /// </summary>
        /// <value>The type of this DialerAction.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Action for "Action"
            /// </summary>
            [EnumMember(Value = "Action")]
            Action,
            
            /// <summary>
            /// Enum Modifycontactattribute for "modifyContactAttribute"
            /// </summary>
            [EnumMember(Value = "modifyContactAttribute")]
            Modifycontactattribute,
            
            /// <summary>
            /// Enum Dataactionbehavior for "dataActionBehavior"
            /// </summary>
            [EnumMember(Value = "dataActionBehavior")]
            Dataactionbehavior
        }
        
        
        
        
        /// <summary>
        /// Additional type specification for this DialerAction.
        /// </summary>
        /// <value>Additional type specification for this DialerAction.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypeNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum DoNotDial for "DO_NOT_DIAL"
            /// </summary>
            [EnumMember(Value = "DO_NOT_DIAL")]
            DoNotDial,
            
            /// <summary>
            /// Enum ModifyContactAttribute for "MODIFY_CONTACT_ATTRIBUTE"
            /// </summary>
            [EnumMember(Value = "MODIFY_CONTACT_ATTRIBUTE")]
            ModifyContactAttribute,
            
            /// <summary>
            /// Enum SwitchToPreview for "SWITCH_TO_PREVIEW"
            /// </summary>
            [EnumMember(Value = "SWITCH_TO_PREVIEW")]
            SwitchToPreview,
            
            /// <summary>
            /// Enum AppendNumberToDncList for "APPEND_NUMBER_TO_DNC_LIST"
            /// </summary>
            [EnumMember(Value = "APPEND_NUMBER_TO_DNC_LIST")]
            AppendNumberToDncList,
            
            /// <summary>
            /// Enum ScheduleCallback for "SCHEDULE_CALLBACK"
            /// </summary>
            [EnumMember(Value = "SCHEDULE_CALLBACK")]
            ScheduleCallback,
            
            /// <summary>
            /// Enum ContactUncallable for "CONTACT_UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "CONTACT_UNCALLABLE")]
            ContactUncallable,
            
            /// <summary>
            /// Enum NumberUncallable for "NUMBER_UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "NUMBER_UNCALLABLE")]
            NumberUncallable,
            
            /// <summary>
            /// Enum SetCallerId for "SET_CALLER_ID"
            /// </summary>
            [EnumMember(Value = "SET_CALLER_ID")]
            SetCallerId,
            
            /// <summary>
            /// Enum SetSkills for "SET_SKILLS"
            /// </summary>
            [EnumMember(Value = "SET_SKILLS")]
            SetSkills,
            
            /// <summary>
            /// Enum DataAction for "DATA_ACTION"
            /// </summary>
            [EnumMember(Value = "DATA_ACTION")]
            DataAction
        }
        
        
        
        
        /// <summary>
        /// Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.
        /// </summary>
        /// <value>Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UpdateOptionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Set for "SET"
            /// </summary>
            [EnumMember(Value = "SET")]
            Set,
            
            /// <summary>
            /// Enum Increment for "INCREMENT"
            /// </summary>
            [EnumMember(Value = "INCREMENT")]
            Increment,
            
            /// <summary>
            /// Enum Decrement for "DECREMENT"
            /// </summary>
            [EnumMember(Value = "DECREMENT")]
            Decrement,
            
            /// <summary>
            /// Enum CurrentTime for "CURRENT_TIME"
            /// </summary>
            [EnumMember(Value = "CURRENT_TIME")]
            CurrentTime
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this DialerAction.
        /// </summary>
        /// <value>The type of this DialerAction.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// Additional type specification for this DialerAction.
        /// </summary>
        /// <value>Additional type specification for this DialerAction.</value>
        [DataMember(Name="actionTypeName", EmitDefaultValue=false)]
        public ActionTypeNameEnum? ActionTypeName { get; set; }
        
        
        
        /// <summary>
        /// Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.
        /// </summary>
        /// <value>Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.</value>
        [DataMember(Name="updateOption", EmitDefaultValue=false)]
        public UpdateOptionEnum? UpdateOption { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DialerAction() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAction" /> class.
        /// </summary>
        /// <param name="Type">The type of this DialerAction. (required).</param>
        /// <param name="ActionTypeName">Additional type specification for this DialerAction. (required).</param>
        /// <param name="UpdateOption">Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE..</param>
        /// <param name="Properties">A map of key-value pairs pertinent to the DialerAction. Different types of DialerActions require different properties. MODIFY_CONTACT_ATTRIBUTE with an updateOption of SET takes a contact column as the key and accepts any value. SCHEDULE_CALLBACK takes a key &#39;callbackOffset&#39; that specifies how far in the future the callback should be scheduled, in minutes. SET_CALLER_ID takes two keys: &#39;callerAddress&#39;, which should be the caller id phone number, and &#39;callerName&#39;. For either key, you can also specify a column on the contact to get the value from. To do this, specify &#39;contact.Column&#39;, where &#39;Column&#39; is the name of the contact column from which to get the value. SET_SKILLS takes a key &#39;skills&#39; with an array of skill ids wrapped into a string (Example: {&#39;skills&#39;: &#39;[&#39;skillIdHere&#39;]&#39;} )..</param>
        /// <param name="DataAction">The Data Action to use for this action. Required for a dataActionBehavior..</param>
        /// <param name="ContactColumnToDataActionFieldMappings">A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionBehavior..</param>
        /// <param name="ContactIdField">The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionBehavior..</param>
        /// <param name="CallAnalysisResultField">The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionBehavior..</param>
        /// <param name="AgentWrapupField">The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionBehavior..</param>
        public DialerAction(TypeEnum? Type = null, ActionTypeNameEnum? ActionTypeName = null, UpdateOptionEnum? UpdateOption = null, Dictionary<string, string> Properties = null, DomainEntityRef DataAction = null, List<ContactColumnToDataActionFieldMapping> ContactColumnToDataActionFieldMappings = null, string ContactIdField = null, string CallAnalysisResultField = null, string AgentWrapupField = null)
        {
            this.Type = Type;
            this.ActionTypeName = ActionTypeName;
            this.UpdateOption = UpdateOption;
            this.Properties = Properties;
            this.DataAction = DataAction;
            this.ContactColumnToDataActionFieldMappings = ContactColumnToDataActionFieldMappings;
            this.ContactIdField = ContactIdField;
            this.CallAnalysisResultField = CallAnalysisResultField;
            this.AgentWrapupField = AgentWrapupField;
            
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// A map of key-value pairs pertinent to the DialerAction. Different types of DialerActions require different properties. MODIFY_CONTACT_ATTRIBUTE with an updateOption of SET takes a contact column as the key and accepts any value. SCHEDULE_CALLBACK takes a key &#39;callbackOffset&#39; that specifies how far in the future the callback should be scheduled, in minutes. SET_CALLER_ID takes two keys: &#39;callerAddress&#39;, which should be the caller id phone number, and &#39;callerName&#39;. For either key, you can also specify a column on the contact to get the value from. To do this, specify &#39;contact.Column&#39;, where &#39;Column&#39; is the name of the contact column from which to get the value. SET_SKILLS takes a key &#39;skills&#39; with an array of skill ids wrapped into a string (Example: {&#39;skills&#39;: &#39;[&#39;skillIdHere&#39;]&#39;} ).
        /// </summary>
        /// <value>A map of key-value pairs pertinent to the DialerAction. Different types of DialerActions require different properties. MODIFY_CONTACT_ATTRIBUTE with an updateOption of SET takes a contact column as the key and accepts any value. SCHEDULE_CALLBACK takes a key &#39;callbackOffset&#39; that specifies how far in the future the callback should be scheduled, in minutes. SET_CALLER_ID takes two keys: &#39;callerAddress&#39;, which should be the caller id phone number, and &#39;callerName&#39;. For either key, you can also specify a column on the contact to get the value from. To do this, specify &#39;contact.Column&#39;, where &#39;Column&#39; is the name of the contact column from which to get the value. SET_SKILLS takes a key &#39;skills&#39; with an array of skill ids wrapped into a string (Example: {&#39;skills&#39;: &#39;[&#39;skillIdHere&#39;]&#39;} ).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }
        
        
        
        /// <summary>
        /// The Data Action to use for this action. Required for a dataActionBehavior.
        /// </summary>
        /// <value>The Data Action to use for this action. Required for a dataActionBehavior.</value>
        [DataMember(Name="dataAction", EmitDefaultValue=false)]
        public DomainEntityRef DataAction { get; set; }
        
        
        
        /// <summary>
        /// A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionBehavior.
        /// </summary>
        /// <value>A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionBehavior.</value>
        [DataMember(Name="contactColumnToDataActionFieldMappings", EmitDefaultValue=false)]
        public List<ContactColumnToDataActionFieldMapping> ContactColumnToDataActionFieldMappings { get; set; }
        
        
        
        /// <summary>
        /// The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionBehavior.
        /// </summary>
        /// <value>The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionBehavior.</value>
        [DataMember(Name="contactIdField", EmitDefaultValue=false)]
        public string ContactIdField { get; set; }
        
        
        
        /// <summary>
        /// The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionBehavior.
        /// </summary>
        /// <value>The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionBehavior.</value>
        [DataMember(Name="callAnalysisResultField", EmitDefaultValue=false)]
        public string CallAnalysisResultField { get; set; }
        
        
        
        /// <summary>
        /// The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionBehavior.
        /// </summary>
        /// <value>The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionBehavior.</value>
        [DataMember(Name="agentWrapupField", EmitDefaultValue=false)]
        public string AgentWrapupField { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerAction {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ActionTypeName: ").Append(ActionTypeName).Append("\n");
            sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DataAction: ").Append(DataAction).Append("\n");
            sb.Append("  ContactColumnToDataActionFieldMappings: ").Append(ContactColumnToDataActionFieldMappings).Append("\n");
            sb.Append("  ContactIdField: ").Append(ContactIdField).Append("\n");
            sb.Append("  CallAnalysisResultField: ").Append(CallAnalysisResultField).Append("\n");
            sb.Append("  AgentWrapupField: ").Append(AgentWrapupField).Append("\n");
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
            return this.Equals(obj as DialerAction);
        }

        /// <summary>
        /// Returns true if DialerAction instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerAction other)
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
                    this.DataAction == other.DataAction ||
                    this.DataAction != null &&
                    this.DataAction.Equals(other.DataAction)
                ) &&
                (
                    this.ContactColumnToDataActionFieldMappings == other.ContactColumnToDataActionFieldMappings ||
                    this.ContactColumnToDataActionFieldMappings != null &&
                    this.ContactColumnToDataActionFieldMappings.SequenceEqual(other.ContactColumnToDataActionFieldMappings)
                ) &&
                (
                    this.ContactIdField == other.ContactIdField ||
                    this.ContactIdField != null &&
                    this.ContactIdField.Equals(other.ContactIdField)
                ) &&
                (
                    this.CallAnalysisResultField == other.CallAnalysisResultField ||
                    this.CallAnalysisResultField != null &&
                    this.CallAnalysisResultField.Equals(other.CallAnalysisResultField)
                ) &&
                (
                    this.AgentWrapupField == other.AgentWrapupField ||
                    this.AgentWrapupField != null &&
                    this.AgentWrapupField.Equals(other.AgentWrapupField)
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
                
                if (this.DataAction != null)
                    hash = hash * 59 + this.DataAction.GetHashCode();
                
                if (this.ContactColumnToDataActionFieldMappings != null)
                    hash = hash * 59 + this.ContactColumnToDataActionFieldMappings.GetHashCode();
                
                if (this.ContactIdField != null)
                    hash = hash * 59 + this.ContactIdField.GetHashCode();
                
                if (this.CallAnalysisResultField != null)
                    hash = hash * 59 + this.CallAnalysisResultField.GetHashCode();
                
                if (this.AgentWrapupField != null)
                    hash = hash * 59 + this.AgentWrapupField.GetHashCode();
                
                return hash;
            }
        }
    }

}
