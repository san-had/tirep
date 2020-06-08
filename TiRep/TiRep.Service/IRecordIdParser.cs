using System;

namespace TiRep.Service
{
    public interface IRecordIdParser
    {
        string ParseRecordId(DateTime dateTime);
    }
}