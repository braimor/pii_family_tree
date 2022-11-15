using System;
namespace Library
{
    public class VisitorLargerName : Visitor
    {
        public Person LargerNameChildren {get; set;}
        public string name {get; set;} = "A";
        public override string Content()
        {
            return LargerNameChildren.name;
        }
        public override void Visit(Person person)
        {
            if (name.Length < person.name.Length)
            {
                name = person.name;
                LargerNameChildren = person;
            }
        }

        public override void Visit(Node node)
        {
            foreach (var children in node.children)
            {
                children.Accept(this);
                Visit(children.person);
            }
        }
    }
}