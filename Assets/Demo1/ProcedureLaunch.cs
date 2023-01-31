using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class ProcedureLaunch : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);

        string welcomeMessage = Utility.Text.Format("Hello! This is an empty project based on Game Framework {0}.", Version.GameFrameworkVersion);
        // ��ӡ���Լ�����־�����ڼ�¼��������־��Ϣ
        Log.Debug(welcomeMessage);

        // ��ӡ��Ϣ������־�����ڼ�¼��������������־��Ϣ
        Log.Info(welcomeMessage);

        // ��ӡ���漶����־�������ڷ����ֲ������߼����󣬵��в��ᵼ����Ϸ�������쳣ʱʹ��
        Log.Warning(welcomeMessage);

        // ��ӡ���󼶱���־�������ڷ��������߼����󣬵��в��ᵼ����Ϸ�������쳣ʱʹ��
        Log.Error(welcomeMessage);

        // ��ӡ���ش��󼶱���־�������ڷ������ش��󣬿��ܵ�����Ϸ�������쳣ʱʹ�ã���ʱӦ�����������̻��ؽ���Ϸ���
        Log.Fatal(welcomeMessage);
    }
}
