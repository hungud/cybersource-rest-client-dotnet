/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2payoutsProcessingInformationPayoutsOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2payoutsProcessingInformationPayoutsOptions :  IEquatable<Ptsv2payoutsProcessingInformationPayoutsOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2payoutsProcessingInformationPayoutsOptions" /> class.
        /// </summary>
        /// <param name="AcquirerMerchantId">This field identifies the card acceptor for defining the point of service terminal in both local and interchange environments. An acquirer-assigned code identifying the card acceptor for the transaction.  Depending on the acquirer and merchant billing and reporting requirements, the code can represent a merchant, a specific merchant location, or a specific merchant location terminal. Acquiring Institution Identification Code uniquely identifies the merchant. The value from the original is required in any subsequent messages, including reversals, chargebacks, and representments. * Applicable only for CTV for Payouts. .</param>
        /// <param name="AcquirerBin">This code identifies the financial institution acting as the acquirer of this customer transaction. The acquirer is the member or system user that signed the merchant or ADM or dispensed cash.  This number is usually Visa-assigned. * Applicable only for CTV for Payouts. .</param>
        /// <param name="RetrievalReferenceNumber">This field contains a number that is used with other data elements as a key to identify and track all messages related to a given cardholder transaction; that is, to a given transaction set.  Format:   Positions 1-4: The yddd equivalent of the date, where y &#x3D; 0-9 and ddd &#x3D; 001 – 366.   Positions 5-12: A unique identification number generated by the merchant  * Applicable only for CTV for Payouts. .</param>
        /// <param name="AccountFundingReferenceId">Visa-generated transaction identifier (TID) that is unique for each original authorization and financial request. * Applicable only for CTV for Payouts. .</param>
        public Ptsv2payoutsProcessingInformationPayoutsOptions(string AcquirerMerchantId = default(string), string AcquirerBin = default(string), string RetrievalReferenceNumber = default(string), string AccountFundingReferenceId = default(string))
        {
            this.AcquirerMerchantId = AcquirerMerchantId;
            this.AcquirerBin = AcquirerBin;
            this.RetrievalReferenceNumber = RetrievalReferenceNumber;
            this.AccountFundingReferenceId = AccountFundingReferenceId;
        }
        
        /// <summary>
        /// This field identifies the card acceptor for defining the point of service terminal in both local and interchange environments. An acquirer-assigned code identifying the card acceptor for the transaction.  Depending on the acquirer and merchant billing and reporting requirements, the code can represent a merchant, a specific merchant location, or a specific merchant location terminal. Acquiring Institution Identification Code uniquely identifies the merchant. The value from the original is required in any subsequent messages, including reversals, chargebacks, and representments. * Applicable only for CTV for Payouts. 
        /// </summary>
        /// <value>This field identifies the card acceptor for defining the point of service terminal in both local and interchange environments. An acquirer-assigned code identifying the card acceptor for the transaction.  Depending on the acquirer and merchant billing and reporting requirements, the code can represent a merchant, a specific merchant location, or a specific merchant location terminal. Acquiring Institution Identification Code uniquely identifies the merchant. The value from the original is required in any subsequent messages, including reversals, chargebacks, and representments. * Applicable only for CTV for Payouts. </value>
        [DataMember(Name="acquirerMerchantId", EmitDefaultValue=false)]
        public string AcquirerMerchantId { get; set; }

        /// <summary>
        /// This code identifies the financial institution acting as the acquirer of this customer transaction. The acquirer is the member or system user that signed the merchant or ADM or dispensed cash.  This number is usually Visa-assigned. * Applicable only for CTV for Payouts. 
        /// </summary>
        /// <value>This code identifies the financial institution acting as the acquirer of this customer transaction. The acquirer is the member or system user that signed the merchant or ADM or dispensed cash.  This number is usually Visa-assigned. * Applicable only for CTV for Payouts. </value>
        [DataMember(Name="acquirerBin", EmitDefaultValue=false)]
        public string AcquirerBin { get; set; }

        /// <summary>
        /// This field contains a number that is used with other data elements as a key to identify and track all messages related to a given cardholder transaction; that is, to a given transaction set.  Format:   Positions 1-4: The yddd equivalent of the date, where y &#x3D; 0-9 and ddd &#x3D; 001 – 366.   Positions 5-12: A unique identification number generated by the merchant  * Applicable only for CTV for Payouts. 
        /// </summary>
        /// <value>This field contains a number that is used with other data elements as a key to identify and track all messages related to a given cardholder transaction; that is, to a given transaction set.  Format:   Positions 1-4: The yddd equivalent of the date, where y &#x3D; 0-9 and ddd &#x3D; 001 – 366.   Positions 5-12: A unique identification number generated by the merchant  * Applicable only for CTV for Payouts. </value>
        [DataMember(Name="retrievalReferenceNumber", EmitDefaultValue=false)]
        public string RetrievalReferenceNumber { get; set; }

        /// <summary>
        /// Visa-generated transaction identifier (TID) that is unique for each original authorization and financial request. * Applicable only for CTV for Payouts. 
        /// </summary>
        /// <value>Visa-generated transaction identifier (TID) that is unique for each original authorization and financial request. * Applicable only for CTV for Payouts. </value>
        [DataMember(Name="accountFundingReferenceId", EmitDefaultValue=false)]
        public string AccountFundingReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2payoutsProcessingInformationPayoutsOptions {\n");
            sb.Append("  AcquirerMerchantId: ").Append(AcquirerMerchantId).Append("\n");
            sb.Append("  AcquirerBin: ").Append(AcquirerBin).Append("\n");
            sb.Append("  RetrievalReferenceNumber: ").Append(RetrievalReferenceNumber).Append("\n");
            sb.Append("  AccountFundingReferenceId: ").Append(AccountFundingReferenceId).Append("\n");
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
            return this.Equals(obj as Ptsv2payoutsProcessingInformationPayoutsOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2payoutsProcessingInformationPayoutsOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2payoutsProcessingInformationPayoutsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2payoutsProcessingInformationPayoutsOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcquirerMerchantId == other.AcquirerMerchantId ||
                    this.AcquirerMerchantId != null &&
                    this.AcquirerMerchantId.Equals(other.AcquirerMerchantId)
                ) && 
                (
                    this.AcquirerBin == other.AcquirerBin ||
                    this.AcquirerBin != null &&
                    this.AcquirerBin.Equals(other.AcquirerBin)
                ) && 
                (
                    this.RetrievalReferenceNumber == other.RetrievalReferenceNumber ||
                    this.RetrievalReferenceNumber != null &&
                    this.RetrievalReferenceNumber.Equals(other.RetrievalReferenceNumber)
                ) && 
                (
                    this.AccountFundingReferenceId == other.AccountFundingReferenceId ||
                    this.AccountFundingReferenceId != null &&
                    this.AccountFundingReferenceId.Equals(other.AccountFundingReferenceId)
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
                if (this.AcquirerMerchantId != null)
                    hash = hash * 59 + this.AcquirerMerchantId.GetHashCode();
                if (this.AcquirerBin != null)
                    hash = hash * 59 + this.AcquirerBin.GetHashCode();
                if (this.RetrievalReferenceNumber != null)
                    hash = hash * 59 + this.RetrievalReferenceNumber.GetHashCode();
                if (this.AccountFundingReferenceId != null)
                    hash = hash * 59 + this.AccountFundingReferenceId.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AcquirerMerchantId (string) maxLength
            if(this.AcquirerMerchantId != null && this.AcquirerMerchantId.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcquirerMerchantId, length must be less than or equal to 15.", new [] { "AcquirerMerchantId" });
            }

            // AcquirerBin (string) maxLength
            if(this.AcquirerBin != null && this.AcquirerBin.Length >= 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcquirerBin, length must be less than or equal to 11.", new [] { "AcquirerBin" });
            }

            // RetrievalReferenceNumber (string) maxLength
            if(this.RetrievalReferenceNumber != null && this.RetrievalReferenceNumber.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RetrievalReferenceNumber, length must be less than or equal to 12.", new [] { "RetrievalReferenceNumber" });
            }

            // AccountFundingReferenceId (string) maxLength
            if(this.AccountFundingReferenceId != null && this.AccountFundingReferenceId.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountFundingReferenceId, length must be less than or equal to 15.", new [] { "AccountFundingReferenceId" });
            }

            yield break;
        }
    }

}
