using GameFramework;
using GameFramework.Event;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Demo4
{

    public class ProcedureMenu : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("����˵�����");
            // ���ؿ��Event���
            EventComponent Event = GameEntry.GetComponent<EventComponent>();
            // ����UI���سɹ��¼�
            Event.Subscribe(OpenUIFormSuccessEventArgs.EventId,OnOpenUIFormSuccess);
            
            //���ؿ��UI���
            UIComponent UI = GameEntry.GetComponent<UIComponent>();
            //����UI
            UI.OpenUIForm("Assets/Demo4/UIMenu.prefab", "DefaultGroup",this);
            
        }
        private void OnOpenUIFormSuccess(object sender, GameEventArgs e)
        {
            OpenUIFormSuccessEventArgs ne = (OpenUIFormSuccessEventArgs)e;
            // �ж�userData�Ƿ�Ϊ�Լ�
            if (ne.UserData != this)
            {
                return;
            }
            Log.Debug("UI_Menu����ϲ�㣬�ɹ����ٻ����ҡ�");
        }
    }
}
