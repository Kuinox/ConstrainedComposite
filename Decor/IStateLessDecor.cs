using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{
    public interface IStateLessDecor<TDecorated, TSelf> where TSelf : IStateLessDecor<TDecorated, TSelf>
    {
        /// <summary>
        /// Build the decorator for <paramref name="decorated"/>. A return value indicate wether the decorator could be built or not.
        /// </summary>
        /// <param name="decorated">The object to decorate.</param>
        /// <param name="decorator">The decorator, not <see langword="null"/> when this method return <see langword="true"/>.</param>
        /// <returns><see langword="true"/> if the decorator has been built, <see langword="false"/> otherwise.</returns>
        static abstract bool IsValid(TDecorated decorated);
    }
}