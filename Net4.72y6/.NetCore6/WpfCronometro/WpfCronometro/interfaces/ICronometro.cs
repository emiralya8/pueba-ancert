using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WpfCronometro.interfaces
{
    public interface ICronometro
    {
        public void start();
        public void stop();
        public void pause();
        public void setLabel(Label lbl);

    }
}
