using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi
{

    public class Publicacion
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Megusta { get; set; }
        public int MeDiscusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivada { get; set; }

        public override string ToString()
        {
            return $"id: {Id} - usuario: {Usuario}-descripcion: {Descripcion} - fechaPublicacion: {FechaPublicacion}" +
                $"megusta: {Megusta} - meDiscusta: {MeDiscusta}-vecesCompartido: {VecesCompartido} - esPrivada: {EsPrivada}";
        }
    }

}
