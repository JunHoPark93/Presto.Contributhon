﻿using Presto.Component.Controls;
using Presto.Plugin.YouTube.Supports;
using System.Windows;

namespace Presto.Plugin.YouTube.Dialogs
{
    /// <summary>
    /// AddPlaylistDialog.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ResultDialog : PrestoWindow
    {
        public ResultDialog()
        {
            InitializeComponent();
            DataContextChanged += ResultDialog_DataContextChanged;
        }

        private void ResultDialog_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            (e.NewValue as BaseViewModel).CloseRequested += delegate
            {
                Close();
            };
        }
    }
}
