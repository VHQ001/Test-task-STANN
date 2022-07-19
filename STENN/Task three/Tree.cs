using System.Collections.Generic;

namespace Task_three
{
    public class Tree
    {
        public string Name { get; set; }

        public IEnumerable<Tree> Children { get; set; }
    }
}
