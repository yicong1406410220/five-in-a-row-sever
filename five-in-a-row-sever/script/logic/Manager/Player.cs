using System;

public class Player {
	//id
	public string id = "";
	//指向ClientState
	public ClientState state;
	//构造函数
	public Player(ClientState state){
		this.state = state;
	}

    //临时数据
    USER_STATE user_state = USER_STATE.US_NULL;

    //数据库数据
    public PlayerData data;

	//发送信息
	public void Send(MsgBase msgBase){
		NetManager.Send(state, msgBase);
	}

}

public enum USER_STATE
{
    //用户状态
    US_NULL,      //没有状态
    US_FREE,      //站立状态
    US_SIT,      //坐下状态
    US_READY,     //准备状态
    US_LOOKON,    //旁观状态
    US_PLAYING,   //游戏状态
    US_OFFLINE,   //断线状态
    US_WAIT      //等待准备
}




