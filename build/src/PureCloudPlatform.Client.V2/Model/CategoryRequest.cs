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
    /// CategoryRequest
    /// </summary>
    [DataContract]
    public partial class CategoryRequest :  IEquatable<CategoryRequest>
    {
        /// <summary>
        /// The type of interaction the category will apply to
        /// </summary>
        /// <value>The type of interaction the category will apply to</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InteractionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Digital for "Digital"
            /// </summary>
            [EnumMember(Value = "Digital")]
            Digital,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All
        }
        /// <summary>
        /// The type of interaction the category will apply to
        /// </summary>
        /// <value>The type of interaction the category will apply to</value>
        [DataMember(Name="interactionType", EmitDefaultValue=false)]
        public InteractionTypeEnum? InteractionType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the category (required).</param>
        /// <param name="Description">The description of the category.</param>
        /// <param name="InteractionType">The type of interaction the category will apply to (required).</param>
        /// <param name="Criteria">A collection of conditions joined together by logical operation to provide more refined filtering of conversations (required).</param>
        public CategoryRequest(string Name = null, string Description = null, InteractionTypeEnum? InteractionType = null, Operand Criteria = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.InteractionType = InteractionType;
            this.Criteria = Criteria;
            
        }
        


        /// <summary>
        /// The name of the category
        /// </summary>
        /// <value>The name of the category</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the category
        /// </summary>
        /// <value>The description of the category</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// A collection of conditions joined together by logical operation to provide more refined filtering of conversations
        /// </summary>
        /// <value>A collection of conditions joined together by logical operation to provide more refined filtering of conversations</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public Operand Criteria { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
            return this.Equals(obj as CategoryRequest);
        }

        /// <summary>
        /// Returns true if CategoryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryRequest other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.InteractionType == other.InteractionType ||
                    this.InteractionType != null &&
                    this.InteractionType.Equals(other.InteractionType)
                ) &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.Equals(other.Criteria)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.InteractionType != null)
                    hash = hash * 59 + this.InteractionType.GetHashCode();

                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                return hash;
            }
        }
    }

}
