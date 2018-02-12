﻿/*
 * ******************************************************************************
 *   Copyright 2014-2018 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

using SpectraLogic.EscapePodClient.Runtime;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace SpectraLogic.EscapePodClient.Test.Mock
{
    public class MockHttpWebResponse : IHttpWebResponse
    {
        #region Fields

        private readonly string _resourceName;

        #endregion Fields

        #region Constructors

        public MockHttpWebResponse(string resourceName, HttpStatusCode statusCode, IDictionary<string, IEnumerable<string>> headers)
        {
            _resourceName = resourceName;
            StatusCode = statusCode;
            Headers = headers;
        }

        #endregion Constructors

        #region Properties

        public HttpStatusCode StatusCode { get; }

        public IDictionary<string, IEnumerable<string>> Headers { get; }

        #endregion Properties

        #region Methods

        public void Dispose()
        {
        }

        public Stream GetResponseStream()
        {
            return string.IsNullOrEmpty(_resourceName) ?
                new MemoryStream(Encoding.UTF8.GetBytes("The HTTP request failed")) :
                Assembly.GetExecutingAssembly().GetManifestResourceStream(_resourceName);
        }

        #endregion Methods
    }
}