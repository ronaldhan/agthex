using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace ConnPostSQL
{
    //经典算法实现
    //主要是两种算法，Dijkstra算法和A*算法
    class ClassicalAlgorithms
    {
        private DB postDB;
        public ClassicalAlgorithms(DB outDB)
        {
            postDB = outDB;
        }

        public void Dijkstra(string ftablename, string startpoint, string endpoint)
        {
            //基于邻接表
            //存储组成最短路径的边的序号
            //结点是否标记
            bool[] final;
            double minLength;
            string sqlstr,tablename,tmpVertex,adjLine,tmpLine,tmpLength;
            DataTable VertexTable,tmpLengthTable;
            int totalVertex,start,end,curVertex;
            string[] tmpAdjLine;
            //存储每个结点到源点的最短路径值
            double[] dist;
            //结点的父结点
            int[] prev;

            tablename=GetLayerName(ftablename) + "_vertex_adjaction";
            sqlstr = "select vertex_id,vertex_adj_id,line_adj_id from " + tablename + " " + "order by vertex_id asc";
            VertexTable = postDB.DoQueryEx(sqlstr);
            totalVertex = VertexTable.Rows.Count;

            //初始化
            start = int.Parse(startpoint);
            end = int.Parse(endpoint);
            //初始化之后默认即为false
            final = new bool[totalVertex];
            dist = new double[totalVertex];
            //prev中存储的索引比结点编号小1
            prev = new int[totalVertex];

            for (int n = 0; n < totalVertex;n++ )
            {
                if (! start.Equals(n+1))
                {
                    dist[n] = double.MaxValue;
                    prev[n] = 0;
                    final[n] = false;
                }
            }
            adjLine = VertexTable.Rows[start - 1]["line_adj_id"].ToString();
            tmpAdjLine = adjLine.Split('_');
            //更新start点连接的边的dist值
            for (int m = 0; m < tmpAdjLine.Length; m++)
            {
                tmpLine = tmpAdjLine[m];
                sqlstr = "select source,target,length from " + ftablename + " where gid=" + tmpLine;
                tmpLengthTable = postDB.DoQueryEx(sqlstr);
                tmpVertex=tmpLengthTable.Rows[0]["source"].ToString();
                tmpLength = tmpLengthTable.Rows[0]["length"].ToString();
                if (startpoint.Equals(tmpVertex))
                {
                    tmpVertex = tmpLengthTable.Rows[0]["target"].ToString();
                    dist[int.Parse(tmpVertex) - 1] = double.Parse(tmpLength);
                    prev[int.Parse(tmpVertex) - 1] = start-1;
                } 
                else
                {
                    dist[int.Parse(tmpVertex) - 1] = double.Parse(tmpLength);
                    prev[int.Parse(tmpVertex) - 1] = start-1;
                }
            }
            dist[start-1] = 0;
            final[start-1] = true;

            //如果end结点被标记即表明已经找到两点之间的最短路径
            while (! final[end-1])
            {
                curVertex = start;
                minLength = double.MaxValue;
                for (int i = 0; i < totalVertex;i++ )
                {
                    if (! final[i] && dist[i]<minLength)
                    {
                        //此处获得的curVertex和真实的结点id小1
                        curVertex = i+1;
                        minLength = dist[i];
                    }
                }
                final[curVertex-1] = true;
#region 邻接表
                //可以通过访问已在内存中的表的记录获取结点的邻接边情况
                adjLine = VertexTable.Rows[curVertex - 1]["line_adj_id"].ToString();
                tmpAdjLine = adjLine.Split('_');
                double tmpdist;
                for (int j = 0; j < tmpAdjLine.Length; j++)
                {
                    tmpLine = tmpAdjLine[j];
                    sqlstr = "select source,target,length from " + ftablename + " where gid=" + tmpLine;
                    tmpLengthTable = postDB.DoQueryEx(sqlstr);
                    tmpVertex = tmpLengthTable.Rows[0]["source"].ToString();
                    tmpLength = tmpLengthTable.Rows[0]["length"].ToString();
                    if (curVertex.Equals(int.Parse(tmpVertex)))
                    {
                        tmpVertex = tmpLengthTable.Rows[0]["target"].ToString();
                    }
                    //当前连接的结点未被标记
                    if (! final[int.Parse(tmpVertex) - 1])
                    {
                        tmpdist = dist[curVertex - 1] + double.Parse(tmpLength);
                        if (tmpdist < dist[int.Parse(tmpVertex) - 1])
                        {
                            dist[int.Parse(tmpVertex) - 1] = tmpdist;
                            //此处可以改造为添加线段的名称和对应的长度，最后在结果表中显示
                            prev[int.Parse(tmpVertex) - 1] = curVertex-1;
                        }
                    }
                }
#endregion
            
            }

            List<int> result;
            int tmp;
            string tmpGeomTxt;

            result = new List<int>();
            result.Add(end);
            tmp = prev[end - 1]+1;
            while (! tmp.Equals(start))
            {
                result.Add(tmp);
                tmp = prev[tmp - 1]+1;
            }
            result.Add(start);
            result.Reverse();
            //将结果写入到表中
            //写入的内容包括边gid,geom,length
            //创建结果表，调用checkcreatetable
            tablename=GetLayerName(ftablename) + "_classicaldijkstra";
            sqlstr = "create table " + tablename + " (gid integer,length double precision,geom geometry)";
            postDB.CheckCreateTable(tablename, sqlstr);
            for (int i = 0; i < result.Count - 1;i++ )
            {
                int cur, next;
                cur = result[i];
                next = result[i + 1];
                tmpLine = GetLineID(ftablename,cur.ToString(), next.ToString());
                sqlstr = "select length,st_astext(geom) as geomtxt from " + ftablename + " " + "where gid=" + tmpLine;
                tmpLengthTable = postDB.DoQueryEx(sqlstr);
                tmpLength = tmpLengthTable.Rows[0]["length"].ToString();
                tmpGeomTxt = tmpLengthTable.Rows[0]["geomtxt"].ToString();
                sqlstr = "INSERT INTO" + " " + tablename + " " + "(gid,length,geom) values (" + tmpLine + ","
                             + tmpLength + "," + "st_geomfromtext('" + tmpGeomTxt + "', 4326)" + ")";
                postDB.ExecNonQuery(sqlstr);
            }       
            
        }

        /// <summary>
        /// 根据两个点的id找到对应边的id
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        private string GetLineID(string ftablename,string point1, string point2)
        {
            DataTable dt;
            string sqlstr,line;

            sqlstr = "select gid from " + ftablename + " where source=" + point1 + " and target=" + point2 + " or source=" + point2 + " and target=" + point1;
            dt = postDB.DoQueryEx(sqlstr);
            line = dt.Rows[0]["gid"].ToString();
            return line;
        }

        
        public void Astar(string ftablename, string startpoint, string endpoint)
        {
#region 使用字典方式
            //两种实现方式，一种使用字段存储不同的值，另外一种使用构造的Point类实现
            //使用字段方式完成
            //Queue<int> Open;
            //Queue<int> Close;
            //Dictionary<int, double> GScore;
            //Dictionary<int, double> FScore;
            ////最短路径上结点的前后关系
            //Dictionary<int, int> ComeFrom;
            //string sqlstr, tablename, tmpAdjVertex;
            //DataTable VertexTable;
            //int totalVertex, start, end, curVertex, adjVertex;
            //string[] adjVertexes;

            //tablename = GetLayerName(ftablename) + "_vertex_adjaction";
            //sqlstr = "select vertex_id,vertex_adj_id,line_adj_id from " + tablename + " " + "order by vertex_id asc";
            //VertexTable = postDB.DoQueryEx(sqlstr);
            //totalVertex = VertexTable.Rows.Count;

            ////初始化
            //start = int.Parse(startpoint);
            //end = int.Parse(endpoint);
            //Open = new Queue<int>();
            //Close = new Queue<int>();
            ////存储最短路径的值
            //GScore = new Dictionary<int, double>();
            ////存储最短路径+启发值
            //FScore = new Dictionary<int, double>();
            ////标记最优路径上结点的前驱结点
            //ComeFrom = new Dictionary<int, int>();

            ////开始结点加入到open队列中
            //Open.Enqueue(start);
            //curVertex = start;
            //GScore.Add(curVertex, 0);
            //FScore.Add(curVertex, GetHeuristic(curVertex, end, ftablename));
            //double tmp;
            //while (Open.Count > 0)
            //{
            //    tmp = GetCost(curVertex, GScore) + GetHeuristic(curVertex, end, ftablename);
            //    foreach (int j in Open)
            //    {
            //        if (tmp > GetCost(j, GScore) + GetHeuristic(j, end, ftablename))
            //        {
            //            tmp = GetCost(j, GScore) + GetHeuristic(j, end, ftablename);
            //            curVertex = j;
            //        }
            //    }

            //    if (curVertex.Equals(end))
            //    {
            //        break;
            //    }
            //    Open.Dequeue();
            //    Close.Enqueue(curVertex);

            //    tmpAdjVertex = VertexTable.Rows[curVertex - 1]["vertex_adj_id"].ToString();
            //    adjVertexes = tmpAdjVertex.Split('_');

            //    for (int i = 0; i < adjVertexes.Length; i++)
            //    {
            //        adjVertex = int.Parse(adjVertexes[i]);
            //        if (Close.Contains(adjVertex))
            //        {
            //            continue;
            //        }
            //        double newGValue = GetCost(curVertex, GScore) + GetDistance(curVertex, adjVertex, ftablename);
            //        bool newIsBetter = false;

            //        if (!Open.Contains(adjVertex))
            //        {
            //            Open.Enqueue(adjVertex);
            //            newIsBetter = true;
            //        }
            //        else if (newGValue < GScore[adjVertex])
            //        {
            //            newIsBetter = true;
            //        }

            //        if (newIsBetter)
            //        {
            //            if (ComeFrom.ContainsKey(adjVertex))
            //            {
            //                ComeFrom[adjVertex] = curVertex;
            //            }
            //            else
            //            {
            //                ComeFrom.Add(adjVertex, curVertex);
            //            }
            //            GScore[adjVertex] = newGValue;
            //            FScore[adjVertex] = GScore[adjVertex] + GetHeuristic(adjVertex, end, ftablename);
            //        }

            //    }

            //}
            ////如果获得的comefrom为空，则未找到相应的路径
            //List<int> result;
            //int tmpid;
            //string tmpGeomTxt, tmpLine, tmpLength;
            //DataTable tmpLengthTable;

            //result = new List<int>();
            //result.Add(end);
            //tmpid = ComeFrom[end];
            //while (!tmpid.Equals(start))
            //{
            //    result.Add(tmpid);
            //    tmpid = ComeFrom[tmpid];
            //}
            //result.Add(start);
            //result.Reverse();
            ////将结果写入到表中
            ////写入的内容包括边gid,geom,length
            ////创建结果表，调用checkcreatetable
            //tablename = GetLayerName(ftablename) + "_classicalastar";
            //sqlstr = "create table " + tablename + " (gid integer,length double precision,geom geometry)";
            //postDB.CheckCreateTable(tablename, sqlstr);
            //for (int i = 0; i < result.Count - 1; i++)
            //{
            //    int cur, next;
            //    cur = result[i];
            //    next = result[i + 1];
            //    tmpLine = GetLineID(ftablename, cur.ToString(), next.ToString());
            //    sqlstr = "select length,st_astext(geom) as geomtxt from " + ftablename + " " + "where gid=" + tmpLine;
            //    tmpLengthTable = postDB.DoQueryEx(sqlstr);
            //    tmpLength = tmpLengthTable.Rows[0]["length"].ToString();
            //    tmpGeomTxt = tmpLengthTable.Rows[0]["geomtxt"].ToString();
            //    sqlstr = "INSERT INTO" + " " + tablename + " " + "(gid,length,geom) values (" + tmpLine + ","
            //                 + tmpLength + "," + "st_geomfromtext('" + tmpGeomTxt + "', 4326)" + ")";
            //    postDB.ExecNonQuery(sqlstr);
            //}
#endregion
            


        }

        //获取当前结点所邻接的结点之间边的权值
        private double GetDistance(int curVertex, int adjVertex, string ftablename)
        {
            double length;
            string sqlstr;
            DataTable tmpdt;

            sqlstr = "select length from " + " " + ftablename + " " + "where source=" + curVertex.ToString() + " and target=" + adjVertex.ToString() + " or source=" + adjVertex.ToString() + " and target=" + curVertex.ToString();
            tmpdt = postDB.DoQueryEx(sqlstr);
            length = double.Parse(tmpdt.Rows[0]["length"].ToString());

            return length;

        }

        //获取当前结点的最短路径值
        private double GetCost(int curVertex, Dictionary<int, double> GScore)
        {
            double cost;

            if (GScore.ContainsKey(curVertex))
            {
                cost = GScore[curVertex];
            } 
            else
            {
                cost=999999;
            }
            return cost;
        }
#region A*算法
        //计算当前结点到终止结点的启发值
        private double GetHeuristic(int curVertex, int end, string tablename)
        {
            string sqlstr;
            double dist,x1,y1,x2,y2;
            DataTable tmpdt;

            tablename=GetLayerName(tablename) + "_vertices";
            sqlstr="select x(st_transform(the_geom,2345)) as x,y(st_transform(the_geom,2345)) as y from " + tablename + " " + "where id=" + curVertex.ToString();
            tmpdt = postDB.DoQueryEx(sqlstr);
            x1 = double.Parse(tmpdt.Rows[0]["x"].ToString());
            y1 = double.Parse(tmpdt.Rows[0]["y"].ToString());
            sqlstr = "select x(st_transform(the_geom,2345)) as x,y(st_transform(the_geom,2345)) as y from " + tablename + " " + "where id=" + end.ToString();
            tmpdt = postDB.DoQueryEx(sqlstr);
            x2 = double.Parse(tmpdt.Rows[0]["x"].ToString());
            y2 = double.Parse(tmpdt.Rows[0]["y"].ToString());
            dist = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return dist;
        }

#endregion
        

        
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
