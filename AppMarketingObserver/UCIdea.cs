using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMarketingObserver
{
    public partial class UCIdea : UserControl
    {
        public EventManager eventManager { get; set; }

        public UCIdea()
        {
            InitializeComponent();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            labelIdeaEstatus.Text = "Aprobado";

            Idea data = new Idea()
            {
                Titulo = labelIdeaTitulo.Text,
                Descripcion = labelIdeaDescripcion.Text
            };

            eventManager.Notify(data);
        }
    }
}
