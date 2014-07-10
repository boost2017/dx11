﻿namespace VoronoiMap {
    public class Edge {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Site[] Region { get; private set; }
        public Site[] Endpoint { get; private set; }
        private int EdgeNum { get; set; }

        public static int EdgeCount;

        public Edge(Site s1, Site s2) {
            Region = new Site[2];
            Endpoint = new Site[2];
            Region[Side.Left] = s1;
            Region[Side.Right] = s2;
            EdgeNum = EdgeCount++;
        }
        public override string ToString() {
            return string.Format("#{7} A={0} B={1} C={2} Ep[L]={3} Ep[R]={4} R[L]={5}, R[R]={6}",
                                 A, B, C, Endpoint[0], Endpoint[1], Region[0], Region[1], EdgeNum);
        }
    }
}