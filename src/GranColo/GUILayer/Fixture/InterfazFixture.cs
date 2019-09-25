using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranColo.GUILayer.Fixture
{
    interface InterfazFixture
    {
        void Btn_consultar_Click(object sender, EventArgs e);

        void Btn_agregar_Click(object sender, EventArgs e);

        void Btn_editar_Click(object sender, EventArgs e);

        void Btn_eliminar_Click(object sender, EventArgs e);

        void Btn_cerrar_Click(object sender, EventArgs e);

        DialogResult ShowDialog();

        bool validarCampos();
    }
}
