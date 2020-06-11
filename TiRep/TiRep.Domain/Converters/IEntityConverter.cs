namespace TiRep.Domain.Converters
{
    public interface IEntityConverter<in TSource, out TTarget>
    {
        TTarget Convert(TSource source);
    }
}