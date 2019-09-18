using System;

namespace DinerMerger
{
    public interface IIterator {
        bool HasNext();
        Object Next();
    }
}
