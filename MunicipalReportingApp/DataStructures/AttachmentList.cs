using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalReportingApp
{
    public class AttachmentNode
    {
        public string FileName;
        public AttachmentNode Next;
        public AttachmentNode(string fileName) { FileName = fileName; }
    }

    public class AttachmentList
    {
        private AttachmentNode head, tail;
        private int count;

        public void Add(string fileName)
        {
            var node = new AttachmentNode(fileName);
            if (head == null) head = tail = node;
            else { tail.Next = node; tail = node; }
            count++;
        }

        public int Count() => count;

        public void ForEach(System.Action<string> action)
        {
            var cur = head;
            while (cur != null) { action(cur.FileName); cur = cur.Next; }
        }

        // Helper for UI labels (no arrays, no List)
        public string ToDelimitedString(string sep)
        {
            var sb = new StringBuilder();
            var cur = head;
            while (cur != null)
            {
                sb.Append(cur.FileName);
                if (cur.Next != null) sb.Append(sep);
                cur = cur.Next;
            }
            return sb.ToString();
        }
    }
}