namespace Trees
{
    public static class MapToArray
    {
        public static TreeNode?[] Map(TreeNode root)
        {
            TreeNode?[] result = new TreeNode[20];

            var index = 0;
            result[0] = root;
            Fill(root, index, result);
            return result;
        }

        private static void Fill(TreeNode? root, int index, TreeNode?[] array)
        {
            if (root == null) return;

            array[2 * index + 1] = root.left;
            array[2 * index + 2] = root.right;
            Fill(root.left, 2 * index + 1, array);
            Fill(root.right, 2 * index + 2, array);
        }
    }
}
