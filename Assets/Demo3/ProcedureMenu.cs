using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Demo3
{

    public class ProcedureMenu : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("����˵����̣�������������ز˵�UI��");
            //���ؿ��UI���
            UIComponent UI = GameEntry.GetComponent<UIComponent>();
            //����UI
            UI.OpenUIForm("Assets/Demo3/UIMenu.prefab", "DefaultGroup");
            
        }
    }
}
