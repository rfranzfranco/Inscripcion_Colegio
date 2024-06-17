using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class InformeController
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=RegistroColegioDB;Integrated Security=True;";

        public DataTable InformeEstFechas(DateTime fechainicio, DateTime fechafin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Ajustar el nombre de las columnas según la estructura real de tu base de datos
                string query = @"
                    SELECT est.nombre, est.ap_paterno, est.ap_materno, cu.grado, cu.paralelo
                    FROM TEstudiante est
                    INNER JOIN TComprobante comp ON est.id_estudiante = comp.id_estudiante
                    INNER JOIN TCurso cu ON cu.id_curso = comp.id_curso
                    WHERE CAST(comp.fecha_reg AS DATE) BETWEEN @fechainicio AND @fechafin
                    ORDER BY est.ap_paterno, est.ap_materno, est.nombre, cu.grado, cu.paralelo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fechainicio", fechainicio);
                    command.Parameters.AddWithValue("@fechafin", fechafin);
                    connection.Open();

                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    return table;
                }
            }
        }
    }
}

