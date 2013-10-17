using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.IO;

namespace ConnPostSQL
{
    public class DB
    {
        private string m_dbName;
        private string m_dbPath;
        private string m_dbPwd;
        private string m_dbServer;
        private string m_dbServiceName;
        private string m_dbSID;
        private string m_dbUser;
        private string m_dbPort;
        private string m_connectString;
        private NpgsqlConnection m_pDbConnection;

        #region ���Զ�����
        public string DBName
        {
            set { m_dbName = value; }
            get { return m_dbName; }
        }

        public string DBPath
        {
            set { m_dbPath = value; }
            get { return m_dbPath; }
        }

        public string DBPwd
        {
            set { m_dbPwd = value; }
            get { return m_dbPwd; }
        }

        public string DBServer
        {
            set { m_dbServer = value; }
            get { return m_dbServer; }
        }

        public string DBServiceName
        {
            set { m_dbServiceName = value; }
            get { return m_dbServiceName; }
        }

        public string DBSID
        {
            set { m_dbSID = value; }
            get { return m_dbSID; }
        }

        public string DBUser
        {
            set { m_dbUser = value; }
            get { return m_dbUser; }
        }

        public string DBPort
        {
            set { m_dbPort = value; }
            get { return m_dbPort; }
        }

        public string ConnectString
        {
            set { m_connectString = value; }
            get { return m_connectString; }
        }

        public NpgsqlConnection DbConnection
        {
            get { return m_pDbConnection; }
        }
        #endregion

        /// <summary>
        /// ���������ݿ�
        /// </summary>
        /// <returns></returns>
        public bool Connection()
        {
            try
            {
                //�����������ݵ������ַ�������Ҫ����������Դ���û��������룬��ȫ�Բ���
                m_connectString = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    m_dbServer, m_dbPort, m_dbUser,
                    m_dbPwd, m_dbSID);
                //����һ���µ����ݿ�����
                m_pDbConnection = new NpgsqlConnection(m_connectString);
                //ʹ��open�����������ݿ�
                m_pDbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }

            return true;
        }

        public void DisConnect()
        { 
            try
            {
                m_pDbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        /// <summary>
        /// �ж��Ƿ������ӵ����ݿ�
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            try
            {
                if (m_pDbConnection == null)
                    return false;

                if (m_pDbConnection.State == ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// ������ѯ
        /// </summary>
        /// <param name="sQuery"></param>
        /// <returns></returns>
        public DataTable DoQueryEx(string sQuery)
        {
            DataTable dt = null;//�������ݱ���������Ϊ��
            try
            {
                dt = new DataTable();
                //����oracle���������������ڲ�ѯ���޸ġ�ɾ������
                NpgsqlDataAdapter nda = new NpgsqlDataAdapter(sQuery, m_pDbConnection);
                //fill���Բ���Ϊdataset��datatable
                nda.Fill(dt);
                //�ͷ�ndaʹ�õķ��й�����Դ
                nda.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }
        
        public void InsertRow(string sqlstr)
        {
            try
            {
                NpgsqlCommand oComm =new NpgsqlCommand();
                oComm.CommandType = CommandType.Text;
                oComm.CommandText = sqlstr;
				oComm.Connection=m_pDbConnection;

                int affected = oComm.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        /* /// <summary>
        /// ������ֶ���
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <param name="imgByte"></param>
        public void InsertRowWithBlobField(string sql, string paraName, Byte[] imgByte)
        {
            try
            {
                OracleConnection oConn = m_pDbConnection as OracleConnection;
                //OracleTransaction��ʾҪ�����ݿ������ɵ�����,BeginTransaction������ʾҪ�����ݿ⿪ʼһ������
                OracleTransaction transaction = oConn.BeginTransaction();
                OracleCommand oComm = oConn.CreateCommand();
                oComm.Transaction = transaction;

                oComm.CommandText = "declare xx blob; " + 
                    "begin dbms_lob.createtemporary(xx, false, 0); " + 
                    ":tempblob := xx; " + 
                    "end;";
                OracleParameter param = new OracleParameter("tempblob", OracleType.Blob);
                param.Direction = ParameterDirection.Output;
                oComm.Parameters.Add(param);
                oComm.ExecuteNonQuery();

                OracleLob tempLob = (OracleLob)oComm.Parameters[0].Value;
                tempLob.BeginBatch(OracleLobOpenMode.ReadWrite);
                tempLob.Write(imgByte, 0, imgByte.Length);
                tempLob.EndBatch();

                oComm.Parameters.Clear();

                oComm.CommandText = sql;
                oComm.Parameters.Add(paraName, OracleType.Blob);
                oComm.Parameters[0].Value = tempLob;

                oComm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                //GUIUtil.ShowMsgDialogOK(ex.ToString());
            }
        } */

        /// <summary>
        /// ɾ����
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int DeleteRow(string sqlstr)
        { 
            try
            {
                NpgsqlCommand oComm =new NpgsqlCommand();
                oComm.CommandType = CommandType.Text;
                oComm.CommandText = sqlstr;
				oComm.Connection=m_pDbConnection;
				
				int affected = oComm.ExecuteNonQuery();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return 0;
            }
        }
		
		/// <summary>
        /// ɾ����
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int DeleteTable(string tablename)
        { 
            try
            {
				string sqlstr = "drop table " + tablename +" "+"cascade";
                NpgsqlCommand oComm =new NpgsqlCommand();
                oComm.CommandType = CommandType.Text;
                oComm.CommandText = sqlstr;
				oComm.Connection=m_pDbConnection;
				
				int affected = oComm.ExecuteNonQuery();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return 0;
            }
        }

        /// <summary>
        /// ִ�зǲ�ѯ����
        /// </summary>
        /// <param name="sqlstr"></param>
        public void ExecNonQuery(string sqlstr)
        {
            try
            {
                NpgsqlCommand oComm = new NpgsqlCommand();
                //�ȴ�ִ�н��ʱ��û������
                oComm.CommandTimeout = 0;
                oComm.CommandType = CommandType.Text;
                oComm.CommandText = sqlstr;
                oComm.Connection = m_pDbConnection;

                int affected = oComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return;
            }
        }

        /* public int UpdateRow(string table, string set, string filter)
        {
            string sql = "update " + table + " set " +
                set + " where " + filter;
            OracleConnection oconn = m_pDbConnection as OracleConnection;
            OracleCommand ocomm = oconn.CreateCommand();
            ocomm.CommandType = CommandType.Text;
            ocomm.CommandText = sql;

            int rowAffected = ocomm.ExecuteNonQuery();
            return rowAffected;
        } */

        public int UpdateRow(string sqlstr)
        {
            try
            {
                NpgsqlCommand oComm =new NpgsqlCommand();
                oComm.CommandType = CommandType.Text;
                oComm.CommandText = sqlstr;
				oComm.Connection=m_pDbConnection;
				
				int affected = oComm.ExecuteNonQuery();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return 0;
            }
        }

        /// <summary>
        /// �����Ƿ����
        /// </summary>
        /// <param name="layername">������</param>
        /// <returns></returns>
        public bool IsExist(string layername)
        {
            string sqlstr = "select count(*) from pg_class where relname ='" + layername + "'";
            DataTable tmpdt = new DataTable();
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(sqlstr, m_pDbConnection);
            nda.Fill(tmpdt);
            string tmpCount = tmpdt.Rows[0][0].ToString();
            int num = Convert.ToInt32(tmpCount);
            nda.Dispose();
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ������ĳһ���Ƿ����
        /// </summary>
        /// <param name="tablename">������</param>
        /// <param name="columnname">������</param>
        /// <returns></returns>
        public bool IsColumnExist(string tablename, string columnname)
        {
            string sqlstr = "SELECT a.attname,pg_catalog.format_type(a.atttypid, a.atttypmod) AS data_type" + " "
                                + "FROM    pg_catalog.pg_attribute a,(SELECT  c.oid FROM    pg_catalog.pg_class c " + " "
                                + "LEFT JOIN pg_catalog.pg_namespace n  ON n.oid = c.relnamespace  WHERE (c.relname) =lower(' " + tablename + "')" + " "
                                + "AND (n.nspname) = lower('public')) b WHERE a.attrelid = b.oid AND a.attnum > 0 AND NOT a.attisdropped ORDER BY a.attnum";
            DataTable tmpdt = new DataTable();
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(sqlstr, m_pDbConnection);
            nda.Fill(tmpdt);
            for (int i = 0; i <= tmpdt.Rows.Count - 1; i++)
            {
                string column = tmpdt.Rows[i][0].ToString();
                if (column.ToLower() == columnname.ToLower())
                {
                    nda.Dispose();
                    return true;
                }
            }
            nda.Dispose();
            return false;
        }

        /// <summary>
        /// �����������Ƿ����
        /// </summary>
        /// <param name="tablename">������</param>
        /// <param name="indexname">��������</param>
        /// <returns></returns>
        public bool IsIndexExist(string tablename, string indexname)
        {
            string sqlstr = "SELECT * from pg_indexes where tablename= '" + tablename + "'";
            DataTable tmpdt = new DataTable();
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(sqlstr, m_pDbConnection);
            nda.Fill(tmpdt);
            for (int i = 0; i <= tmpdt.Rows.Count - 1; i++)
            {
                //��������index name
                string tmpnamestr = tmpdt.Rows[i][2].ToString();
                if (tmpnamestr.ToLower() == indexname.ToLower())
                {
                    nda.Dispose();
                    return true;
                }
            }
            nda.Dispose();
            return false;
        }

        /// <summary>
        /// �����Ƿ���ڣ�����������򴴽�
        /// </summary>
        /// <param name="tablename">������</param>
        /// <param name="sqlstr">�������</param>
        public void CheckCreateTable(string tablename, string sqlstr)
        {
            if (IsExist(tablename))
            {
                //��ɾ��ԭ�б��ٴ����±�
                string deletesql = "drop table " + tablename + " " + "cascade";
                NpgsqlCommand oComm = new NpgsqlCommand();
                oComm.CommandType = CommandType.Text;
                oComm.CommandText = deletesql;
                oComm.Connection = m_pDbConnection;
                int affected = oComm.ExecuteNonQuery();

                oComm.CommandText = sqlstr;
                oComm.Connection = m_pDbConnection;
                affected = oComm.ExecuteNonQuery();
            }
            else
            {
                NpgsqlCommand oComm = new NpgsqlCommand();
                oComm.CommandType = CommandType.Text;
                oComm.CommandText = sqlstr;
                oComm.Connection = m_pDbConnection;
                int affected = oComm.ExecuteNonQuery();
            }
        }

    }

}
