using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FARMACIA.BLL
{
    internal class SucursalBLL
    {
        /*(<id_farmacia, char(5),>
           ,<nombre_farm, varchar(100),>
           ,<calle_farm, varchar(100),>
           ,<no_exterior_farm, varchar(6),>
           ,<no_interior_farm, varchar(4),>
           ,<colonia_farm, varchar(100),>
           ,<CP_FARM, varchar(7),>
           ,<id_propietario, varchar(10),>
           ,<id_ciudad, varchar(10),>)*/

        public int id_farm;
        public string nombre_farm;
        public string calle_farm;
        public int no_exterior_farm;
        public string no_interior_farm;
        public string colonia_farm;
        public int CP_farm;
        public int id_propi_farm;
        public int id_Ciudad_farm;
    }
}
