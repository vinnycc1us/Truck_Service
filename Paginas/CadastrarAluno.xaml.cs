﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Projeto_Educa_Sonho_Meu.Arquivos.Classes;

namespace Projeto_Educa_Sonho_Meu.Paginas
{
    /// <summary>
    /// Interação lógica para CadastrarAluno.xam
    /// </summary>
    public partial class CadastrarAluno : Page
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno(object sender, RoutedEventArgs e)
        {
            // Instancia a nova janela
            CadastrarAluno cadastrarAluno = new CadastrarAluno();
            // Navega para a nova página
            this.NavigationService.Navigate(cadastrarAluno);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Aluno aluno = new Aluno();

            AlunoDAO.Insert(aluno);
        }
    }
}
