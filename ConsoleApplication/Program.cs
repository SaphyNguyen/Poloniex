﻿using Poloniex.Api.Implementation;
using Poloniex.Core.Domain.Constants;
using Poloniex.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger.Write("Console application started");

            //// ################################################################
            //// Testing database
            //// ################################################################
            #region 
            //using (var db = new PoloniexContext())
            //{
            //    var cp = new CryptoCurrencyDataPoint
            //    {
            //        CryptoCurrencyDataPointId = Guid.NewGuid(),
            //        Currency = CurrencyConstants.BTC,
            //        ClosingDateTime = DateTime.UtcNow,
            //        ClosingValue = 0.12M,
            //        Interval = 60000
            //    };

            //    db.CryptoCurrencyDataPoints.Add(cp);

            //    db.SaveChanges();
            //}
            #endregion
            //// ################################################################
            //// Testing Poloniex API
            //// ################################################################
            #region
            //var interval = 20;

            //DateTime dateTimeNow = DateTime.UtcNow;
            //dateTimeNow = dateTimeNow.AddSeconds(-dateTimeNow.Second);
            //DateTime dateTimePast = dateTimeNow.AddMinutes(-60);

            //var result = PoloniexExchangeService.Instance.ReturnTradeHistory(CurrencyPairConstants.BTC_ETH, DateTime.UtcNow.AddMinutes(-60), DateTime.UtcNow);
            //result = result.OrderBy(x => x.date).ToList();

            //List<CryptoCurrencyDataPoint> cryptoCurrencyDataPoints = new List<CryptoCurrencyDataPoint>();

            //int curPos = 0;
            //var curRate = result.First().rate;

            //for (int i = interval; i > 0; i--)
            //{
            //    var intervalBeginningDateTime = dateTimeNow.AddMinutes(-i);
            //    var intervalEndDateTime = dateTimeNow.AddMinutes(-(i + 1));

            //    var dataPoint = new CryptoCurrencyDataPoint
            //    {
            //        CryptoCurrencyDataPointId = Guid.NewGuid(),
            //        Currency = CurrencyPairConstants.BTC_ETH,
            //        Interval = interval,
            //        ClosingDateTime = intervalEndDateTime,
            //    };

            //    bool isAnyData = false;
            //    while (result[curPos].date < intervalEndDateTime && curPos < result.Count)
            //    {
            //        isAnyData = true;
            //        curPos++;
            //    }

            //    if (isAnyData)
            //    {
            //        curRate = result[curPos].rate;
            //    }

            //    dataPoint.ClosingValue = curRate;

            //    cryptoCurrencyDataPoints.Add(dataPoint);
            //}
            #endregion
            //// ################################################################
            //// Calculate simple moving average
            //// ################################################################
            #region
            //var simpleMovingAverage = new SimpleMovingAverage
            //{
            //    SimpleMovingAverageId = Guid.NewGuid(),
            //    Currency = CurrencyPairConstants.BTC_ETH,
            //    Interval = interval,
            //    ClosingDateTime = dateTimeNow
            //};
            //simpleMovingAverage.ClosingValue = cryptoCurrencyDataPoints.Sum(x => x.ClosingValue) / interval;
            #endregion
            //// ################################################################
            //// Calculate exponential moving average
            //// ################################################################
            #region
            //var timePeriods = interval;
            //var multiplier = 2M / (timePeriods + 1M);
            //decimal ema = 0;

            //// get previous otherwise start at first;
            //var previous = cryptoCurrencyDataPoints[0].ClosingValue;
            //for (int i = 0; i < interval; i++)
            //{
            //    ema = ((cryptoCurrencyDataPoints[0].ClosingValue - previous) * multiplier) + previous;
            //    previous = ema;
            //}

            //var exponentialMovingAverage = new ExponentialMovingAverage
            //{
            //    ExponentialMovingAverageId = Guid.NewGuid(),
            //    Currency = CurrencyPairConstants.BTC_ETH,
            //    Interval = interval,
            //    ClosingDateTime = dateTimeNow,
            //    ClosingValue = ema
            //};
            #endregion
            //// ################################################################
            //// Testing thread lock
            //// ################################################################
            #region
            //System.Threading.Tasks.Task.Run(() =>
            //{
            //    var tmp1 = PoloniexExchangeService.Instance.ReturnTradeHistory(CurrencyPairConstants.BTC_ETH, DateTime.UtcNow.AddMinutes(-60), DateTime.UtcNow);
            //    Logger.Write("First thread completed");
            //});

            //System.Threading.Tasks.Task.Run(() =>
            //{
            //    var tmp = PoloniexExchangeService.Instance.ReturnTradeHistory(CurrencyPairConstants.BTC_ETH, DateTime.UtcNow.AddMinutes(-60), DateTime.UtcNow);
            //    Logger.Write("Second thread completed");
            //});

            //int stop = 0;
            #endregion
            // ################################################################
            // Testing Task data access
            // ################################################################
            #region
            //using (var db = new PoloniexContext())
            //{
            //    db.Tasks.Add(new Task()
            //    {
            //        TaskType = "GatherTask",
            //        TaskLoop = new TaskLoop()
            //        {
            //            LoopStatus = "RequestToStart",
            //            Interval = 3000,
            //        },
            //        GatherTask = new GatherTask()
            //        {
            //            CurrencyPair = CurrencyPairConstants.BTC_ETH,
            //            Interval = 30000
            //        }
            //    });

            //    db.SaveChanges();
            //}

            //TaskLoopScheduler tls = new TaskLoopScheduler();
            //tls.PollForTasksToStartOrStop();
            #endregion
            // ################################################################
            // Testing GatherTaskManager
            // ################################################################
            #region
            //GatherTaskManager.GatherTaskElapsed(null, CurrencyPairConstants.USDT_BTC, 60);

            //Logger.Write("test started.");
            //Logger.Write("syncing test tick.");
            //while (DateTime.UtcNow.Second != 0) ;
            //Logger.Write("test tick synced.");

            //var taskLoop1 = new TaskLoop()
            //{
            //    Interval = 60
            //};

            //var interval = 60;

            //var timer1 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_BTC, interval, true);
            ////var timer2 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_ETH, interval, true);
            ////var timer3 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_DASH, interval, true);
            ////var timer4 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_XRP, interval, true);
            ////var timer5 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_XMR, interval, true);
            ////var timer6 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_ETC, interval, true);
            ////var timer7 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_LTC, interval, true);
            ////var timer8 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_ZEC, interval, true);
            ////var timer9 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_REP, interval, true);
            ////var timer10 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_STR, interval, true);
            ////var timer11 = GatherTaskManager.GetGatherTaskTimer(CurrencyPairConstants.USDT_NXT, interval, true);

            //GlobalStateManager gsm = new GlobalStateManager();
            //gsm.AddTaskLoop(taskLoop1, timer1);

            ////var poloniexData = PoloniexExchangeService.Instance.ReturnTradeHistory(CurrencyPairConstants.USDT_BTC, DateTime.UtcNow.AddHours(-(6)), DateTime.UtcNow);
            ////GatherTaskManager.BackFillGatherTaskData(CurrencyPairConstants.USDT_BTC, 60, 44640);  //.GetGatherTaskTimer(CurrencyPairConstants.USDT_BTC, interval, true);

            ////var dt = DateTime.UtcNow;

            ////Console.WriteLine("Started: " + dt.ToString("yyyy-MM-dd hh:mm:ss:fff"));

            ////GatherTaskManager.BackFillGatherTaskDataForOneMonthAtMinuteIntervals(CurrencyPairConstants.USDT_BTC, dt);

            ////Console.WriteLine("Finished: " + DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss:fff"));

            ////GatherTaskManager.BackFillGatherTaskDataForOneMonthAtMinuteIntervals(CurrencyPairConstants.USDT_BTC, DateTime.Parse("2017-01-15 00:00:00.000"));
            #endregion
            // ################################################################
            // Testing MovingAverage
            // ################################################################
            #region
            //var dateFilterStart = DateTime.Parse("2017-02-22 00:00:00");
            //var dateFilterEnd = DateTime.Parse("2017-03-02 00:00:00");
            ////var dateFilter = DateTime.Parse("2017-01-01 00:00:00");

            //var bitCoinModifier = 0.0625M;
            ////var bitCoinModifier = 0.59166M;

            //List<CryptoCurrencyDataPoint> data;
            //using (var db = new PoloniexContext())
            //{
            //    data = db.CryptoCurrencyDataPoints.Where(x => x.ClosingDateTime > dateFilterStart && x.ClosingDateTime < dateFilterEnd && x.Currency == CurrencyPairConstants.USDT_BTC).OrderBy(x => x.ClosingDateTime).ToList();
            //}

            //var startTime = data.First().ClosingDateTime;
            //var endTime = data.Last().ClosingDateTime;

            //var smallInterval = 1;
            //var largeInterval = 5;
            //var initData = data.GetRange(0, largeInterval).Select(x => x.ClosingValue).ToList();

            //var smallIntervalList = initData.GetRange(largeInterval - smallInterval, smallInterval);
            //var largeIntervalList = initData;

            //data.RemoveRange(0, largeInterval);

            //var smallEma = MovingAverageManager.CalculateSma(smallIntervalList);
            //var largeEma = MovingAverageManager.CalculateSma(largeIntervalList);

            //bool isBullish = smallEma > largeEma;
            //bool wasPreviousBullish = !isBullish;

            //bool inTrade = false;
            //decimal buyPrice = 0;
            //decimal totalProfit = 0;

            //while (data.Count > 0)
            //{
            //    var closeValue = data[0].ClosingValue;
            //    data.RemoveAt(0);
            //    smallEma = MovingAverageManager.CalculateEma(closeValue, smallEma, smallInterval);
            //    largeEma = MovingAverageManager.CalculateEma(closeValue, largeEma, largeInterval);
            //    wasPreviousBullish = isBullish;
            //    isBullish = smallEma > largeEma;
            //    //Console.WriteLine($"closeValue: {closeValue}");
            //    //Console.WriteLine($"smallEma: {smallEma}");
            //    //Console.WriteLine($"largeEma: {largeEma}");
            //    //Console.WriteLine($"isBullish: {isBullish}");
            //    if (isBullish)
            //    {
            //        //Console.WriteLine($"################################################################");
            //        if (!wasPreviousBullish)
            //        {
            //            inTrade = true;
            //            buyPrice = closeValue * bitCoinModifier - (closeValue * bitCoinModifier * 0.00025M + 0.00098307M * closeValue);
            //        }
            //    }
            //    else
            //    {
            //        if (wasPreviousBullish)
            //        {
            //            if (inTrade)
            //            {
            //                inTrade = false;
            //                totalProfit += buyPrice - (closeValue * bitCoinModifier - (closeValue * bitCoinModifier * 0.00025M + 0.00098307M * closeValue));
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"################################################################");
            //Console.WriteLine($"################################################################");
            //Console.WriteLine($"Start Time: {startTime}");
            //Console.WriteLine($"Estimated Profit: {totalProfit}");
            //Console.WriteLine($"End Time: {endTime}");
            //Console.WriteLine($"################################################################");
            //Console.WriteLine($"################################################################");
            #endregion
            // ################################################################
            // Testing Trade
            // ################################################################
            #region
            //Dictionary<string, decimal> balances = PoloniexExchangeService.Instance.ReturnBalances();
            //var usdtBalance = balances[CurrencyConstants.USDT];
            //var btcBalance = balances[CurrencyConstants.BTC];

            //Dictionary<string, Dictionary<string, decimal>> res = PoloniexExchangeService.Instance.ReturnTicker();
            //var latestUsdtBtcTicker = res[CurrencyPairConstants.USDT_BTC];
            //var usdtBtcLowestAsk = latestUsdtBtcTicker[TickerResultKeys.LowestAsk];
            //var usdtBtcHighestBid = latestUsdtBtcTicker[TickerResultKeys.HighestBid];

            //// BUY
            //decimal buyRequestPrice = (0.00M * usdtBtcLowestAsk) + (0.75M * usdtBtcHighestBid);
            //var buyRate = buyRequestPrice;
            //decimal buyAmount = usdtBalance / buyRate;
            //var buyResult = PoloniexExchangeService.Instance.Buy(CurrencyPairConstants.USDT_BTC, buyRate, buyAmount, false, false, false);

            // SELL
            //decimal sellRequestPrice = (1.25M * usdtBtcLowestAsk) + (0.00M * usdtBtcHighestBid);
            //var sellRate = sellRequestPrice;
            //decimal sellAmount = btcBalance / sellRate;
            //var sellResult = PoloniexExchangeService.Instance.Sell(CurrencyPairConstants.USDT_BTC, sellRate, sellAmount, false, true, false);

            //int stop = 0;
            #endregion
            // ################################################################
            // ################################################################
            // ################################################################

            //List<Dictionary<string, string>> openOrders = PoloniexExchangeService.Instance.ReturnOpenOrders("USDT_BTC");
            //var findPreviousOrder = openOrders.SingleOrDefault(x => x[OpenOrderKeys.OrderNumber] == (buyResult.orderNumber).ToString());

            //int stop = 0;

            //TradeManager.BuyBtcFromUsdt();
            TradeManager.SellBtcToUsdt();

            Console.ReadLine();
        }
    }
}
