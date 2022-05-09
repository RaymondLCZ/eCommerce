
namespace Zee.eCommerce.Domain.Shared;

public enum EntityState
{
    /// <summary>草稿</summary>
    Draft,

    /// <summary>待審核</summary>
    PendingReview,

    /// <summary>退回</summary>
    Reject,

    /// <summary>啟用</summary>
    Active,

    /// <summary>封存</summary>
    Archive

}