using Extension_Methods;

internal class Program {

    static void Main(string[] args) {

        //var str = "This is a test.";

        //str.Debug("str is");

        //var i = 12;
        //i.Debug("i is ");

        //i.Cubed().Debug("I cubed");

        //i.Func().Debug($"f({i}) = ");

        var cust = new Customer {
            Id = 1, Name = "TQL",
            City = "Cincinnati", StateCode = "OH",
            Sales = 1000000
        };
        cust.Debug("TQL");
    }
}
