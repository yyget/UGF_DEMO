using GameFramework;
using GameFramework.DataTable;
using GameFramework.Event;
using GameFramework.Procedure;
using System;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Demo5
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("初始！");
            // 获取框架事件组件
            EventComponent Event = GameEntry.GetComponent<EventComponent>();
            // 订阅加载成功事件
            Event.Subscribe(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            // 获取框架数据表组件
            DataTableComponent DataTable = GameEntry.GetComponent<DataTableComponent>();
            Type dataRowType = Type.GetType("Demo5.DRHero");
            DataTableBase dataTableBase = DataTable.CreateDataTable(dataRowType);
            dataTableBase.ReadData("Assets/Demo5/Hero.txt");
        
        }
        private void OnLoadDataTableSuccess(object sender, GameEventArgs e)
        { 
            // 获取框架数据表组件
            DataTableComponent DataTable = GameEntry.GetComponent<DataTableComponent>();
            // 获得数据表
            IDataTable<DRHero> dtScene = DataTable.GetDataTable<DRHero>();
            
            // 获得所有行
            DRHero[] drHeros = dtScene.GetAllDataRows();
 
            Log.Debug("drHeros:" + drHeros.Length);
            // 根据行号获得某一行
            DRHero drScene = dtScene.GetDataRow(1); // 或直接使用 dtScene[1]
            if (drScene != null)
            {
                // 此行存在，可以获取内容了
                string name = drScene.Name;
                int atk = drScene.Atk;
                Log.Debug("name:" + name + ", atk:" + atk);
            }
            else
            {
                // 此行不存在
            }

            // 获得满足条件的所有行
            DRHero[] drScenesWithCondition = dtScene.GetDataRows(x => x.Id > 0);
         
            // 获得满足条件的第一行
            DRHero drSceneWithCondition = dtScene.GetDataRow(x => x.Name == "三笠");
            Log.Debug(drSceneWithCondition.Name);
        }
    }
}

