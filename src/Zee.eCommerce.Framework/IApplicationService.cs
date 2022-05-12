namespace Zee.eCommerce.Framework;


/// <summary>
/// 定義 Application Service 泛型函式
/// </summary>
public interface IApplicationService
{
    Task Handle(object command);
}