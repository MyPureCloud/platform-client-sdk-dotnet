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
    /// Used to filter response queries
    /// </summary>
    [DataContract]
    public partial class ResponseFilter :  IEquatable<ResponseFilter>
    {
        /// <summary>
        /// Filter operation: IN, EQUALS, NOTEQUALS.
        /// </summary>
        /// <value>Filter operation: IN, EQUALS, NOTEQUALS.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In,
            
            /// <summary>
            /// Enum Equals for "EQUALS"
            /// </summary>
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            /// <summary>
            /// Enum Notequals for "NOTEQUALS"
            /// </summary>
            [EnumMember(Value = "NOTEQUALS")]
            Notequals
        }
        /// <summary>
        /// Filter operation: IN, EQUALS, NOTEQUALS.
        /// </summary>
        /// <value>Filter operation: IN, EQUALS, NOTEQUALS.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        /// <param name="Name">Field to filter on. Allowed values are 'name', 'libraryId', 'text.contentType', 'messagingTemplate' and 'responseType' (required).</param>
        /// <param name="Operator">Filter operation: IN, EQUALS, NOTEQUALS. (required).</param>
        /// <param name="Values">Values to filter on. If name is 'responseType' then allowed values are 'CampaignSmsTemplate', 'CampaignEmailTemplate', 'Footer' and 'Signature' (required).</param>
        public ResponseFilter(string Name = null, OperatorEnum? Operator = null, List<string> Values = null)
        {
            this.Name = Name;
            this.Operator = Operator;
            this.Values = Values;
            
        }
        


        /// <summary>
        /// Field to filter on. Allowed values are 'name', 'libraryId', 'text.contentType', 'messagingTemplate' and 'responseType'
        /// </summary>
        /// <value>Field to filter on. Allowed values are 'name', 'libraryId', 'text.contentType', 'messagingTemplate' and 'responseType'</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Values to filter on. If name is 'responseType' then allowed values are 'CampaignSmsTemplate', 'CampaignEmailTemplate', 'Footer' and 'Signature'
        /// </summary>
        /// <value>Values to filter on. If name is 'responseType' then allowed values are 'CampaignSmsTemplate', 'CampaignEmailTemplate', 'Footer' and 'Signature'</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseFilter {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as ResponseFilter);
        }

        /// <summary>
        /// Returns true if ResponseFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
