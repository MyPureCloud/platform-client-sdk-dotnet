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
    /// SupportCenterDetailedCategoryModuleTemplate
    /// </summary>
    [DataContract]
    public partial class SupportCenterDetailedCategoryModuleTemplate :  IEquatable<SupportCenterDetailedCategoryModuleTemplate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterDetailedCategoryModuleTemplate" /> class.
        /// </summary>
        /// <param name="Active">Whether this template is active or not.</param>
        /// <param name="Sidebar">Sidebar settings for the template.</param>
        public SupportCenterDetailedCategoryModuleTemplate(bool? Active = null, SupportCenterDetailedCategoryModuleSidebar Sidebar = null)
        {
            this.Active = Active;
            this.Sidebar = Sidebar;
            
        }
        


        /// <summary>
        /// Whether this template is active or not
        /// </summary>
        /// <value>Whether this template is active or not</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }



        /// <summary>
        /// Sidebar settings for the template
        /// </summary>
        /// <value>Sidebar settings for the template</value>
        [DataMember(Name="sidebar", EmitDefaultValue=false)]
        public SupportCenterDetailedCategoryModuleSidebar Sidebar { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterDetailedCategoryModuleTemplate {\n");

            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Sidebar: ").Append(Sidebar).Append("\n");
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
            return this.Equals(obj as SupportCenterDetailedCategoryModuleTemplate);
        }

        /// <summary>
        /// Returns true if SupportCenterDetailedCategoryModuleTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterDetailedCategoryModuleTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterDetailedCategoryModuleTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.Sidebar == other.Sidebar ||
                    this.Sidebar != null &&
                    this.Sidebar.Equals(other.Sidebar)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                if (this.Sidebar != null)
                    hash = hash * 59 + this.Sidebar.GetHashCode();

                return hash;
            }
        }
    }

}
