using Microsoft.JSInterop;
using System.Text;
namespace QLCongViec
{
    public enum AcceptStatus
    {
        ChuaGui = 0,
        DaGui = 1,
        DaXacNhan = 2,
        TuChoiXacNhan = 3,
    }

    public enum HistoryAction
    {
        DaXoa = -1,
        DaTao = 0,
        DaGui = 1,
        DaXacNhan = 2,
        TuChoiXacNhan = 3,

    }
    public class TypeDrop
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}