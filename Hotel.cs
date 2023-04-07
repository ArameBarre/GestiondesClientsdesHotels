using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiondesClientsdansunHotel
{
    internal class Hotel
    {
        public ArrayList Client { get; set; }

       
public Hotel()
        {
            Client = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            Client.Add(client);
        }
    }

}
}
