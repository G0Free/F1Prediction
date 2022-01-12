using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    [DataContract]
    public class Race
    {
        /// <summary>
        /// Gets or Sets Season
        /// </summary>

        [DataMember(Name = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>

        [DataMember(Name = "round")]
        public string Round { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>

        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets RaceName
        /// </summary>

        [DataMember(Name = "raceName")]
        public string RaceName { get; set; }

        /// <summary>
        /// Gets or Sets Circuit
        /// </summary>

        [DataMember(Name = "Circuit")]
        public Circuit Circuit { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>

        [DataMember(Name = "date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>

        [DataMember(Name = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>

        [DataMember(Name = "Results")]
        public List<Result> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Race {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  RaceName: ").Append(RaceName).Append("\n");
            sb.Append("  Circuit: ").Append(Circuit).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Race)obj);
        }

        /// <summary>
        /// Returns true if Race instances are equal
        /// </summary>
        /// <param name="other">Instance of Race to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Race other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Season == other.Season ||
                    Season != null &&
                    Season.Equals(other.Season)
                ) &&
                (
                    Round == other.Round ||
                    Round != null &&
                    Round.Equals(other.Round)
                ) &&
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) &&
                (
                    RaceName == other.RaceName ||
                    RaceName != null &&
                    RaceName.Equals(other.RaceName)
                ) &&
                (
                    Circuit == other.Circuit ||
                    Circuit != null &&
                    Circuit.Equals(other.Circuit)
                ) &&
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) &&
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) &&
                (
                    Results == other.Results ||
                    Results != null &&
                    Results.SequenceEqual(other.Results)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Season != null)
                    hashCode = hashCode * 59 + Season.GetHashCode();
                if (Round != null)
                    hashCode = hashCode * 59 + Round.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (RaceName != null)
                    hashCode = hashCode * 59 + RaceName.GetHashCode();
                if (Circuit != null)
                    hashCode = hashCode * 59 + Circuit.GetHashCode();
                if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                if (Results != null)
                    hashCode = hashCode * 59 + Results.GetHashCode();
                return hashCode;
            }
        }

    }
}
