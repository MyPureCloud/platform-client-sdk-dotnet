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
    /// ContactsPatchChange
    /// </summary>
    [DataContract]
    public partial class ContactsPatchChange :  IEquatable<ContactsPatchChange>
    {
        /// <summary>
        /// The action of the operation.UpdateIfEmpty: Update if and only if the current value is emptyUpdate: Update the field unconditionally.UpdateIfExists: Update the field if and only if the existing field is not empty.AppendToCollection: Add new items to a collection, preserving existing data.Remove: Remove the current value unconditionally.RemoveFromCollection: Remove specified value from a collection.
        /// </summary>
        /// <value>The action of the operation.UpdateIfEmpty: Update if and only if the current value is emptyUpdate: Update the field unconditionally.UpdateIfExists: Update the field if and only if the existing field is not empty.AppendToCollection: Add new items to a collection, preserving existing data.Remove: Remove the current value unconditionally.RemoveFromCollection: Remove specified value from a collection.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Updateifempty for "UpdateIfEmpty"
            /// </summary>
            [EnumMember(Value = "UpdateIfEmpty")]
            Updateifempty,
            
            /// <summary>
            /// Enum Updateifexists for "UpdateIfExists"
            /// </summary>
            [EnumMember(Value = "UpdateIfExists")]
            Updateifexists,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Appendtocollection for "AppendToCollection"
            /// </summary>
            [EnumMember(Value = "AppendToCollection")]
            Appendtocollection,
            
            /// <summary>
            /// Enum Remove for "Remove"
            /// </summary>
            [EnumMember(Value = "Remove")]
            Remove,
            
            /// <summary>
            /// Enum Removefromcollection for "RemoveFromCollection"
            /// </summary>
            [EnumMember(Value = "RemoveFromCollection")]
            Removefromcollection
        }
        /// <summary>
        /// The action of the operation.UpdateIfEmpty: Update if and only if the current value is emptyUpdate: Update the field unconditionally.UpdateIfExists: Update the field if and only if the existing field is not empty.AppendToCollection: Add new items to a collection, preserving existing data.Remove: Remove the current value unconditionally.RemoveFromCollection: Remove specified value from a collection.
        /// </summary>
        /// <value>The action of the operation.UpdateIfEmpty: Update if and only if the current value is emptyUpdate: Update the field unconditionally.UpdateIfExists: Update the field if and only if the existing field is not empty.AppendToCollection: Add new items to a collection, preserving existing data.Remove: Remove the current value unconditionally.RemoveFromCollection: Remove specified value from a collection.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsPatchChange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactsPatchChange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsPatchChange" /> class.
        /// </summary>
        /// <param name="Field">A JSONPath string, whose syntax is a strict subset of the JSONPath RFC 9535.  The root of the field string must be \&quot;$.\&quot; indicating a path from the root of the entity. You may only use dot-notation to access named fields. Examples: To select the &#x60;firstName&#x60; field of a Contact, use: \&quot;$.firstName\&quot;.To access object fields, use the top level object field name: \&quot;$.address\&quot;. To access nested field names, use the nested field name: \&quot;$.address.city\&quot;. Note: trying to patch both nested fields and their parent field is not allowed and will result in a 409 error response. (required).</param>
        /// <param name="Value">The value which is applied to the selected field for the patch. Acceptable types are String, Integer, Boolean, Array, Map..</param>
        /// <param name="Action">The action of the operation.UpdateIfEmpty: Update if and only if the current value is emptyUpdate: Update the field unconditionally.UpdateIfExists: Update the field if and only if the existing field is not empty.AppendToCollection: Add new items to a collection, preserving existing data.Remove: Remove the current value unconditionally.RemoveFromCollection: Remove specified value from a collection. (required).</param>
        public ContactsPatchChange(string Field = null, Object Value = null, ActionEnum? Action = null)
        {
            this.Field = Field;
            this.Value = Value;
            this.Action = Action;
            
        }
        


        /// <summary>
        /// A JSONPath string, whose syntax is a strict subset of the JSONPath RFC 9535.  The root of the field string must be \&quot;$.\&quot; indicating a path from the root of the entity. You may only use dot-notation to access named fields. Examples: To select the &#x60;firstName&#x60; field of a Contact, use: \&quot;$.firstName\&quot;.To access object fields, use the top level object field name: \&quot;$.address\&quot;. To access nested field names, use the nested field name: \&quot;$.address.city\&quot;. Note: trying to patch both nested fields and their parent field is not allowed and will result in a 409 error response.
        /// </summary>
        /// <value>A JSONPath string, whose syntax is a strict subset of the JSONPath RFC 9535.  The root of the field string must be \&quot;$.\&quot; indicating a path from the root of the entity. You may only use dot-notation to access named fields. Examples: To select the &#x60;firstName&#x60; field of a Contact, use: \&quot;$.firstName\&quot;.To access object fields, use the top level object field name: \&quot;$.address\&quot;. To access nested field names, use the nested field name: \&quot;$.address.city\&quot;. Note: trying to patch both nested fields and their parent field is not allowed and will result in a 409 error response.</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }



        /// <summary>
        /// The value which is applied to the selected field for the patch. Acceptable types are String, Integer, Boolean, Array, Map.
        /// </summary>
        /// <value>The value which is applied to the selected field for the patch. Acceptable types are String, Integer, Boolean, Array, Map.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsPatchChange {\n");

            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as ContactsPatchChange);
        }

        /// <summary>
        /// Returns true if ContactsPatchChange instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactsPatchChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactsPatchChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                return hash;
            }
        }
    }

}
