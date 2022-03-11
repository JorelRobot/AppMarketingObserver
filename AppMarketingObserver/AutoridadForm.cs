namespace AppMarketingObserver
{
    public partial class AutoridadForm : Form, Suscriptor
    {
        private EventManager eventManager;
        private GerenteForm gerenteForm;
        private int count_ideas = 0;

        public AutoridadForm()
        {
            InitializeComponent();

            eventManager = new EventManager();
            gerenteForm = new GerenteForm(eventManager);

            eventManager.Suscribir(gerenteForm);
            gerenteForm.Show();
        }

        public EventManager getGerenteEventManager()
        {
            return gerenteForm.GetEventManager();
        }

        public void Actualizar(Idea idea)
        {
            UCIdea card_idea = new UCIdea();
            card_idea.labelIdeaTitulo.Text = idea.Titulo;
            card_idea.labelIdeaDescripcion.Text = idea.Descripcion;
            card_idea.labelIdeaEstatus.Text = "Pendiente";
            card_idea.SetBounds(0, count_ideas + 80, 650, 135);
            card_idea.eventManager = this.eventManager;
            mainFlowLayoutPanel.Controls.Add(card_idea);

            count_ideas += 150;
        }
    }
}