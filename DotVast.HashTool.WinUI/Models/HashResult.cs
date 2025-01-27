using DotVast.HashTool.WinUI.Enums;

namespace DotVast.HashTool.WinUI.Models;

public sealed class HashResult
{
    /// <summary>
    /// 哈希结果的计算类型.
    /// </summary>
    public HashResultType? Type { get; set; }

    /// <summary>
    /// 哈希结果的计算内容.
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 哈希结果.
    /// </summary>
    public IList<HashResultItem>? Data { get; set; }
}

public sealed record HashResultItem(string Name, string Hash);
