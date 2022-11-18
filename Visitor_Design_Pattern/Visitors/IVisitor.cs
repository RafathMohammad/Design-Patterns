namespace Visitor_Design_Pattern
{
    public interface IVisitor
    {
        void Visit(Patient patient);  //we're calling `Visit', which matches the
                                      // current class name. This way we let the visitor know the class of the
                                      // component it works with.
    }
}
