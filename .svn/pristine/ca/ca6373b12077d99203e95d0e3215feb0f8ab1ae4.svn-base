using System;
using System.Collections.Generic;
using System.Text;

namespace ConnPostSQL
{
    /// <summary>
    /// 完成使用PostgreSQL中提供的函数完成Dijkstra算法、Astar算法和Shooting-Star算法
    /// 可以对三个函数进行进一步的抽象，使用case句子进行判断，代码会更简练
    /// PostgreSQL中表名为小写，故代码中表名均为小写
    /// </summary>
    class ShortestPath
    {
        private DB postDB;
        public ShortestPath(DB outDB)
        {
            postDB = outDB;
        }

        public void Dijkstra(string ftablename, string startpoint, string endpoint)
        {
            //进行计算前的准备工作，如为length字段赋值等在主程序中完成
            //在此处完成构建结果表的任务，在主程序中继续完善表，将结果表中的道路赋予几何实体
            string sqlstr, substr;
            string tablename;
            tablename = GetLayerName(ftablename) + "_dijkstra";
            substr = "select gid as id,source::integer,target::integer,length::double precision as cost from " + ftablename;
            sqlstr = "create table " + tablename + " as select * from shortest_path('" + substr + "'," + startpoint + "," + endpoint + ",false,false)";
            //需要检测结果表是否存在
            postDB.CheckCreateTable(tablename,sqlstr);
        }

        public void Astar(string ftablename, string startpoint, string endpoint)
        {
            string sqlstr, substr;
            string tablename;
            tablename = GetLayerName(ftablename) + "_astar";
            substr = "select gid as id,source::integer,target::integer,length::double precision as cost,x1,y1,x2,y2 from " + ftablename;
            sqlstr = "create table " + tablename + " as select * from shortest_path_astar('" + substr + "'," + startpoint + "," + endpoint + ",false,false)";
            postDB.CheckCreateTable(tablename, sqlstr);
        }

        public void ShootingStar(string ftablename, string startedge, string endedge)
        {
            string sqlstr, substr;
            string tablename;
            tablename = GetLayerName(ftablename) + "_shootingstar";
            substr = "select gid as id,source::integer,target::integer,length::double precision as cost,x1,y1,x2,y2,rule,to_cost from " + ftablename;
            sqlstr = "create table " + tablename + " as select * from shortest_path_shooting_star('" + substr + "'," + startedge + "," + endedge + ",false,false)";
            postDB.CheckCreateTable(tablename, sqlstr);
        }

        private string GetLayerName(string ftablename)
        {
            int index;
            string name;
            index = ftablename.LastIndexOf('_');
            name = ftablename.Substring(0, index);
            return name;
        }

    }
}
