using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace ConnPostSQL
{
    //���ڷֲ���㷨ʵ��
    //��Ҫ�������㷨��Dijkstra�㷨��A*�㷨
    //����㷨����ǰ��Ҫ������в㼶��·����Ӧ��length�ֶ��Ƿ��Ѿ����ã����û�������򲹳�˹���
    //���ڵ�������ÿ���������ڻ��߳��ڵ㲢���ڴ�������
    //��Ҫ�ҳ����ض������ཻ��level1�ϵĵ�·
    class HierarchyAlgorithms
    {
        private DB postDB;
        public HierarchyAlgorithms(DB outDB)
        {
            postDB = outDB;
        }

        public void Dijkstra(string ftablename, string startpoint, string endpoint)
        {
            //�����ж����������ڵĲ�Σ��ڴ˴������������ͬ�ڵ�һ�㣬ͬ�ڵڶ��㣬һ���ڵ�һ�㣬��һ���ڵڶ���
            //��ʱ���յ�ǰ�ķֲ㷽ʽд���룬������ͨ�õ��ʺ϶����Σ�����Ҫ�ݹ�
            //��ʾ������������
            string sk, ek;
            string tablename,sqlstr,resultTable,substr;
            DataTable tmpdt;

            //�����õ��ĵ�·ͼ��
            SetRoadLength();
            tablename = GetLayerName(ftablename) + "_vertex_adjaction";
            sqlstr = "select kind from " + tablename + " where vertex_id=" + startpoint;
            tmpdt = postDB.DoQueryEx(sqlstr);
            sk = tmpdt.Rows[0]["kind"].ToString();
            sqlstr = "select kind from " + tablename + " where vertex_id=" + endpoint;
            tmpdt = postDB.DoQueryEx(sqlstr);
            ek = tmpdt.Rows[0]["kind"].ToString();

            resultTable = GetLayerName(ftablename) + "_hierarchydijkstra";

            if (sk.Equals(ek))
            {
                //����ͬһ��
                if (sk.Equals("1"))
                {
                    //λ�ڵ�һ��
                    tablename = "level" + sk + "_newlines";
                    substr = "select gid as id,source::integer,target::integer,length::double precision as cost from " + tablename;
                    sqlstr = "create table " + resultTable + " as select * from shortest_path('" + substr + "'," + startpoint + "," + endpoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(resultTable, sqlstr);
                } 
                else
                {
                    //λ�ڵڶ���
                    //��ʾ�������������������
                    string sSubNum, eSubNum;

                    tablename = GetLayerName(ftablename) + "_vertex_adjaction";
                    sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + startpoint;
                    tmpdt = postDB.DoQueryEx(sqlstr);
                    sSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();
                    sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + endpoint;
                    tmpdt = postDB.DoQueryEx(sqlstr);
                    eSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();

                    if (sSubNum.Equals(eSubNum))
                    {
                        //λ����ͬ������
                        string subTable;

                        subTable=GetLayerName(ftablename) + "_subtable_" + eSubNum;
                        sqlstr = "create table " + subTable + " as select gid as id,source::integer,target::integer,length::double precision as cost from " + ftablename +
                            " " + "where subnum=" + sSubNum;
                        postDB.CheckCreateTable(subTable, sqlstr);
                        substr="select * from " + subTable;
                        sqlstr = "create table " + resultTable + " as select * from shortest_path('" + substr + "'," + startpoint + "," + endpoint + ",false,false)";
                        //��Ҫ��������Ƿ����
                        postDB.CheckCreateTable(resultTable, sqlstr);

                    } 
                    else
                    {
                        //λ�ڲ�ͬ������
                        string sSubTable, eSubTable,entrypointTable,ePoints,eResultTable,midResultTable;
                        DataTable tmpEntryPoint;
                        string transformPoint1,transformPoint2;

                        sSubTable = GetLayerName(ftablename) + "_subtable_" + sSubNum;
                        //sqlstr = "create table " + sSubTable + " as select gid as id,source::integer,target::integer,length::double precision as cost from " + ftablename +
                        //    " " + "where subnum=" + sSubNum;
                        //�������Ӧ��Ŷ���ε�����ȡ����
                        sqlstr = "create table " + sSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + sSubNum;
                        postDB.CheckCreateTable(sSubTable, sqlstr);
                        
                        
                        eSubTable = GetLayerName(ftablename) + "_subtable_" + eSubNum;
                        sqlstr = "create table " + eSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + eSubNum;
                        postDB.CheckCreateTable(eSubTable, sqlstr);

                        //�ֱ��ҳ�����������ڵ㣬��������������ڵ㵽������ľ���Ӻͣ�ȡ��Сֵ��Ӧ�ĵ�Ϊѡȡ����ڵ�
                        entrypointTable=GetLayerName(ftablename) + "_entrypoint_subgraph";
                        sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + sSubNum;
                        tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                        ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                        transformPoint1 = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                        substr = "select * from " + sSubTable;
                        sqlstr = "create table " + resultTable + " as select * from shortest_path('" + substr + "'," + startpoint + "," + transformPoint1 + ",false,false)";
                        //��Ҫ��������Ƿ����
                        postDB.CheckCreateTable(resultTable, sqlstr);

                        sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + eSubNum;
                        tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                        ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                        transformPoint2 = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                        substr = "select * from " + eSubTable;
                        eResultTable = GetLayerName(ftablename) + "_path_end";
                        sqlstr = "create table " + eResultTable + " as select * from shortest_path('" + substr + "'," + transformPoint2 + "," + endpoint + ",false,false)";
                        //������洢����ʱ����
                        postDB.CheckCreateTable(eResultTable, sqlstr);

                        //��������������ڵ�֮�����·����level1�Ͻ���
                        tablename = "level1_newlines";
                        midResultTable = GetLayerName(ftablename) + "_path_mid";
                        substr = "select gid as id,source::integer,target::integer,length::double precision as cost from " + tablename;
                        sqlstr = "create table " + midResultTable + " as select * from shortest_path('" + substr + "'," + transformPoint1 + "," + transformPoint2 + ",false,false)";
                        //��Ҫ��������Ƿ����
                        postDB.CheckCreateTable(midResultTable, sqlstr);

                        //��һ����Ҫ��������ʱ���еĽ�����µ����ս������
                        //�����ȷ��������ʱ��ɾ��
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable + " " + "where edge_id <> -1";
                        sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable;
                        postDB.ExecNonQuery(sqlstr);
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eSubTable + " " + "where edge_id <> -1";
                        sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eSubTable;
                        postDB.ExecNonQuery(sqlstr);

                        //�˴�Ҳ���Կ��ǽ��м��ת����Ҳ���뵽��¼�У���Ϊ�����һ�ֿ��ӻ���ʾ
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable;
                        //postDB.ExecNonQuery(sqlstr);
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eSubTable;
                        //postDB.ExecNonQuery(sqlstr);
                    }

                }
            } 
            else
            {
                //���ڲ�ͬ��
                //��Ҫ�ж��ĸ�����ڵײ�
                string sSubTable, eSubTable, entrypointTable, ePoints, eResultTable, midResultTable;
                DataTable tmpEntryPoint;
                string transformPoint;
                int startkind, endkind;
                string eSubNum, sSubNum;

                startkind = int.Parse(sk);
                endkind = int.Parse(ek);

                tablename = GetLayerName(ftablename) + "_vertex_adjaction";
                sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + startpoint;
                tmpdt = postDB.DoQueryEx(sqlstr);
                sSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();
                sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + endpoint;
                tmpdt = postDB.DoQueryEx(sqlstr);
                eSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();

                if (startkind>endkind)
                {
                    //��ʼ��λ�ڵײ�����
                    sSubTable = GetLayerName(ftablename) + "_subtable_" + sSubNum;
                    sqlstr = "create table " + sSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + sSubNum;
                    postDB.CheckCreateTable(sSubTable, sqlstr);

                    //�ֱ���ڵ㣬��������������ڵ㵽������ľ���Ӻͣ�ȡ��Сֵ��Ӧ�ĵ�Ϊѡȡ����ڵ�
                    entrypointTable = GetLayerName(ftablename) + "_entrypoint_subgraph";
                    sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + sSubNum;
                    tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                    ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                    transformPoint = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                    //�������·��
                    substr = "select * from " + sSubTable;
                    sqlstr = "create table " + resultTable + " as select * from shortest_path('" + substr + "'," + startpoint + "," + transformPoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(resultTable, sqlstr);

                    //��������������ڵ�֮�����·����level1�Ͻ���
                    tablename = "level1_newlines";
                    midResultTable = GetLayerName(ftablename) + "_path_mid";
                    substr = "select gid as id,source::integer,target::integer,length::double precision as cost from " + tablename;
                    sqlstr = "create table " + midResultTable + " as select * from shortest_path('" + substr + "'," + transformPoint + "," + endpoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(midResultTable, sqlstr);

                    //��һ����Ҫ��������ʱ���еĽ�����µ����ս������
                    //�����ȷ��������ʱ��ɾ��
                    //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable + " " + "where edge_id <> -1";
                    sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable;
                    postDB.ExecNonQuery(sqlstr);
                    

                } 
                else
                {
                    //��ֹ��λ�ڵײ�����
                    eSubTable = GetLayerName(ftablename) + "_subtable_" + eSubNum;
                    sqlstr = "create table " + eSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + eSubNum;
                    //sqlstr = "create table " + eSubTable + " as select gid as id,source::integer,target::integer,length::double precision as cost from " + ftablename +
                    //    " " + "where subnum=" + eSubNum;
                    postDB.CheckCreateTable(eSubTable, sqlstr);

                    //�ֱ���ڵ㣬��������������ڵ㵽������ľ���Ӻͣ�ȡ��Сֵ��Ӧ�ĵ�Ϊѡȡ����ڵ�
                    entrypointTable = GetLayerName(ftablename) + "_entrypoint_subgraph";
                    sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + eSubNum;
                    tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                    ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                    transformPoint = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                    //��������������ڵ�֮�����·����level1�Ͻ���
                    tablename = "level1_newlines";
                    substr = "select gid as id,source::integer,target::integer,length::double precision as cost from " + tablename;
                    sqlstr = "create table " + resultTable + " as select * from shortest_path('" + substr + "'," + startpoint + "," + transformPoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(resultTable, sqlstr);

                    //�������·��
                    eResultTable = GetLayerName(ftablename) + "_path_end";
                    substr = "select * from " + eSubTable;
                    sqlstr = "create table " + eResultTable + " as select * from shortest_path('" + substr + "'," + transformPoint + "," + endpoint+",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(eResultTable, sqlstr);

                    //��һ����Ҫ��������ʱ���еĽ�����µ����ս������
                    //�����ȷ��������ʱ��ɾ��
                    //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eResultTable + " " + "where edge_id <> -1";
                    sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eResultTable;
                    postDB.ExecNonQuery(sqlstr);
                }


            }

        }

        public void Astar(string ftablename, string startpoint, string endpoint)
        {
            //�����ж����������ڵĲ�Σ��ڴ˴������������ͬ�ڵ�һ�㣬ͬ�ڵڶ��㣬һ���ڵ�һ�㣬��һ���ڵڶ���
            //��ʱ���յ�ǰ�ķֲ㷽ʽд���룬������ͨ�õ��ʺ϶����Σ�����Ҫ�ݹ�
            //��ʾ������������
            string sk, ek;
            string tablename, sqlstr, resultTable, substr;
            DataTable tmpdt;

            //�����õ��ĵ�·ͼ��
            SetRoadLength();
            tablename = GetLayerName(ftablename) + "_vertex_adjaction";
            sqlstr = "select kind from " + tablename + " where vertex_id=" + startpoint;
            tmpdt = postDB.DoQueryEx(sqlstr);
            sk = tmpdt.Rows[0]["kind"].ToString();
            sqlstr = "select kind from " + tablename + " where vertex_id=" + endpoint;
            tmpdt = postDB.DoQueryEx(sqlstr);
            ek = tmpdt.Rows[0]["kind"].ToString();

            resultTable = GetLayerName(ftablename) + "_hierarchyastar";

            if (sk.Equals(ek))
            {
                //����ͬһ��
                if (sk.Equals("1"))
                {
                    //λ�ڵ�һ��
                    tablename = "level" + sk + "_newlines";
                    substr = "select gid as id,source::integer,target::integer,length::double precision as cost,x1,y1,x2,y2 from " + tablename;
                    sqlstr = "create table " + resultTable + " as select * from shortest_path_astar('" + substr + "'," + startpoint + "," + endpoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(resultTable, sqlstr);
                }
                else
                {
                    //λ�ڵڶ���
                    //��ʾ�������������������
                    string sSubNum, eSubNum;

                    tablename = GetLayerName(ftablename) + "_vertex_adjaction";
                    sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + startpoint;
                    tmpdt = postDB.DoQueryEx(sqlstr);
                    sSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();
                    sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + endpoint;
                    tmpdt = postDB.DoQueryEx(sqlstr);
                    eSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();

                    if (sSubNum.Equals(eSubNum))
                    {
                        //λ����ͬ������
                        string subTable;

                        subTable = GetLayerName(ftablename) + "_subtable_" + eSubNum;
                        sqlstr = "create table " + subTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost,a.x1,a.y1,a.x2,a.y2 from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + eSubNum;
                        //sqlstr = "create table " + subTable + " as select gid as id,source::integer,target::integer,length::double precision as cost,x1,y1,x2,y2 from " + ftablename +
                        //    " " + "where subnum=" + sSubNum;
                        postDB.CheckCreateTable(subTable, sqlstr);
                        substr = "select * from " + subTable;
                        sqlstr = "create table " + resultTable + " as select * from shortest_path_astar('" + substr + "'," + startpoint + "," + endpoint + ",false,false)";
                        //��Ҫ��������Ƿ����
                        postDB.CheckCreateTable(resultTable, sqlstr);

                    }
                    else
                    {
                        //λ�ڲ�ͬ������
                        string sSubTable, eSubTable, entrypointTable, ePoints, eResultTable, midResultTable;
                        DataTable tmpEntryPoint;
                        string transformPoint1, transformPoint2;

                        sSubTable = GetLayerName(ftablename) + "_subtable_" + sSubNum;
                        sqlstr = "create table " + sSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost,a.x1,a.y1,a.x2,a.y2 from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + sSubNum;
                        postDB.CheckCreateTable(sSubTable, sqlstr);

                        eSubTable = GetLayerName(ftablename) + "_subtable_" + eSubNum;
                        sqlstr = "create table " + eSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost,a.x1,a.y1,a.x2,a.y2 from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + eSubNum;
                        postDB.CheckCreateTable(eSubTable, sqlstr);

                        //�ֱ��ҳ�����������ڵ㣬��������������ڵ㵽������ľ���Ӻͣ�ȡ��Сֵ��Ӧ�ĵ�Ϊѡȡ����ڵ�
                        entrypointTable = GetLayerName(ftablename) + "_entrypoint_subgraph";
                        sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + sSubNum;
                        tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                        ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                        transformPoint1 = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                        substr = "select * from " + sSubTable;
                        sqlstr = "create table " + resultTable + " as select * from shortest_path_astar('" + substr + "'," + startpoint + "," + transformPoint1 + ",false,false)";
                        //��Ҫ��������Ƿ����
                        postDB.CheckCreateTable(resultTable, sqlstr);

                        sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + eSubNum;
                        tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                        ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                        transformPoint2 = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                        substr = "select * from " + eSubTable;
                        eResultTable = GetLayerName(ftablename) + "_path_end";
                        sqlstr = "create table " + eResultTable + " as select * from shortest_path_astar('" + substr + "'," + transformPoint2 + "," + endpoint + ",false,false)";
                        //������洢����ʱ����
                        postDB.CheckCreateTable(eResultTable, sqlstr);

                        //��������������ڵ�֮�����·����level1�Ͻ���
                        tablename = "level1_newlines";
                        midResultTable = GetLayerName(ftablename) + "_path_mid";
                        substr = "select gid as id,source::integer,target::integer,length::double precision as cost,x1,y1,x2,y2 from " + tablename;
                        sqlstr = "create table " + midResultTable + " as select * from shortest_path_astar('" + substr + "'," + transformPoint1 + "," + transformPoint2 + ",false,false)";
                        //��Ҫ��������Ƿ����
                        postDB.CheckCreateTable(midResultTable, sqlstr);

                        //��һ����Ҫ��������ʱ���еĽ�����µ����ս������
                        //�����ȷ��������ʱ��ɾ��
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable + " " + "where edge_id <> -1";
                        sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable;
                        postDB.ExecNonQuery(sqlstr);
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eSubTable + " " + "where edge_id <> -1";
                        sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eSubTable;
                        postDB.ExecNonQuery(sqlstr);

                        //�˴�Ҳ���Կ��ǽ��м��ת����Ҳ���뵽��¼�У���Ϊ�����һ�ֿ��ӻ���ʾ
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable;
                        //postDB.ExecNonQuery(sqlstr);
                        //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eSubTable;
                        //postDB.ExecNonQuery(sqlstr);
                    }

                }
            }
            else
            {
                //���ڲ�ͬ��
                //��Ҫ�ж��ĸ�����ڵײ�
                string sSubTable, eSubTable, entrypointTable, ePoints, eResultTable, midResultTable;
                DataTable tmpEntryPoint;
                string transformPoint;
                int startkind, endkind;
                string eSubNum, sSubNum;

                startkind = int.Parse(sk);
                endkind = int.Parse(ek);

                tablename = GetLayerName(ftablename) + "_vertex_adjaction";
                sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + startpoint;
                tmpdt = postDB.DoQueryEx(sqlstr);
                sSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();
                sqlstr = "select subgraphnum from " + tablename + " where vertex_id=" + endpoint;
                tmpdt = postDB.DoQueryEx(sqlstr);
                eSubNum = tmpdt.Rows[0]["subgraphnum"].ToString();

                if (startkind > endkind)
                {
                    //��ʼ��λ�ڵײ�����
                    sSubTable = GetLayerName(ftablename) + "_subtable_" + sSubNum;
                    sqlstr = "create table " + sSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost,a.x1,a.y1,a.x2,a.y2 from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + sSubNum;
                    //sqlstr = "create table " + sSubTable + " as select gid as id,source::integer,target::integer,length::double precision as cost from " + ftablename +
                    //        " " + "where subnum=" + sSubNum;
                    postDB.CheckCreateTable(sSubTable, sqlstr);

                    //�ֱ���ڵ㣬��������������ڵ㵽������ľ���Ӻͣ�ȡ��Сֵ��Ӧ�ĵ�Ϊѡȡ����ڵ�
                    entrypointTable = GetLayerName(ftablename) + "_entrypoint_subgraph";
                    sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + sSubNum;
                    tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                    ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                    transformPoint = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                    //�������·��
                    substr = "select * from " + sSubTable;
                    sqlstr = "create table " + resultTable + " as select * from shortest_path_astar('" + substr + "'," + startpoint + "," + transformPoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(resultTable, sqlstr);

                    //��������������ڵ�֮�����·����level1�Ͻ���
                    tablename = "level1_newlines";
                    midResultTable = GetLayerName(ftablename) + "_path_mid";
                    substr = "select gid as id,source::integer,target::integer,length::double precision as cost,x1,y1,x2,y2 from " + tablename;
                    sqlstr = "create table " + midResultTable + " as select * from shortest_path_astar('" + substr + "'," + transformPoint + "," + endpoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(midResultTable, sqlstr);

                    //��һ����Ҫ��������ʱ���еĽ�����µ����ս������
                    //�����ȷ��������ʱ��ɾ��
                    //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable + " " + "where edge_id <> -1";
                    sqlstr = "insert into " + " " + resultTable + " " + "select * from " + midResultTable;
                    postDB.ExecNonQuery(sqlstr);


                }
                else
                {
                    //��ֹ��λ�ڵײ�����
                    eSubTable = GetLayerName(ftablename) + "_subtable_" + eSubNum;
                    sqlstr = "create table " + eSubTable + " " + "as select a.gid as id,a.source::integer,a.target::integer,a.length::double precision as cost,a.x1,a.y1,a.x2,a.y2 from " + ftablename +
                            " a," + "level1_polygon b where st_contains(st_buffer(st_transform(b.the_geom,2345),5),st_transform(a.geom,2345))=true and b.subnum=" + eSubNum;
                    //sqlstr = "create table " + eSubTable + " as select gid as id,source::integer,target::integer,length::double precision as cost from " + ftablename +
                    //        " " + "where subnum=" + eSubNum;
                    postDB.CheckCreateTable(eSubTable, sqlstr);

                    //�ֱ���ڵ㣬��������������ڵ㵽������ľ���Ӻͣ�ȡ��Сֵ��Ӧ�ĵ�Ϊѡȡ����ڵ�
                    entrypointTable = GetLayerName(ftablename) + "_entrypoint_subgraph";
                    sqlstr = "select entrypoint from " + entrypointTable + " where subnum=" + eSubNum;
                    tmpEntryPoint = postDB.DoQueryEx(sqlstr);
                    ePoints = tmpEntryPoint.Rows[0]["entrypoint"].ToString();
                    transformPoint = GetEntryPoint(ePoints, startpoint, endpoint, ftablename);

                    //��������������ڵ�֮�����·����level1�Ͻ���
                    tablename = "level1_newlines";
                    substr = "select gid as id,source::integer,target::integer,length::double precision as cost,x1,y1,x2,y2 from " + tablename;
                    sqlstr = "create table " + resultTable + " as select * from shortest_path_astar('" + substr + "'," + startpoint + "," + transformPoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(resultTable, sqlstr);

                    //�������·��
                    eResultTable = GetLayerName(ftablename) + "_path_end";
                    substr = "select * from " + eSubTable;
                    sqlstr = "create table " + eResultTable + " as select * from shortest_path_astar('" + substr + "'," + transformPoint + "," + endpoint + ",false,false)";
                    //��Ҫ��������Ƿ����
                    postDB.CheckCreateTable(eResultTable, sqlstr);

                    //��һ����Ҫ��������ʱ���еĽ�����µ����ս������
                    //�����ȷ��������ʱ��ɾ��
                    //sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eResultTable + " " + "where edge_id <> -1";
                    sqlstr = "insert into " + " " + resultTable + " " + "select * from " + eResultTable;
                    postDB.ExecNonQuery(sqlstr);
                }

            }
        }

        private string GetLayerName(string ftablename)
        {
            int index;
            string name;
            index = ftablename.LastIndexOf('_');
            name = ftablename.Substring(0, index);
            return name;
        }

        private string GetEntryPoint(string ePoints, string startpoint, string endpoint, string ftablename)
        {
            //��һ���������ڵ���ѡ����ʵ�һ�����������С
            string[] points;
            string tablename, sqlstr,tmpPoint;
            double xs, ys, xt, yt, xe, ye;
            double distST, distTE;
            Hashtable ht;
            DataTable tmpdt;
            string[] keyPoints;
            double[] valuePoints;

            tablename = GetLayerName(ftablename) + "_vertex_adjaction";
            sqlstr = "select x(st_transform(geom,2345)) as x,y(st_transform(geom,2345)) as y from " + tablename + " where vertex_id=" + startpoint;
            tmpdt = postDB.DoQueryEx(sqlstr);
            xs = double.Parse(tmpdt.Rows[0]["x"].ToString());
            ys = double.Parse(tmpdt.Rows[0]["y"].ToString());
            sqlstr = "select x(st_transform(geom,2345)) as x,y(st_transform(geom,2345)) as y from " + tablename + " where vertex_id=" + endpoint;
            tmpdt = postDB.DoQueryEx(sqlstr);
            xe = double.Parse(tmpdt.Rows[0]["x"].ToString());
            ye = double.Parse(tmpdt.Rows[0]["y"].ToString());
            points = ePoints.Split('_');
            ht = new Hashtable();
            for (int i = 0; i < points.Length;i++ )
            {
                ht.Clear();
                tmpPoint = points[i];
                sqlstr = "select x(st_transform(geom,2345)) as x,y(st_transform(geom,2345)) as y from " + tablename + " where vertex_id=" + tmpPoint;
                tmpdt = postDB.DoQueryEx(sqlstr);
                xt = double.Parse(tmpdt.Rows[0]["x"].ToString());
                yt = double.Parse(tmpdt.Rows[0]["y"].ToString());
                distST = Math.Sqrt((xt - xs) * (xt - xs) + (yt - ys) * (yt - ys));
                distTE = Math.Sqrt((xt - xe) * (xt - xe) + (yt - ye) * (yt - ye));
                ht.Add(tmpPoint, distST + distTE);
            }
            keyPoints = new string[ht.Count];
            valuePoints = new double[ht.Count];
            ht.Keys.CopyTo(keyPoints, 0);
            ht.Values.CopyTo(valuePoints, 0);
            Array.Sort(valuePoints, keyPoints);

            return keyPoints[0];
        }

        // ���ø߲��·��length�ֶΣ��˹���Ҳ�������������н���
        private void SetRoadLength()
        {
            //���õ�·��length
            string tablename, sqlstr, colName, geoClm, projectsrid, columnName;
            //Ϊ��·ͼ���geometry���index
            string indexName;

#region level1
            tablename = "level1_newlines";
            geoClm = "geom";
            colName = "length";
            projectsrid = "2345";
            if (postDB.IsColumnExist(tablename, colName))
            {
                sqlstr = "update " + tablename + " " + "set " + colName + "=st_length(st_transform(" + geoClm + "," + projectsrid + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + colName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + colName + "=st_length(st_transform(" + geoClm + "," + projectsrid + "))";
                postDB.ExecNonQuery(sqlstr);
            }

            columnName = "x1";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            columnName = "y1";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            columnName = "x2";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            columnName = "y2";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }

            indexName = "level1_index_geom";
            if (postDB.IsIndexExist(tablename, geoClm))
            {
                sqlstr = "drop index " + " " + indexName;
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "create index" + " " + indexName + " " + "on" + " " + tablename + " " + "using gist(" + geoClm + ")";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "create index" + " " + indexName + " " + "on" + " " + tablename + " " + "using gist(" + geoClm + ")";
                postDB.ExecNonQuery(sqlstr);
            }
#endregion
            
#region level2
            tablename = "level2_newlines";
            if (postDB.IsColumnExist(tablename, colName))
            {
                sqlstr = "update " + tablename + " " + "set " + colName + "=st_length(st_transform(" + geoClm + "," + projectsrid + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + colName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + colName + "=st_length(st_transform(" + geoClm + "," + projectsrid + "))";
                postDB.ExecNonQuery(sqlstr);
            }

            columnName = "x1";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            columnName = "y1";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(startpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            columnName = "x2";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=x(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            columnName = "y2";
            if (postDB.IsColumnExist(tablename, columnName))
            {
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "alter table " + tablename + " " + "add column  " + " " + columnName + " " + "double precision";
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "update " + tablename + " " + "set " + columnName + "=y(endpoint(" + geoClm + "))";
                postDB.ExecNonQuery(sqlstr);
            }

            indexName = "level2_index_geom";
            if (postDB.IsIndexExist(tablename, geoClm))
            {
                sqlstr = "drop index " + " " + indexName;
                postDB.ExecNonQuery(sqlstr);
                sqlstr = "create index" + " " + indexName + " " + "on" + " " + tablename + " " + "using gist(" + geoClm + ")";
                postDB.ExecNonQuery(sqlstr);
            }
            else
            {
                sqlstr = "create index" + " " + indexName + " " + "on" + " " + tablename + " " + "using gist(" + geoClm + ")";
                postDB.ExecNonQuery(sqlstr);
            }
#endregion
            


        }

    }
}
