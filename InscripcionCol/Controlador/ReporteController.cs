using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class ReporteController
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=RegistroColegioDB;Integrated Security=True;";
        public DataTable ReporteEstFechas(DateTime fechainicio, DateTime fechafin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    select cu.grado,cu.paralelo,
                           count(est.id_estudiante) as cantidad_estudiantes
                    from TComprobante comp
                    inner join TEstudiante est on est.id_estudiante=comp.id_estudiante
                    inner join TCurso cu on cu.id_curso=comp.id_curso
                    where cast(comp.fecha_reg as date) between @fechainicio and @fechafin
                    group by cu.grado,cu.paralelo
                    order by cu.grado, cu.paralelo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fechainicio", fechainicio);
                    command.Parameters.AddWithValue("@fechafin", fechafin);
                    connection.Open();

                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
