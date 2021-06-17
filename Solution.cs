// Solution to the challenge at https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

namespace CodilityChallenges
{
    using System;

    class Solution
    {
        public static int[] solution(int[] A, int K)
        {
            int arrayLen = A.Length;
            if (A.Length == 0)
            {
                return A;
            }
            int[] newArray = new int[arrayLen];
            int placesToMove = K > arrayLen ? K % arrayLen : K;
            for (int index = 0; index < arrayLen; index++)
            {
                int newPosition = (index + placesToMove) > arrayLen - 1 ? placesToMove - ((arrayLen - 1) - index) - 1 : index + placesToMove;
                newArray[newPosition] = A[index];
            }
            return newArray;
        }

        public static void Main(string[] args)
        {
            int[] A = { 1, 1, 2, 3, 5};
            int [] C = solution(A, 42);
            // Expected: 35112
            foreach (var item in C)
            {
                Console.Write(item);
            }
        }
    }
}
