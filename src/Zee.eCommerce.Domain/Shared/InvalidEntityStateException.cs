namespace Zee.eCommerce.Domain.Shared;
public class InvalidEntityStateException : Exception
{
    public InvalidEntityStateException(object entity, string message)
    : base($"{entity.GetType().Name} 資料變更被拒絕, {message}")
    {
    }
}