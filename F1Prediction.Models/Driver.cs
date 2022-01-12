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
    public class Driver : IEquatable<Driver>
    {
        /// <summary>
        /// Gets or Sets DriverId
        /// </summary>

        [DataMember(Name = "driverId")]
        public string DriverId { get; set; }

        /// <summary>
        /// Gets or Sets PermanentNumber
        /// </summary>

        [DataMember(Name = "permanentNumber")]
        public string PermanentNumber { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>

        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>

        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>

        [DataMember(Name = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>

        [DataMember(Name = "familyName")]
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>

        [DataMember(Name = "dateOfBirth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>

        [DataMember(Name = "nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Driver {\n");
            sb.Append("  DriverId: ").Append(DriverId).Append("\n");
            sb.Append("  PermanentNumber: ").Append(PermanentNumber).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Driver)obj);
        }

        /// <summary>
        /// Returns true if Driver instances are equal
        /// </summary>
        /// <param name="other">Instance of Driver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Driver other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    DriverId == other.DriverId ||
                    DriverId != null &&
                    DriverId.Equals(other.DriverId)
                ) &&
                (
                    PermanentNumber == other.PermanentNumber ||
                    PermanentNumber != null &&
                    PermanentNumber.Equals(other.PermanentNumber)
                ) &&
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) &&
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) &&
                (
                    GivenName == other.GivenName ||
                    GivenName != null &&
                    GivenName.Equals(other.GivenName)
                ) &&
                (
                    FamilyName == other.FamilyName ||
                    FamilyName != null &&
                    FamilyName.Equals(other.FamilyName)
                ) &&
                (
                    DateOfBirth == other.DateOfBirth ||
                    DateOfBirth != null &&
                    DateOfBirth.Equals(other.DateOfBirth)
                ) &&
                (
                    Nationality == other.Nationality ||
                    Nationality != null &&
                    Nationality.Equals(other.Nationality)
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
                if (DriverId != null)
                    hashCode = hashCode * 59 + DriverId.GetHashCode();
                if (PermanentNumber != null)
                    hashCode = hashCode * 59 + PermanentNumber.GetHashCode();
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (GivenName != null)
                    hashCode = hashCode * 59 + GivenName.GetHashCode();
                if (FamilyName != null)
                    hashCode = hashCode * 59 + FamilyName.GetHashCode();
                if (DateOfBirth != null)
                    hashCode = hashCode * 59 + DateOfBirth.GetHashCode();
                if (Nationality != null)
                    hashCode = hashCode * 59 + Nationality.GetHashCode();
                return hashCode;
            }
        }

    }
}
