/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This structure is returned in the response object of the <a>DescribeCertificate</a>
    /// function.
    /// </summary>
    public partial class CertificateDetail
    {
        private string _certificateArn;
        private DateTime? _createdAt;
        private string _domainName;
        private List<DomainValidation> _domainValidationOptions = new List<DomainValidation>();
        private List<string> _inUseBy = new List<string>();
        private DateTime? _issuedAt;
        private string _issuer;
        private KeyAlgorithm _keyAlgorithm;
        private DateTime? _notAfter;
        private DateTime? _notBefore;
        private RevocationReason _revocationReason;
        private DateTime? _revokedAt;
        private string _serial;
        private string _signatureAlgorithm;
        private CertificateStatus _status;
        private string _subject;
        private List<string> _subjectAlternativeNames = new List<string>();

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        ///  Amazon Resource Name (ARN) of the certificate. This is of the form: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>. 
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  Time at which the certificate was requested. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  Fully qualified domain name (FQDN), such as www.example.com or example.com, for the
        /// certificate. 
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        ///  References a <a>DomainValidation</a> structure that contains the domain name in the
        /// certificate and the email address that can be used for validation. 
        /// </para>
        /// </summary>
        public List<DomainValidation> DomainValidationOptions
        {
            get { return this._domainValidationOptions; }
            set { this._domainValidationOptions = value; }
        }

        // Check to see if DomainValidationOptions property is set
        internal bool IsSetDomainValidationOptions()
        {
            return this._domainValidationOptions != null && this._domainValidationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InUseBy. 
        /// <para>
        ///  List that identifies ARNs that are using the certificate. A single ACM certificate
        /// can be used by multiple AWS resources. 
        /// </para>
        /// </summary>
        public List<string> InUseBy
        {
            get { return this._inUseBy; }
            set { this._inUseBy = value; }
        }

        // Check to see if InUseBy property is set
        internal bool IsSetInUseBy()
        {
            return this._inUseBy != null && this._inUseBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        ///  Time at which the certificate was issued. 
        /// </para>
        /// </summary>
        public DateTime IssuedAt
        {
            get { return this._issuedAt.GetValueOrDefault(); }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        ///  The X.500 distinguished name of the CA that issued and signed the certificate. 
        /// </para>
        /// </summary>
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        ///  Asymmetric algorithm used to generate the public and private key pair. Currently
        /// the only supported value is <code>RSA_2048</code>. 
        /// </para>
        /// </summary>
        public KeyAlgorithm KeyAlgorithm
        {
            get { return this._keyAlgorithm; }
            set { this._keyAlgorithm = value; }
        }

        // Check to see if KeyAlgorithm property is set
        internal bool IsSetKeyAlgorithm()
        {
            return this._keyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        ///  Time after which the certificate is not valid. 
        /// </para>
        /// </summary>
        public DateTime NotAfter
        {
            get { return this._notAfter.GetValueOrDefault(); }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        ///  Time before which the certificate is not valid. 
        /// </para>
        /// </summary>
        public DateTime NotBefore
        {
            get { return this._notBefore.GetValueOrDefault(); }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevocationReason. 
        /// <para>
        ///  A <code>RevocationReason</code> enumeration value that indicates why the certificate
        /// was revoked. This value exists only if the certificate has been revoked. This can
        /// be one of the following vales: <ul> <li>UNSPECIFIED</li> <li>KEY_COMPROMISE</li> <li>CA_COMPROMISE</li>
        /// <li>AFFILIATION_CHANGED</li> <li>SUPERCEDED</li> <li>CESSATION_OF_OPERATION</li> <li>CERTIFICATE_HOLD</li>
        /// <li>REMOVE_FROM_CRL</li> <li>PRIVILEGE_WITHDRAWN</li> <li>A_A_COMPROMISE</li> </ul>
        /// 
        /// </para>
        /// </summary>
        public RevocationReason RevocationReason
        {
            get { return this._revocationReason; }
            set { this._revocationReason = value; }
        }

        // Check to see if RevocationReason property is set
        internal bool IsSetRevocationReason()
        {
            return this._revocationReason != null;
        }

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        ///  The time, if any, at which the certificate was revoked. This value exists only if
        /// the certificate has been revoked. 
        /// </para>
        /// </summary>
        public DateTime RevokedAt
        {
            get { return this._revokedAt.GetValueOrDefault(); }
            set { this._revokedAt = value; }
        }

        // Check to see if RevokedAt property is set
        internal bool IsSetRevokedAt()
        {
            return this._revokedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Serial. 
        /// <para>
        ///  String that contains the serial number of the certificate. 
        /// </para>
        /// </summary>
        public string Serial
        {
            get { return this._serial; }
            set { this._serial = value; }
        }

        // Check to see if Serial property is set
        internal bool IsSetSerial()
        {
            return this._serial != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        ///  Algorithm used to generate a signature. Currently the only supported value is <code>SHA256WITHRSA</code>.
        /// 
        /// </para>
        /// </summary>
        public string SignatureAlgorithm
        {
            get { return this._signatureAlgorithm; }
            set { this._signatureAlgorithm = value; }
        }

        // Check to see if SignatureAlgorithm property is set
        internal bool IsSetSignatureAlgorithm()
        {
            return this._signatureAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  A <code>CertificateStatus</code> enumeration value that can contain one of the following:
        /// <ul> <li>PENDING_VALIDATION</li> <li>ISSUED</li> <li>INACTIVE</li> <li>EXPIRED</li>
        /// <li>REVOKED</li> <li>FAILED</li> <li>VALIDATION_TIMED_OUT</li> </ul> 
        /// </para>
        /// </summary>
        public CertificateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        ///  The X.500 distinguished name of the entity associated with the public key contained
        /// in the certificate. 
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        ///  One or more domain names (subject alternative names) included in the certificate
        /// request. After the certificate is issued, this list includes the domain names bound
        /// to the public key contained in the certificate. The subject alternative names include
        /// the domain name (CN) of the certificate and additional domain names that can be used
        /// to connect to the website. 
        /// </para>
        /// </summary>
        public List<string> SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null && this._subjectAlternativeNames.Count > 0; 
        }

    }
}