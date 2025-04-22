namespace SharpTeach
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();//new comment in our branch!!!
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}