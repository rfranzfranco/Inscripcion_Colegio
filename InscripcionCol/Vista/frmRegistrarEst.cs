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
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace InscripcionCol
{
    public partial class frmRegistrarEst : Form
    {
        private readonly RegistroColegioDBEntities _db = new RegistroColegioDBEntities();
        private readonly EstudianteController _estudianteController;
        private readonly frmestudiante _frmestudiante;
        private EstudianteViewModel _estudianteSeleccionado;
        public frmRegistrarEst(frmestudiante frmEstudiante, EstudianteController estudianteController)
        {
            InitializeComponent();
            _frmestudiante = frmEstudiante;
            _estudianteController = estudianteController;

            cbx_paisNac.SelectedIndexChanged += cbx_paisNac_SelectedIndexChanged;
            cbx_dptoNac.SelectedIndexChanged += cbx_dptoNac_SelectedIndexChanged;
            cbx_provNac.SelectedIndexChanged += cbx_provNac_SelectedIndexChanged;

            cbx_dptoAct.SelectedIndexChanged += cbx_dptoAct_SelectedIndexChanged;
            cbx_provAct.SelectedIndexChanged += cbx_provAct_SelectedIndexChanged;
            cbx_munAct.SelectedIndexChanged += cbx_provAct_SelectedIndexChanged;
        }
        private List<Ubicacion> ObtenerDatos()
        {
            return new List<Ubicacion>
            {
                new Ubicacion
                {
                    Nombre = "Bolivia",
                    SubUbicaciones = new List<Ubicacion>
                    {                        
                        new Ubicacion
                        {
                            Nombre = "La Paz",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Aroma",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Sica Sica"},
                                        new Ubicacion{Nombre="Ayo Ayo"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bautista Saavedra",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Charazani"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Camacho",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Puerto Acosta"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Caranavi",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Caranavi"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Eliodoro Camacho",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Puerto Acosta"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Franz Tamayo",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Apolo"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Gualberto Villarroel",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Pedro de Curahuara"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ingavi",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Viacha"},
                                        new Ubicacion{Nombre="Guaqui"},
                                        new Ubicacion{Nombre="Desaguadero"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Inquisivi",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Inquisivi"},
                                        new Ubicacion{Nombre="Quime"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José Manuel Pando",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Santiago de Machaca"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Larecaja",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Sorata"},
                                        new Ubicacion{Nombre="Guanay"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Loayza",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Luribay"},
                                        new Ubicacion{Nombre="Malla"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Los Andes",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Pucarani"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Manco Kapac",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Copacabana"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Muñecas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Chuma"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Nor Yungas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Coroico"},
                                        new Ubicacion{Nombre="Chulumani"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Omasuyos",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Achacachi"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pacajes",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Coro Coro"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pedro Domingo Murillo",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="La Paz"},
                                        new Ubicacion{Nombre="El Alto"},
                                        new Ubicacion{Nombre="Mecapaca"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sud Yungas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Chulumani"},
                                        new Ubicacion{Nombre="Irupana"}
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Oruro",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Atahuallpa",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Challapata"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Carangas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Corque"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cercado",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Oruro"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Eduardo Avaroa",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Challapata"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ladislao Cabrera",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Salinas de Garci Mendoza"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Litoral",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Huachacalla"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Nor Carangas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Huayllamarca"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pantaleón Dalence",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Huanuni"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Poopó",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Poopó"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sajama",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Curahuara de Carangas"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Pedro de Totora",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Totora"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Saucarí",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Toledo"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sebastián Pagador",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Santiago de Huari"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sud Carangas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Andamarca"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tomás Barrón",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Eucaliptus"}
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cochabamba",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Arani",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Arani"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Arque",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Arque"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ayopaya",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Ayopaya"},
                                        new Ubicacion{Nombre="Cocapata"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bolívar",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Bolívar"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Capinota",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Capinota"},
                                        new Ubicacion{Nombre="Sicaya"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Carrasco",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Totora"},
                                        new Ubicacion{Nombre="Pojo"},
                                        new Ubicacion{Nombre="Pocona"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cercado",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Cochabamba"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Chapare",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Villa Tunari"},
                                        new Ubicacion{Nombre="Chimoré"},
                                        new Ubicacion{Nombre="Ivirgarzama"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Esteban Arce",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Tarata"},
                                        new Ubicacion{Nombre="Anzaldo"},
                                        new Ubicacion{Nombre="Arbieto"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Germán Jordán",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Cliza"},
                                        new Ubicacion{Nombre="Toco"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Mizque",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Mizque"},
                                        new Ubicacion{Nombre="Vila Vila"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Punata",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Punata"},
                                        new Ubicacion{Nombre="Villa Rivero"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Quillacollo",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Quillacollo"},
                                        new Ubicacion{Nombre="Vinto"},
                                        new Ubicacion{Nombre="Colcapirhua"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tapacarí",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Tapacarí"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tiraque",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Tiraque"}
                                    }
                                }                                
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Santa Cruz",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Andrés Ibáñez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Santa Cruz de la Sierra"},
                                        new Ubicacion{Nombre="Cotoca"},
                                        new Ubicacion{Nombre="La Guardia"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ángel Sandoval",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Matías"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Chiquitos",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San José de Chiquitos"},
                                        new Ubicacion{Nombre="Roboré"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cordillera",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Camiri"},
                                        new Ubicacion{Nombre="Charagua"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Florida",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Samaipata"},
                                        new Ubicacion{Nombre="Mairana"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Germán Busch",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Puerto Suárez"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Guarayos",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Ascención de Guarayos"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ichilo",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Buena Vista"},
                                        new Ubicacion{Nombre="Yapacaní"}

                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ignacio Warnes",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Warnes"},
                                        new Ubicacion{Nombre="Montero"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José Miguel de Velasco",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Ignacio de Velasco"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Manuel María Caballero",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Comarapa"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ñuflo de Chávez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Concepción"},
                                        new Ubicacion{Nombre="San Javier"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Obispo Santistevan",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Montero"},
                                        new Ubicacion{Nombre="Mineros"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sara",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Portachuelo"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Vallegrande",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Vallegrande"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Warnes",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Warnes"}
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Potosí",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Alonso de Ibáñez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Sacaca"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Antonio Quijarro",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Uyuni"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bernardino Bilbao",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Arampampa"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Charcas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Pedro de Buena Vista"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Chayanta",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Llallagua"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cornelio Saavedra",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Betanzos"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Daniel Campos",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Llica"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Enrique Baldivieso",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Agustín"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José María Linares",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Puna"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Modesto Omiste",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Villazón"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Nor Chichas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Cotagaita"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Nor Lípez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Colcha K"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Rafael Bustillo",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Uncía"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sud Chichas",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Tupiza"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sud Lípez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Pablo de Lípez"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tomás Frías",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Potosí"}
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Pando",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Abuná",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Santa Rosa del Abuná"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Federico Román",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Villa Nueva"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Madre de Dios",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Puerto Gonzalo Moreno"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Manuripi",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Puerto Rico"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Nicolás Suárez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Cobija"},
                                        new Ubicacion{Nombre="Porvenir"}
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Beni",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Cercado",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Trinidad"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Antonio Vaca Díez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Riberalta"},
                                        new Ubicacion{Nombre="Guayaramerín"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ballivián",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Reyes"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Iténez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Magdalena"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José Ballivián",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Borja"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Mamoré",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Joaquín"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Marbán",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Loreto"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Moxos",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Ignacio de Moxos"},
                                        new Ubicacion{Nombre="San Javier"}
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Chuquisaca",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Azurduy",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Azurduy"},
                                        new Ubicacion{Nombre="Tarvita"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Belisario Boeto",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Villa Serrano"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Hernando Siles",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Monteagudo"},
                                        new Ubicacion{Nombre="Padilla"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Jaime Zudáñez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Zudáñez"},
                                        new Ubicacion{Nombre="Tomina"},
                                        new Ubicacion{Nombre="Icla"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Luis Calvo",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Villa Vaca Guzmán"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Nor Cinti",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Camargo"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Oropeza",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Sucre"},
                                        new Ubicacion{Nombre="Yotala"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sud Cinti",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Culpina"},
                                        new Ubicacion{Nombre="Villa Charcas"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tomina",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Padilla"},
                                        new Ubicacion{Nombre="El Villar"},
                                        new Ubicacion{Nombre="Presto"},
                                        new Ubicacion{Nombre="Villa Alcalá"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Yamparáez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Tarabuco"},
                                        new Ubicacion{Nombre="Yamparáez"}
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Tarija",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Aniceto Arce",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Padcaya"},
                                        new Ubicacion{Nombre="Bermejo"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Burnet O'Connor",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Entre Ríos"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cercado",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Tarija"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Eustaquio Méndez",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="San Lorenzo"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Gran Chaco",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Yacuiba"},
                                        new Ubicacion{Nombre="Villamontes"},
                                        new Ubicacion{Nombre="Caraparí"}
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José María Avilés",
                                    SubUbicaciones=new List<Ubicacion>
                                    {
                                        new Ubicacion{Nombre="Uriondo"}
                                    }
                                }
                            }
                        }
                    }
                },
                new Ubicacion
                {
                    Nombre = "Argentina",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Buenos Aires",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Almirante Brown",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Adrogué" },
                                        new Ubicacion { Nombre = "Burzaco" },
                                        new Ubicacion { Nombre = "Glew" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Avellaneda",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Avellaneda" },
                                        new Ubicacion { Nombre = "Sarandí" },
                                        new Ubicacion { Nombre = "Wilde" }
                                    }
                                },
                                // Añadir más partidos y localidades aquí...
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Córdoba",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Capital",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Córdoba" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Punilla",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Villa Carlos Paz" },
                                        new Ubicacion { Nombre = "La Falda" },
                                        new Ubicacion { Nombre = "Cosquín" }
                                    }
                                },
                                // Añadir más departamentos y localidades aquí...
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Santa Fe",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Rosario",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Rosario" },
                                        new Ubicacion { Nombre = "Granadero Baigorria" },
                                        new Ubicacion { Nombre = "Villa Gobernador Gálvez" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "La Capital",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Fe" },
                                        new Ubicacion { Nombre = "Santo Tomé" }
                                    }
                                },
                                // Añadir más departamentos y localidades aquí...
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Mendoza",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Capital",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Mendoza" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Godoy Cruz",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Godoy Cruz" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Luján de Cuyo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Luján de Cuyo" },
                                        new Ubicacion { Nombre = "Agrelo" }
                                    }
                                },
                                // Añadir más departamentos y localidades aquí...
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Salta",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Capital",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Salta" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cafayate",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cafayate" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cachi",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cachi" }
                                    }
                                },
                                // Añadir más departamentos y localidades aquí...
                            }
                        },
                        // Añadir más provincias y localidades aquí...
                    }
                },
                new Ubicacion
                {
                    Nombre = "Brasil",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Acre",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Rio Branco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Rio Branco" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cruzeiro do Sul",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cruzeiro do Sul" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Amazonas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Manaus",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Manaus" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Parintins",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Parintins" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Bahia",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Salvador",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Salvador" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Feira de Santana",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Feira de Santana" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Ceará",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Fortaleza",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Fortaleza" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Juazeiro do Norte",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Juazeiro do Norte" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Minas Gerais",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Belo Horizonte",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Belo Horizonte" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Uberlândia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Uberlândia" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Pará",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Belém",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Belém" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Santarém",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santarém" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Paraná",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Curitiba",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Curitiba" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Londrina",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Londrina" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Pernambuco",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Recife",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Recife" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Olinda",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Olinda" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Rio de Janeiro",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Rio de Janeiro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Rio de Janeiro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Niterói",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Niterói" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Rio Grande do Sul",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Porto Alegre",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Porto Alegre" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Caxias do Sul",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Caxias do Sul" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "São Paulo",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "São Paulo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "São Paulo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Campinas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Campinas" }
                                    }
                                }
                            }
                        }
                    }
                },
                new Ubicacion
                {
                    Nombre = "Chile",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Región de Arica y Parinacota",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Arica",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Arica" },
                                        new Ubicacion { Nombre = "Camarones" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Parinacota",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Putre" },
                                        new Ubicacion { Nombre = "General Lagos" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Tarapacá",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Iquique",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Iquique" },
                                        new Ubicacion { Nombre = "Alto Hospicio" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Tamarugal",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pozo Almonte" },
                                        new Ubicacion { Nombre = "Pica" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Antofagasta",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Antofagasta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Antofagasta" },
                                        new Ubicacion { Nombre = "Mejillones" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de El Loa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Calama" },
                                        new Ubicacion { Nombre = "San Pedro de Atacama" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Tocopilla",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tocopilla" },
                                        new Ubicacion { Nombre = "María Elena" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Atacama",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Copiapó",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Copiapó" },
                                        new Ubicacion { Nombre = "Tierra Amarilla" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Chañaral",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chañaral" },
                                        new Ubicacion { Nombre = "Diego de Almagro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Huasco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Vallenar" },
                                        new Ubicacion { Nombre = "Freirina" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Coquimbo",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Elqui",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "La Serena" },
                                        new Ubicacion { Nombre = "Coquimbo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Limarí",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ovalle" },
                                        new Ubicacion { Nombre = "Monte Patria" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Choapa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Illapel" },
                                        new Ubicacion { Nombre = "Salamanca" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Valparaíso",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Valparaíso",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Valparaíso" },
                                        new Ubicacion { Nombre = "Viña del Mar" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Marga Marga",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Quilpué" },
                                        new Ubicacion { Nombre = "Villa Alemana" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de San Antonio",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Antonio" },
                                        new Ubicacion { Nombre = "Cartagena" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región Metropolitana de Santiago",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Santiago",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santiago" },
                                        new Ubicacion { Nombre = "Las Condes" },
                                        new Ubicacion { Nombre = "Providencia" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Chacabuco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Colina" },
                                        new Ubicacion { Nombre = "Lampa" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Maipo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Bernardo" },
                                        new Ubicacion { Nombre = "Buin" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de O'Higgins",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Cachapoal",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Rancagua" },
                                        new Ubicacion { Nombre = "Rengo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Colchagua",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Fernando" },
                                        new Ubicacion { Nombre = "Santa Cruz" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Cardenal Caro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pichilemu" },
                                        new Ubicacion { Nombre = "Marchigüe" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región del Maule",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Talca",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Talca" },
                                        new Ubicacion { Nombre = "Constitución" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Curicó",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Curicó" },
                                        new Ubicacion { Nombre = "Molina" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Linares",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Linares" },
                                        new Ubicacion { Nombre = "Parral" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Cauquenes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cauquenes" },
                                        new Ubicacion { Nombre = "Chanco" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Ñuble",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Diguillín",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chillán" },
                                        new Ubicacion { Nombre = "Bulnes" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Punilla",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Carlos" },
                                        new Ubicacion { Nombre = "Coihueco" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Itata",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Quirihue" },
                                        new Ubicacion { Nombre = "Cobquecura" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región del Biobío",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Concepción",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Concepción" },
                                        new Ubicacion { Nombre = "Talcahuano" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Arauco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Lebu" },
                                        new Ubicacion { Nombre = "Curanilahue" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Biobío",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Los Ángeles" },
                                        new Ubicacion { Nombre = "Mulchén" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de La Araucanía",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Cautín",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Temuco" },
                                        new Ubicacion { Nombre = "Villarrica" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Malleco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Angol" },
                                        new Ubicacion { Nombre = "Collipulli" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Los Ríos",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Valdivia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Valdivia" },
                                        new Ubicacion { Nombre = "Panguipulli" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Ranco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "La Unión" },
                                        new Ubicacion { Nombre = "Futrono" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Los Lagos",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Osorno",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Osorno" },
                                        new Ubicacion { Nombre = "Río Negro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Llanquihue",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Montt" },
                                        new Ubicacion { Nombre = "Puerto Varas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Chiloé",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Castro" },
                                        new Ubicacion { Nombre = "Ancud" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Palena",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chaitén" },
                                        new Ubicacion { Nombre = "Futaleufú" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Aysén",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Coyhaique",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Coyhaique" },
                                        new Ubicacion { Nombre = "Lago Verde" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Aysén",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Aysén" },
                                        new Ubicacion { Nombre = "Cisnes" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Capitán Prat",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cochrane" },
                                        new Ubicacion { Nombre = "O'Higgins" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de General Carrera",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chile Chico" },
                                        new Ubicacion { Nombre = "Río Ibáñez" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Región de Magallanes y de la Antártica Chilena",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Magallanes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Punta Arenas" },
                                        new Ubicacion { Nombre = "Río Verde" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Última Esperanza",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Natales" },
                                        new Ubicacion { Nombre = "Torres del Paine" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Tierra del Fuego",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Porvenir" },
                                        new Ubicacion { Nombre = "Primavera" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Antártica Chilena",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cabo de Hornos" },
                                        new Ubicacion { Nombre = "Antártica" }
                                    }
                                }
                            }
                        }
                    }
                },
                new Ubicacion
                {
                    Nombre = "Colombia",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Antioquia",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Medellín",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Medellín" },
                                        new Ubicacion { Nombre = "Bello" },
                                        new Ubicacion { Nombre = "Itagüí" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Urabá",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Apartadó" },
                                        new Ubicacion { Nombre = "Turbo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Atlántico",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Barranquilla",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Barranquilla" },
                                        new Ubicacion { Nombre = "Soledad" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Suroccidente",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Sabanalarga" },
                                        new Ubicacion { Nombre = "Baranoa" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Bogotá",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Distrito Capital",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Bogotá" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Bolívar",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Cartagena",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cartagena de Indias" },
                                        new Ubicacion { Nombre = "Turbaco" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Magangué",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Magangué" },
                                        new Ubicacion { Nombre = "Mompox" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Boyacá",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Tunja",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tunja" },
                                        new Ubicacion { Nombre = "Duitama" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Norte y Gutiérrez",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Sogamoso" },
                                        new Ubicacion { Nombre = "Paipa" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Caldas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Manizales",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Manizales" },
                                        new Ubicacion { Nombre = "Villamaría" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Norte",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Aguadas" },
                                        new Ubicacion { Nombre = "Salamina" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cauca",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Popayán",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Popayán" },
                                        new Ubicacion { Nombre = "El Tambo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Santander de Quilichao",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santander de Quilichao" },
                                        new Ubicacion { Nombre = "Puerto Tejada" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cesar",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Valledupar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Valledupar" },
                                        new Ubicacion { Nombre = "Aguachica" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Chiriguaná",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chiriguaná" },
                                        new Ubicacion { Nombre = "Curumaní" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Córdoba",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Montería",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Montería" },
                                        new Ubicacion { Nombre = "Cereté" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Lorica",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Lorica" },
                                        new Ubicacion { Nombre = "Sahagún" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cundinamarca",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Sabana Centro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Zipaquirá" },
                                        new Ubicacion { Nombre = "Cajicá" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Sabana Occidente",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Facatativá" },
                                        new Ubicacion { Nombre = "Madrid" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Chocó",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Quibdó",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Quibdó" },
                                        new Ubicacion { Nombre = "Istmina" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del San Juan",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Condoto" },
                                        new Ubicacion { Nombre = "Tadó" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Huila",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Neiva",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Neiva" },
                                        new Ubicacion { Nombre = "Campoalegre" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Sur",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pitalito" },
                                        new Ubicacion { Nombre = "Garzón" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "La Guajira",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Riohacha",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Riohacha" },
                                        new Ubicacion { Nombre = "Maicao" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Fonseca",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Fonseca" },
                                        new Ubicacion { Nombre = "San Juan del Cesar" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Magdalena",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Santa Marta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Marta" },
                                        new Ubicacion { Nombre = "Ciénaga" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Río",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Banco" },
                                        new Ubicacion { Nombre = "Plato" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Meta",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Villavicencio",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Villavicencio" },
                                        new Ubicacion { Nombre = "Acacías" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Ariari",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Granada" },
                                        new Ubicacion { Nombre = "San Martín" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Nariño",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Pasto",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pasto" },
                                        new Ubicacion { Nombre = "Ipiales" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Tumaco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tumaco" },
                                        new Ubicacion { Nombre = "La Tola" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Norte de Santander",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Cúcuta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cúcuta" },
                                        new Ubicacion { Nombre = "Villa del Rosario" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Pamplona",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pamplona" },
                                        new Ubicacion { Nombre = "Ocaña" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Quindío",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Armenia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Armenia" },
                                        new Ubicacion { Nombre = "Quimbaya" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Calarcá",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Calarcá" },
                                        new Ubicacion { Nombre = "La Tebaida" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Risaralda",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Pereira",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pereira" },
                                        new Ubicacion { Nombre = "Dosquebradas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Norte",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Rosa de Cabal" },
                                        new Ubicacion { Nombre = "Marsella" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Santander",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Bucaramanga",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Bucaramanga" },
                                        new Ubicacion { Nombre = "Floridablanca" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Vélez",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Vélez" },
                                        new Ubicacion { Nombre = "Barbosa" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Sucre",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Sincelejo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Sincelejo" },
                                        new Ubicacion { Nombre = "Corozal" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de San Marcos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Marcos" },
                                        new Ubicacion { Nombre = "Majagual" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Tolima",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Ibagué",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ibagué" },
                                        new Ubicacion { Nombre = "Espinal" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia del Sur",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Honda" },
                                        new Ubicacion { Nombre = "Chaparral" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Valle del Cauca",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Cali",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cali" },
                                        new Ubicacion { Nombre = "Palmira" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Tuluá",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tuluá" },
                                        new Ubicacion { Nombre = "Buga" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Vaupés",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Mitú",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Mitú" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Vichada",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Provincia de Puerto Carreño",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Carreño" }
                                    }
                                }
                            }
                        }
                    }
                },
                new Ubicacion
                {
                    Nombre = "Ecuador",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Azuay",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Cuenca",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cuenca" },
                                        new Ubicacion { Nombre = "Baños" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Girón",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Girón" },
                                        new Ubicacion { Nombre = "San Gerardo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Bolívar",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Guaranda",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Guaranda" },
                                        new Ubicacion { Nombre = "San Luis de Pambil" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Chillanes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chillanes" },
                                        new Ubicacion { Nombre = "San José del Tambo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cañar",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Azogues",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Azogues" },
                                        new Ubicacion { Nombre = "Luis Cordero" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cañar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cañar" },
                                        new Ubicacion { Nombre = "Suscal" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Carchi",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Tulcán",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tulcán" },
                                        new Ubicacion { Nombre = "Maldonado" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Montúfar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Gabriel" },
                                        new Ubicacion { Nombre = "Cristóbal Colón" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Chimborazo",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Riobamba",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Riobamba" },
                                        new Ubicacion { Nombre = "Licán" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Guano",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Guano" },
                                        new Ubicacion { Nombre = "San Andrés" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cotopaxi",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Latacunga",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Latacunga" },
                                        new Ubicacion { Nombre = "Mulaló" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Salcedo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Miguel" },
                                        new Ubicacion { Nombre = "Cusubamba" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "El Oro",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Machala",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Machala" },
                                        new Ubicacion { Nombre = "El Cambio" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Santa Rosa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Rosa" },
                                        new Ubicacion { Nombre = "Bellavista" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Esmeraldas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Esmeraldas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Esmeraldas" },
                                        new Ubicacion { Nombre = "Tachina" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Atacames",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Atacames" },
                                        new Ubicacion { Nombre = "Súa" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Galápagos",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "San Cristóbal",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Baquerizo Moreno" },
                                        new Ubicacion { Nombre = "El Progreso" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Isabela",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Villamil" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Guayas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Guayaquil",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Guayaquil" },
                                        new Ubicacion { Nombre = "Chongón" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Samborondón",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Samborondón" },
                                        new Ubicacion { Nombre = "La Puntilla" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Imbabura",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Ibarra",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ibarra" },
                                        new Ubicacion { Nombre = "Ambuquí" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Otavalo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Otavalo" },
                                        new Ubicacion { Nombre = "San Pablo del Lago" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Loja",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Loja",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Loja" },
                                        new Ubicacion { Nombre = "Vilcabamba" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Catamayo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Catamayo" },
                                        new Ubicacion { Nombre = "San Pedro de la Bendita" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Los Ríos",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Babahoyo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Babahoyo" },
                                        new Ubicacion { Nombre = "Barreiro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Quevedo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Quevedo" },
                                        new Ubicacion { Nombre = "San Carlos" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Manabí",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Portoviejo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Portoviejo" },
                                        new Ubicacion { Nombre = "Crucita" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Manta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Manta" },
                                        new Ubicacion { Nombre = "San Lorenzo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Morona Santiago",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Macas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Macas" },
                                        new Ubicacion { Nombre = "General Proaño" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Gualaquiza",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Gualaquiza" },
                                        new Ubicacion { Nombre = "El Rosario" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Napo",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Tena",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tena" },
                                        new Ubicacion { Nombre = "Puerto Napo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Archidona",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Archidona" },
                                        new Ubicacion { Nombre = "Cotundo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Pastaza",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Puyo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puyo" },
                                        new Ubicacion { Nombre = "Tarqui" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Mera",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Mera" },
                                        new Ubicacion { Nombre = "Shell" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Pichincha",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Quito",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Quito" },
                                        new Ubicacion { Nombre = "Cumbayá" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Rumiñahui",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Sangolquí" },
                                        new Ubicacion { Nombre = "San Rafael" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Santa Elena",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Santa Elena",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Elena" },
                                        new Ubicacion { Nombre = "Manglaralto" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "La Libertad",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "La Libertad" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Santo Domingo de los Tsáchilas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Santo Domingo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santo Domingo" },
                                        new Ubicacion { Nombre = "Chiguilpe" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "La Concordia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "La Concordia" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Sucumbíos",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Nueva Loja",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Nueva Loja" },
                                        new Ubicacion { Nombre = "Dureno" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Lago Agrio",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Lago Agrio" },
                                        new Ubicacion { Nombre = "El Eno" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Tungurahua",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Ambato",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ambato" },
                                        new Ubicacion { Nombre = "Quisapincha" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Baños",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Baños" },
                                        new Ubicacion { Nombre = "Ulba" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Zamora Chinchipe",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Zamora",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Zamora" },
                                        new Ubicacion { Nombre = "Cumbaratza" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Yantzaza",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Yantzaza" },
                                        new Ubicacion { Nombre = "Los Encuentros" }
                                    }
                                }
                            }
                        }
                    }
                },
                new Ubicacion
                {
                    Nombre = "Paraguay",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Alto Paraguay",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Fuerte Olimpo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Fuerte Olimpo" },
                                        new Ubicacion { Nombre = "Puerto Casado" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bahía Negra",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Bahía Negra" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Alto Paraná",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Ciudad del Este",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad del Este" },
                                        new Ubicacion { Nombre = "Hernandarias" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Minga Guazú",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Minga Guazú" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Amambay",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Pedro Juan Caballero",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pedro Juan Caballero" },
                                        new Ubicacion { Nombre = "Zanja Pytã" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Boquerón",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Filadelfia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Filadelfia" },
                                        new Ubicacion { Nombre = "Mariscal Estigarribia" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Caaguazú",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Coronel Oviedo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Coronel Oviedo" },
                                        new Ubicacion { Nombre = "Caaguazú" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Caaguazú",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Caaguazú" },
                                        new Ubicacion { Nombre = "Repatriación" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Caazapá",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Caazapá",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Caazapá" },
                                        new Ubicacion { Nombre = "San Juan Nepomuceno" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Canindeyú",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Salto del Guairá",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Salto del Guairá" },
                                        new Ubicacion { Nombre = "Curuguaty" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Central",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Areguá",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Areguá" },
                                        new Ubicacion { Nombre = "Capiatá" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Luque",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Luque" },
                                        new Ubicacion { Nombre = "San Lorenzo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Concepción",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Concepción",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Concepción" },
                                        new Ubicacion { Nombre = "Horqueta" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cordillera",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Caacupé",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Caacupé" },
                                        new Ubicacion { Nombre = "Tobatí" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Bernardino",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Bernardino" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Guairá",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Villarrica",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Villarrica" },
                                        new Ubicacion { Nombre = "Independencia" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Itapúa",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Encarnación",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Encarnación" },
                                        new Ubicacion { Nombre = "Hohenau" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Misiones",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "San Juan Bautista",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Juan Bautista" },
                                        new Ubicacion { Nombre = "Santa Rosa" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Ñeembucú",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Pilar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pilar" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Paraguarí",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Paraguarí",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Paraguarí" },
                                        new Ubicacion { Nombre = "Yaguarón" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Presidente Hayes",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Villa Hayes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Villa Hayes" },
                                        new Ubicacion { Nombre = "Benjamín Aceval" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "San Pedro",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "San Pedro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Pedro" },
                                        new Ubicacion { Nombre = "San Estanislao" }
                                    }
                                }
                            }
                        }
                    }
                },

                new Ubicacion
                {
                    Nombre = "Perú",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Amazonas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Chachapoyas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chachapoyas" },
                                        new Ubicacion { Nombre = "Asunción" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bagua",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Bagua" },
                                        new Ubicacion { Nombre = "La Peca" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Áncash",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Huaraz",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Huaraz" },
                                        new Ubicacion { Nombre = "Independencia" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Carhuaz",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Carhuaz" },
                                        new Ubicacion { Nombre = "Acopampa" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Apurímac",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Abancay",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Abancay" },
                                        new Ubicacion { Nombre = "Tamburco" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Andahuaylas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Andahuaylas" },
                                        new Ubicacion { Nombre = "Talavera" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Arequipa",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Arequipa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Arequipa" },
                                        new Ubicacion { Nombre = "Cayma" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Camana",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Camana" },
                                        new Ubicacion { Nombre = "Ocoña" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Ayacucho",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Huamanga",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ayacucho" },
                                        new Ubicacion { Nombre = "Carmen Alto" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Huanta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Huanta" },
                                        new Ubicacion { Nombre = "Luricocha" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cajamarca",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Cajamarca",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cajamarca" },
                                        new Ubicacion { Nombre = "Los Baños del Inca" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Jaén",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Jaén" },
                                        new Ubicacion { Nombre = "Bellavista" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Callao",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Callao",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Callao" },
                                        new Ubicacion { Nombre = "Bellavista" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cusco",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Cusco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cusco" },
                                        new Ubicacion { Nombre = "San Sebastián" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Urubamba",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Urubamba" },
                                        new Ubicacion { Nombre = "Ollantaytambo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Huancavelica",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Huancavelica",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Huancavelica" },
                                        new Ubicacion { Nombre = "Acobambilla" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tayacaja",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pampas" },
                                        new Ubicacion { Nombre = "Colcabamba" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Huánuco",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Huánuco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Huánuco" },
                                        new Ubicacion { Nombre = "Amarilis" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Leoncio Prado",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tingo María" },
                                        new Ubicacion { Nombre = "Rupa-Rupa" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Ica",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Ica",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ica" },
                                        new Ubicacion { Nombre = "Subtanjalla" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Nazca",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Nazca" },
                                        new Ubicacion { Nombre = "Vista Alegre" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Junín",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Huancayo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Huancayo" },
                                        new Ubicacion { Nombre = "El Tambo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Jauja",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Jauja" },
                                        new Ubicacion { Nombre = "Masma" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "La Libertad",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Trujillo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Trujillo" },
                                        new Ubicacion { Nombre = "Florencia de Mora" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ascope",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ascope" },
                                        new Ubicacion { Nombre = "Chocope" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Lambayeque",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Chiclayo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Chiclayo" },
                                        new Ubicacion { Nombre = "José Leonardo Ortiz" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ferreñafe",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ferreñafe" },
                                        new Ubicacion { Nombre = "Manuel Antonio Mesones Muro" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Lima",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Lima",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Lima" },
                                        new Ubicacion { Nombre = "San Isidro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Huaral",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Huaral" },
                                        new Ubicacion { Nombre = "Chancay" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Loreto",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Maynas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Iquitos" },
                                        new Ubicacion { Nombre = "Punchana" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Mariscal Ramón Castilla",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Caballococha" },
                                        new Ubicacion { Nombre = "Pebas" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Madre de Dios",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Tambopata",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Maldonado" },
                                        new Ubicacion { Nombre = "Inambari" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Manu",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Salvación" },
                                        new Ubicacion { Nombre = "Fitzcarrald" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Moquegua",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Mariscal Nieto",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Moquegua" },
                                        new Ubicacion { Nombre = "Samegua" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ilo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ilo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Pasco",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Pasco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cerro de Pasco" },
                                        new Ubicacion { Nombre = "Yanacancha" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Daniel Alcides Carrión",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Yanahuanca" },
                                        new Ubicacion { Nombre = "Chacayan" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Piura",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Piura",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Piura" },
                                        new Ubicacion { Nombre = "Castilla" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sullana",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Sullana" },
                                        new Ubicacion { Nombre = "Bellavista" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Puno",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Puno",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puno" },
                                        new Ubicacion { Nombre = "Chucuito" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Román",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Juliaca" },
                                        new Ubicacion { Nombre = "Caracoto" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "San Martín",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Moyobamba",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Moyobamba" },
                                        new Ubicacion { Nombre = "Soritor" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Lamas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Lamas" },
                                        new Ubicacion { Nombre = "Tabalosos" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Tacna",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Tacna",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tacna" },
                                        new Ubicacion { Nombre = "Alto de la Alianza" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tarata",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tarata" },
                                        new Ubicacion { Nombre = "Estique" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Tumbes",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Tumbes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tumbes" },
                                        new Ubicacion { Nombre = "Corrales" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Zarumilla",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Zarumilla" },
                                        new Ubicacion { Nombre = "Aguas Verdes" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Ucayali",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Coronel Portillo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pucallpa" },
                                        new Ubicacion { Nombre = "Yarinacocha" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Atalaya",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Atalaya" },
                                        new Ubicacion { Nombre = "Sepahua" }
                                    }
                                }
                            }
                        }
                    }
                },
                new Ubicacion
                {
                    Nombre = "Uruguay",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Artigas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Artigas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Artigas" },
                                        new Ubicacion { Nombre = "Bella Unión" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tomás Gomensoro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tomás Gomensoro" },
                                        new Ubicacion { Nombre = "Sequeira" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Canelones",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Canelones",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Canelones" },
                                        new Ubicacion { Nombre = "Las Piedras" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pando",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pando" },
                                        new Ubicacion { Nombre = "Barros Blancos" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cerro Largo",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Melo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Melo" },
                                        new Ubicacion { Nombre = "Fraile Muerto" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Río Branco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Río Branco" },
                                        new Ubicacion { Nombre = "Vergara" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Colonia",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Colonia del Sacramento",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Colonia del Sacramento" },
                                        new Ubicacion { Nombre = "Nueva Helvecia" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Carmelo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Carmelo" },
                                        new Ubicacion { Nombre = "Tarariras" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Durazno",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Durazno",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Durazno" },
                                        new Ubicacion { Nombre = "Sarandí del Yi" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Villa del Carmen",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Villa del Carmen" },
                                        new Ubicacion { Nombre = "Blanquillo" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Flores",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Trinidad",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Trinidad" },
                                        new Ubicacion { Nombre = "Ismael Cortinas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Andresito",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Andresito" },
                                        new Ubicacion { Nombre = "La Casilla" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Florida",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Florida",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Florida" },
                                        new Ubicacion { Nombre = "Sarandí Grande" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "25 de Agosto",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "25 de Agosto" },
                                        new Ubicacion { Nombre = "Fray Marcos" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Lavalleja",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Minas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Minas" },
                                        new Ubicacion { Nombre = "Solís de Mataojo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José Pedro Varela",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "José Pedro Varela" },
                                        new Ubicacion { Nombre = "Zapicán" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Maldonado",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Maldonado",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Maldonado" },
                                        new Ubicacion { Nombre = "Punta del Este" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Carlos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Carlos" },
                                        new Ubicacion { Nombre = "Aiguá" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Montevideo",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Montevideo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Centro" },
                                        new Ubicacion { Nombre = "Pocitos" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ciudad Vieja",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad Vieja" },
                                        new Ubicacion { Nombre = "Aguada" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Paysandú",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Paysandú",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Paysandú" },
                                        new Ubicacion { Nombre = "Guichón" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Quebracho",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Quebracho" },
                                        new Ubicacion { Nombre = "Piedras Coloradas" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Río Negro",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Fray Bentos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Fray Bentos" },
                                        new Ubicacion { Nombre = "Young" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Javier",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Javier" },
                                        new Ubicacion { Nombre = "Nuevo Berlín" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Rivera",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Rivera",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Rivera" },
                                        new Ubicacion { Nombre = "Tranqueras" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Vichadero",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Vichadero" },
                                        new Ubicacion { Nombre = "Lagunón" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Rocha",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Rocha",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Rocha" },
                                        new Ubicacion { Nombre = "Chuy" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Lascano",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Lascano" },
                                        new Ubicacion { Nombre = "Castillos" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Salto",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Salto",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Salto" },
                                        new Ubicacion { Nombre = "Constitución" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Belén",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Belén" },
                                        new Ubicacion { Nombre = "Rincón de Valentín" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "San José",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "San José de Mayo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San José de Mayo" },
                                        new Ubicacion { Nombre = "Libertad" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ciudad del Plata",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad del Plata" },
                                        new Ubicacion { Nombre = "Delta del Tigre" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Soriano",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Mercedes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Mercedes" },
                                        new Ubicacion { Nombre = "Dolores" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cardona",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cardona" },
                                        new Ubicacion { Nombre = "Rodríguez" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Tacuarembó",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Tacuarembó",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tacuarembó" },
                                        new Ubicacion { Nombre = "Paso de los Toros" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Gregorio de Polanco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Gregorio de Polanco" },
                                        new Ubicacion { Nombre = "Achar" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Treinta y Tres",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Treinta y Tres",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Treinta y Tres" },
                                        new Ubicacion { Nombre = "Santa Clara de Olimar" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Vergara",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Vergara" },
                                        new Ubicacion { Nombre = "Rincón" }
                                    }
                                }
                            }
                        }
                    }
                },
                new Ubicacion
                {
                    Nombre = "Venezuela",
                    SubUbicaciones = new List<Ubicacion>
                    {
                        new Ubicacion
                        {
                            Nombre = "Amazonas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Alto Orinoco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "La Esmeralda" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Atabapo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Fernando de Atabapo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Atures",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Ayacucho" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Autana",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Isla Ratón" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Manapiare",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Juan de Manapiare" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Maroa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Maroa" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Río Negro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Carlos de Río Negro" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Anzoátegui",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Anaco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Anaco" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Aragua",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Aragua de Barcelona" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Simón Bolívar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Barcelona" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bruzual",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Clarines" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cajigal",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Onoto" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Carvajal",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Valle de Guanape" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Diego Bautista Urbaneja",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Lechería" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Freites",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cantaura" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Guanipa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San José de Guanipa" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Guanta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Guanta" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Independencia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Soledad" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Libertad",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Mateo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "McGregor",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Chaparro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Miranda",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pariaguán" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Monagas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Diego de Cabrutica" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Peñalver",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Píritu" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Píritu",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Píritu" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Juan de Capistrano",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Boca de Uchire" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Santa Ana",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Ana" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Simón Rodríguez",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Tigre" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sotillo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto La Cruz" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Apure",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Achaguas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Achaguas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Biruaca",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Biruaca" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Muñoz",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Bruzual" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Páez",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Guasdualito" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pedro Camejo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Juan de Payara" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Rómulo Gallegos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Elorza" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Fernando",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Fernando de Apure" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Aragua",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Bolívar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Mateo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Camatagua",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Camatagua" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Francisco Linares Alcántara",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Rita" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Girardot",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Maracay" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José Ángel Lamas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Cruz" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José Félix Ribas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "La Victoria" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "José Rafael Revenga",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Consejo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Libertador",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Palo Negro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Mario Briceño Iragorry",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Limón" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ocumare de la Costa de Oro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ocumare de la Costa" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Casimiro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Casimiro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Sebastián",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Sebastián de los Reyes" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Santiago Mariño",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Turmero" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Santos Michelena",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Las Tejerías" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sucre",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cagua" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tovar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Colonia Tovar" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Urdaneta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Barbacoas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Zamora",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Villa de Cura" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Barinas",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Alberto Arvelo Torrealba",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Sabaneta" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Andrés Eloy Blanco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Cantón" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Antonio José de Sucre",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Socopó" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Arismendi",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Arismendi" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Barinas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Barinas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bolívar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Barinitas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cruz Paredes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Barrancas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ezequiel Zamora",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Bárbara" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Obispos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Obispos" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pedraza",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad Bolivia" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Rojas",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Libertad" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sosa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad de Nutrias" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Bolívar",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Caroní",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad Guayana" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cedeño",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Caicara del Orinoco" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "El Callao",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Callao" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Gran Sabana",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Elena de Uairén" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Heres",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad Bolívar" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Piar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Upata" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Angostura del Orinoco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Ciudad Piar" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sifontes",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tumeremo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Sucre",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Maripa" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Padre Pedro Chien",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Palmar" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Carabobo",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Bejuma",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Bejuma" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Carlos Arvelo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Güigüe" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Diego Ibarra",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Mariara" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Guacara",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Guacara" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Juan José Mora",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Morón" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Libertador",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tocuyito" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Los Guayos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Los Guayos" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Miranda",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Miranda" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Montalbán",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Montalbán" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Naguanagua",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Naguanagua" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Puerto Cabello",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Puerto Cabello" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Diego",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Diego" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Joaquín",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Joaquín" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Valencia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Valencia" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Cojedes",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Anzoátegui",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Cojedes" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tinaquillo",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tinaquillo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Girardot",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Baúl" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Lima Blanco",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Macapo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pao de San Juan Bautista",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "El Pao" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Ricaurte",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Libertad de Cojedes" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Rómulo Gallegos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Las Vegas" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "San Carlos",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Carlos" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Delta Amacuro",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Antonio Díaz",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Curiapo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Casacoima",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Sierra Imataca" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Pedernales",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pedernales" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Tucupita",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Tucupita" }
                                    }
                                }
                            }
                        },
                        new Ubicacion
                        {
                            Nombre = "Falcón",
                            SubUbicaciones = new List<Ubicacion>
                            {
                                new Ubicacion
                                {
                                    Nombre = "Acosta",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Juan de los Cayos" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Bolívar",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "San Luis" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Buchivacoa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Capatárida" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Cacique Manaure",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Yaracal" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Carirubana",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Punto Fijo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Colina",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "La Vela de Coro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Dabajuro",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Dabajuro" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Democracia",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pedregal" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Falcón",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Pueblo Nuevo" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Federación",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Churuguara" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Jacura",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Jacura" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Los Taques",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Cruz de Los Taques" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Mauroa",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Mene de Mauroa" }
                                    }
                                },
                                new Ubicacion
                                {
                                    Nombre = "Miranda",
                                    SubUbicaciones = new List<Ubicacion>
                                    {
                                        new Ubicacion { Nombre = "Santa Ana de Coro" }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
        private List<UbicacionDptos> DepartamentosBolivia()
        {
            return new List<UbicacionDptos>
            {
                new UbicacionDptos
                {
                    NombreD = "Oruro",
                    SubUbicaciones = new List<UbicacionDptos>
                    {
                        new UbicacionDptos
                        {
                            NombreD = "Atahuallpa",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Santiago de Huayllamarca",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Santiago de Huayllamarca" }
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Chipaya",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Chipaya" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Carangas",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Corque",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Corque" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Cercado",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Oruro",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Oruro" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Eduardo Avaroa",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Challapata",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Challapata" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Ladislao Cabrera",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Salinas de Garci Mendoza",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Salinas de Garci Mendoza" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Litoral",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Huachacalla",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Huachacalla" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Nor Carangas",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Huayllamarca",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Huayllamarca" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Pantaleón Dalence",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Huanuni",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Huanuni" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Poopó",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Poopó",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Poopó" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Sajama",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Curahuara de Carangas",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Curahuara de Carangas" }
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Turco",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Turco" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "San Pedro de Totora",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Totora",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Totora" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Saucarí",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Toledo",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Toledo" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Sebastián Pagador",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Santiago de Huari",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Santiago de Huari" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Sud Carangas",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Andamarca",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Andamarca" }
                                    }
                                }
                            }
                        },
                        new UbicacionDptos
                        {
                            NombreD = "Tomás Barrón",
                            SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Eucaliptus",
                                    SubUbicaciones = new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos { NombreD = "Eucaliptus" }
                                    }
                                }
                            }
                        }
                    }
                },
                new UbicacionDptos
                {
                    NombreD = "La Paz",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Aroma",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Sica Sica"},
                                        new UbicacionDptos{NombreD="Ayo Ayo"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Bautista Saavedra",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Charazani"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Camacho",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Puerto Acosta"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Caranavi",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Caranavi"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Eliodoro Camacho",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Puerto Acosta"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Franz Tamayo",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Apolo"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Gualberto Villarroel",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Pedro de Curahuara"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Ingavi",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Viacha"},
                                        new UbicacionDptos{NombreD="Guaqui"},
                                        new UbicacionDptos{NombreD="Desaguadero"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Inquisivi",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Inquisivi"},
                                        new UbicacionDptos{NombreD="Quime"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "José Manuel Pando",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Santiago de Machaca"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Larecaja",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Sorata"},
                                        new UbicacionDptos{NombreD="Guanay"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Loayza",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Luribay"},
                                        new UbicacionDptos{NombreD="Malla"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Los Andes",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Pucarani"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Manco Kapac",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Copacabana"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Muñecas",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Chuma"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Nor Yungas",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Coroico"},
                                        new UbicacionDptos{NombreD="Chulumani"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Omasuyos",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Achacachi"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Pacajes",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Coro Coro"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Pedro Domingo Murillo",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="La Paz"},
                                        new UbicacionDptos{NombreD="El Alto"},
                                        new UbicacionDptos{NombreD="Mecapaca"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Sud Yungas",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Chulumani"},
                                        new UbicacionDptos{NombreD="Irupana"}
                                    }
                                }
                            }
                },                
                new UbicacionDptos
                {
                    NombreD = "Cochabamba",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Arani",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Arani"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Arque",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Arque"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Ayopaya",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Ayopaya"},
                                        new UbicacionDptos{NombreD="Cocapata"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Bolívar",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Bolívar"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Capinota",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Capinota"},
                                        new UbicacionDptos{NombreD="Sicaya"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Carrasco",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Totora"},
                                        new UbicacionDptos{NombreD="Pojo"},
                                        new UbicacionDptos{NombreD="Pocona"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Cercado",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Cochabamba"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Chapare",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Villa Tunari"},
                                        new UbicacionDptos{NombreD="Chimoré"},
                                        new UbicacionDptos{NombreD="Ivirgarzama"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Esteban Arce",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Tarata"},
                                        new UbicacionDptos{NombreD="Anzaldo"},
                                        new UbicacionDptos{NombreD="Arbieto"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Germán Jordán",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Cliza"},
                                        new UbicacionDptos{NombreD="Toco"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Mizque",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Mizque"},
                                        new UbicacionDptos{NombreD="Vila Vila"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Punata",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Punata"},
                                        new UbicacionDptos{NombreD="Villa Rivero"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Quillacollo",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Quillacollo"},
                                        new UbicacionDptos{NombreD="Vinto"},
                                        new UbicacionDptos{NombreD="Colcapirhua"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Tapacarí",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Tapacarí"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Tiraque",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Tiraque"}
                                    }
                                }
                            }
                },
                new UbicacionDptos
                {
                    NombreD = "Santa Cruz",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Andrés Ibáñez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Santa Cruz de la Sierra"},
                                        new UbicacionDptos{NombreD="Cotoca"},
                                        new UbicacionDptos{NombreD="La Guardia"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Ángel Sandoval",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Matías"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Chiquitos",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San José de Chiquitos"},
                                        new UbicacionDptos{NombreD="Roboré"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Cordillera",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Camiri"},
                                        new UbicacionDptos{NombreD="Charagua"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Florida",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Samaipata"},
                                        new UbicacionDptos{NombreD="Mairana"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Germán Busch",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Puerto Suárez"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Guarayos",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Ascención de Guarayos"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Ichilo",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Buena Vista"},
                                        new UbicacionDptos{NombreD="Yapacaní"}

                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Ignacio Warnes",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Warnes"},
                                        new UbicacionDptos{NombreD="Montero"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "José Miguel de Velasco",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Ignacio de Velasco"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Manuel María Caballero",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Comarapa"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Ñuflo de Chávez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Concepción"},
                                        new UbicacionDptos{NombreD="San Javier"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Obispo Santistevan",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Montero"},
                                        new UbicacionDptos{NombreD="Mineros"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Sara",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Portachuelo"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Vallegrande",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Vallegrande"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Warnes",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Warnes"}
                                    }
                                }
                            }
                },
                new UbicacionDptos
                {
                    NombreD = "Potosí",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Alonso de Ibáñez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Sacaca"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Antonio Quijarro",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Uyuni"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Bernardino Bilbao",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Arampampa"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Charcas",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Pedro de Buena Vista"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Chayanta",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Llallagua"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Cornelio Saavedra",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Betanzos"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Daniel Campos",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Llica"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Enrique Baldivieso",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Agustín"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "José María Linares",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Puna"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Modesto Omiste",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Villazón"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Nor Chichas",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Cotagaita"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Nor Lípez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Colcha K"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Rafael Bustillo",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Uncía"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Sud Chichas",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Tupiza"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Sud Lípez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Pablo de Lípez"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Tomás Frías",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Potosí"}
                                    }
                                }
                            }
                },
                new UbicacionDptos
                {
                    NombreD = "Pando",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Abuná",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Santa Rosa del Abuná"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Federico Román",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Villa Nueva"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Madre de Dios",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Puerto Gonzalo Moreno"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Manuripi",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Puerto Rico"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Nicolás Suárez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Cobija"},
                                        new UbicacionDptos{NombreD="Porvenir"}
                                    }
                                }
                            }
                },
                new UbicacionDptos
                {
                    NombreD = "Beni",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Cercado",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Trinidad"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Antonio Vaca Díez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Riberalta"},
                                        new UbicacionDptos{NombreD="Guayaramerín"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Ballivián",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Reyes"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Iténez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Magdalena"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "José Ballivián",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Borja"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Mamoré",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Joaquín"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Marbán",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Loreto"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Moxos",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Ignacio de Moxos"},
                                        new UbicacionDptos{NombreD="San Javier"}
                                    }
                                }
                            }
                },
                new UbicacionDptos
                {
                    NombreD = "Chuquisaca",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Azurduy",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Azurduy"},
                                        new UbicacionDptos{NombreD="Tarvita"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Belisario Boeto",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Villa Serrano"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Hernando Siles",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Monteagudo"},
                                        new UbicacionDptos{NombreD="Padilla"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Jaime Zudáñez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Zudáñez"},
                                        new UbicacionDptos{NombreD="Tomina"},
                                        new UbicacionDptos{NombreD="Icla"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Luis Calvo",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Villa Vaca Guzmán"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Nor Cinti",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Camargo"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Oropeza",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Sucre"},
                                        new UbicacionDptos{NombreD="Yotala"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Sud Cinti",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Culpina"},
                                        new UbicacionDptos{NombreD="Villa Charcas"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Tomina",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Padilla"},
                                        new UbicacionDptos{NombreD="El Villar"},
                                        new UbicacionDptos{NombreD="Presto"},
                                        new UbicacionDptos{NombreD="Villa Alcalá"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Yamparáez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Tarabuco"},
                                        new UbicacionDptos{NombreD="Yamparáez"}
                                    }
                                }
                            }
                },
                new UbicacionDptos
                {
                    NombreD = "Tarija",
                    SubUbicaciones = new List<UbicacionDptos>
                            {
                                new UbicacionDptos
                                {
                                    NombreD = "Aniceto Arce",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Padcaya"},
                                        new UbicacionDptos{NombreD="Bermejo"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Burnet O'Connor",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Entre Ríos"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Cercado",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Tarija"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Eustaquio Méndez",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="San Lorenzo"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "Gran Chaco",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Yacuiba"},
                                        new UbicacionDptos{NombreD="Villamontes"},
                                        new UbicacionDptos{NombreD="Caraparí"}
                                    }
                                },
                                new UbicacionDptos
                                {
                                    NombreD = "José María Avilés",
                                    SubUbicaciones=new List<UbicacionDptos>
                                    {
                                        new UbicacionDptos{NombreD="Uriondo"}
                                    }
                                }
                            }
                }
            };
        }
        public frmRegistrarEst(frmestudiante frmEstudiante, EstudianteViewModel estudianteSeleccionado, EstudianteController estudianteController) : this(frmEstudiante, estudianteController)
        {
            _estudianteSeleccionado = estudianteSeleccionado;
            CargarDatosEstudianteSeleccionado();         
        }        
        private void CargarDatosEstudianteSeleccionado()
        {
            if (_estudianteSeleccionado != null)
            {
                txt_appaterno.Text = _estudianteSeleccionado.Ap_Paterno_E;
                txt_apmaterno.Text = _estudianteSeleccionado.Ap_Materno_E;
                txt_nombre.Text = _estudianteSeleccionado.Nombre_E;
                txt_ci.Text = _estudianteSeleccionado.Ci_E.ToString();
                txt_compl.Text = _estudianteSeleccionado.Complemento;
                txt_exp.Text = _estudianteSeleccionado.Expedido;
                txt_rude.Text = _estudianteSeleccionado.Codigo_Rude.ToString();
                if (_estudianteSeleccionado.Sexo == "M")
                {
                    rbtmasculino.Checked = true;
                }
                else 
                {
                    rbtfemenino.Checked = true;
                }
                date_nac.Value = _estudianteSeleccionado.fecha_Nacimiento;
                cbx_escol.Text = _estudianteSeleccionado.Grado.ToString();

                cbx_paisNac.Text = _estudianteSeleccionado.Pais;
                cbx_provNac.Text = _estudianteSeleccionado.Provincia;
                cbx_dptoNac.Text = _estudianteSeleccionado.Departamento;
                cbx_locNac.Text = _estudianteSeleccionado.Localidad;
                cbx_dptoAct.Text = _estudianteSeleccionado.DepartamentoActual;
                cbx_provAct.Text = _estudianteSeleccionado.ProvinciaActual;
                cbx_munAct.Text = _estudianteSeleccionado.MunicipioActual;
                cbx_locAct.Text = _estudianteSeleccionado.LocalidadActual;
                txt_zonaAct.Text = _estudianteSeleccionado.ZonaActual;
                txt_avenAct.Text = _estudianteSeleccionado.AvenidaActual;
                txt_num.Text = _estudianteSeleccionado.NumeroViviendaActual;
                txt_telefono.Text = _estudianteSeleccionado.Telefono_Fijo.ToString();
                txt_cel.Text = _estudianteSeleccionado.Celular.ToString();
                txt_ciTutor.Text = _estudianteSeleccionado.Ci_T.ToString();
                txt_appaternoTutor.Text = _estudianteSeleccionado.Ap_Paterno_T;
                txt_apmaternoTutor.Text = _estudianteSeleccionado.Ap_Materno_T;
                txt_nombreTutor.Text = _estudianteSeleccionado.Nombre_T;
                txt_complTutor.Text = _estudianteSeleccionado.ComplementoTutor;
                txt_expTutor.Text = _estudianteSeleccionado.ExpedidoTutor;
                txt_dptoComprob.Text = _estudianteSeleccionado.DepartamentoComprobante;
                date_regComprob.Value = _estudianteSeleccionado.FechaRegistroComprobante;
            }
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
        public class Ubicacion
        {
            public string Nombre { get; set; }
            public List<Ubicacion> SubUbicaciones { get; set; }
        }
        public class UbicacionDptos
        {
            public string NombreD { get; set; }
            public List<UbicacionDptos> SubUbicaciones { get; set; }
        }
        private async void btn_guardar_Click(object sender, EventArgs e)
        {
            if(txt_appaterno.Text==""||txt_apmaterno.Text==""||txt_nombre.Text==""||txt_ci.Text==""||txt_rude.Text==""||
                txt_exp.Text==""||txt_compl.Text==""||cbx_escol.Text==""||cbx_paisNac.Text==""||cbx_dptoNac.Text==""||
                cbx_provNac.Text==""||cbx_locNac.Text==""||cbx_dptoAct.Text==""||cbx_provAct.Text==""||
                cbx_munAct.Text==""||cbx_locAct.Text==""||txt_zonaAct.Text==""||txt_avenAct.Text==""||
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
                estudiante.codigo_rude = Convert.ToInt64(txt_rude.Text);
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
                bool estudianteRegistrado = await _estudianteController.RegistrarEstudianteAsync(estudiante);

                if(estudianteRegistrado)
                {                                    
                    nacimiento.id_estudiante = estudiante.id_estudiante;
                    nacimiento.pais = cbx_paisNac.Text;
                    nacimiento.provincia = cbx_provNac.Text;
                    nacimiento.dpto = cbx_dptoNac.Text;
                    nacimiento.localidad = cbx_locNac.Text;
                    await _estudianteController.RegistrarNacimientoAsync(nacimiento);
                                        
                    direccion.dpto = cbx_dptoAct.Text;
                    direccion.provincia = cbx_provAct.Text;
                    direccion.municipio = cbx_munAct.Text;
                    direccion.localidad = cbx_locAct.Text;
                    direccion.zona=txt_zonaAct.Text;
                    direccion.avenida=txt_avenAct.Text;
                    direccion.nro_vivienda = txt_num.Text;
                    await _estudianteController.RegistrarDireccionAsync(direccion);

                    dir_Est.id_estudiante = estudiante.id_estudiante;
                    dir_Est.id_direccion = direccion.id_direccion;
                    await _estudianteController.RegistrarDir_EstAsync(dir_Est);

                    contacto.id_direccion=direccion.id_direccion;
                    contacto.telefono_fijo = Convert.ToInt32(txt_telefono.Text);
                    contacto.celular = Convert.ToInt32(txt_cel.Text);
                    await _estudianteController.RegistrarContactoAsync(contacto);

                    tutor.ci = Convert.ToInt32(txt_ciTutor.Text);
                    tutor.complemento = txt_complTutor.Text;
                    tutor.expedido = txt_expTutor.Text;
                    tutor.ap_paterno = txt_appaternoTutor.Text;
                    tutor.ap_materno = txt_apmaternoTutor.Text;
                    tutor.nombre = txt_nombreTutor.Text;
                    await _estudianteController.RegistrarTutorAsync(tutor);

                    tutor_Est.id_estudiante=estudiante.id_estudiante;
                    tutor_Est.id_tutor=tutor.id_tutor;
                    await _estudianteController.RegistrarTutor_EstAsync(tutor_Est);

                    comp.id_estudiante = estudiante.id_estudiante;
                    comp.id_tutor=tutor.id_tutor;
                    comp.lugar_dpto = txt_dptoComprob.Text;
                    comp.fecha_reg = date_regComprob.Value.Date;
                    asignarCurso();
                    await _estudianteController.RegistrarComprobanteAsync(comp);

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
            var datos = ObtenerDatos();
            cbx_paisNac.DisplayMember = "Nombre";
            cbx_paisNac.DataSource = datos;

            var dptos = DepartamentosBolivia();
            cbx_dptoAct.DisplayMember = "NombreD";
            cbx_dptoAct.DataSource = dptos;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (txt_appaterno.Text == "" || txt_apmaterno.Text == "" || txt_nombre.Text == "" || txt_ci.Text == "" || txt_rude.Text == "" ||
        txt_exp.Text == "" || txt_compl.Text == "" || cbx_escol.Text == "" || cbx_paisNac.Text == "" || cbx_dptoNac.Text == "" ||
        cbx_provNac.Text == "" || cbx_locNac.Text == "" || cbx_dptoAct.Text == "" || cbx_provAct.Text == "" ||
        cbx_munAct.Text == "" || cbx_locAct.Text == "" || txt_zonaAct.Text == "" || txt_avenAct.Text == "" ||
        txt_num.Text == "" || txt_telefono.Text == "" || txt_cel.Text == "" || txt_ciTutor.Text == "" || txt_appaternoTutor.Text == "" ||
        txt_apmaternoTutor.Text == "" || txt_nombreTutor.Text == "" || txt_complTutor.Text == "" || txt_expTutor.Text == "" ||
        txt_dptoComprob.Text == "")
            {
                MessageBox.Show("Existen campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener la entidad estudiante desde la base de datos
                var estudianteExistente = _db.TEstudiante.Find(_estudianteSeleccionado.Id_Estudiante);
                if (estudianteExistente == null)
                {
                    MessageBox.Show("El estudiante no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar los datos del estudiante
                estudianteExistente.ap_paterno = txt_appaterno.Text;
                estudianteExistente.ap_materno = txt_apmaterno.Text;
                estudianteExistente.nombre = txt_nombre.Text;
                estudianteExistente.ci = Convert.ToInt32(txt_ci.Text);
                estudianteExistente.complemento = txt_compl.Text;
                estudianteExistente.expedido = txt_exp.Text;
                estudianteExistente.codigo_rude = Convert.ToInt64(txt_rude.Text);
                estudianteExistente.sexo = rbtmasculino.Checked ? "M" : "F";
                estudianteExistente.fec_nacimiento = date_nac.Value.Date;
                estudianteExistente.grado_sec = Convert.ToInt32(cbx_escol.Text);

                // Modificar el estudiante
                bool estudianteModificado = await _estudianteController.ModificarEstudianteAsync(estudianteExistente);

                if (estudianteModificado)
                {
                    // Obtener y modificar nacimiento
                    var nacimientoExistente = _db.TNacimiento.FirstOrDefault(n => n.id_estudiante == estudianteExistente.id_estudiante);
                    if (nacimientoExistente != null)
                    {
                        nacimientoExistente.pais = cbx_paisNac.Text;
                        nacimientoExistente.provincia = cbx_provNac.Text;
                        nacimientoExistente.dpto = cbx_dptoNac.Text;
                        nacimientoExistente.localidad = cbx_locNac.Text;
                        await _estudianteController.ModificarNacimientoAsync(nacimientoExistente);
                    }

                    // Obtener y modificar dirección
                    var dirEstExistente = _db.TDir_Est.FirstOrDefault(de => de.id_estudiante == estudianteExistente.id_estudiante);
                    if (dirEstExistente != null)
                    {
                        var direccionExistente = _db.TDireccion.Find(dirEstExistente.id_direccion);
                        if (direccionExistente != null)
                        {
                            direccionExistente.dpto = cbx_dptoAct.Text;
                            direccionExistente.provincia = cbx_provAct.Text;
                            direccionExistente.municipio = cbx_munAct.Text;
                            direccionExistente.localidad = cbx_locAct.Text;
                            direccionExistente.zona = txt_zonaAct.Text;
                            direccionExistente.avenida = txt_avenAct.Text;
                            direccionExistente.nro_vivienda = txt_num.Text;
                            await _estudianteController.ModificarDireccionAsync(direccionExistente);
                        }

                        // Obtener y modificar contacto
                        var contactoExistente = _db.TContacto.FirstOrDefault(c => c.id_direccion == direccionExistente.id_direccion);
                        if (contactoExistente != null)
                        {
                            contactoExistente.telefono_fijo = Convert.ToInt32(txt_telefono.Text);
                            contactoExistente.celular = Convert.ToInt32(txt_cel.Text);
                            await _estudianteController.ModificarContactoAsync(contactoExistente);
                        }
                    }

                    // Obtener y modificar tutor
                    var tutorEstExistente=_db.TTutor_Est.FirstOrDefault(te=>te.id_estudiante==estudianteExistente.id_estudiante);
                    if (tutorEstExistente != null)
                    { 
                        var tutorExistente = _db.TTutor.Find(tutorEstExistente.id_tutor);
                        if (tutorExistente != null)
                        {
                            tutorExistente.ci = Convert.ToInt32(txt_ciTutor.Text);
                            tutorExistente.complemento = txt_complTutor.Text;
                            tutorExistente.expedido = txt_expTutor.Text;
                            tutorExistente.ap_paterno = txt_appaternoTutor.Text;
                            tutorExistente.ap_materno = txt_apmaternoTutor.Text;
                            tutorExistente.nombre = txt_nombreTutor.Text;
                            await _estudianteController.ModificarTutorAsync(tutorExistente);
                        }
                    }
                    // Obtener y modificar comprobante
                    var comprobanteExistente = _db.TComprobante.FirstOrDefault(c => c.id_estudiante == estudianteExistente.id_estudiante);
                    if (comprobanteExistente != null)
                    {
                        comprobanteExistente.lugar_dpto = txt_dptoComprob.Text;
                        comprobanteExistente.fecha_reg = date_regComprob.Value.Date;
                        await _estudianteController.ModificarComprobanteAsync(comprobanteExistente);
                    }

                    MessageBox.Show("Estudiante modificado con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmestudiante.cargar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar el estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_paisNac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPais = (Ubicacion)cbx_paisNac.SelectedItem;
            if (selectedPais != null)
            {
                cbx_dptoNac.DisplayMember = "Nombre";
                cbx_dptoNac.DataSource = selectedPais.SubUbicaciones;
                cbx_dptoNac.Enabled = true;
                cbx_provNac.Enabled = false;
                cbx_locNac.Enabled = false;
            }
        }

        private void cbx_dptoNac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDpto = (Ubicacion)cbx_dptoNac.SelectedItem;
            if (selectedDpto != null)
            {
                cbx_provNac.DisplayMember = "Nombre";
                cbx_provNac.DataSource = selectedDpto.SubUbicaciones;
                cbx_provNac.Enabled = true;
                cbx_locNac.Enabled = false;
            }
        }

        private void cbx_provNac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProv = (Ubicacion)cbx_provNac.SelectedItem;
            if (selectedProv != null)
            {
                cbx_locNac.DisplayMember = "Nombre";
                cbx_locNac.DataSource = selectedProv.SubUbicaciones;
                cbx_locNac.Enabled = true;
            }
        }

        private void cbx_dptoAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDpto = (UbicacionDptos)cbx_dptoAct.SelectedItem;
            if (selectedDpto != null)
            {
                cbx_provAct.DisplayMember = "NombreD";
                cbx_provAct.DataSource = selectedDpto.SubUbicaciones;
                cbx_provAct.Enabled = true;
                cbx_munAct.Enabled = false;
                cbx_locAct.Enabled = false;
            }
        }

        private void cbx_provAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProv = (UbicacionDptos)cbx_provAct.SelectedItem;
            if (selectedProv != null)
            {
                cbx_munAct.DisplayMember = "NombreD";
                cbx_munAct.DataSource = selectedProv.SubUbicaciones;
                cbx_munAct.Enabled = true;
            }
        }
        
        private void cbx_munAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMun = (UbicacionDptos)cbx_munAct.SelectedItem;
            if (selectedMun != null)
            {
                cbx_locAct.DisplayMember = "NombreD";
                cbx_locAct.DataSource = selectedMun.SubUbicaciones;
                cbx_locAct.Enabled = true;
            }
        }
        private void cbx_locAct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
