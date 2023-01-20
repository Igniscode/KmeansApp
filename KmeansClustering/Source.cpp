#include "Clustering.h"

struct cluster {
public:
	int x = 0, y = 0;

};

vector<vector<cluster>> clusters;

void initializer(int k);
float distance(cluster C1, cluster C2);
cluster average(vector<cluster> D);
void comparing(int d, int k);
void setZero(int d);
void showData(int d);

int main(void) {
	//k is number of cluster ,  D is number of data set (cluster[D][k]
	int D, k;
	cout << "input D and k : ";
	cin >> D >> k;
	//0 : default list, 1 , 2 .. , n : each data set list
	clusters.resize(D + 1);

	clusters[0].resize(k);

	for (int i = 1; i <= D; i++) {
		clusters[i].resize(1);
	}

	initializer(k);

	for (int i = 1; i <= D; i++) {
		clusters[i][0] = clusters[0][rand() % k];
	}
	for (int i = 0; i < 5 ; i++) {
		comparing(D, k);
		showData(D);
		setZero(D);
	}
	comparing(D, k);

	showData(D);

	return 0;
}


void showData(int d) {
	for (int i = 1; i <= d; i++) {
		cout << i << " Data set " << endl;
		for (int j = 0; j < clusters[i].size() ; j++) {
			cout <<"("<<clusters[i][j].x << "," << clusters[i][j].y <<")   " ;
		}
		cout << endl;
	}
}

void setZero(int d) {
	cluster temp;
	for (int i = 1; i <= d ; i++) {
		temp = average(clusters[i]);
		clusters[i].clear();
		clusters[i].push_back(temp);
	}
}

void comparing(int d, int k) {

	for (int i = 0; i < k; i++) {
		int temp_int = 0 ;
		float temp_dist = MAX_FLOAT;
		for (int j = 1; j <= d ; j++) {
			if (distance(clusters[0][i], clusters[j][0]) < temp_dist) {
				temp_int = j;
				temp_dist = distance(clusters[0][i], clusters[j][0]);
			}
			cout << i << " " << j << " OK " << temp_dist << endl;
		}
		clusters[temp_int].push_back(clusters[0][i]);
		cout << temp_int << endl;
	}
}

void initializer(int k) {
	for (int i = 0; i < k; i++) {
		clusters[0][i].x = rand() % 100;
		clusters[0][i].y = rand() % 100;
	}
}

float distance(cluster C1, cluster C2) {
	return sqrt((C1.x - C2.x) ^ 2 + (C1.y - C2.y) ^ 2);
}

cluster average(vector<cluster> D) {
	cluster avg;
	cluster null;
	for (int i = 1; i < D.size(); i++) {
		avg.x = avg.x + D[i].x;
		avg.y = avg.x + D[i].y;
	}
	if (D.size() == 1) return null;
	avg.x = avg.x / (D.size() - 1);
	avg.y = avg.y / (D.size() - 1);
//	cout <<"avg is "<< avg.x << " " << avg.y << " size is "<< D.size() << endl;
	return avg;
}
