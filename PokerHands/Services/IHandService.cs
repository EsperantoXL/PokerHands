using System;
using System.Collections;
using System.Collections.Generic;

namespace PokerHands.Core
{
    /// <summary>
    /// Interface for all hand providing services
    /// </summary>
    public interface IHandService
    {
        IEnumerable<Hand> GetHands();
    }
}

