using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMarketingObserver
{
    public class EventManager
    {
        private List<Suscriptor> listeners = new List<Suscriptor>();

        public void Suscribir(Suscriptor listener)
        {
            listeners.Add(listener);
        }

        public void Desuscribir(Suscriptor listener)
        {
            listeners.Add(listener);
        }

        public void Notify(Idea data) {
            foreach (Suscriptor listener in listeners) {
                listener.Actualizar(data);
            }
        }
    }
}
