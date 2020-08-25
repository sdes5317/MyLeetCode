using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Solutions
{
    public class _108_ConvertSortedArraytoBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return GetTreeNode(nums, 0, nums.Length - 1);
        }

        public TreeNode GetTreeNode(int[] nums, int left, int right)
        {
            if (left > right) return null;
            var mid = left + (right - left) / 2;

            return new TreeNode(nums[mid], GetTreeNode(nums, left, mid - 1), GetTreeNode(nums, mid + 1, right));
        }
    }

}
