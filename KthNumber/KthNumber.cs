using System;

namespace KthNumber
{
    class KthNumber
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];

            // commands 배열의 행 개수만큼 for문
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                // 임시 배열 생성 ( 잘라서 담아줘야 할 값들을 위해 )
                int tempArrLength = commands[i, 1] - commands[i, 0] + 1;
                int[] tempArr = new int[tempArrLength];

                for (int j = 0; j < tempArrLength; j++)
                    tempArr[j] = array[commands[i, 0] - 1 + j];

                Array.Sort(tempArr); // 정렬            
                answer[i] = tempArr[commands[i, 2] - 1];
            }
            return answer;
        }
    }
}
