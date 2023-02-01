using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.DataTable;
using UnityGameFramework.Runtime;
namespace Demo5
{

    public class DRHero : IDataRow
    {
        private int m_Id = 0;
        /// <summary>
        /// ��ȡӢ�۱�š�
        /// </summary>
        public   int Id
        {
            get
            {
                return m_Id;
            }
        }
         
        public string Name { get; private set; }
        public int Atk { get; private set; }
        public   bool ParseDataRow(string dataRowText, object userData)
        {
            string[] text = dataRowText.Split('\t');

            int index = 0;
            index++; // ����#ע����
            m_Id = int.Parse(text[index++]);
            Name = text[index++];
            Atk = int.Parse(text[index++]);
            return true;
        }

        public   bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            throw new System.NotImplementedException();
        }
    }
}
