using BreakingGym.EntidadesNegocioEN;
using BreakingGym.LogicasNegociosBL;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BreakingGym.InterfazUsuarioUI
{
    /// <summary>
    /// Lógica de interacción para Estado.xaml
    /// </summary>
    public partial class Estado : MetroWindow
    {
        EstadoBL _mostrarEstado = new EstadoBL();
        EstadoEN _estadoEN = new EstadoEN();
        public Estado()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgMostrarEstado.ItemsSource = _mostrarEstado.MostrarEstado();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            var estado = new EstadoEN
            {
                Nombre = txtEstado.Text.Trim(),
            };

            // Validar campo vacío
            if (string.IsNullOrEmpty(estado.Nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Obtener lista de estados existentes
            var listaEstados = _mostrarEstado.MostrarEstado(); // Debe devolver la lista completa de estados

            // Validar duplicado por nombre (ignorando mayúsculas/minúsculas)
            bool yaExiste = listaEstados.Any(n => n.Nombre.Equals(estado.Nombre, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un estado con ese nombre. No se puede duplicar.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Guardar estado
            _mostrarEstado.GuardarEstado(estado);

            // Limpiar campo
            txtEstado.Clear();
            CargarGrid();

            MessageBox.Show("Estado guardado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, seleccione un Id.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validar que sea numérico
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("El Id debe ser un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Por favor, seleccione un Id válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var est = new EstadoEN
            {
                Id = id
            };

            // Confirmación
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas eliminar este Estado?",
                                               "Confirmar eliminación",
                                               MessageBoxButton.YesNo,
                                               MessageBoxImage.Question);

            if (confirmResult == MessageBoxResult.No)
                return;

            // Eliminar
            _mostrarEstado.EliminarEstado(est);

            // Limpiar campos
            txtId.Clear();
            txtEstado.Clear();

            // Refrescar DataGrid
            CargarGrid();

            MessageBox.Show("Estado eliminado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}