using System.Collections.Generic;
using System.Linq;

namespace Task_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static IEnumerable<string> GetNames(Tree tree)
        {
            yield return tree.Name;

            if (tree.Children == null || !tree.Children.Any())
                yield break;


            var names = GetNames(tree.Children);
            foreach (var name in names)
                yield return name;
        }

        private static IEnumerable<string> GetNames(IEnumerable<Tree> trees)
        {
            foreach (var tree in trees)
            {
                var names = GetNames(tree);
                foreach (var name in names)
                    yield return name;
            }
        }
    }
}
