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
    /// TssV2TransactionsGet200ResponseProcessingInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseProcessingInformation :  IEquatable<TssV2TransactionsGet200ResponseProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseProcessingInformation" /> class.
        /// </summary>
        /// <param name="PaymentSolution">Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay. .</param>
        /// <param name="CommerceIndicator">Type of transaction. Certain card associations use this information when determining discount rates to charge you. Required for Verified by Visa and MasterCard SecureCode transactions.      This field can contain one of these values:      * 5: &#x60;vbv&#x60; (Successful Verified by Visa transaction)     * 6: &#x60;spa&#x60; (MasterCard SecureCode transaction)     * 7: &#x60;internet&#x60; (default) (eCommerce order placed by     using a Web site)     * 8: &#x60;vbv_attempted&#x60; (Verified by Visa transaction     was attempted but not authenticated)     * E: &#x60;vbv_failure&#x60; (Depending on your payment     processor, you may receive this result if Visa’s     directory service is not available)     * F: &#x60;spa_failure&#x60; (MasterCard SecureCode     authentication failed)     * M: &#x60;moto&#x60; (Mail order or telephone order)     * P: &#x60;retail&#x60; (Point-of-sale transaction)     * R: &#x60;recurring&#x60; (Recurring transaction)     * S: &#x60;install&#x60; (Installment payment) .</param>
        /// <param name="BusinessApplicationId">Payouts transaction type. Required for OCT transactions. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. **Note** When the request includes this field, this value overrides the information in your CyberSource account.  For valid values, see the &#x60;invoiceHeader_businessApplicationID&#x60; field description in [Payouts Using the Simple Order API.](http://apps.cybersource.com/library/documentation/dev_guides/payouts_SO/Payouts_SO_API.pdf) .</param>
        /// <param name="AuthorizationOptions">AuthorizationOptions.</param>
        /// <param name="BankTransferOptions">BankTransferOptions.</param>
        /// <param name="JapanPaymentOptions">JapanPaymentOptions.</param>
        public TssV2TransactionsGet200ResponseProcessingInformation(string PaymentSolution = default(string), string CommerceIndicator = default(string), string BusinessApplicationId = default(string), TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions AuthorizationOptions = default(TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions), TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions BankTransferOptions = default(TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions), TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions JapanPaymentOptions = default(TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions))
        {
            this.PaymentSolution = PaymentSolution;
            this.CommerceIndicator = CommerceIndicator;
            this.BusinessApplicationId = BusinessApplicationId;
            this.AuthorizationOptions = AuthorizationOptions;
            this.BankTransferOptions = BankTransferOptions;
            this.JapanPaymentOptions = JapanPaymentOptions;
        }
        
        /// <summary>
        /// Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay. 
        /// </summary>
        /// <value>Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay. </value>
        [DataMember(Name="paymentSolution", EmitDefaultValue=false)]
        public string PaymentSolution { get; set; }

        /// <summary>
        /// Type of transaction. Certain card associations use this information when determining discount rates to charge you. Required for Verified by Visa and MasterCard SecureCode transactions.      This field can contain one of these values:      * 5: &#x60;vbv&#x60; (Successful Verified by Visa transaction)     * 6: &#x60;spa&#x60; (MasterCard SecureCode transaction)     * 7: &#x60;internet&#x60; (default) (eCommerce order placed by     using a Web site)     * 8: &#x60;vbv_attempted&#x60; (Verified by Visa transaction     was attempted but not authenticated)     * E: &#x60;vbv_failure&#x60; (Depending on your payment     processor, you may receive this result if Visa’s     directory service is not available)     * F: &#x60;spa_failure&#x60; (MasterCard SecureCode     authentication failed)     * M: &#x60;moto&#x60; (Mail order or telephone order)     * P: &#x60;retail&#x60; (Point-of-sale transaction)     * R: &#x60;recurring&#x60; (Recurring transaction)     * S: &#x60;install&#x60; (Installment payment) 
        /// </summary>
        /// <value>Type of transaction. Certain card associations use this information when determining discount rates to charge you. Required for Verified by Visa and MasterCard SecureCode transactions.      This field can contain one of these values:      * 5: &#x60;vbv&#x60; (Successful Verified by Visa transaction)     * 6: &#x60;spa&#x60; (MasterCard SecureCode transaction)     * 7: &#x60;internet&#x60; (default) (eCommerce order placed by     using a Web site)     * 8: &#x60;vbv_attempted&#x60; (Verified by Visa transaction     was attempted but not authenticated)     * E: &#x60;vbv_failure&#x60; (Depending on your payment     processor, you may receive this result if Visa’s     directory service is not available)     * F: &#x60;spa_failure&#x60; (MasterCard SecureCode     authentication failed)     * M: &#x60;moto&#x60; (Mail order or telephone order)     * P: &#x60;retail&#x60; (Point-of-sale transaction)     * R: &#x60;recurring&#x60; (Recurring transaction)     * S: &#x60;install&#x60; (Installment payment) </value>
        [DataMember(Name="commerceIndicator", EmitDefaultValue=false)]
        public string CommerceIndicator { get; set; }

        /// <summary>
        /// Payouts transaction type. Required for OCT transactions. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. **Note** When the request includes this field, this value overrides the information in your CyberSource account.  For valid values, see the &#x60;invoiceHeader_businessApplicationID&#x60; field description in [Payouts Using the Simple Order API.](http://apps.cybersource.com/library/documentation/dev_guides/payouts_SO/Payouts_SO_API.pdf) 
        /// </summary>
        /// <value>Payouts transaction type. Required for OCT transactions. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. **Note** When the request includes this field, this value overrides the information in your CyberSource account.  For valid values, see the &#x60;invoiceHeader_businessApplicationID&#x60; field description in [Payouts Using the Simple Order API.](http://apps.cybersource.com/library/documentation/dev_guides/payouts_SO/Payouts_SO_API.pdf) </value>
        [DataMember(Name="businessApplicationId", EmitDefaultValue=false)]
        public string BusinessApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationOptions
        /// </summary>
        [DataMember(Name="authorizationOptions", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions AuthorizationOptions { get; set; }

        /// <summary>
        /// Gets or Sets BankTransferOptions
        /// </summary>
        [DataMember(Name="bankTransferOptions", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions BankTransferOptions { get; set; }

        /// <summary>
        /// Gets or Sets JapanPaymentOptions
        /// </summary>
        [DataMember(Name="japanPaymentOptions", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions JapanPaymentOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseProcessingInformation {\n");
            sb.Append("  PaymentSolution: ").Append(PaymentSolution).Append("\n");
            sb.Append("  CommerceIndicator: ").Append(CommerceIndicator).Append("\n");
            sb.Append("  BusinessApplicationId: ").Append(BusinessApplicationId).Append("\n");
            sb.Append("  AuthorizationOptions: ").Append(AuthorizationOptions).Append("\n");
            sb.Append("  BankTransferOptions: ").Append(BankTransferOptions).Append("\n");
            sb.Append("  JapanPaymentOptions: ").Append(JapanPaymentOptions).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseProcessingInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentSolution == other.PaymentSolution ||
                    this.PaymentSolution != null &&
                    this.PaymentSolution.Equals(other.PaymentSolution)
                ) && 
                (
                    this.CommerceIndicator == other.CommerceIndicator ||
                    this.CommerceIndicator != null &&
                    this.CommerceIndicator.Equals(other.CommerceIndicator)
                ) && 
                (
                    this.BusinessApplicationId == other.BusinessApplicationId ||
                    this.BusinessApplicationId != null &&
                    this.BusinessApplicationId.Equals(other.BusinessApplicationId)
                ) && 
                (
                    this.AuthorizationOptions == other.AuthorizationOptions ||
                    this.AuthorizationOptions != null &&
                    this.AuthorizationOptions.Equals(other.AuthorizationOptions)
                ) && 
                (
                    this.BankTransferOptions == other.BankTransferOptions ||
                    this.BankTransferOptions != null &&
                    this.BankTransferOptions.Equals(other.BankTransferOptions)
                ) && 
                (
                    this.JapanPaymentOptions == other.JapanPaymentOptions ||
                    this.JapanPaymentOptions != null &&
                    this.JapanPaymentOptions.Equals(other.JapanPaymentOptions)
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
                if (this.PaymentSolution != null)
                    hash = hash * 59 + this.PaymentSolution.GetHashCode();
                if (this.CommerceIndicator != null)
                    hash = hash * 59 + this.CommerceIndicator.GetHashCode();
                if (this.BusinessApplicationId != null)
                    hash = hash * 59 + this.BusinessApplicationId.GetHashCode();
                if (this.AuthorizationOptions != null)
                    hash = hash * 59 + this.AuthorizationOptions.GetHashCode();
                if (this.BankTransferOptions != null)
                    hash = hash * 59 + this.BankTransferOptions.GetHashCode();
                if (this.JapanPaymentOptions != null)
                    hash = hash * 59 + this.JapanPaymentOptions.GetHashCode();
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
            // PaymentSolution (string) maxLength
            if(this.PaymentSolution != null && this.PaymentSolution.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentSolution, length must be less than or equal to 12.", new [] { "PaymentSolution" });
            }

            // CommerceIndicator (string) maxLength
            if(this.CommerceIndicator != null && this.CommerceIndicator.Length >= 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommerceIndicator, length must be less than or equal to 20.", new [] { "CommerceIndicator" });
            }

            yield break;
        }
    }

}
