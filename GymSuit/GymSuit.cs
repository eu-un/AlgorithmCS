/*
테스트 1 〉	통과 (0.30ms, 31.7MB)
테스트 2 〉	통과 (0.28ms, 31.7MB)
테스트 3 〉	통과 (0.27ms, 31.5MB)
테스트 4 〉	통과 (0.28ms, 31.6MB)
테스트 5 〉	통과 (0.27ms, 31.5MB)
테스트 6 〉	통과 (0.28ms, 31.5MB)
테스트 7 〉	통과 (0.35ms, 31.5MB)
테스트 8 〉	통과 (0.29ms, 31.8MB)
테스트 9 〉	통과 (0.27ms, 31.6MB)
테스트 10 〉	통과 (0.28ms, 31.5MB)
테스트 11 〉	통과 (0.30ms, 31.3MB)
테스트 12 〉	통과 (0.29ms, 31.6MB)
테스트 13 〉	통과 (0.29ms, 31.5MB)
테스트 14 〉	통과 (0.29ms, 31.4MB)
테스트 15 〉	통과 (0.28ms, 31.6MB)
테스트 16 〉	통과 (0.48ms, 31.6MB)
테스트 17 〉	통과 (0.28ms, 31.7MB)
테스트 18 〉	통과 (0.29ms, 31.8MB)
테스트 19 〉	통과 (0.28ms, 31.5MB)
테스트 20 〉	통과 (0.28ms, 31.6MB)
*/

using System;

namespace GymSuit
{
    class GymSuit
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;
            int[] check = new int[n + 1];

            // 전체 학생이 다 가져왔다고 생각하고 1로 설정
            for (int i = 1; i <= n; i++)
                check[i] = 1;

            // 안가져온 학생은 -1 ( = 0 )
            foreach (int l in lost)
                check[l]--;

            // 여분 가져온 학생은 +1 ( = 2 )
            foreach(int r in reserve)
                check[r]++;

            for (int i = 1; i <= n; i++)
            {
                if (check[i] == 0)
                {
                    // 앞사람한테 빌리기
                    if (i - 1 >= 1 && check[i - 1] == 2)
                    {
                        check[i - 1]--;
                        check[i]++;
                    }
                    // 뒷사람한테 빌리기
                    else if (i + 1 <= n && check[i + 1] == 2)
                    {
                        check[i + 1]--;
                        check[i]++;
                    }
                }
            }

            // 체육복이 준비된 학생 수 count
            for(int i = 1; i <= n; i++)
            {
                if (check[i] >= 1)
                    answer++;
            }    

            return answer;
        }
    }
}
