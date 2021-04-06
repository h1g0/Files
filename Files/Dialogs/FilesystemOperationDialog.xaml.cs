﻿using Windows.UI.Xaml.Controls;
using Files.ViewModels.Dialogs;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Files.Dialogs
{
    public sealed partial class FilesystemOperationDialog : ContentDialog
    {
        public FilesystemOperationDialogViewModel ViewModel
        {
            get => (FilesystemOperationDialogViewModel)DataContext;
            set => DataContext = value;
        }

        public FilesystemOperationDialog(FilesystemOperationDialogViewModel viewModel)
        {
            this.InitializeComponent();

            ViewModel = viewModel;
        }
    }
}