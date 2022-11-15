using System;
namespace Library
{
    public class VisitorAge : Visitor
    {
        public int totalAge {get; set;} 
        public VisitorAge()
        {
            this.totalAge= 0;
        }
        public override string Content()
        {
          return totalAge.ToString();
        }
    
        public override void Visit(Person person)
        {
            totalAge += person.age;
        }
        public override void Visit(Node node)
        {   
            Visit(node.person);
            foreach (var children in node.children)
            {
                children.Accept(this);
            }
        }
    }
}