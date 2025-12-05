using PenanoJanBert.View;

namespace PenanoJanBert
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();


            Routing.RegisterRoute("main", typeof(Main));
        }


    }
}
