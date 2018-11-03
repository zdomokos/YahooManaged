// ******************************************************************************
// ** 
// **  Yahoo! Managed
// **  Written by Marius H�usler 2012
// **  It would be pleasant, if you contact me when you are using this code.
// **  Contact: YahooFinanceManaged@gmail.com
// **  Project Home: http://code.google.com/p/yahoo-finance-managed/
// **  
// ******************************************************************************
// **  
// **  Copyright 2012 Marius H�usler
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

using MaasOne.Finance.YahooFinance;


namespace MaasOne.Finance.YahooScreener.Criterias
{

	/// <summary>
	/// Criteria class for free cash flow
	/// </summary>
	/// <remarks></remarks>
	public class FreeCashFlowCriteria : StockDigitCriteriaDefinition
	{

		public override string DisplayName => "Free Cash Flow Criteria";

		public override string CriteriaName => "Free Cash Flow";

		public override StockScreenerCriteriaGroup CriteriaGroup => StockScreenerCriteriaGroup.CashFlow;

		public override QuoteProperty[] ProvidedQuoteProperties => new  QuoteProperty[] {QuoteProperty.Symbol,QuoteProperty.Name,QuoteProperty.LastTradePriceOnly,QuoteProperty.LastTradeTime,QuoteProperty.MarketCapitalization};

		public override StockScreenerProperty[] ProvidedScreenerProperties => new  StockScreenerProperty[] {StockScreenerProperty.ReturnOnEquity,StockScreenerProperty.ReturnOnAssets,StockScreenerProperty.ForwardPriceToEarningsRatio,StockScreenerProperty.FreeCashFlow};

		public FreeCashFlowCriteria() : base("8y")
		{
		}
	}

	/// <summary>
	/// Criteria class for operating cash flow
	/// </summary>
	/// <remarks></remarks>
	public class OperatingCashFlowCriteria : StockDigitCriteriaDefinition
	{

		public override string DisplayName => "Operating Cash Flow Criteria";

		public override string CriteriaName => "Operating Cash Flow";

		public override StockScreenerCriteriaGroup CriteriaGroup => StockScreenerCriteriaGroup.CashFlow;

		public override QuoteProperty[] ProvidedQuoteProperties => new  QuoteProperty[] {QuoteProperty.Symbol,QuoteProperty.Name,QuoteProperty.LastTradePriceOnly,QuoteProperty.LastTradeTime,QuoteProperty.MarketCapitalization};

		public override StockScreenerProperty[] ProvidedScreenerProperties => new  StockScreenerProperty[] {StockScreenerProperty.ReturnOnEquity,StockScreenerProperty.ReturnOnAssets,StockScreenerProperty.ForwardPriceToEarningsRatio,StockScreenerProperty.OperatingCashFlow};

		public OperatingCashFlowCriteria() : base("8z")
		{
		}
	}

}
