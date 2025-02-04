using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public unsafe class BST
    {
        static BstNode* Root =  null; //(Node*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Node)));

        private static void Insert (BstNode** node, uint data)
        {
            if (*node == null)
            {
                *node = (BstNode*)Marshal.AllocHGlobal (Marshal.SizeOf (typeof (BstNode)));
                (*node)->Data = data;
                (*node)->Left = null;
                (*node)->Right = null;

                return;
            }

            if (data <= (*node)->Data)
            {
                Insert(&(*node)->Left, data);
            }
            else
            {
                Insert (&(*node)->Right, data);
            }

        }

        static private bool Search(BstNode* node, uint data)
        {
            bool result;

            if (node == null)
            {
                return false;
            }
            else if (data == node->Data) 
                return true;

            if (data <= node->Data)
                result = Search(node->Left, data);
            else
                result = Search(node->Right, data);

            return result;
        }

        static private bool Delete(BstNode** node, BstNode* parent,uint data)
        {
            if (*node == null)
            {
                return false;
            }
            else if (data == (*node)->Data)
            {
                (*node)->Right->Left = (*node)->Left;
                *node = (*node)->Right;
            }

            if (data <= (*node)->Data)
            {
                return Delete(&(*node)->Left, parent,data);
            }
            else
            {
                return Delete (&(*node)->Right, parent, data);
            }
                   
        }

        static public void InsertTree (uint data)
        {
            fixed (BstNode** ppNode = &Root)
            {
                Insert(ppNode, data);
            }
        }

        static public bool SearchTree (uint data)
        {
           return Search (Root, data); 
        }

        static public void DeleteDataFromTree (uint data)
        {
            fixed(BstNode** ppRoot = &Root)
                Delete(ppRoot,Root,data);
        }
    }


}

unsafe struct BstNode
{
    public uint Data;
    public BstNode* Left;
    public BstNode* Right;
}
