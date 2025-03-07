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
    /// This is a set of enabled characteristics for the loglevel
    /// </summary>
    [DataContract]
    public partial class FlowCharacteristics :  IEquatable<FlowCharacteristics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowCharacteristics" /> class.
        /// </summary>
        /// <param name="ExecutionItems">Whether to report execution data about individual actions, menus, states, tasks, etc. etc. that ran during execution of the flow..</param>
        /// <param name="ExecutionInputOutputs">Whether to report input setting input setting values and output data values for individual execution items above.  For example, if you have FlowExecutionInputOutputs and a Call Data Action ran in a flow, if FlowExecutionItems was enabled you&#39;d see the fact a Call Data Action ran and the output path it took but nothing about which Data Action it ran, the input data sent to it at flow runtime and the data returned from it.  If you enable this characteristic, execution data will contain this additional detail..</param>
        /// <param name="Communications">Communications are either audio or digital communications sent to or received from a participant.  An example here would be the initial greeting in an inbound call flow where it plays a greeting message to the participant..</param>
        /// <param name="EventError">Whether to report flow error events..</param>
        /// <param name="EventWarning">Whether to report flow warning events..</param>
        /// <param name="EventOther">Whether to report events other than errors or warnings such as a language change, loop event..</param>
        /// <param name="Variables">Whether to report assignment of values to variables in flow execution data. It&#39;s important to remember there is a difference between variable value assignments and output data from an action.  If you have a Call Digital Bot flow action in an Inbound Message flow and there is no variable bound to the Exit Reason output but FlowExecutionInputOutputs is enabled, you will still be able to see the exit reason from the digital bot flow in execution data even though it is not bound to a variable..</param>
        /// <param name="Names">This characteristic specifies whether or not name information should be emitted in execution data such as action, task, state or even the flow name itself.  Names are very handy from a readability standpoint but they do take up additional space in flow execution data instances..</param>
        public FlowCharacteristics(bool? ExecutionItems = null, bool? ExecutionInputOutputs = null, bool? Communications = null, bool? EventError = null, bool? EventWarning = null, bool? EventOther = null, bool? Variables = null, bool? Names = null)
        {
            this.ExecutionItems = ExecutionItems;
            this.ExecutionInputOutputs = ExecutionInputOutputs;
            this.Communications = Communications;
            this.EventError = EventError;
            this.EventWarning = EventWarning;
            this.EventOther = EventOther;
            this.Variables = Variables;
            this.Names = Names;
            
        }
        


        /// <summary>
        /// Whether to report execution data about individual actions, menus, states, tasks, etc. etc. that ran during execution of the flow.
        /// </summary>
        /// <value>Whether to report execution data about individual actions, menus, states, tasks, etc. etc. that ran during execution of the flow.</value>
        [DataMember(Name="executionItems", EmitDefaultValue=false)]
        public bool? ExecutionItems { get; set; }



        /// <summary>
        /// Whether to report input setting input setting values and output data values for individual execution items above.  For example, if you have FlowExecutionInputOutputs and a Call Data Action ran in a flow, if FlowExecutionItems was enabled you&#39;d see the fact a Call Data Action ran and the output path it took but nothing about which Data Action it ran, the input data sent to it at flow runtime and the data returned from it.  If you enable this characteristic, execution data will contain this additional detail.
        /// </summary>
        /// <value>Whether to report input setting input setting values and output data values for individual execution items above.  For example, if you have FlowExecutionInputOutputs and a Call Data Action ran in a flow, if FlowExecutionItems was enabled you&#39;d see the fact a Call Data Action ran and the output path it took but nothing about which Data Action it ran, the input data sent to it at flow runtime and the data returned from it.  If you enable this characteristic, execution data will contain this additional detail.</value>
        [DataMember(Name="executionInputOutputs", EmitDefaultValue=false)]
        public bool? ExecutionInputOutputs { get; set; }



        /// <summary>
        /// Communications are either audio or digital communications sent to or received from a participant.  An example here would be the initial greeting in an inbound call flow where it plays a greeting message to the participant.
        /// </summary>
        /// <value>Communications are either audio or digital communications sent to or received from a participant.  An example here would be the initial greeting in an inbound call flow where it plays a greeting message to the participant.</value>
        [DataMember(Name="communications", EmitDefaultValue=false)]
        public bool? Communications { get; set; }



        /// <summary>
        /// Whether to report flow error events.
        /// </summary>
        /// <value>Whether to report flow error events.</value>
        [DataMember(Name="eventError", EmitDefaultValue=false)]
        public bool? EventError { get; set; }



        /// <summary>
        /// Whether to report flow warning events.
        /// </summary>
        /// <value>Whether to report flow warning events.</value>
        [DataMember(Name="eventWarning", EmitDefaultValue=false)]
        public bool? EventWarning { get; set; }



        /// <summary>
        /// Whether to report events other than errors or warnings such as a language change, loop event.
        /// </summary>
        /// <value>Whether to report events other than errors or warnings such as a language change, loop event.</value>
        [DataMember(Name="eventOther", EmitDefaultValue=false)]
        public bool? EventOther { get; set; }



        /// <summary>
        /// Whether to report assignment of values to variables in flow execution data. It&#39;s important to remember there is a difference between variable value assignments and output data from an action.  If you have a Call Digital Bot flow action in an Inbound Message flow and there is no variable bound to the Exit Reason output but FlowExecutionInputOutputs is enabled, you will still be able to see the exit reason from the digital bot flow in execution data even though it is not bound to a variable.
        /// </summary>
        /// <value>Whether to report assignment of values to variables in flow execution data. It&#39;s important to remember there is a difference between variable value assignments and output data from an action.  If you have a Call Digital Bot flow action in an Inbound Message flow and there is no variable bound to the Exit Reason output but FlowExecutionInputOutputs is enabled, you will still be able to see the exit reason from the digital bot flow in execution data even though it is not bound to a variable.</value>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public bool? Variables { get; set; }



        /// <summary>
        /// This characteristic specifies whether or not name information should be emitted in execution data such as action, task, state or even the flow name itself.  Names are very handy from a readability standpoint but they do take up additional space in flow execution data instances.
        /// </summary>
        /// <value>This characteristic specifies whether or not name information should be emitted in execution data such as action, task, state or even the flow name itself.  Names are very handy from a readability standpoint but they do take up additional space in flow execution data instances.</value>
        [DataMember(Name="names", EmitDefaultValue=false)]
        public bool? Names { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowCharacteristics {\n");

            sb.Append("  ExecutionItems: ").Append(ExecutionItems).Append("\n");
            sb.Append("  ExecutionInputOutputs: ").Append(ExecutionInputOutputs).Append("\n");
            sb.Append("  Communications: ").Append(Communications).Append("\n");
            sb.Append("  EventError: ").Append(EventError).Append("\n");
            sb.Append("  EventWarning: ").Append(EventWarning).Append("\n");
            sb.Append("  EventOther: ").Append(EventOther).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
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
            return this.Equals(obj as FlowCharacteristics);
        }

        /// <summary>
        /// Returns true if FlowCharacteristics instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowCharacteristics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowCharacteristics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExecutionItems == other.ExecutionItems ||
                    this.ExecutionItems != null &&
                    this.ExecutionItems.Equals(other.ExecutionItems)
                ) &&
                (
                    this.ExecutionInputOutputs == other.ExecutionInputOutputs ||
                    this.ExecutionInputOutputs != null &&
                    this.ExecutionInputOutputs.Equals(other.ExecutionInputOutputs)
                ) &&
                (
                    this.Communications == other.Communications ||
                    this.Communications != null &&
                    this.Communications.Equals(other.Communications)
                ) &&
                (
                    this.EventError == other.EventError ||
                    this.EventError != null &&
                    this.EventError.Equals(other.EventError)
                ) &&
                (
                    this.EventWarning == other.EventWarning ||
                    this.EventWarning != null &&
                    this.EventWarning.Equals(other.EventWarning)
                ) &&
                (
                    this.EventOther == other.EventOther ||
                    this.EventOther != null &&
                    this.EventOther.Equals(other.EventOther)
                ) &&
                (
                    this.Variables == other.Variables ||
                    this.Variables != null &&
                    this.Variables.Equals(other.Variables)
                ) &&
                (
                    this.Names == other.Names ||
                    this.Names != null &&
                    this.Names.Equals(other.Names)
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
                if (this.ExecutionItems != null)
                    hash = hash * 59 + this.ExecutionItems.GetHashCode();

                if (this.ExecutionInputOutputs != null)
                    hash = hash * 59 + this.ExecutionInputOutputs.GetHashCode();

                if (this.Communications != null)
                    hash = hash * 59 + this.Communications.GetHashCode();

                if (this.EventError != null)
                    hash = hash * 59 + this.EventError.GetHashCode();

                if (this.EventWarning != null)
                    hash = hash * 59 + this.EventWarning.GetHashCode();

                if (this.EventOther != null)
                    hash = hash * 59 + this.EventOther.GetHashCode();

                if (this.Variables != null)
                    hash = hash * 59 + this.Variables.GetHashCode();

                if (this.Names != null)
                    hash = hash * 59 + this.Names.GetHashCode();

                return hash;
            }
        }
    }

}
