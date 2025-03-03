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
    /// Container for the parameters to the DeleteCertificate operation.
    /// Deletes a certificate and its associated private key. If this function succeeds,
    /// the certificate will no longer appear in the list of certificates that can be displayed
    /// by calling the <a>ListCertificates</a> function or be retrieved by calling the <a>GetCertificate</a>
    /// function. The certificate will not be available for use by other AWS services. <note>You
    /// cannot delete a certificate that is being used by another AWS service. To delete a
    /// certificate that is in use, the certificate association must first be removed. </note>
    /// </summary>
    public partial class DeleteCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteCertificateRequest() { }

        /// <summary>
        /// Instantiates DeleteCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="certificateArn"> String that contains the ARN of the certificate to be deleted. This must be of the form:   <code>arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>   For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>. </param>
        public DeleteCertificateRequest(string certificateArn)
        {
            _certificateArn = certificateArn;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        ///  String that contains the ARN of the certificate to be deleted. This must be of the
        /// form: 
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

    }
}