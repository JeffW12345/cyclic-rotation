# Python solution to the challenge at https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

def solution(A, K):
    if len(A) == 0:
        return A
    array_of_nums = A
    num_rotations = K
    num_rotations = num_rotations % len(array_of_nums)
    for i in range(num_rotations):
        array_of_nums = move_by_one(array_of_nums)
    return array_of_nums


def move_by_one(arr):
    final_entry = arr[-1]
    del arr[-1]
    arr.insert(0, final_entry)
    return arr


A = [1, 2, 3, 4]
K = 5
print(solution(A, K))  # Should be [4, 1, 2, 3]
