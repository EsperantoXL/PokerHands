using System;

namespace PokerHands.Core
{
    /// <summary>
    /// Hand service provides a collection of hands
    /// </summary>
    public class HandService : IHandService
    {
        public HandService()
        {
        }

        #region IHandService implementation

        public System.Collections.IEnumerable GetHands()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

