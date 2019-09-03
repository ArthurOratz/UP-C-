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
using System.Windows.Shapes;

namespace Desafio_Agenda
{
    /// <summary>
    /// Lógica interna para WindowContatos.xaml
    /// </summary>
    public partial class WindowContatos : Window
    {
        public ViewModel.ModelContatos ModelContatos { get; set; }

        public WindowContatos()
        {
            InitializeComponent();
            this.ModelContatos = new ViewModel.ModelContatos();
            this.DataContext = this;
        }

        private void Adicionar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Remover_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            this.ModelContatos.adicionar();
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            this.ModelContatos.Salvar();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
