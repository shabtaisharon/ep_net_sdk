﻿/*
 * ******************************************************************************
 *   Copyright 2014-2020 Spectra Logic Corporation. All Rights Reserved.
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

using System.Net;
using log4net;
using Newtonsoft.Json;
using SpectraLogic.SpectraRioBrokerClient.Exceptions;
using SpectraLogic.SpectraRioBrokerClient.Model;
using SpectraLogic.SpectraRioBrokerClient.Runtime;
using SpectraLogic.SpectraRioBrokerClient.Utils;

namespace SpectraLogic.SpectraRioBrokerClient.ResponseParsers
{
    internal class HeadResponseParser : IResponseParser<bool>
    {
        #region Private Fields

        private static readonly ILog Log = LogManager.GetLogger("HeadResponseParser");

        #endregion Private Fields

        #region Public Methods

        public bool Parse(IHttpWebResponse response)
        {
            using (response)
            {
                var requestId = response.Headers.GetRequestIdFromHeader();
                Log.Debug($"Request: {requestId} {response.StatusCode}");


                if (response.StatusCode == HttpStatusCode.ServiceUnavailable)
                {
                    var errorResponse =
                        JsonConvert.DeserializeObject<ErrorResponse>(
                            "{\"message\":\"The service is unavailable\",\"statusCode\":503}");
                    throw new ErrorResponseException(errorResponse);
                }

                return response.StatusCode == HttpStatusCode.OK;
            }
        }

        #endregion Public Methods
    }
}