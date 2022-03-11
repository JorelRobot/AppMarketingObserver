namespace AppMarketingObserver
{
    public partial class GerenteForm : Form, Suscriptor
    {
        private EventManager eventManager;
        private EventManager gerenteEventManager;
        private int count_ideas = 0;

        public GerenteForm(EventManager _eventManager)
        {
            InitializeComponent();
            this.eventManager = _eventManager;
            gerenteEventManager = new EventManager();
        }

        public EventManager GetEventManager()
        {
            return gerenteEventManager;
        }

        public void Actualizar(Idea idea)
        {
            UCIdea card_idea = new UCIdea();
            card_idea.labelIdeaTitulo.Text = idea.Titulo;
            card_idea.labelIdeaDescripcion.Text = idea.Descripcion;
            card_idea.labelIdeaEstatus.Text = "Pendiente";
            card_idea.SetBounds(0, count_ideas + 80, 650, 135);
            card_idea.eventManager = this.gerenteEventManager;
            panel1.Controls.Add(card_idea);

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