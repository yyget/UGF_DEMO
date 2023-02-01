using GameFramework;
using GameFramework.DataTable;
using GameFramework.Event;
using GameFramework.Procedure;
using System;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Demo6
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("��ʼ��");
         
            base.OnEnter(procedureOwner);
            // ��ȡ���ʵ�����
            EntityComponent entityComponent  =  GameEntry.GetComponent<EntityComponent>();    
            // ����ʵ��
            entityComponent.ShowEntity<HeroLogic>(1, "Assets/Demo6/HeroEntity.prefab", "HeroGroup");

        }
      
    }
}

