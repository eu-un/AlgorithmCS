/*
테스트 1 〉	통과 (0.63ms, 31.2MB)
테스트 2 〉	통과 (0.70ms, 31.5MB)
테스트 3 〉	통과 (0.72ms, 31.3MB)
테스트 4 〉	통과 (0.82ms, 31.2MB)
테스트 5 〉	통과 (0.61ms, 31.3MB)
테스트 6 〉	통과 (0.64ms, 31.4MB)
테스트 7 〉	통과 (0.69ms, 31.2MB)
테스트 8 〉	통과 (0.69ms, 31.5MB)
테스트 9 〉	통과 (0.77ms, 31.5MB)
테스트 10 〉	통과 (0.68ms, 31.4MB)
테스트 11 〉	통과 (0.79ms, 31.1MB)
테스트 12 〉	통과 (0.83ms, 31.4MB)
테스트 13 〉	통과 (0.62ms, 31.2MB)
테스트 14 〉	통과 (0.70ms, 31.2MB) 
*/

using System;
using System.Collections.Generic;

namespace MockTest
{
    class MockTest
    {
        public int[] solution(int[] answers)
        {           
            int[] student1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] student2 = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] student3 = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] score = new int[3] { 0, 0, 0 };

            // 답이 맞았을 경우 각 학생들의 점수 +1 점
            for(int i = 0; i < answers.Length; i++)
            {
                if (student1[i % 5] == answers[i]) score[0]++;
                if (student2[i % 8] == answers[i]) score[1]++;
                if (student3[i % 10] == answers[i]) score[2]++;
            }

            // 각 학생들의 점수를 비교하여 제일 큰 값 구하기
            int max = 0;
            for(int i = 0; i < score.Length; i++)            
                if (max < score[i]) max = score[i];

            // max의 값이 같은 학생들을 list에 담기
            List<int> list = new List<int>();
            for(int i = 0; i < score.Length; i++)            
                if (max == score[i]) list.Add(i + 1);

            return list.ToArray();
        }
    }
}
