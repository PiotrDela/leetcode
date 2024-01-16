namespace LeetCode.Solutions;

public class _88_Merge_Sorted_Array
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var nums = new int[m];
        for (int ii = 0; ii < m; ii++)
        {
            nums[ii] = nums1[ii];
        }
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < m && j < n)
        {
            if (nums[i] < nums2[j])
            {
                nums1[k] = nums[i];
                i++;
                k++;
            }
            else
            {
                nums1[k] = nums2[j];
                j++;
                k++;
            }
        }
        while (i < m)
        {
            nums1[k] = nums[i];
            i++;
            k++;
        }

        while (j < n)
        {
            nums1[k] = nums2[j];
            j++;
            k++;
        }
    }
}
