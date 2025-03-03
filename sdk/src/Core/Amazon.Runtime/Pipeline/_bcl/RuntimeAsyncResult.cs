﻿/*
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

using System;
using System.Threading;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
    public class RuntimeAsyncResult : IAsyncResult, IDisposable
    {
        private object _lockObj;
        private ManualResetEvent _waitHandle;
        private bool _disposed = false;
        private bool _callbackInvoked = false;
        private ILogger _logger;

        public RuntimeAsyncResult(AsyncCallback asyncCallback, object asyncState)
        {
            _lockObj = new object();
            _callbackInvoked = false;
            _logger = Logger.GetLogger(typeof(RuntimeAsyncResult));

            this.AsyncState = asyncState;
            this.IsCompleted = false;
            this.AsyncCallback = asyncCallback;
            this.CompletedSynchronously = false;
        }

        private AsyncCallback AsyncCallback { get; set; }

        public object AsyncState { get; private set; }

        public System.Threading.WaitHandle AsyncWaitHandle
        {
            get
            {
                if (this._waitHandle != null)
                {
                    return this._waitHandle;
                }

                lock (this._lockObj)
                {
                    if (this._waitHandle == null)
                    {
                        this._waitHandle = new ManualResetEvent(this.IsCompleted);
                    }
                }
                return this._waitHandle;
            }
        }

        public bool CompletedSynchronously { get; private set; }

        public bool IsCompleted { get; private set; }

        public Exception Exception { get; set; }

        public AmazonWebServiceResponse Response { get; set; }

        private void SignalWaitHandle()
        {
            this.IsCompleted = true;
            if (this._waitHandle != null)
            {
                this._waitHandle.Set();
            }
        }

        internal void HandleException(Exception exception)
        {
            this.Exception = exception;
            InvokeCallback();
        }

        internal void InvokeCallback()
        {
            this.SignalWaitHandle();
            if (!_callbackInvoked && this.AsyncCallback != null)
            {
                _callbackInvoked = true;
                try
                {
                    this.AsyncCallback(this);
                }
                catch(Exception exception)
                {
                    // Log unhandled exceptions thrown from the user callback for the async method.
                    // Do not rethrow the exception.
                    _logger.Error(exception, "An unhandled exception of type {0} was thrown from the user callback method {1}.{2}",
                    exception.GetType().Name, this.AsyncCallback.Method.DeclaringType.FullName, this.AsyncCallback.Method.Name);
                }
            }
        }

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing && _waitHandle != null)
                {
#if PCL
                    _waitHandle.Dispose();
#else
                    _waitHandle.Close();
#endif
                    _waitHandle = null;
                }
                this._disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
