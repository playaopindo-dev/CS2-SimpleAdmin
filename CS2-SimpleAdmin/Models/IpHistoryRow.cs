namespace CS2_SimpleAdmin.Models;

public sealed class IpHistoryRow
{
    public IpHistoryRow(long steamid, string? name, long address, DateTime used_at)
    {
        Steamid = Convert.ToUInt64(steamid);
        Name = name;
        Address = Convert.ToUInt32(address);
        Used_at = used_at;
    }

    public ulong Steamid { get; }
    public string? Name { get; }
    public uint Address { get; }
    public DateTime Used_at { get; }
}
