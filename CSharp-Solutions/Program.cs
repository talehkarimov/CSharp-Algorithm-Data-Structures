using CSharp_Solutions.DataStructures;
using CSharp_Solutions.Solutions;

var tree = new BstTree<int>();
var invert = new InvertBinaryTree();

tree.Insert(4);
tree.Insert(2);
tree.Insert(7);
tree.Insert(1);
tree.Insert(3);
tree.Insert(6);
tree.Insert(9);

var test = invert.InvertTree(tree.Root);
Console.WriteLine(test);

