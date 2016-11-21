using CurrencyTrader.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurrencyTrader.AdoNet
{
    class AsynchTradeStorage : ITradeStorage
    {
        protected AsynchTradeStorage SynchTradeStorage;
        public void Persist(IEnumerable<TradeRecord> trades)
        {
            Task.Run(() => SynchTradeStorage.Persist(trades));
            
        }
    }
}
