using System.Collections.Generic;

namespace Nasfaq.JSON
{
    public class WSCoinHistoryUpdate: IWebsocketData
    {
        public Dictionary<string, WSCoinPriceUpdate> data { get; set; }
    }
}