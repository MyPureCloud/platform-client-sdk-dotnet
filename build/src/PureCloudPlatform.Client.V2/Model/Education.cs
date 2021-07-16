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
    /// Education
    /// </summary>
    [DataContract]
    public partial class Education :  IEquatable<Education>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Education" /> class.
        /// </summary>
        /// <param name="School">School.</param>
        /// <param name="FieldOfStudy">FieldOfStudy.</param>
        /// <param name="Notes">Notes about education has a 2000 character limit.</param>
        /// <param name="DateStart">Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateEnd">Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        public Education(string School = null, string FieldOfStudy = null, string Notes = null, String DateStart = null, String DateEnd = null)
        {
            this.School = School;
            this.FieldOfStudy = FieldOfStudy;
            this.Notes = Notes;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FieldOfStudy
        /// </summary>
        [DataMember(Name="fieldOfStudy", EmitDefaultValue=false)]
        public string FieldOfStudy { get; set; }
        
        
        
        /// <summary>
        /// Notes about education has a 2000 character limit
        /// </summary>
        /// <value>Notes about education has a 2000 character limit</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        
        
        
        /// <summary>
        /// Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public String DateStart { get; set; }
        
        
        
        /// <summary>
        /// Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public String DateEnd { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Education {\n");
            
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  FieldOfStudy: ").Append(FieldOfStudy).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
            return this.Equals(obj as Education);
        }

        /// <summary>
        /// Returns true if Education instances are equal
        /// </summary>
        /// <param name="other">Instance of Education to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Education other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.School == other.School ||
                    this.School != null &&
                    this.School.Equals(other.School)
                ) &&
                (
                    this.FieldOfStudy == other.FieldOfStudy ||
                    this.FieldOfStudy != null &&
                    this.FieldOfStudy.Equals(other.FieldOfStudy)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
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
                
                if (this.School != null)
                    hash = hash * 59 + this.School.GetHashCode();
                
                if (this.FieldOfStudy != null)
                    hash = hash * 59 + this.FieldOfStudy.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();
                
                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();
                
                return hash;
            }
        }
    }

}
