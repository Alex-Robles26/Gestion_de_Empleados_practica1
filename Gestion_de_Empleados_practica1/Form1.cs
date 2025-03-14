using administrativo;
using tecnico;


namespace Gestion_de_Empleados_practica1
{
    public partial class ManauryRobles : Form
    {
        private List<Empleado> empleados = new List<Empleado>();//TODO Lista de empleados
        public ManauryRobles()
        {
            InitializeComponent();
            cbCargo.Items.AddRange(new string[] { "Tecnico", "Administrador" });//TODO Agrega las opciones de cargos al combo box
            dgvEmpleados.ReadOnly = true;  //TODO Hace que el DataGridView sea de solo lectura
            txtNombre.TabIndex = 0;
            txtApellido.TabIndex = 1;
            txtEdad.TabIndex = 2;
            cbCargo.TabIndex = 3;
            txtSalario.TabIndex = 4;
            btn_registrar.TabIndex = 5;
            btn_eliminar.TabIndex = 6;
            dgvEmpleados.TabIndex = 7;
            dgvEmpleados.ReadOnly = true;//TODO Hace que el DataGridView sea de solo lectura
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //TODO Verifica si algun campo esta vacio, para que no se pueda guardar si alguno lo esta
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                 string.IsNullOrWhiteSpace(txtApellido.Text) ||
                 string.IsNullOrWhiteSpace(txtEdad.Text) ||
                 cbCargo.SelectedItem == null ||
                 string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                //TODO Si algún campo está vacío, muestra un mensaje de error
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //TODO Verifica si la edad y salario son valores numéricos
            if (!int.TryParse(txtEdad.Text, out int edad) || !decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                //Si no son valores numéricos, muestra un mensaje de error
                MessageBox.Show("Edad y salario deben ser valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //TODO Crea un nuevo objeto "Empleado" según el cargo seleccionado
            Empleado empleado = cbCargo.SelectedItem.ToString() == "Administrativo"
                ? new Administrativo(txtNombre.Text, txtApellido.Text, edad, cbCargo.SelectedItem.ToString(), salario)
                : new Tecnico(txtNombre.Text, txtApellido.Text, edad, cbCargo.SelectedItem.ToString(), salario);

            //TODO Agrega el nuevo empleado a la lista
            empleados.Add(empleado);

            //TODO Muestra un mensaje de éxito
            MessageBox.Show("Empleado registrado de forma correcta", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //TODO Llama al método RefrescarLista para actualizar el DataGridView
            RefrescarLista();
        }



        private void RefrescarLista()
        {
            dgvEmpleados.DataSource = null;  //TODO Limpia la fuente de datos
            dgvEmpleados.DataSource = empleados;  //TODO Asigna la lista de empleados directamente
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado alguna fila en el DataGridView
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                //TODO Obtiene el índice de la fila seleccionada
                int indice = dgvEmpleados.SelectedRows[0].Index;

                //TODO Elimina el empleado de la lista en el índice correspondiente
                empleados.RemoveAt(indice);

                //TODO Muestra un mensaje de éxito
                MessageBox.Show("Empleado borrado de forma correcta", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                //TODO Llama al método RefrescarLista para actualizar el DataGridView
                RefrescarLista();
            }
        }
    }
}
