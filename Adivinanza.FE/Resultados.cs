using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanza.Back
{
    public class Resultados
    {
        public DataTable ResultadosDT { get; set; } = new DataTable();

        public Resultados()
        {
            ResultadosDT.TableName = "Historial de Partidas";
            ResultadosDT.Columns.Add("Id", typeof(int));
            ResultadosDT.Columns.Add("Nombre");
            ResultadosDT.Columns.Add("Numero adivinado", typeof(int));
            ResultadosDT.Columns.Add("Cantidad de intentos", typeof(int));
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Resultados.xml"))
            {
                ResultadosDT.ReadXml("Resultados.xml");
            }
        }

        public void InsertarResultado(Resultado resultado)
        {
            int id = NuevoId();

            ResultadosDT.Rows.Add(); 
            int NuevoRenglon = ResultadosDT.Rows.Count - 1;
            ResultadosDT.Rows[NuevoRenglon]["Id"] = id;
            ResultadosDT.Rows[NuevoRenglon]["Nombre"] = resultado.nombre;
            ResultadosDT.Rows[NuevoRenglon]["Numero adivinado"] = resultado.numadiv;
            ResultadosDT.Rows[NuevoRenglon]["Cantidad de intentos"] = resultado.intentos;

            ResultadosDT.WriteXml("Resultados.xml");
        }

        private int NuevoId()
        {
            int NuevoId = 0;

            foreach (DataRow fila in ResultadosDT.Rows)
            {
                if (NuevoId < Convert.ToInt32(fila["Id"]))
                {
                    NuevoId = Convert.ToInt32(fila["Id"]);
                }
            }

            NuevoId++;
            return NuevoId;
        }
    }
}
