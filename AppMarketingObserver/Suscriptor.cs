using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMarketingObserver
{
    public interface Suscriptor
    {
        public void Actualizar(Idea data);
    }
}
