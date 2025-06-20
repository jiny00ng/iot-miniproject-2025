﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;
using WpfMrpSimulatorApp.Views;

namespace WpfMrpSimulatorApp.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        // 다이얼로그 코디네이터 변수 선언
        private readonly IDialogCoordinator dialogCoordinator;

        public string _greeting;
        private UserControl _currentView;

        public MainViewModel(IDialogCoordinator coordinator)
        {
            this.dialogCoordinator = coordinator;   // dialogcoordinator 초기화

            Greeting = "MRP 공정관리!";
        }

        private string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value);
        }

        public UserControl CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }

        [RelayCommand]
        public async Task AppExit()
        {
            // var result = MessageBox.Show("종료하시겠습니까?", "종료확인", MessageBoxButton.YesNo, MessageBoxImage.Question);
            var result = await this.dialogCoordinator.ShowMessageAsync(this, "종료확인", "종료하시겠습니까?", MessageDialogStyle.AffirmativeAndNegative);
            if (result == MessageDialogResult.Affirmative)
            {
                Application.Current.Shutdown();
            } else
            {
                return;
            }
        }

        [RelayCommand]
        public void AppSetting()
        {
            var ViewModel = new SettingViewModel();
            var view = new SettingView
            {
                DataContext = ViewModel,

            };

            CurrentView = view;
        }
    }
}
