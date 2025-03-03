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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action to write to a DynamoDB table.
    /// 
    ///  
    /// <para>
    /// The <code>tableName</code>, <code>hashKeyField</code>, and <code>rangeKeyField</code>
    /// values must match the values used when you created the table.
    /// </para>
    ///  
    /// <para>
    /// The <code>hashKeyValue</code> and <code>rangeKeyvalue</code> fields use a substitution
    /// template syntax. These templates provide data at runtime. The syntax is as follows:
    /// ${<i>sql-expression</i>}.
    /// </para>
    ///  
    /// <para>
    /// You can specify any expression that's valid in a WHERE or SELECT clause, including
    /// JSON properties, comparisons, calculations, and functions. For example, the following
    /// field uses the third level of the topic:
    /// </para>
    ///  
    /// <para>
    /// <code>"hashKeyValue": "${topic(3)}"</code>
    /// </para>
    ///  
    /// <para>
    /// The following field uses the timestamp:
    /// </para>
    ///  
    /// <para>
    /// <code>"rangeKeyValue": "${timestamp()}"</code>
    /// </para>
    /// </summary>
    public partial class DynamoDBAction
    {
        private string _hashKeyField;
        private string _hashKeyValue;
        private string _payloadField;
        private string _rangeKeyField;
        private string _rangeKeyValue;
        private string _roleArn;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property HashKeyField. 
        /// <para>
        /// The hash key name.
        /// </para>
        /// </summary>
        public string HashKeyField
        {
            get { return this._hashKeyField; }
            set { this._hashKeyField = value; }
        }

        // Check to see if HashKeyField property is set
        internal bool IsSetHashKeyField()
        {
            return this._hashKeyField != null;
        }

        /// <summary>
        /// Gets and sets the property HashKeyValue. 
        /// <para>
        /// The hash key value.
        /// </para>
        /// </summary>
        public string HashKeyValue
        {
            get { return this._hashKeyValue; }
            set { this._hashKeyValue = value; }
        }

        // Check to see if HashKeyValue property is set
        internal bool IsSetHashKeyValue()
        {
            return this._hashKeyValue != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadField. 
        /// <para>
        /// The action payload, this name can be customized.
        /// </para>
        /// </summary>
        public string PayloadField
        {
            get { return this._payloadField; }
            set { this._payloadField = value; }
        }

        // Check to see if PayloadField property is set
        internal bool IsSetPayloadField()
        {
            return this._payloadField != null;
        }

        /// <summary>
        /// Gets and sets the property RangeKeyField. 
        /// <para>
        /// The range key name.
        /// </para>
        /// </summary>
        public string RangeKeyField
        {
            get { return this._rangeKeyField; }
            set { this._rangeKeyField = value; }
        }

        // Check to see if RangeKeyField property is set
        internal bool IsSetRangeKeyField()
        {
            return this._rangeKeyField != null;
        }

        /// <summary>
        /// Gets and sets the property RangeKeyValue. 
        /// <para>
        /// The range key value.
        /// </para>
        /// </summary>
        public string RangeKeyValue
        {
            get { return this._rangeKeyValue; }
            set { this._rangeKeyValue = value; }
        }

        // Check to see if RangeKeyValue property is set
        internal bool IsSetRangeKeyValue()
        {
            return this._rangeKeyValue != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants access to the DynamoDB table.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the DynamoDB table.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}