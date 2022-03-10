namespace AppMarketingObserver
{
    public partial class GerenteForm : Form, Suscriptor
    {
        private EventManager eventManager;
        public GerenteForm(EventManager _eventManager)
        {
            InitializeComponent();
            this.eventManager = _eventManager;
        }
        //Boton de Aceptar
        private void button1_Click(object sender, EventArgs e)
        {
            eventManager.Suscribir(this);
        }
        //Boton de Rechazar
        private void BtnRechazar_Click(object sender, EventArgs e)
        {
            eventManager.Desuscribir(this);
        }

        public void Actualizar(Idea data)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}