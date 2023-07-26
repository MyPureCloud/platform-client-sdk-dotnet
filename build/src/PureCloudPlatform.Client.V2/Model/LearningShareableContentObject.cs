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
    /// Learning assignment SCO (Shareable Content Object)
    /// </summary>
    [DataContract]
    public partial class LearningShareableContentObject :  IEquatable<LearningShareableContentObject>
    {
        /// <summary>
        /// The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.
        /// </summary>
        /// <value>The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LessonStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Passed for "Passed"
            /// </summary>
            [EnumMember(Value = "Passed")]
            Passed,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Incomplete for "Incomplete"
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete,
            
            /// <summary>
            /// Enum Browsed for "Browsed"
            /// </summary>
            [EnumMember(Value = "Browsed")]
            Browsed,
            
            /// <summary>
            /// Enum Notattempted for "NotAttempted"
            /// </summary>
            [EnumMember(Value = "NotAttempted")]
            Notattempted
        }
        /// <summary>
        /// Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.
        /// </summary>
        /// <value>Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExitEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Timeout for "Timeout"
            /// </summary>
            [EnumMember(Value = "Timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Suspend for "Suspend"
            /// </summary>
            [EnumMember(Value = "Suspend")]
            Suspend,
            
            /// <summary>
            /// Enum Logout for "Logout"
            /// </summary>
            [EnumMember(Value = "Logout")]
            Logout,
            
            /// <summary>
            /// Enum Empty for "Empty"
            /// </summary>
            [EnumMember(Value = "Empty")]
            Empty
        }
        /// <summary>
        /// Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.
        /// </summary>
        /// <value>Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CreditEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Credit for "Credit"
            /// </summary>
            [EnumMember(Value = "Credit")]
            Credit,
            
            /// <summary>
            /// Enum Nocredit for "NoCredit"
            /// </summary>
            [EnumMember(Value = "NoCredit")]
            Nocredit
        }
        /// <summary>
        /// Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.
        /// </summary>
        /// <value>Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Abinitio for "AbInitio"
            /// </summary>
            [EnumMember(Value = "AbInitio")]
            Abinitio,
            
            /// <summary>
            /// Enum Resume for "Resume"
            /// </summary>
            [EnumMember(Value = "Resume")]
            Resume,
            
            /// <summary>
            /// Enum Empty for "Empty"
            /// </summary>
            [EnumMember(Value = "Empty")]
            Empty
        }
        /// <summary>
        /// Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.
        /// </summary>
        /// <value>Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Browse for "Browse"
            /// </summary>
            [EnumMember(Value = "Browse")]
            Browse,
            
            /// <summary>
            /// Enum Normal for "Normal"
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal,
            
            /// <summary>
            /// Enum Review for "Review"
            /// </summary>
            [EnumMember(Value = "Review")]
            Review
        }
        /// <summary>
        /// The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.
        /// </summary>
        /// <value>The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property.</value>
        [DataMember(Name="lessonStatus", EmitDefaultValue=false)]
        public LessonStatusEnum? LessonStatus { get; set; }
        /// <summary>
        /// Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.
        /// </summary>
        /// <value>Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property.</value>
        [DataMember(Name="exit", EmitDefaultValue=false)]
        public ExitEnum? Exit { get; set; }
        /// <summary>
        /// Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.
        /// </summary>
        /// <value>Whether completing this course counts towards the overall assignment. Maps to the SCORM 1.2 cmi.core.credit property.</value>
        [DataMember(Name="credit", EmitDefaultValue=false)]
        public CreditEnum? Credit { get; private set; }
        /// <summary>
        /// Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.
        /// </summary>
        /// <value>Whether the learner has previously accessed this SCO. Maps to the SCORM 1.2 cmi.core.entry property.</value>
        [DataMember(Name="entry", EmitDefaultValue=false)]
        public EntryEnum? Entry { get; private set; }
        /// <summary>
        /// Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.
        /// </summary>
        /// <value>Identifies the mode in which the SCO should be presented to the learner. Maps to the SCORM 1.2 cmi.core.lesson_mode property.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningShareableContentObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningShareableContentObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningShareableContentObject" /> class.
        /// </summary>
        /// <param name="Id">The ID of the SCO from the course manifest. (required).</param>
        /// <param name="LessonStatus">The status of the SCO. Maps to the SCORM 1.2 cmi.core.lesson_status property..</param>
        /// <param name="Exit">Indicates how or why the learner left the SCO. Maps to the SCORM 1.2 cmi.core.exit property..</param>
        /// <param name="Location">The learner’s current location in the SCO. Maps to the SCORM 1.2 cmi.core.lesson_location property..</param>
        /// <param name="ScoreRaw">The score of the most recent attempt on the SCO. Maps to the SCORM 1.2 cmi.core.score.raw property..</param>
        /// <param name="ScoreMax">The maximum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.max property..</param>
        /// <param name="ScoreMin">The minimum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.min property..</param>
        /// <param name="SuspendData">The unique information generated by the SCO from previous uses. Maps to the SCORM 1.2 cmi.suspend_data property..</param>
        /// <param name="SessionTime">The amount of time spent in the SCO in this session expressed as an ISO-8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.session_time property..</param>
        public LearningShareableContentObject(string Id = null, LessonStatusEnum? LessonStatus = null, ExitEnum? Exit = null, string Location = null, float? ScoreRaw = null, float? ScoreMax = null, float? ScoreMin = null, string SuspendData = null, string SessionTime = null)
        {
            this.Id = Id;
            this.LessonStatus = LessonStatus;
            this.Exit = Exit;
            this.Location = Location;
            this.ScoreRaw = ScoreRaw;
            this.ScoreMax = ScoreMax;
            this.ScoreMin = ScoreMin;
            this.SuspendData = SuspendData;
            this.SessionTime = SessionTime;
            
        }
        


        /// <summary>
        /// The ID of the SCO from the course manifest.
        /// </summary>
        /// <value>The ID of the SCO from the course manifest.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }







        /// <summary>
        /// The learner’s current location in the SCO. Maps to the SCORM 1.2 cmi.core.lesson_location property.
        /// </summary>
        /// <value>The learner’s current location in the SCO. Maps to the SCORM 1.2 cmi.core.lesson_location property.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }



        /// <summary>
        /// The score of the most recent attempt on the SCO. Maps to the SCORM 1.2 cmi.core.score.raw property.
        /// </summary>
        /// <value>The score of the most recent attempt on the SCO. Maps to the SCORM 1.2 cmi.core.score.raw property.</value>
        [DataMember(Name="scoreRaw", EmitDefaultValue=false)]
        public float? ScoreRaw { get; set; }



        /// <summary>
        /// The maximum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.max property.
        /// </summary>
        /// <value>The maximum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.max property.</value>
        [DataMember(Name="scoreMax", EmitDefaultValue=false)]
        public float? ScoreMax { get; set; }



        /// <summary>
        /// The minimum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.min property.
        /// </summary>
        /// <value>The minimum score that could be achieved on the SCO. Maps to the SCORM 1.2 cmi.core.score.min property.</value>
        [DataMember(Name="scoreMin", EmitDefaultValue=false)]
        public float? ScoreMin { get; set; }



        /// <summary>
        /// The unique information generated by the SCO from previous uses. Maps to the SCORM 1.2 cmi.suspend_data property.
        /// </summary>
        /// <value>The unique information generated by the SCO from previous uses. Maps to the SCORM 1.2 cmi.suspend_data property.</value>
        [DataMember(Name="suspendData", EmitDefaultValue=false)]
        public string SuspendData { get; set; }









        /// <summary>
        /// The total amount of time the learner has spent in the SCO expressed as an ISO 8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.total_time property.
        /// </summary>
        /// <value>The total amount of time the learner has spent in the SCO expressed as an ISO 8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.total_time property.</value>
        [DataMember(Name="totalTime", EmitDefaultValue=false)]
        public string TotalTime { get; private set; }



        /// <summary>
        /// The amount of time spent in the SCO in this session expressed as an ISO-8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.session_time property.
        /// </summary>
        /// <value>The amount of time spent in the SCO in this session expressed as an ISO-8601 Duration, for example PT2H10M3.5S. Maps to the SCORM 1.2 cmi.core.session_time property.</value>
        [DataMember(Name="sessionTime", EmitDefaultValue=false)]
        public string SessionTime { get; set; }



        /// <summary>
        /// The href from the course manifest for this SCO.
        /// </summary>
        /// <value>The href from the course manifest for this SCO.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; private set; }



        /// <summary>
        /// The parameters from the course manifest for this SCO.
        /// </summary>
        /// <value>The parameters from the course manifest for this SCO.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public string Parameters { get; private set; }



        /// <summary>
        /// The launch data from the course manifest for this SCO.
        /// </summary>
        /// <value>The launch data from the course manifest for this SCO.</value>
        [DataMember(Name="launchData", EmitDefaultValue=false)]
        public string LaunchData { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningShareableContentObject {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LessonStatus: ").Append(LessonStatus).Append("\n");
            sb.Append("  Exit: ").Append(Exit).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ScoreRaw: ").Append(ScoreRaw).Append("\n");
            sb.Append("  ScoreMax: ").Append(ScoreMax).Append("\n");
            sb.Append("  ScoreMin: ").Append(ScoreMin).Append("\n");
            sb.Append("  SuspendData: ").Append(SuspendData).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Entry: ").Append(Entry).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  TotalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  SessionTime: ").Append(SessionTime).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  LaunchData: ").Append(LaunchData).Append("\n");
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
            return this.Equals(obj as LearningShareableContentObject);
        }

        /// <summary>
        /// Returns true if LearningShareableContentObject instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningShareableContentObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningShareableContentObject other)
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
                    this.LessonStatus == other.LessonStatus ||
                    this.LessonStatus != null &&
                    this.LessonStatus.Equals(other.LessonStatus)
                ) &&
                (
                    this.Exit == other.Exit ||
                    this.Exit != null &&
                    this.Exit.Equals(other.Exit)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.ScoreRaw == other.ScoreRaw ||
                    this.ScoreRaw != null &&
                    this.ScoreRaw.Equals(other.ScoreRaw)
                ) &&
                (
                    this.ScoreMax == other.ScoreMax ||
                    this.ScoreMax != null &&
                    this.ScoreMax.Equals(other.ScoreMax)
                ) &&
                (
                    this.ScoreMin == other.ScoreMin ||
                    this.ScoreMin != null &&
                    this.ScoreMin.Equals(other.ScoreMin)
                ) &&
                (
                    this.SuspendData == other.SuspendData ||
                    this.SuspendData != null &&
                    this.SuspendData.Equals(other.SuspendData)
                ) &&
                (
                    this.Credit == other.Credit ||
                    this.Credit != null &&
                    this.Credit.Equals(other.Credit)
                ) &&
                (
                    this.Entry == other.Entry ||
                    this.Entry != null &&
                    this.Entry.Equals(other.Entry)
                ) &&
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) &&
                (
                    this.TotalTime == other.TotalTime ||
                    this.TotalTime != null &&
                    this.TotalTime.Equals(other.TotalTime)
                ) &&
                (
                    this.SessionTime == other.SessionTime ||
                    this.SessionTime != null &&
                    this.SessionTime.Equals(other.SessionTime)
                ) &&
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.Equals(other.Parameters)
                ) &&
                (
                    this.LaunchData == other.LaunchData ||
                    this.LaunchData != null &&
                    this.LaunchData.Equals(other.LaunchData)
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

                if (this.LessonStatus != null)
                    hash = hash * 59 + this.LessonStatus.GetHashCode();

                if (this.Exit != null)
                    hash = hash * 59 + this.Exit.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.ScoreRaw != null)
                    hash = hash * 59 + this.ScoreRaw.GetHashCode();

                if (this.ScoreMax != null)
                    hash = hash * 59 + this.ScoreMax.GetHashCode();

                if (this.ScoreMin != null)
                    hash = hash * 59 + this.ScoreMin.GetHashCode();

                if (this.SuspendData != null)
                    hash = hash * 59 + this.SuspendData.GetHashCode();

                if (this.Credit != null)
                    hash = hash * 59 + this.Credit.GetHashCode();

                if (this.Entry != null)
                    hash = hash * 59 + this.Entry.GetHashCode();

                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();

                if (this.TotalTime != null)
                    hash = hash * 59 + this.TotalTime.GetHashCode();

                if (this.SessionTime != null)
                    hash = hash * 59 + this.SessionTime.GetHashCode();

                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                if (this.LaunchData != null)
                    hash = hash * 59 + this.LaunchData.GetHashCode();

                return hash;
            }
        }
    }

}
