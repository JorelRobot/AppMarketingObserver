namespace AppMarketingObserver
{
    public partial class GerenteForm : Form, Suscriptor
    {
        private EventManager eventManager;
        private int count_ideas = 0;
        public GerenteForm(EventManager _eventManager)
        {
            InitializeComponent();
            this.eventManager = _eventManager;
        }

        public void Actualizar(Idea idea)
        {
            UserControlCampaña1 card_aprobada = new UserControlCampaña1();
            card_aprobada.labelTitulo.Text = idea.Titulo;
            card_aprobada.labelIdea.Text = idea.Descripcion;
            card_aprobada.SetBounds(0, count_ideas + 80, 650, 135);
            card_aprobada.eventManager = this.eventManager;
            this.Controls.Add(card_aprobada);

            count_ideas += 150;
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

 

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}