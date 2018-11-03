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


namespace MaasOne.Search.BOSS
{
    
    public class SearchData : SearchBaseData
    {
        private Uri mClickUrl;
        public Uri ClickUrl => mClickUrl;

	    internal SearchData(string title, string @abstract, Uri url, Uri clkUrl)
            : base(title, @abstract, url)
        {
            mClickUrl = clkUrl;
        }
    }





    public class WebSearchData : SearchData
    {

        private string mDisplayUrl = string.Empty;
        private DateTime mCrawlingDate;
        private Language mLanguage = Language.en;

        private string mSMFeed = string.Empty;
        public string DisplayUrl => mDisplayUrl;

	    public DateTime CrawlingDate => mCrawlingDate;

	    public Language Language => mLanguage;

	    public string SMFeed => mSMFeed;

	    internal WebSearchData(SearchData result, string dispUrl, DateTime crwDate, Language language, string smFeed)
            : base(result.Title, result.Description, result.Url, result.ClickUrl)
        {
            mDisplayUrl = dispUrl;
            mCrawlingDate = crwDate;
            mLanguage = language;
            mSMFeed = smFeed;
        }
    }


    public class ImageSearchData : SearchData
    {

        private Uri mRefererUrl;
        private Uri mRefererClickUrl;
        private long mFileSize;
        private ImageFileType mFileFormat;
        private int mHeight;
        private int mWidth;

        private Thumbnail mThumbnail;

        public Uri RefererUrl => mRefererUrl;

	    public Uri RefererClickUrl => mRefererClickUrl;

	    public long FileSize => mFileSize;

	    public ImageFileType FileFormat => mFileFormat;

	    public int Height => mHeight;

	    public int Width => mWidth;

	    public Thumbnail Thumbnail => mThumbnail;


	    internal ImageSearchData(SearchData result, Uri refUrl, Uri refClkUrl, long fileSize, ImageFileType fileFormat, int height, int width, Uri tmbUrl, int tmbHeight, int tmbWidth)
            : base(result.Title, result.Description, result.Url, result.ClickUrl)
        {
            mRefererUrl = refUrl;
            mRefererClickUrl = refClkUrl;
            mFileSize = fileSize;
            mFileFormat = fileFormat;
            mHeight = height;
            mWidth = width;
            mThumbnail = new Thumbnail(tmbUrl, tmbHeight, tmbWidth);
        }

    }





    public class NewsSearchResult : SearchData
    {

        private DateTime mCrawlingDate;
        private Language mLanguage;
        private string mSource = string.Empty;

        private Uri mSourceUrl;
        public string Source => mSource;

	    public Uri SourceUrl => mSourceUrl;

	    public DateTime CrawlingDate => mCrawlingDate;

	    public Language Language => mLanguage;

	    internal NewsSearchResult(SearchData result, string source, Uri sourceUrl, DateTime crwDate, Language language)
            : base(result.Title, result.Description, result.Url, result.ClickUrl)
        {
            mSource = source;
            mSourceUrl = sourceUrl;
            mCrawlingDate = crwDate;
            mLanguage = language;
        }

    }





    public class SpellingSearchData : SearchData
    {

        public string Suggestion => base.Title;

	    internal SpellingSearchData(string sugg)
            : base(sugg, string.Empty, null, null)
        {
        }

    }


}
