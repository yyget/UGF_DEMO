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
            Log.Debug("��ʼ��");
            // ��ȡ����¼����
            EventComponent Event = GameEntry.GetComponent<EventComponent>();
            // ���ļ��سɹ��¼�
            Event.Subscribe(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            // ��ȡ������ݱ����
            DataTableComponent DataTable = GameEntry.GetComponent<DataTableComponent>();
            Type dataRowType = Type.GetType("Demo5.DRHero");
            DataTableBase dataTableBase = DataTable.CreateDataTable(dataRowType);
            dataTableBase.ReadData("Assets/Demo5/Hero.txt");
        
        }
        private void OnLoadDataTableSuccess(object sender, GameEventArgs e)
        { 
            // ��ȡ������ݱ����
            DataTableComponent DataTable = GameEntry.GetComponent<DataTableComponent>();
            // ������ݱ�
            IDataTable<DRHero> dtScene = DataTable.GetDataTable<DRHero>();
            
            // ���������
            DRHero[] drHeros = dtScene.GetAllDataRows();
 
            Log.Debug("drHeros:" + drHeros.Length);
            // �����кŻ��ĳһ��
            DRHero drScene = dtScene.GetDataRow(1); // ��ֱ��ʹ�� dtScene[1]
            if (drScene != null)
            {
                // ���д��ڣ����Ի�ȡ������
                string name = drScene.Name;
                int atk = drScene.Atk;
                Log.Debug("name:" + name + ", atk:" + atk);
            }
            else
            {
                // ���в�����
            }

            // �������������������
            DRHero[] drScenesWithCondition = dtScene.GetDataRows(x => x.Id > 0);
         
            // ������������ĵ�һ��
            DRHero drSceneWithCondition = dtScene.GetDataRow(x => x.Name == "����");
            Log.Debug(drSceneWithCondition.Name);
        }
    }
}

