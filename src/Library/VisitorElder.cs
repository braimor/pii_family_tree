using System;
namespace Library
{
    public class VisitorElder : Visitor
    {
        public Person ElderChildren {get; set;}
        public int age {get; set;}
        public override string Content()
        {
            return ElderChildren.name;
        }
        public override void Visit(Person person)
        {
            if (age < person.age)
            {
                age = person.age;
                ElderChildren = person;
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