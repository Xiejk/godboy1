using System.ComponentModel;

namespace GodBoy.CL.Order.Enum
{
    /// <summary>
    /// 交通
    /// </summary>
    public enum Traffic:byte
    {
        [Description("火车")]
        Train = 1,
        [Description("大巴")]
        Bus = 2,
        [Description("飞机")]
        Flight = 3,
        [Description("轮船")]
        Other = 4,
        [Description("徒步")]
        OnFoot = 5
    }
	//this is a Comment;
}