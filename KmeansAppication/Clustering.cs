using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KmeansAppication
{

    public struct cluster
    {
        public int x, y;
        public cluster(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Clustering
    {
        Random rand = new Random();
        
        public List<List<cluster>> clusters = new List<List<cluster>>();
        
    public void initializer(int k, int d)
        {
            for (int i = 0; i <= d; i++) { 
                clusters.Add(new List<cluster>());
            }
            for (int i = 0; i < k; i++)
            {
                clusters[0].Add(new cluster(rand.Next(0, 100), rand.Next(0, 100)));
            }
            for (int i = 1; i <= d; i++)
            {
                clusters[i].Add(clusters[0][rand.Next(0, k)]);
                
            }
        }

        public double distance(cluster C1 , cluster C2)
        {
            return Math.Sqrt((C1.x - C2.x)* (C1.x - C2.x) + (C1.y - C2.y)* (C1.y - C2.y));
        }

        public cluster average(List<cluster> D)
        {
            cluster avg = new cluster(0 , 0);
            float x, y;
            for (int i = 1; i < D.Count; i++)
            {
                avg.x = avg.x + D[i].x;
                avg.y = avg.y + D[i].y;
            }
            if (D.Count == 1) return D[0];
            x = avg.x / (D.Count-1);
            y = avg.y / (D.Count-1);
            avg.x = (int)x;
            avg.y = (int)y;
            return avg;
        }

        public cluster closest(List<cluster> D , cluster avg)
        {
            cluster temp = new cluster(0, 0);
            double temp_dist = 99999999;
            for (int i = 0; i < D.Count; i++)
            {
                if (distance(D[i], avg) < temp_dist)
                {
                    temp = D[i];
                    temp_dist = distance(D[i], avg);
                }
            }
            return temp;
        }

        public void comparing(int d, int k)
        {
            int temp_int;
            double temp_dist;

            for (int i = 0; i < k; i++)
            {
                temp_int = 0;
                temp_dist = 99999999;
                for (int j = 1; j <= d; j++)
                {
                    if (distance(clusters[0][i], clusters[j][0]) < temp_dist)
                    {
                        temp_int = j;
                        temp_dist = distance(clusters[0][i], clusters[j][0]);
                    }
                }
                clusters[temp_int].Add(clusters[0][i]);
            }
        }

        public void setZero(int d)
        {
            cluster temp;
            for (int i = 1; i <= d; i++)
            {
                temp = closest(clusters[i], average(clusters[i]));
                clusters[i].Clear();
                clusters[i].Add(temp);
            }
        }

    }
}
