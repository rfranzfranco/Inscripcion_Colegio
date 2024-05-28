using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionCol.Modelo;
using InscripcionCol.Controlador;
using InscripcionCol.Vista;

namespace InscripcionCol
{
    public partial class frmRegistrarEst : Form
    {
        EstudianteController estudianteController = new EstudianteController();
        private frmestudiante _frmestudiante;
        public frmRegistrarEst(frmestudiante frmEstudiante)
        {
            InitializeComponent();
            _frmestudiante = frmEstudiante;
            
        }    

        TEstudiante estudiante = new TEstudiante();
        TNacimiento nacimiento = new TNacimiento();
        TDireccion direccion = new TDireccion();
        TContacto contacto = new TContacto();
        TTutor tutor = new TTutor();
        TCurso curso = new TCurso();
        TComprobante comp = new TComprobante();
        TTutor_Est tutor_Est = new TTutor_Est();
        TDir_Est dir_Est=new TDir_Est();
        
        public void asignarCurso()
        {
            Random rnd = new Random();
            int minCurso, maxCurso;

            switch (estudiante.grado_sec)
            {
                case 1:
                    minCurso = 1;
                    maxCurso = 5;
                    break;
                case 2:
                    minCurso = 6;
                    maxCurso = 10;
                    break;
                case 3:
                    minCurso = 11;
                    maxCurso = 15;
                    break;
                case 4:
                    minCurso = 16;
                    maxCurso = 20;
                    break;
                case 5:
                    minCurso = 21;
                    maxCurso = 25;
                    break;
                case 6:
                    minCurso = 26;
                    maxCurso = 30;
                    break;
                default:
                    throw new InvalidOperationException("Grado no válido");
            }

            comp.id_curso = rnd.Next(minCurso, maxCurso + 1);
        }
        private async void btn_guardar_Click(object sender, EventArgs e)
        {
            if(txt_appaterno.Text==""||txt_apmaterno.Text==""||txt_nombre.Text==""||txt_ci.Text==""||txt_rude.Text==""||
                txt_exp.Text==""||txt_compl.Text==""||cbx_escol.Text==""||txt_paisNac.Text==""||txt_dptoNac.Text==""||
                txt_provinciaNac.Text==""||txt_localidadNac.Text==""||cbx_dptoAct.Text==""||txt_provinciaAct.Text==""||
                txt_municipioAct.Text==""||txt_localidadAct.Text==""||txt_zonaAct.Text==""||txt_avenAct.Text==""||
                txt_num.Text==""||txt_telefono.Text==""||txt_cel.Text==""||txt_ciTutor.Text==""||txt_appaternoTutor.Text==""||
                txt_apmaternoTutor.Text==""||txt_nombreTutor.Text==""||txt_complTutor.Text==""||txt_expTutor.Text==""||
                txt_dptoComprob.Text=="")
            { 
                MessageBox.Show("Existen campos vacios","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            try
            {                
                estudiante.ap_paterno = txt_appaterno.Text;
                estudiante.ap_materno = txt_apmaterno.Text;
                estudiante.nombre = txt_nombre.Text;
                estudiante.ci = Convert.ToInt32(txt_ci.Text);
                estudiante.complemento = txt_compl.Text;
                estudiante.expedido = txt_exp.Text;
                estudiante.codigo_rude = txt_rude.Text;
                string genero;
                if (rbtmasculino.Checked == true)
                {
                    genero = "M";
                }
                else
                {
                    genero = "F";
                }
                estudiante.sexo = genero;
                estudiante.fec_nacimiento = date_nac.Value.Date;
                estudiante.grado_sec=Convert.ToInt32(cbx_escol.Text);
                bool estudianteRegistrado = await estudianteController.RegistrarEstudianteAsync(estudiante);

                if(estudianteRegistrado)
                {                                    
                    nacimiento.id_estudiante = estudiante.id_estudiante;
                    nacimiento.pais = txt_paisNac.Text;
                    nacimiento.provincia = txt_provinciaNac.Text;
                    nacimiento.dpto = txt_dptoNac.Text;
                    nacimiento.localidad = txt_localidadNac.Text;
                    await estudianteController.RegistrarNacimientoAsync(nacimiento);
                                        
                    direccion.dpto = cbx_dptoAct.Text;
                    direccion.provincia = txt_provinciaAct.Text;
                    direccion.municipio = txt_municipioAct.Text;
                    direccion.localidad = txt_localidadAct.Text;
                    direccion.zona=txt_zonaAct.Text;
                    direccion.avenida=txt_avenAct.Text;
                    direccion.nro_vivienda = txt_num.Text;
                    await estudianteController.RegistrarDireccionAsync(direccion);

                    dir_Est.id_estudiante = estudiante.id_estudiante;
                    dir_Est.id_direccion = direccion.id_direccion;
                    await estudianteController.RegistrarDir_EstAsync(dir_Est);

                    contacto.id_direccion=direccion.id_direccion;
                    contacto.telefono_fijo = Convert.ToInt32(txt_telefono.Text);
                    contacto.celular = Convert.ToInt32(txt_cel.Text);
                    await estudianteController.RegistrarContactoAsync(contacto);

                    tutor.ci = Convert.ToInt32(txt_ciTutor.Text);
                    tutor.complemento = txt_complTutor.Text;
                    tutor.expedido = txt_expTutor.Text;
                    tutor.ap_paterno = txt_appaternoTutor.Text;
                    tutor.ap_materno = txt_apmaternoTutor.Text;
                    tutor.nombre = txt_nombreTutor.Text;
                    await estudianteController.RegistrarTutorAsync(tutor);

                    tutor_Est.id_estudiante=estudiante.id_estudiante;
                    tutor_Est.id_tutor=tutor.id_tutor;
                    await estudianteController.RegistrarTutor_EstAsync(tutor_Est);

                    comp.id_estudiante = estudiante.id_estudiante;
                    comp.id_tutor=tutor.id_tutor;
                    comp.lugar_dpto = txt_dptoComprob.Text;
                    comp.fecha_reg = date_regComprob.Value.Date;
                    asignarCurso();
                    await estudianteController.RegistrarComprobanteAsync(comp);

                    MessageBox.Show("Se ha registrado el estudiante con exito","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _frmestudiante.cargar();
                }
                else
                {
                    MessageBox.Show("Error al registrar el estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public TextBox txtci => txt_ci;
        public TextBox txtrude=>txt_rude;
        public TextBox txtapPaterno => txt_appaterno;
        public TextBox txtnombre => txt_nombre;
        public ComboBox txtgrado => cbx_escol;

        private void frmRegistrarEst_Load(object sender, EventArgs e)
        {

        }
    }
}
