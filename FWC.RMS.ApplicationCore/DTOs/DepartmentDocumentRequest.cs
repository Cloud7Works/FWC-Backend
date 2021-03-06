/*
 * Revenue Management System
 *
 * Florida Fish and Wildlife Conservation Commision - Revenue Management System.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@fwc.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FWC.RMS.ApplicationCore.DTOs
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DepartmentDocumentRequest : IEquatable<DepartmentDocumentRequest>
    { 
        /// <summary>
        /// Gets or Sets CheckNumber
        /// </summary>
        [DataMember(Name="checkNumber")]
        public long? CheckNumber { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets CheckAmount
        /// </summary>
        [DataMember(Name="checkAmount")]
        public double? CheckAmount { get; set; }

        /// <summary>
        /// Gets or Sets CashListing
        /// </summary>
        [DataMember(Name="cashListing")]
        public string CashListing { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepartmentDocumentRequest {\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CheckAmount: ").Append(CheckAmount).Append("\n");
            sb.Append("  CashListing: ").Append(CashListing).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DepartmentDocumentRequest)obj);
        }

        /// <summary>
        /// Returns true if DepartmentDocumentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DepartmentDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepartmentDocumentRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CheckNumber == other.CheckNumber ||
                    CheckNumber != null &&
                    CheckNumber.Equals(other.CheckNumber)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    CompanyName == other.CompanyName ||
                    CompanyName != null &&
                    CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    CheckAmount == other.CheckAmount ||
                    CheckAmount != null &&
                    CheckAmount.Equals(other.CheckAmount)
                ) && 
                (
                    CashListing == other.CashListing ||
                    CashListing != null &&
                    CashListing.Equals(other.CashListing)
                ) && 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
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
                    if (CheckNumber != null)
                    hashCode = hashCode * 59 + CheckNumber.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (CompanyName != null)
                    hashCode = hashCode * 59 + CompanyName.GetHashCode();
                    if (CheckAmount != null)
                    hashCode = hashCode * 59 + CheckAmount.GetHashCode();
                    if (CashListing != null)
                    hashCode = hashCode * 59 + CashListing.GetHashCode();
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DepartmentDocumentRequest left, DepartmentDocumentRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DepartmentDocumentRequest left, DepartmentDocumentRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
