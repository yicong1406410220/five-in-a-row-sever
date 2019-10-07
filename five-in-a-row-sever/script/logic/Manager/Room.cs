using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Room
{
    public int id = 0;

    public Dictionary<string, Player> players = new Dictionary<string, Player>();

    /// <summary>
    /// 房间状态
    /// </summary>
    public ROOM_STATE room_state = ROOM_STATE.ROOM_WAIT;

    /// <summary>
    /// 倒计时
    /// </summary>
    public int countDown = 30;
    public int StepNumber = 0;
    public QiZhiDetail[,] QiZhiDetails = new QiZhiDetail[15, 15];

    //房间是否已满
    public bool IsFull()
    {
        if (players.Count >= 2)
        {
            return true;
        }
        return false;
    }

    //添加玩家
    public void AddPlayer(string id, Player player)
    {
        if (!IsFull())
        {
            players.Add(id, player);
        }
    }
    //删除玩家
    public void RemovePlayer(string id)
    {
        players.Remove(id);
    }

    //给房间里所有玩家发消息
    public void Send(MsgBase msgBase)
    {
        foreach (var item in players.Values)
        {
            item.Send(msgBase);
        }
    }

}

public enum ROOM_STATE
{
    //用户状态
    ROOM_NULL,      //没有状态
    ROOM_WAIT,      //等待准备
    ROOM_PLAYING,   //游戏状态
}

public class QiZhiDetail
{
    public QiZhiStatus qiZhiStatus = QiZhiStatus.Null;
    public int StepNumber = 0;
}

public enum QiZhiStatus
{
    Null,
    Hei,
    Bai
}
