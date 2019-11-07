using System;
using System.Collections.Generic;

namespace Pattern
{
    //Client Code
    //ViewGroup viewGroup1 = new ViewGroup("parrent Group");
    //View view1 = new View("View 1");
    //View view2 = new View("View 2");
    //viewGroup1.add(view1);
    //        viewGroup1.add(view2);

    //        ViewGroup viewGroup2 = new ViewGroup("child Group");
    //viewGroup2.add(new View("level 2 child"));
    //        viewGroup1.add(viewGroup2);

    //        viewGroup1.paint();


    public abstract class UIWidget
    {
        public String id;
        public UIWidget(string id)
        {
            this.id = id;
        }
        public abstract void paint();
    }

    public class View : UIWidget
    {
        //String id;
        public View(string id) : base(id)
        {


        }
        public override void paint()
        {
            Console.WriteLine("Paint " + this.id);
        }
    }

    public class ViewGroup : UIWidget
    {
        List<UIWidget> children = new List<UIWidget>();
        public ViewGroup(string id) : base(id)
        {

        }
        public void add(UIWidget child)
        {
            children.Add(child);
        }

        public override void paint()
        {
            Console.WriteLine("Paint " + this.id);
            foreach (UIWidget child in children)
            {
                child.paint();
            }
        }
    }
}
