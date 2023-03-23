using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronometroApp.interfaces
{
    public interface ICronometro
    {
        void setLabel(Label lbl);
        Label getLabel();
        void Start();
        void Stop();
        void Pause();
    }
}
