namespace AppMarketingObserver
{
    public partial class FormIdeas : Form
    {
        private EventManager eventmanager;
        private AutoridadForm autoridadform;


        public FormIdeas()
        {
            InitializeComponent();

            eventmanager = new EventManager();
            autoridadform = new AutoridadForm();

            eventmanager.Suscribir(autoridadform);
            autoridadform.Show();
        }



        // Para enviar titulo y descripcion de la idea
        private void btnEnviar_Click(object sender, EventArgs e)
        {

            Idea data = new Idea()
            {

                Titulo = txtTitulo.Text,
                Descripcion = txtDesc.Text

            };

            eventmanager.Notify(data);
        }

        private void FormIdeas_Load(object sender, EventArgs e)
        {

        }
    }
}