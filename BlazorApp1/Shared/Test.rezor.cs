using BlazorApp1.Data;

namespace BlazorApp1.Shared
{
    public partial class Test
    {
        private bool emailShow = false;
        public List<People> humans;

        private Dictionary<string, object> keys = new Dictionary<string, object>()
    {
       { "placeholder", "Name" },
       {"type", "text"}

    };
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3000);
            humans = new List<People>()
        {
            new People{Name="Asilbek", Job="Doctor", Age =20,Email="asilbek@gmil.com" },
            new People{Name="Avazbek", Job="Xacer", Age=34, Email="weraee@yahoo.com" },
            new People{Name="Ali", Job="Student", Age=22, Email="ali@mail.com" }
        };

            base.OnInitializedAsync();
        }
    }
}
