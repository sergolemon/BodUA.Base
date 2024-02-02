namespace WebApp.Pages.Catalog
{
    public partial class Catalog
    {
        List<string> TestDivClasses { get; }

        public Catalog()
        {
            TestDivClasses = new();
        }

        void ToggleClass()
        {
            if (TestDivClasses.Contains("active"))
            {
                TestDivClasses.Remove("active");
            }
            else
            {
                TestDivClasses.Add("active");
            }
        }
    }
}
