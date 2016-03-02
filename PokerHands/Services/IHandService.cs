using System;
using System.Collections;

namespace PokerHands.Core
{
    /// <summary>
    /// Interface for all hand providing services
    /// </summary>
    public interface IHandService
    {
        IEnumerable GetHands();
    }
}

