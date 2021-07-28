// Solution to the challenge at https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

namespace CodilityChallenges
{
    using System;

    class Solution
    {
        public static int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
            {
                return A;
            }
            int[] newArray = new int[arrayLen];
            int placesToMove = K % arrayLen;
            for (int index = 0; index < A.Length; index++)
            {
                int numIndexesAfterThis = A.Length - index - 1;
                if (placesToMove > numIndexesAfterThis)
                {
                    int indentation = placesToMove - numIndexesAfterThis - 1;
                    newArray[indentation] = A[index];
                }
                else
                {
                    newArray[index + placesToMove] = A[index];
                }
            }
            return newArray;
        }

        public static void Main(string[] args)
        {
            int[] A = { 1, 1, 2, 3, 5 };
            int[] testArray = solution(A, 42); // Expected: 35112
            foreach (var item in testArray)
            {
                Console.Write(item);
            }
        }
    }
}
