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
    /// Coretype
    /// </summary>
    [DataContract]
    public partial class Coretype :  IEquatable<Coretype>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Coretype" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">A positive integer denoting the core type&#39;s version.</param>
        /// <param name="DateCreated">The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Schema">The core type&#39;s built-in schema.</param>
        /// <param name="Current">A boolean indicating if the core type&#39;s version is the current one in use by the system.</param>
        /// <param name="ValidationFields">An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type..</param>
        /// <param name="ValidationLimits">A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field..</param>
        /// <param name="ItemValidationFields">Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation.</param>
        /// <param name="ItemValidationLimits">A structure denoting the system-imposed minimum and maximum string length for string-array based core types such as \&quot;tag\&quot; and \&quot;enum\&quot;.  Forexample, the validationLimits for a schema field using a tag core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schema author on individual tags.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field&#39;s tags..</param>
        public Coretype(string Name = null, int? Version = null, DateTime? DateCreated = null, Schema Schema = null, bool? Current = null, List<string> ValidationFields = null, ValidationLimits ValidationLimits = null, List<string> ItemValidationFields = null, ItemValidationLimits ItemValidationLimits = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.Schema = Schema;
            this.Current = Current;
            this.ValidationFields = ValidationFields;
            this.ValidationLimits = ValidationLimits;
            this.ItemValidationFields = ItemValidationFields;
            this.ItemValidationLimits = ItemValidationLimits;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// A positive integer denoting the core type&#39;s version
        /// </summary>
        /// <value>A positive integer denoting the core type&#39;s version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// The core type&#39;s built-in schema
        /// </summary>
        /// <value>The core type&#39;s built-in schema</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public Schema Schema { get; set; }
        
        
        
        /// <summary>
        /// A boolean indicating if the core type&#39;s version is the current one in use by the system
        /// </summary>
        /// <value>A boolean indicating if the core type&#39;s version is the current one in use by the system</value>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public bool? Current { get; set; }
        
        
        
        /// <summary>
        /// An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type.
        /// </summary>
        /// <value>An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type.</value>
        [DataMember(Name="validationFields", EmitDefaultValue=false)]
        public List<string> ValidationFields { get; set; }
        
        
        
        /// <summary>
        /// A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.
        /// </summary>
        /// <value>A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.</value>
        [DataMember(Name="validationLimits", EmitDefaultValue=false)]
        public ValidationLimits ValidationLimits { get; set; }
        
        
        
        /// <summary>
        /// Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation
        /// </summary>
        /// <value>Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation</value>
        [DataMember(Name="itemValidationFields", EmitDefaultValue=false)]
        public List<string> ItemValidationFields { get; set; }
        
        
        
        /// <summary>
        /// A structure denoting the system-imposed minimum and maximum string length for string-array based core types such as \&quot;tag\&quot; and \&quot;enum\&quot;.  Forexample, the validationLimits for a schema field using a tag core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schema author on individual tags.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field&#39;s tags.
        /// </summary>
        /// <value>A structure denoting the system-imposed minimum and maximum string length for string-array based core types such as \&quot;tag\&quot; and \&quot;enum\&quot;.  Forexample, the validationLimits for a schema field using a tag core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schema author on individual tags.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field&#39;s tags.</value>
        [DataMember(Name="itemValidationLimits", EmitDefaultValue=false)]
        public ItemValidationLimits ItemValidationLimits { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Coretype {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  ValidationFields: ").Append(ValidationFields).Append("\n");
            sb.Append("  ValidationLimits: ").Append(ValidationLimits).Append("\n");
            sb.Append("  ItemValidationFields: ").Append(ItemValidationFields).Append("\n");
            sb.Append("  ItemValidationLimits: ").Append(ItemValidationLimits).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Coretype);
        }

        /// <summary>
        /// Returns true if Coretype instances are equal
        /// </summary>
        /// <param name="other">Instance of Coretype to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Coretype other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this.Current == other.Current ||
                    this.Current != null &&
                    this.Current.Equals(other.Current)
                ) &&
                (
                    this.ValidationFields == other.ValidationFields ||
                    this.ValidationFields != null &&
                    this.ValidationFields.SequenceEqual(other.ValidationFields)
                ) &&
                (
                    this.ValidationLimits == other.ValidationLimits ||
                    this.ValidationLimits != null &&
                    this.ValidationLimits.Equals(other.ValidationLimits)
                ) &&
                (
                    this.ItemValidationFields == other.ItemValidationFields ||
                    this.ItemValidationFields != null &&
                    this.ItemValidationFields.SequenceEqual(other.ItemValidationFields)
                ) &&
                (
                    this.ItemValidationLimits == other.ItemValidationLimits ||
                    this.ItemValidationLimits != null &&
                    this.ItemValidationLimits.Equals(other.ItemValidationLimits)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                
                if (this.Current != null)
                    hash = hash * 59 + this.Current.GetHashCode();
                
                if (this.ValidationFields != null)
                    hash = hash * 59 + this.ValidationFields.GetHashCode();
                
                if (this.ValidationLimits != null)
                    hash = hash * 59 + this.ValidationLimits.GetHashCode();
                
                if (this.ItemValidationFields != null)
                    hash = hash * 59 + this.ItemValidationFields.GetHashCode();
                
                if (this.ItemValidationLimits != null)
                    hash = hash * 59 + this.ItemValidationLimits.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
