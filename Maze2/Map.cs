using System;
using System.Collections.Generic;
using System.Drawing;

namespace Maze2
{
    public class Element
    {
        public int x, y;
        public bool w, s, a, d;
        public Element(int X, int Y)
        {
            x = X;
            y = Y;
            w = s = a = d = true;
        }
    }  // 迷宫单元格
    public class Map
    {
        private readonly int m, n, num;
        public readonly Element[,] map;
        private readonly char[] directions = { 'w', 's', 'a', 'd' };
        public Map(int M, int N)
        {
            m = M;
            n = N;
            num = m * n;
            map = new Element[n, m];
            for (int x = 0; x < n; x++)
                for (int y = 0; y < m; y++)
                    map[x, y] = new Element(x, y);
            CreatMap();
        }  // 迷宫构造方法 
        private void BreakWall(Element e, char d) 
        {
            switch (d)
            {
                case 'w':
                    if (e.y != 0) e.w = map[e.x, e.y - 1].s = false; break;
                case 's':
                    if (e.y != m - 1)  e.s = map[e.x, e.y + 1].w = false; break;
                case 'a':
                    if (e.x != 0) e.a = map[e.x - 1, e.y].d = false; break;
                case 'd':
                    if (e.x != n - 1) e.d = map[e.x + 1, e.y].a = false; break;
                default: break;
            }
        }  // 拆墙方法
        private Element NextRoad(Element e, char d)
        {
            switch (d)
            {
                case 'w':
                    if (e.y != 0) return map[e.x, e.y - 1];
                    else return e;
                case 's':
                    if (e.y != m - 1) return map[e.x, e.y + 1];
                    else return e;
                case 'a':
                    if (e.x != 0) return map[e.x - 1, e.y];
                    else return e;
                case 'd':
                    if (e.x != n - 1) return map[e.x + 1, e.y];
                    else return e;
                default: return e;
            }
        }  // 指路方法
        private bool IsRoadOver(Element e, List<Element> r)
        {
            if (r.Contains(NextRoad(e, 'w')) && r.Contains(NextRoad(e, 's'))
                && r.Contains(NextRoad(e, 'a')) && r.Contains(NextRoad(e, 'd'))) return true;
            else return false;
        } // 判断一个
        private void CreatMap()
        {
            List<Element> roads = new List<Element>(num) { map[0, 0] };
            Random r = new Random();
            Element e;
            char d = 'w';
            e = roads[0];
            while (roads.Count != num)
            {
                while (IsRoadOver(e, roads)) e = roads[r.Next(roads.Count)];
                while (roads.Contains(NextRoad(e, d))) d = directions[r.Next(4)];
                roads.Add(NextRoad(e, d));
                BreakWall(e, d);
                // 尽量生成较长的死胡同
                e = NextRoad(e, d);
                d = directions[r.Next(4)];
            }
        }  // 迷宫生成方法
        public Point[,] DrawPoints(int X, int Y, int px)
        {
            Point[,] points = new Point[2, 3 * m * n];
            int i = 0;
            foreach (Element e in map)
            {
                if (e.w)
                {
                    points[0, i] = new Point(X + px * e.x, Y + px * e.y);
                    points[1, i++] = new Point(X + px * (e.x + 1), Y + px * e.y);
                }
                if (e.s)
                {
                    points[0, i] = new Point(X + px * e.x, Y + px * (e.y + 1));
                    points[1, i++] = new Point(X + px * (e.x + 1), Y + px * (e.y + 1));
                }
                if (e.a)
                {
                    points[0, i] = new Point(X + px * e.x, Y + px * e.y);
                    points[1, i++] = new Point(X + px * e.x, Y + px * (e.y + 1));
                }
                if (e.d)
                {
                    points[0, i] = new Point(X + px * (e.x + 1), Y + px * e.y);
                    points[1, i++] = new Point(X + px * (e.x + 1), Y + px * (e.y + 1));
                }
            }
            _ = new Point[2, i];
            Point[,] points1 = points;
            return points1;
        } // 迷宫点阵生成方法
    }
}
