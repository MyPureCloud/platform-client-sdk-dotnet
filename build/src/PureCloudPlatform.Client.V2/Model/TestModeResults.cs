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
    /// Information about trigger test mode execution
    /// </summary>
    [DataContract]
    public partial class TestModeResults :  IEquatable<TestModeResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestModeResults" /> class.
        /// </summary>
        /// <param name="SchemaValidation">Information about the validation of the schema of the event body passed in to test mode.</param>
        /// <param name="TargetValidation">Information about the validation of the trigger target.</param>
        /// <param name="JsonPathValidation">Information about the json path matching criteria.</param>
        /// <param name="TriggerMatches">Whether the trigger would have matched on the provided event body.</param>
        public TestModeResults(TestSchemaOperation SchemaValidation = null, TestTargetOperation TargetValidation = null, TestMatchesOperation JsonPathValidation = null, bool? TriggerMatches = null)
        {
            this.SchemaValidation = SchemaValidation;
            this.TargetValidation = TargetValidation;
            this.JsonPathValidation = JsonPathValidation;
            this.TriggerMatches = TriggerMatches;
            
        }
        


        /// <summary>
        /// Information about the validation of the schema of the event body passed in to test mode
        /// </summary>
        /// <value>Information about the validation of the schema of the event body passed in to test mode</value>
        [DataMember(Name="schemaValidation", EmitDefaultValue=false)]
        public TestSchemaOperation SchemaValidation { get; set; }



        /// <summary>
        /// Information about the validation of the trigger target
        /// </summary>
        /// <value>Information about the validation of the trigger target</value>
        [DataMember(Name="targetValidation", EmitDefaultValue=false)]
        public TestTargetOperation TargetValidation { get; set; }



        /// <summary>
        /// Information about the json path matching criteria
        /// </summary>
        /// <value>Information about the json path matching criteria</value>
        [DataMember(Name="jsonPathValidation", EmitDefaultValue=false)]
        public TestMatchesOperation JsonPathValidation { get; set; }



        /// <summary>
        /// Whether the trigger would have matched on the provided event body
        /// </summary>
        /// <value>Whether the trigger would have matched on the provided event body</value>
        [DataMember(Name="triggerMatches", EmitDefaultValue=false)]
        public bool? TriggerMatches { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestModeResults {\n");

            sb.Append("  SchemaValidation: ").Append(SchemaValidation).Append("\n");
            sb.Append("  TargetValidation: ").Append(TargetValidation).Append("\n");
            sb.Append("  JsonPathValidation: ").Append(JsonPathValidation).Append("\n");
            sb.Append("  TriggerMatches: ").Append(TriggerMatches).Append("\n");
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
            return this.Equals(obj as TestModeResults);
        }

        /// <summary>
        /// Returns true if TestModeResults instances are equal
        /// </summary>
        /// <param name="other">Instance of TestModeResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestModeResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SchemaValidation == other.SchemaValidation ||
                    this.SchemaValidation != null &&
                    this.SchemaValidation.Equals(other.SchemaValidation)
                ) &&
                (
                    this.TargetValidation == other.TargetValidation ||
                    this.TargetValidation != null &&
                    this.TargetValidation.Equals(other.TargetValidation)
                ) &&
                (
                    this.JsonPathValidation == other.JsonPathValidation ||
                    this.JsonPathValidation != null &&
                    this.JsonPathValidation.Equals(other.JsonPathValidation)
                ) &&
                (
                    this.TriggerMatches == other.TriggerMatches ||
                    this.TriggerMatches != null &&
                    this.TriggerMatches.Equals(other.TriggerMatches)
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
                if (this.SchemaValidation != null)
                    hash = hash * 59 + this.SchemaValidation.GetHashCode();

                if (this.TargetValidation != null)
                    hash = hash * 59 + this.TargetValidation.GetHashCode();

                if (this.JsonPathValidation != null)
                    hash = hash * 59 + this.JsonPathValidation.GetHashCode();

                if (this.TriggerMatches != null)
                    hash = hash * 59 + this.TriggerMatches.GetHashCode();

                return hash;
            }
        }
    }

}
