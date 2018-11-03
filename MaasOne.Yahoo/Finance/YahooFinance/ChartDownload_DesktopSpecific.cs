﻿// ******************************************************************************
// ** 
// **  Yahoo! Managed
// **  Written by Marius Häusler 2012
// **  It would be pleasant, if you contact me when you are using this code.
// **  Contact: YahooFinanceManaged@gmail.com
// **  Project Home: http://code.google.com/p/yahoo-finance-managed/
// **  
// ******************************************************************************
// **  
// **  Copyright 2012 Marius Häusler
// **  
// **  Licensed under the Apache License, Version 2.0 (the "License");
// **  you may not use this file except in compliance with the License.
// **  You may obtain a copy of the License at
// **  
// **    http://www.apache.org/licenses/LICENSE-2.0
// **  
// **  Unless required by applicable law or agreed to in writing, software
// **  distributed under the License is distributed on an "AS IS" BASIS,
// **  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// **  See the License for the specific language governing permissions and
// **  limitations under the License.
// ** 
// ******************************************************************************
using System;


namespace MaasOne.Finance.YahooFinance
{
    public partial class ChartDownload
    {

        /// <summary>
        /// Downloads a chart image.
        /// </summary>
        /// <param name="managedID">The managed ID of the stock</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public Base.Response<ChartResult> Download(IID managedID)
        {
            if (managedID == null)
                throw new ArgumentNullException("managedID", "The passed ID is null.");
            return this.Download(managedID.ID);
        }
        /// <summary>
        /// Downloads a chart image.
        /// </summary>
        /// <param name="unmanagedID">The unmanaged ID of the stock</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public Base.Response<ChartResult> Download(string unmanagedID)
        {
            if (unmanagedID == string.Empty)
                throw new ArgumentNullException("unmanagedID", "The passed ID is empty.");
            ChartDownloadSettings settings = (ChartDownloadSettings)this.Settings.Clone();
            settings.ID = unmanagedID;
            return this.Download(settings);
        }
        public Base.Response<ChartResult> Download(ChartDownloadSettings settings)
        {
            return base.Download(settings);
        }

    }
}
