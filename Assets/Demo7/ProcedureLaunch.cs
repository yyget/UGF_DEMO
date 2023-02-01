using GameFramework;
using GameFramework.DataTable;
using GameFramework.Event;
using GameFramework.Procedure;
using System;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Demo7
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("��ʼ��");
            // ��ȡ����¼����
            EventComponent Event  =  GameEntry.GetComponent<EventComponent>();
            Event.Subscribe(WebRequestSuccessEventArgs.EventId, OnWebRequestSuccess);
            Event.Subscribe(WebRequestFailureEventArgs.EventId, OnWebRequestFailure);

            // ��ȡ����������
            WebRequestComponent WebRequest  = GameEntry.GetComponent<WebRequestComponent>();
            string url = "https://www.boy3d.com/zb_users/upload/demo7.txt";
            WebRequest.AddWebRequest(url, this);


        }
        private void OnWebRequestSuccess(object sender, GameEventArgs e)
        {
            WebRequestSuccessEventArgs ne = (WebRequestSuccessEventArgs)e;
            // ��ȡ��Ӧ������
            string responseJson = Utility.Converter.GetString(ne.GetWebResponseBytes());
            Log.Debug("responseJson��" + responseJson);
        }
        private void OnWebRequestFailure(object sender, GameEventArgs e)
        {
            Log.Warning("����ʧ��");
        }

    }
}

