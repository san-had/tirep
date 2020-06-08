using System;

namespace TiRep.Extensibility
{
    public interface IDateTimeProvider
    {
        DateTime GetCurrentDateTime();
    }
}