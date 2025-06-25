using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;

namespace WpfMrpSimulatorApp.ViewModels
{
    public partial class MonitoringViewModel : ObservableObject
    {
        private readonly IDialogCoordinator dialogCoordinator;

        public MonitoringViewModel(IDialogCoordinator dIALOGCOORDINATOR)
        {
            dialogCoordinator = dIALOGCOORDINATOR;  // 파라미터값으로 초기화
        }

        [RelayCommand]
        public async Task SearchProcess()
        {
            await this.dialogCoordinator.ShowMessageAsync(this, "공정조회", "조회를 시작합니다.");
        }

        [RelayCommand]
        public async Task StartProcess()
        {
            await this.dialogCoordinator.ShowMessageAsync(this, "공정시작", "공정를 시작합니다.");
        }
    }
}
