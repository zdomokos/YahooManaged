// ******************************************************************************
// ** 
// **  MaasOne WebServices
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
using System.Collections.Generic;
using System.Net;


namespace MaasOne.Base
{

    public abstract partial class SettingsBase : ICloneable
    {

        protected abstract string GetUrl();
        public abstract object Clone();

        private List<KeyValuePair<HttpRequestHeader, string>> mAdditionalHeaders = new List<KeyValuePair<HttpRequestHeader, string>>();

        protected virtual List<KeyValuePair<HttpRequestHeader, string>> AdditionalHeaders => mAdditionalHeaders;
	    protected virtual RequestMethod Method => RequestMethod.GET;
	    protected virtual CookieContainer Cookies => null;
	    protected virtual string ContentType => string.Empty;
	    protected virtual string PostData => string.Empty;
	    protected virtual bool DownloadResponseStream => true;

	    internal string GetUrlInternal()
        {
            return this.GetUrl();
        }
        internal List<KeyValuePair<HttpRequestHeader, string>> GetAdditionalHeadersInternal => mAdditionalHeaders;
	    internal RequestMethod MethodInternal => this.Method;
	    internal CookieContainer CookiesInternal => this.Cookies;
	    internal string ContentTypeInternal => this.ContentType;
	    internal string PostDataInternal => this.PostData;
	    internal bool DownloadResponseStreamInternal => this.DownloadResponseStream;
    }

}
