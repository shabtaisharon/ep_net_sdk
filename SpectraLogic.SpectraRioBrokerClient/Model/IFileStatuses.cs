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

using System.Collections.Generic;

namespace SpectraLogic.SpectraRioBrokerClient.Model
{
    /// <summary>
    /// </summary>
    public interface IFileStatuses
    {
        #region Properties

        /// <summary>
        /// Gets the job file statuses.
        /// </summary>
        /// <value>The job file statuses.</value>
        IList<FileStatus> FileStatusesList { get; }

        /// <summary>
        /// Gets the page.
        /// </summary>
        /// <value>The page.</value>
        PageResult Page { get; }

        #endregion Properties
    }
}