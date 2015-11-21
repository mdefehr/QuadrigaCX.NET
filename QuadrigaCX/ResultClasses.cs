using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrigaCX
{
    public class CurrentTradingInformation
    {
        public decimal high { get; set; }
        public decimal last { get; set; }
        public DateTime timestamp { get; set; }
        public decimal volume { get; set; }
        public decimal vwap { get; set; }
        public decimal low { get; set; }
        public decimal ask { get; set; }
        public decimal bid { get; set; }

        public static CurrentTradingInformation GetFromJson(dynamic APICallResult, bool localTime)
        {
            return new CurrentTradingInformation
            {
                high = APICallResult.high,
                last = APICallResult.last,
                timestamp = Helpers.UnixTimeStampToDateTime(Convert.ToDouble(APICallResult.timestamp), localTime),
                volume = APICallResult.volume,
                vwap = APICallResult.vwap,
                low = APICallResult.low,
                ask = APICallResult.ask,
                bid = APICallResult.bid
            };
        }
    }

    public class OrderBookEntry
    {
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
    }
    public class OrderBook
    {
        public DateTime timestamp { get; set; }
        public List<OrderBookEntry> bids { get; set; }
        public List<OrderBookEntry> asks { get; set; }

        public static OrderBook GetFromJson(dynamic APICallResult, bool localTime)
        {
            OrderBook ob = new OrderBook();
            ob.timestamp = Helpers.UnixTimeStampToDateTime(Convert.ToDouble(APICallResult.timestamp), localTime);
            ob.bids = new List<OrderBookEntry>();
            foreach (dynamic bid in APICallResult.bids)
            {
                ob.bids.Add(new OrderBookEntry{Amount = bid[1], Price = bid[0]});
            }
            ob.asks = new List<OrderBookEntry>();
            foreach (dynamic ask in APICallResult.asks)
            {
                ob.asks.Add(new OrderBookEntry { Amount = ask[1], Price = ask[0] });
            }
            return ob;
        }
    }

    public class Transaction
    {
        public decimal amount { get; set; }
        public DateTime date { get; set; }
        public decimal price { get; set; }
        public int tid { get; set; }
        public string side { get; set; }

        public static Transaction GetFromJson(dynamic APICallResult, bool localTime)
        {
            return new Transaction
            {
                amount = APICallResult.amount,
                date = Helpers.UnixTimeStampToDateTime(Convert.ToDouble(APICallResult.date), localTime),
                price = APICallResult.price,
                tid = APICallResult.tid,
                side = APICallResult.side
            };
        }
    }

    public class AccountBalance
    {
        public decimal btc_available { get; set; }
        public decimal btc_reserved { get; set; }
        public decimal btc_balance { get; set; }
        public decimal cad_available { get; set; }
        public decimal cad_reserved { get; set; }
        public decimal cad_balance { get; set; }
        public decimal usd_available { get; set; }
        public decimal usd_reserved { get; set; }
        public decimal usd_balance { get; set; }
        public decimal xau_available { get; set; }
        public decimal xau_reserved { get; set; }
        public decimal xau_balance { get; set; }
        public decimal fee { get; set; }

        public static AccountBalance GetFromJson(dynamic APICallResult)
        {
            return new AccountBalance
            {
                btc_available = APICallResult.btc_available,
                btc_reserved = APICallResult.btc_reserved,
                btc_balance = APICallResult.btc_balance,
                cad_available = APICallResult.cad_available,
                cad_reserved = APICallResult.cad_reserved,
                cad_balance = APICallResult.cad_balance,
                usd_available = APICallResult.usd_available,
                usd_reserved = APICallResult.usd_reserved,
                usd_balance = APICallResult.usd_balance,
                xau_available = APICallResult.xau_available,
                xau_reserved = APICallResult.xau_reserved,
                xau_balance = APICallResult.xau_balance,
                fee = APICallResult.fee 
            };
        }
    }

    public enum UserTransactionType
    {
        Deposit=0, Withdrawal=1, MarketTrade=2
    }
    public class UserTransaction
    {
        public decimal? cad { get; set; }
        public decimal? btc { get; set; }
        public DateTime datetime { get; set; }
        public decimal? fee { get; set; }
        public int? id { get; set; }
        public string order_id { get; set; }
        public decimal? rate { get; set; }
        public UserTransactionType type { get; set; }

        public static UserTransaction GetFromJson(dynamic APICallResult)
        {
            return new UserTransaction
            {
                cad = APICallResult.cad,
                btc = APICallResult.btc,
                datetime = DateTime.Parse(APICallResult.datetime.ToString()),
                fee = APICallResult.fee,
                id = APICallResult.id,
                order_id = APICallResult.order_id,
                rate = APICallResult.rate,
                type = APICallResult.type
            };
        }
    }

    public enum OpenOrderStatus
    {
        Cancelled = -1, Active=0, PartiallyFilled=1, Complete=2
    }
    public enum OpenOrderType
    {
        Buy=0,Sell=1
    }
    public class OpenOrder
    {
        public decimal amount { get; set; }
        public DateTime created { get; set; }
        public string id { get; set; }
        public decimal price { get; set; }
        public OpenOrderStatus status { get; set; }
        public OpenOrderType type { get; set; }
        public string book { get; set; }
        public DateTime updated { get; set; }

        public static OpenOrder GetFromJson(dynamic APICallResult, string book)
        {
            OpenOrder o = new OpenOrder
            {
                amount = APICallResult.amount,
                id = APICallResult.id,
                price = APICallResult.price,
                status = APICallResult.status,
                type = APICallResult.type,
                book = book
            };
            try { o.updated = DateTime.Parse(APICallResult.updated.ToString()); }
            catch (Exception) {}
            try { o.created = DateTime.Parse(APICallResult.datetime.ToString()); }
            catch (Exception) { }
            try { o.created = DateTime.Parse(APICallResult.created.ToString()); }
            catch (Exception) { }
            return o;
        }
    }
}
