using PrimeiroProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PrimeiroProjeto
{
    public partial class ExemploListView : ContentPage
    {
        public ExemploListView()
        {
            InitializeComponent();

            GerarListaUsuario();
        }

        public void GerarListaUsuario()
        {
            List<UsuarioModel> usuariosModel = new List<UsuarioModel>();

            for (int i = 1; i <= 20; i++)
            {
                usuariosModel.Add(new UsuarioModel {
                    Nome = $"Usuario {i}",
                    Detalhe = $"Detalhes do usuario {i}",
                    ImagemUsuario = ImageSource.FromUri(new Uri("https://cdn1.iconfinder.com/data/icons/user-pictures/100/male3-128.png"))
                });
            }

            listViewUsuarios.ItemsSource = usuariosModel;
        }
    }
}
