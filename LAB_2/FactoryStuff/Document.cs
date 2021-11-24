using System;
using System.Collections.Generic;
using System.Text;

namespace patterns
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }

        public abstract void CreatePages();


        public void ListPages()
        {
            
                Console.WriteLine("\n" + this.GetType().Name + "--");
                foreach (Page page in _pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }

        }
    }
}
