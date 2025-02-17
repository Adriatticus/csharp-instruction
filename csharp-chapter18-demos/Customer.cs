using System.Xml.Linq;

namespace csharp_chapter18_demos;

public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; } = "";

    public override string ToString()
    {
        return $"Customer: ({CustomerID})|{Name}";
    }
}

