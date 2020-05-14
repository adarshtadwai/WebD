using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;

//Time Limit Exceeded although O(n) Complexity
public class CircleOfMonsters
{
	public CircleOfMonsters()
	{
		int Q = int.Parse(Console.ReadLine());
		while(Q-- > 0)
		{
			int n = int.Parse(Console.ReadLine());
			long ans = 0;
			long[] A = new long[n];	long[] B = new long[n];
			for(int i=0;i<n;i++)
			{
				long[] inp = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray();
				A[i] = inp[0];	B[i] = inp[1];
			}
			for(int i=0;i<n;i++)
			{
				int j = (i - 1 + n) % n;
				if(A[i] > B[j])
				{
					ans += (A[i] - B[j]);
					A[i] = B[j];	
				}
			}
			Console.WriteLine(ans + A.Min());
		}
	}
}


/*
 * Accepted
 #include <bits/stdc++.h>
using namespace std;

#define ipr 			pair<int, int>
#define pb 				push_back
#define ff 				first
#define ss 				second
#define mp 				make_pair
#define fr(i, j, k) 	for (int i = j; i < k; i++)
#define rf(i, j, k) 	for (int i = j; i >= k; i--)
#define int 			long long
#define ll 				unsigned long long
#define ld 				long double
#define all(x) 			x.begin(), x.end()
#define rall(x) 		x.rbegin(), x.rend()
#define cnt_ones(x) 	__builtin_popcountll(x)
#define dbg() 			cerr << "okay" << endl;			

#define IOS                           \
	std::ios::sync_with_stdio(false); \
	cin.tie(NULL);                    \
	cout.tie(NULL);

const int inf = 1000000000000000000;
const int Maxn = 100001;
const ld pi = acos(-1);
const int mod = 998244353;

template <class T>
ostream &operator<<(ostream &out, vector<T> &A)
{
	for (auto x : A)
		out << x << " ";
	return out;
}

int32_t main(){IOS
	int Q;	cin>>Q;
	while(Q--){
		int n;	cin>>n;
		vector<int>A(n),B(n);
		fr(i,0,n)	cin>>A[i]>>B[i];
		int ans = 0;
		fr(i,0,n){
			int j = (i-1+n)%n;
			if(A[i] > B[j]){
				ans += A[i]-B[j];
				A[i] = B[j];
			}
		}
		cout << ans + *min_element(all(A)) << endl;
	}
	return 0;
}
*/
