using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RoomManager
{
    //玩家列表
    static Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    //房间是否在线
    public static bool IsOnline(string id)
    {
        return rooms.ContainsKey(id);
    }
    //获取房间
    public static Room GetRoom(string id)
    {
        return rooms[id];
    }
    //创建房间
    public static void AddRoom(string id, Room room)
    {
        rooms.Add(id, room);
    }
    //删除房间
    public static void RemoveRoom(string id)
    {
        rooms.Remove(id);
    }
    //给房间里所有玩家发消息
    public static void Send(MsgBase msgBase)
    {
        foreach (var item in rooms.Values)
        {
            item.Send(msgBase);
        }
    }
}
