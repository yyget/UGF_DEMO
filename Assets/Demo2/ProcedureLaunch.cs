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
            Log.Debug("初始！");
            SceneComponent scene  = GameEntry.GetComponent<SceneComponent>();
            // 切换场景
            scene.LoadScene("Assets/Demo2/Demo2Menu.unity", this);

            // 切换流程
            ChangeState<ProcedureMenu>(procedureOwner);
        }
    }
}

