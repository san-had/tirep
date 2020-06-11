namespace TiRep.Service
{
    public interface IServiceConverter<in TSource, out TTarget>
    {
        TTarget Convert(TSource source);
    }
}