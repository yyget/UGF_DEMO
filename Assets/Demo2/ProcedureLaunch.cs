using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Demo2
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("��ʼ��");
            SceneComponent scene  = GameEntry.GetComponent<SceneComponent>();
            // �л�����
            scene.LoadScene("Assets/Demo2/Demo2Menu.unity", this);

            // �л�����
            ChangeState<ProcedureMenu>(procedureOwner);
        }
    }
}

